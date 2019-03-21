using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL
{
    public partial class Form1 : Form
    {
        string tabla;

        public Form1()
        {
            InitializeComponent();
            try
            {
                string query = "SELECT TABLE_NAME FROM Hitss_TM.INFORMATION_SCHEMA.TABLES";
                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database=Hitss_TM ; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    if (DR[0].Equals("sysdiagrams"))
                    {
                        break;
                    }
                    Tablas.Items.Add(DR[0]);

                }
                conexion.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM " + tabla;
                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database=Hitss_TM ; integrated security = true");
                conexion.Open();
               // SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(query, conexion);
                // DataTable table = new DataTable();
                DataSet table = new DataSet();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
                dataGridView1.DataMember = "Table";
                conexion.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string ID = txt.Text;
                string query = "SELECT * FROM "+ tabla + "  WHERE ID =" + ID;
                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database=Hitss_TM ; integrated security = true");
                conexion.Open();
               // SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter da = new SqlDataAdapter(query,conexion);
                // DataTable table = new DataTable();
                DataSet table = new DataSet();
                da.Fill(table);
                dataGridView1.DataSource = new BindingSource(table, null);
                dataGridView1.DataMember = "Table";

                conexion.Close();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabla=Convert.ToString(Tablas.SelectedItem);
            btnAll.Enabled =  true;
            btnSearch.Enabled = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
