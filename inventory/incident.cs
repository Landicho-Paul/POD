﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class incident : Form
    {
        public incident()
        {
            InitializeComponent();
            loadData();

        }

        public string constring = "datasource=localhost;username=root;password=;database=db_hccpod";
        //public string constring = "datasource=localhost;username=id22175641_grimlocker08;password=Grimlocker_08;database=id22175641_podserverdatabase";
        //public string constring = "server=localhost;database= id22175641_podserverdatabase; uid = id22175641_grimlocker08; pwd=Grimlocker_08;";
        private void incident_Load(object sender, EventArgs e)
        {

        }
        
        public void update() { 
            MySqlConnection conn1 = new MySqlConnection(constring);
            try
            {

                conn1.Open();
                string query = "";
                MySqlCommand cmd = new MySqlCommand(query, conn1);
                int check = cmd.ExecuteNonQuery();
                if (check > 0)
                {
                    
                    loadData();
                    

                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        public void loadData()
        {
            
            txtuname.Text = Class1.uname;
            MySqlConnection conn = new MySqlConnection(constring);
            try
            {
                String query = "SELECT fullname,course_year_section,home_address,phone_number,identity,incident_date,incident_time,incident_location,incident_description from tbl_incidentdata";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                toolsdt.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {
            Form HOME = new MainDashboard();
            HOME.Show();
            this.Hide();
        }

        private void guna2HtmlLabel28_Click(object sender, EventArgs e)
        {
            Form HOME = new ACCOUNT();
            HOME.Show();
            this.Hide();
        }

        private void guna2HtmlLabel26_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel37_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel34_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel39_Click(object sender, EventArgs e)
        {
            Form HOME = new ACCOUNT();
            HOME.Show();
            this.Hide();
        }

        private void guna2HtmlLabel36_Click(object sender, EventArgs e)
        {
            Form HOME = new MainDashboard();
            HOME.Show();
            this.Hide();
        }

        private void guna2HtmlLabel35_Click(object sender, EventArgs e)
        {
            Form HOME = new Form1();
            HOME.Show();
            this.Hide();
        }

        private void guna2HtmlLabel30_Click(object sender, EventArgs e)
        {
            Form HOME = new Setting();
            HOME.Show();
            this.Hide();
        }

        private void toolsdt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1)
            {
                

                DataGridViewCell Fname = toolsdt.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Class1.Fname = Fname.Value.ToString();

                

                Form HOME = new view();
                HOME.Show();
                this.Hide();




            }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

        }
    }
}
