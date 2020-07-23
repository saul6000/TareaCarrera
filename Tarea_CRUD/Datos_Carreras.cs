using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tarea_CRUD.Modelo;

namespace Tarea_CRUD
{
    public partial class Datos_Carreras : Form
    {
        public Datos_Carreras()
        {
            InitializeComponent();
        }

        private void btbguardar_Click(object sender, EventArgs e)
        {
            Tarea_CRUD.Modelo.DatosCarrera carrera = new Tarea_CRUD.Modelo.DatosCarrera();
            int x = 0;
            try
            {
                carrera.Codigo = txtcodigo.Text;
                carrera.Materia = txtmteria.Text;
                carrera.Nivel = int.Parse(txtnivel.Text);
                carrera.Creditos = int.Parse(txtcreditos.Text) ;
                carrera.Carrera = txtcarrera.Text;
                if (Tarea_CRUD.Modelo.DatosCarreraDAO.existecodigo(this.txtcodigo.Text))
                {
                    MessageBox.Show("Este Codigo ya existe");
                    return; //abandonar;
                }
                x = Tarea_CRUD.Modelo.DatosCarreraDAO.creacion(carrera);
                if (x > 0)
                {
                    MessageBox.Show("Datos Guardados");
                }
                else
                {
                    MessageBox.Show("Datos no Guardados");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                this.cargargridcarrera();
            }

        }

        private void btbdelete_Click(object sender, EventArgs e)
        {
            int x = 0;

            try
            {
                x = Tarea_CRUD.Modelo.DatosCarreraDAO.btbdelete(txtdelete.Text);
                if (x == 1)
                {

                    MessageBox.Show("Registro Borrado");


                }
                else
                {
                    MessageBox.Show("Código no Borrado");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                cargargridcarrera();
            }
        }

        private void Datos_Carreras_Load(object sender, EventArgs e)
        {
            this.cargargridcarrera();
        }
        private void cargargridcarrera()
        {
            DataTable dt = Tarea_CRUD.Modelo.DatosCarreraDAO.getAll();
            this.djcarrera.DataSource = dt;
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void validarletras(object sender, KeyPressEventArgs e)
        {
            Tarea_CRUD.Modelo.validar_tipodecaracter.letra(e);
        }
        private void validarnumeros(object sender, KeyPressEventArgs e)
        {
            Tarea_CRUD.Modelo.validar_tipodecaracter.Numeros(e);
        }
        private void djcarrera_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView grid = (DataGridView)sender;
            if (grid.Columns[e.ColumnIndex].Name == "linkEliminar")
            {
                int fila = e.RowIndex;
                // MessageBox.Show("Fila: " + fila.ToString() + ", col: " + col.ToString());
                string codgio = djcarrera[2, fila].Value.ToString();
                string confirmMessage = string.Format("¿Está seguro de que desea eliminar a la persona de numero de código {0}?"
                    , grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, "Eliminar Persona", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Registro Eliminado Exitosamente");
                    grid.Rows.RemoveAt(fila);
                    int x = Tarea_CRUD.Modelo.DatosCarreraDAO.btbdelete(codgio);


                }


            }
            if (grid.Columns[e.ColumnIndex].Name == "linkModificar")
            {
                int fila = e.RowIndex;
                // MessageBox.Show("Fila: " + fila.ToString() + ", col: " + col.ToString());
                string codgio = djcarrera[2, fila].Value.ToString();
                string materia = djcarrera[3, fila].Value.ToString();
                string confirmMessage = string.Format("¿Está seguro de que desea Modificar  la materia"+" "+materia+"?"
                    , grid.Rows[fila].Cells[2].Value);
                if (MessageBox.Show(confirmMessage, "Eliminar Persona", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosCarrera H = Tarea_CRUD.Modelo.DatosCarreraDAO.getcarrera(codgio);
                    FrmModificar modificar = new FrmModificar(H);
                    modificar.ShowDialog();
                    cargargridcarrera();

                    

                }
            }
        }
    }
}
