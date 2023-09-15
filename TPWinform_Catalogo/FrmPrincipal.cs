using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPWinform_Catalogo
{
    public partial class FrmPrincipal : Form
    {
        private List<Articulo> listaArticulo;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cargar();
        }


        private void cargar()
        {

            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dataGridViewArticulos.DataSource = listaArticulo;
                ocultarColumnas();
                pictureBoxFoto.Load(listaArticulo[0].imagen.url);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }



        private void dataGridViewCelulares_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewArticulos.CurrentRow != null)
            {

                Articulo seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.imagen.url);

            }


        }

        private void ocultarColumnas()
        {
            dataGridViewArticulos.Columns["Id"].Visible = false;
            dataGridViewArticulos.Columns["Imagen"].Visible = false;

        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pictureBoxFoto.Load(imagen);
            }
            catch (Exception ex)
            {

                pictureBoxFoto.Load("https://www.webempresa.com/foro/wp-content/uploads/wpforo/attachments/3200/318277=80538-Sin_imagen_disponible.jpg");
            }
        }






        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }




        


       

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar ventanaAgregar = new FormAgregar();
            ventanaAgregar.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            Articulo seleccionado;
            seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;

            FormAgregar modificar = new FormAgregar(seleccionado);
            modificar.ShowDialog();
            cargar();

        }

        private void dataGridViewArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio articulo = new ArticuloNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Quieres Eliminar Este Articulo?", "Eliminando..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dataGridViewArticulos.CurrentRow.DataBoundItem;
                    articulo.EliminarArticulo(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }



            

    }
    }
