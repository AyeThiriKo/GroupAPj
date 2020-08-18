﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupAProducts.View
{
    public partial class ProductCategory : Form
    {
        private ProductDetails ProductDetails;

        public ProductCategory()
        {
            InitializeComponent();
        }

        private void dGV_ProductCategory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductDetails = new ProductDetails();
            ProductDetails.Show();           
        }
    }
}