using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consulta_BD
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sobre;password=;");
            MySqlCommand cmd = new MySqlCommand("Insert into t_veiculo (codigo,modelo,marca,ano,cor) Value (   @1 ,@Gol,@Volkswagen,@2018,@Preto)", conn);

            //Inserção no Banco de dados

            cmd.Parameters.AddWithValue("@1",textBox1.Text);
            cmd.Parameters.AddWithValue("@Gol", textBox2.Text);
            cmd.Parameters.AddWithValue("@Volkswagen", textBox3.Text);
            cmd.Parameters.AddWithValue("@2018", textBox4.Text);
            cmd.Parameters.AddWithValue("@Preto", textBox5.Text);

            //Abrir conexão

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            conn.Close();

            //validando a inserção de dados
                
                if (rowsAffected >0)
            {
                MessageBox.Show("Dados inseridos com sucesso!!!");
            }
            else
            {
                MessageBox.Show("Fala ao inserir dados");
            }

        }
    }
}
