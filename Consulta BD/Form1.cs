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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sobre;password=;");
           MySqlCommand cmd = new MySqlCommand("SELECT*FROM t_veiculo", conn);

            //DataTable = Armazenar os resultados da coluna
            DataTable dt = new DataTable ();    
            conn.Open ();

            //MySqlDataAdapter = preencher o database com os resultados da consulta
            MySqlDataAdapter da =  new MySqlDataAdapter(cmd);
            da.Fill(dt);   
            conn.Close ();  

            //Vincule o DataTable ao DataGridView para exibir os dados na grade
            dataGridView1.DataSource= dt;   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = textBox1.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user=root;database=sobre;password=;");
            MySqlCommand cmd = new MySqlCommand("SELECT*FROM t_veiculo where modelo like '%" + pesquisa+"%'", conn);

            //DataTable = Armazenar os resultados da coluna
            DataTable dt = new DataTable();
            conn.Open();

            //MySqlDataAdapter = preencher o database com os resultados da consulta
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();

            //Vincule o DataTable ao DataGridView para exibir os dados na grade
            dataGridView1.DataSource = dt;

        }
    }
}
