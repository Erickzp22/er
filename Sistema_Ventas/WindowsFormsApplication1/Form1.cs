using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btn_Retiro_MouseHover(object sender, EventArgs e)
        {
            btn_Retiro.Image = Resources.Retirar2;
        }

        private void btn_Retiro_MouseLeave(object sender, EventArgs e)
        {
            btn_Retiro.Image = Resources.Retirar1;
        }

        private void btn_Vendedor_MouseHover(object sender, EventArgs e)
        {
            btn_Vendedor.Image = Resources.vendedor2;
        }

        private void btn_Vendedor_MouseLeave(object sender, EventArgs e)
        {
            btn_Vendedor.Image = Resources.vendedor1;
        }

        private void btn_Administrador_MouseHover(object sender, EventArgs e)
        {
            btn_Administrador.Image = Resources.Administrador2;
        }

        private void btn_Administrador_MouseLeave(object sender, EventArgs e)
        {
            btn_Administrador.Image = Resources.Administrador1;
        }

        private void btn_Cierre_MouseHover(object sender, EventArgs e)
        {
            btn_Cierre.Image = Resources.cierre2;
        }

        private void btn_Cierre_MouseLeave(object sender, EventArgs e)
        {
            btn_Cierre.Image = Resources.Inicio1;
        }

        private void btn_Abrir_MouseHover(object sender, EventArgs e)
        {
            btn_Abrir.Image = Resources.Inicio2;
        }

        private void btn_Abrir_MouseLeave(object sender, EventArgs e)
        {
            btn_Abrir.Image = Resources.cierre2;
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
