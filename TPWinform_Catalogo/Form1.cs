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

namespace TPWinform_Catalogo
{
    public partial class Form1 : Form
    {
        private List<Articulo> ListaArticulo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            ListaArticulo = artNegocio.listar();
            dataGridViewArticulos.DataSource = ListaArticulo;
       
        
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

        private void dataGridViewCelulares_SelectionChanged(object sender, EventArgs e)
        {

            Articulo artic = (Articulo) dataGridViewArticulos.CurrentRow.DataBoundItem;
            
           
            cargarImagen(artic.imagen.url);
        }
    
    
    private void cargarImagen(string imagen)
        {

            
            try
            {

                pictureBoxFoto.Load(imagen);



            }
            catch (Exception ex)
            {

                pictureBoxFoto.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            FormAgregar ventanaAgregar = new FormAgregar();
            ventanaAgregar.ShowDialog();


        }
    }
}
