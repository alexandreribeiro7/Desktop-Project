using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoForms {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=ASPIRE-VX5\SQLEXPRESS;Initial Catalog=Registro;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void button2_Click(object sender, EventArgs e) {
            new Form1().Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void Register_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text==""&& textBox2.Text=="") 
            {

                MessageBox.Show("Usuário ou senha errada.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }else if(textBox3.Text == textBox2.Text)
            {
                con.Open();
                string REGISTRO = "insert into user_tb values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                cmd = new SqlCommand(REGISTRO,con);
                cmd.ExecuteReader();
                con.Close();
                textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
                MessageBox.Show("Usuário criado com sucesso.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else 
            {
                MessageBox.Show("As senhas não conferem.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {

            if (checkBox1.Checked) {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            } else {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }
    }
}
