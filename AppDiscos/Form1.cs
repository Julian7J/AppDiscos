using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDiscos
{
    public partial class Form1 : Form
    {
        private List<Discos> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosNegocio negocio = new DiscosNegocio();
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            pictureBoxDiscos.Load(listaDiscos[0].UrlImagenTapa);

           
        }

         //   CargarDiscos();
         //  }

            //   private void CargarDiscos()
            //   {
            //       DiscosNegocio negocio = new DiscosNegocio();
            //       List<Discos> listaDiscos = negocio.listar();

            //       if (listaDiscos.Count > 0)
            //       {
            //           pictureBoxDiscos.ImageLocation = "https://proyectodegardo.weebly.com/uploads/1/9/4/0/19400833/3638973.jpg?478";
            //       }
            //       else
            //       {
            //           MessageBox.Show("No hay discos disponibles para mostrar.");
            //       }
        }
    }
}
