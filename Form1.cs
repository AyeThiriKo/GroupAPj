﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAProducts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String constring = "Server=127.0.0.1;Port=5432;Database=basicsql;User Id=postgres;Password=ssmroot;Timeout=15;";
                NpgsqlConnection conDataBase = new NpgsqlConnection(constring);
                conDataBase.Open();

                MessageBox.Show("Hello Success");
                //NpgsqlDataAdapter sda = new NpgsqlDataAdapter(string.Join(space, word1), constring);
                //DataTable dbdataset = new DataTable();
                //sda.Fill(dbdataset);
                //dataGridView1.DataSource = dbdataset;

                ////Bind the data tothe GridView to display table data
                //BindingSource bsource = new BindingSource();
                //bsource.DataSource = dbdataset;
                //dataGridView1.DataSource = bsource;

                ////Resize the DataGridView columns to fit the newly loaded content
                //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}