using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Myshop
{
    public partial class History : Form
    {
    
        private MySqlConnection databaseConnection()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=myshop;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }
        private void showdataGridView1()
        {   
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM salehis";
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
        public History()
        {
            InitializeComponent();
            showdataGridView1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            admin log = new admin();
            log.Show();
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void history_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {
            textBox2.Text = "0";
            MySqlConnection conn = databaseConnection();
            DataSet ds = new DataSet();
            conn.Open();
            MySqlCommand cmd;
            cmd = conn.CreateCommand();
             
            cmd.CommandText = ($"SELECT * FROM salehis WHERE date >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}' AND date <= '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")}'");
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(ds);
            MySqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                MySqlConnection conn2 = databaseConnection();
                conn2.Open();
                MySqlCommand cmd2;
                cmd2 = conn2.CreateCommand(); 
                cmd2.CommandText = ($"SELECT * FROM salehis WHERE date >= '{dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss")}' AND date <= '{dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss")}'");
                MySqlDataReader dr2 = cmd2.ExecuteReader();
                int x = 0;
                while (dr2.Read())
                {
                    x += dr2.GetInt32(4);
                   
                }
                conn2.Close();
                textBox2.Text = x.ToString();
            }


            conn.Close();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void History_Shown(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
