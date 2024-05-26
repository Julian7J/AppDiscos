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

            try
            {
            listaDiscos = negocio.listar();
            dgvDiscos.DataSource = listaDiscos;
            cargarImagen(listaDiscos[0].UrlImagenTapa);

            }
            catch ( Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }

        private void pictureBoxDiscos_Click(object sender, EventArgs e)
        {

        }

        private void dgvDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
           cargarImagen(seleccionado.UrlImagenTapa);

        }

       private void cargarImagen (string imagen) 
        {
            try
            {
                pictureBoxDiscos.Load(imagen);
            }
            catch (Exception)
            {

                pictureBoxDiscos.Load("https://sunrisedaycamp.org/wp-content/uploads/2020/10/placeholder.png");
            }
        }
    } 
    }

