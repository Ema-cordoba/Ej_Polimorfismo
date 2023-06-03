using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ej_Polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Empleado> le;

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado auxE = null;
                if (radioButtonEmplAdministrativo.Checked)
                {
                    auxE = new EmpleadoAdministrativo(Interaction.InputBox("Nombre : "), Interaction.InputBox("DNI : "), Interaction.InputBox("Apellido : "), decimal.Parse(Interaction.InputBox("Suledo Bruto")), decimal.Parse(Interaction.InputBox("Premio : ")));
                }
                else
                {
                    auxE = new EmpleadoGerente(Interaction.InputBox("Nombre : "), Interaction.InputBox("DNI : "), Interaction.InputBox("Apellido : "), decimal.Parse(Interaction.InputBox("Suledo Bruto")), decimal.Parse(Interaction.InputBox("Bono : ")));
                }

                le.Add(auxE);
                Mostrar(dataGridView1, le);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void Mostrar(DataGridView dDGV,List<Empleado> pListaEmpleado)
        {
            EmpleadoVista ev = new EmpleadoVista();

            dDGV.DataSource = null;

            dDGV.DataSource = ev.RetornaListadeEmpleado(pListaEmpleado);

        }

        public class EmpleadoVista
        {
            public EmpleadoVista(string pNombre, string pApellido, string pDNI, decimal pSueldoBruto, decimal pDescuento, decimal pPremio, decimal pBono, decimal pSueldoApagar )
            {
                Nombre = pNombre; Apellido = pApellido; DNI = pDNI; SueldoBruto = pSueldoBruto; Descuento = pDescuento; Premio = pPremio; Bono = pBono ; SueldoApagar = pSueldoApagar;
            }

            public EmpleadoVista() { }

            public string Nombre { get; set; }

            public string Apellido { get; set; }

            public string DNI { get; set; }

            public decimal SueldoBruto { get; set; }

            public decimal Descuento { get; set; }

            public decimal Premio { get; set; }

            public decimal Bono { get; set; }

            public decimal SueldoApagar { get; set; }

            public List<EmpleadoVista> RetornaListadeEmpleado(List<Empleado> pListaDeEmpleado)
            {
                List<EmpleadoVista> auxLEV = new List<EmpleadoVista>();

                foreach(Empleado emp in pListaDeEmpleado)
                {
                    EmpleadoVista auxEV = new EmpleadoVista();

                    auxEV.Nombre = emp.Nombre;

                    auxEV.DNI = emp.DNI;

                    auxEV.Apellido = emp.Apellido;

                    auxEV.SueldoBruto = emp.SueldoBruto;

                    auxEV.SueldoApagar = emp.CalcularSueldo();

                    auxEV.Descuento = emp.Descuento;

                    if (emp is EmpleadoAdministrativo)
                    {
                        auxEV.Premio = (emp as EmpleadoAdministrativo).Premio;
                        auxEV.Bono =0;
                    }
                    else
                    {
                        auxEV.Bono = (emp as EmpleadoGerente).BonoPorciento;
                        auxEV.Premio = 0;
                    }
                    auxLEV.Add(auxEV);
                }

                return auxLEV;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            le = new List<Empleado>();
        }
    }

    public abstract class Empleado
    {
        public Empleado(string pNombre, string pDNI, string pApellido, decimal pSueldoBruto )
        {
            DNI = pDNI; Nombre = pNombre; Apellido = pApellido; SueldoBruto = pSueldoBruto;
        }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DNI { get; set; }

        public decimal SueldoBruto { get; set; }

        public abstract decimal Descuento { get; }

        public abstract decimal CalcularSueldo();
    }

    public class EmpleadoAdministrativo : Empleado
    {
        public EmpleadoAdministrativo(string pNombre, string pDNI, string pApellido, decimal pSueldoBruto, decimal pPremio):base(pNombre,pDNI,pApellido,pSueldoBruto)
        {
            Premio = pPremio;
        }

        public decimal Premio { get; set; }

        decimal descuento;

        public override decimal Descuento => descuento;

        public override decimal CalcularSueldo()
        {
            descuento = (SueldoBruto + Premio) * .1m;

            return (SueldoBruto + Premio - descuento);
        }
    }

    public class EmpleadoGerente : Empleado
    {
        public EmpleadoGerente(string pNombre, string pDNI, string pApellido, decimal pSueldoBruto, decimal pBonoPorciento) : base(pNombre, pDNI, pApellido, pSueldoBruto)
        {
            BonoPorciento = pBonoPorciento;
        }


        public decimal BonoPorciento { get; set; }

        decimal descuento;

        public override decimal Descuento => descuento;

        public override decimal CalcularSueldo()
        {
            descuento = (SueldoBruto * (1 + (BonoPorciento/100))) * .2m;

            return (SueldoBruto * (1 + (BonoPorciento / 100))) - descuento;
        }
        
    }
}
