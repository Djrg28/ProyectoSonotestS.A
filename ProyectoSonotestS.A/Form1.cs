using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSonotestS.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login, password;
            login = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if (login == "sonotest" && password == "djrg")
            {
                MessageBox.Show("Bienvenido al Sistema");
                Form2 PestañaPrincipal = new Form2();

                PestañaPrincipal.Show();
            }
            else {
                MessageBox.Show(" Acceso Denegado");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
