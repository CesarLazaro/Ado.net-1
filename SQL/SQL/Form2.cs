using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            try
            {
                string query = "SELECT * FROM sys.databases";
                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database=Northwind ; integrated security = true");
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {                 
                    BD.Items.Add(DR[0]);
                }
                conexion.Close();

            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");
            }
        }

        private void BD_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tables.Items.Clear();
            Views.Items.Clear();
            SPs.Items.Clear();
            string temporal = Convert.ToString(BD.SelectedItem);
            ShowTables(temporal);
            ShowViews(temporal);
            ShowSP(temporal);




        }
        public void ShowTables (string temporal)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database= "
                    + temporal + "; integrated security = true");
                string query = "SELECT * FROM sysobjects T WHERE T.xtype = 'U'";            
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    Tables.Items.Add(DR[0]);
                }
                conexion.Close();

            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");
            }
        }
        public void ShowViews(string temporal)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database= "
                    + temporal + "; integrated security = true");
                string query = "SELECT * FROM sysobjects T WHERE T.xtype = 'V'";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    Views.Items.Add(DR[0]);
                }
                conexion.Close();

            }
            catch (SqlException Ex)
            {
                MessageBox.Show("ERROR AL CONECTAR CON LA BD");
            }
        }
        public void ShowSP(string temporal)
        {
            try
            {

                SqlConnection conexion = new SqlConnection("server=HGDLAPLAZAROCA\\SQLEXPRESS ; database= "
                    + temporal + "; integrated security = true");
                string query = "SELECT * FROM sysobjects T WHERE T.xtype = 'P'";
                conexion.Open();
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    SPs.Items.Add(DR[0]);
                }
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
    }
}
