using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoForms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=ASPIRE-VX5\SQLEXPRESS;Initial Catalog=Registro;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            string login = "select*from user_tb where usuário='" + textBox1.Text + "'and senha='" + textBox2.Text + "'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()==true) 
            {
                    new Form3().Show();
                this.Hide();
            }else 
            {
                MessageBox.Show("Usuário ou senha invalido.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            new Form2().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            if(checkBox1.Checked) 
            {
                textBox2.PasswordChar = '\0';
            }else 
            {
                textBox2.PasswordChar = '*';
            }
        }
    }
}
