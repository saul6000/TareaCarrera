using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea_CRUD.Modelo;

namespace Tarea_CRUD
{
    public partial class FrmModificar : Form
    {
        public FrmModificar(DatosCarrera carrera)
        {
            InitializeComponent();
            txtcarrera.Text = carrera.Carrera;
            txtcodigo.Text = carrera.Codigo;
            txtcreditos.Text = carrera.Creditos.ToString();
            txtmteria.Text = carrera.Materia;
            txtnivel.Text = carrera.Nivel.ToString();
        }

        private void btbCambios_Click(object sender, EventArgs e)
        {
            int x = 0;
            try {            
            Tarea_CRUD.Modelo.DatosCarrera carrera = new DatosCarrera();
            carrera.Codigo = txtcodigo.Text;
            carrera.Materia = txtmteria.Text;
            carrera.Nivel = int.Parse(txtnivel.Text);
            carrera.Creditos = int.Parse(txtcreditos.Text);
            carrera.Carrera = txtcarrera.Text;



                x = Tarea_CRUD.Modelo.DatosCarreraDAO.update(carrera); 
                    if (x > 0)

                        MessageBox.Show("Actualizacion completa");


                    else
                        MessageBox.Show("No se pudo actualizar los cambios ");             
            }
            catch
            {
                MessageBox.Show("Formato no aceptado");
            }
            finally
            {

                this.Close();
            }
        }

        private void btbcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
