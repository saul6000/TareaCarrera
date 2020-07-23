using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_CRUD
{
    public partial class Buscar : Form
    {
        public Buscar()
        {
            InitializeComponent();
        }
        private void cargarComboCarrera()
        {
            DataTable dt = Tarea_CRUD.Modelo.DatosCarreraDAO.getAll();
            this.cmCodigo.DataSource = dt;
            this.cmCodigo.ValueMember = "Código";
            this.cmCodigo.DisplayMember = "Materia";


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarComboCarrera();
        }
        private void cargarCarrera(Modelo.DatosCarrera carrera)
        {



            //cargar los datos en los texbox

            this.txtcodigo.Text = carrera.Codigo;
            this.txtcreditos.Text = carrera.Creditos.ToString();
            this.txtcarrera.Text = carrera.Carrera;          
            this.txtnivel.Text = carrera.Nivel.ToString();
            this.txtmteria.Text = carrera.Materia;
           
        }

        private void cmCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = this.cmCodigo.SelectedValue.ToString();
            Modelo.DatosCarrera carreras = new Modelo.DatosCarrera();
            carreras = Modelo.DatosCarreraDAO.getcarrera(codigo);
            cargarCarrera(carreras);
        }
    }
}
