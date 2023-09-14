using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinform_Catalogo
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

            Articulo artic = new Articulo();
            ArticuloNegocio articNegocio = new ArticuloNegocio();

            try
            {
                /*
                                artic.Id = int.Parse( textBoxId.Text);
                                artic.nombre = textBoxNombre.Text;
                                artic.descripcion = textBoxDescripcion.Text;
                                artic.Categoria.nomCategoria = textBoxCategoria.Text;
                                artic.codigoArticulo = textBoxCodArticulo.Text;
                                artic.imagen.url = textBoxUrlImagen.Text;
                                artic.Marca.nomMarca = textBoxMarca.Text;
                                artic.precio = decimal.Parse(textBoxPrecio.Text );

                                articNegocio.agregarArticulo(artic);
                                */
            }
            catch (Exception)
            {

                throw;
            }





        }

        private void textBoxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(textBoxUrlImagen.Text);
        }



        private void cargarImagen(string imagen)
        {


            try
            {

                pictureBoxAlta.Load(imagen);



            }
            catch (Exception ex)
            {

                pictureBoxAlta.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }



        }

       
    }
}
