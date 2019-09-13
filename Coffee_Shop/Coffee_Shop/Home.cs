using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
{
    public partial class Home : Form
    {
        private string custtxtbx = "";
        private Int16 conttxtbx = 0;
        private string addtxtbx = "";
        private string ordercobox = "";
        private int quntxtbx = 0;
        private double unitPrice = "";
        private double totalPrice = 0;
        public Home()
        {
            InitializeComponent();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //customerName = custtxtbx.Text;
            //contact = conttxtbx.Text;
            //address = addtxtbx.Text;
            //order = ordercobox.Text;
            //quantity = quntxtbx.Text;
            totalPrice = unitPrice * quntxtbx;

        showtxtbx.Text("Customer Name : " + custtxtbx.Text + "\nContact No : " + conttxtbx.Text + "\n Address :" + addtxtbx.Text + "\n Order :" + ordercobox.Text + "\n Quantity :" + quntxtbx.Text + "\n Total Price :" + totalPrice);





        }
    }
}
