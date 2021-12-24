using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicação_C_Sharp
{
    public partial class Form1 : Form
    {
       
        public static Boolean verificar = true;
        public Form1()
        {
            InitializeComponent();
        }
        public static class Program
        {
        

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(nome.Text)) || (String.IsNullOrWhiteSpace(email.Text)) || (String.IsNullOrWhiteSpace(Telefone.Text)) || (String.IsNullOrWhiteSpace(Senha.Text)) || (String.IsNullOrWhiteSpace(ConfirmarSenha.Text)) || (!(Senha.Text == ConfirmarSenha.Text)))

            {
                MessageBox.Show("Campo em branco");
            }
            else {
                Cadastro cad = new Cadastro(nome.Text, email.Text, Senha.Text);
                MessageBox.Show(cad.mensagem);
                panel2.Visible = true;
                panel1.Visible = false;
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            nome.Text = nome.Text.ToUpper();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else {
                panel2.Visible = false;
                    }

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel1.Visible = true;
                panel2.Visible = false;

            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(login.Text, senhalogin.Text);
            if (controle.mensagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("login deu certo");

                }
                else
                {
                    MessageBox.Show("deu errado");

                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);   
            
            }
        }
    }
}
