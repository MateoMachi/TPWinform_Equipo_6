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
        private List<Articulo> listCelulares;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            listCelulares = artNegocio.listar();
            dataGridViewCelulares.DataSource = listCelulares;
        }
    }
}
