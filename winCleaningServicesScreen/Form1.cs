using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winCleaningServicesScreen
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtSubTotal_01.Text = (Convert.ToDouble(txtUnitPrice01.Text) * Convert.ToDouble(txtQty1.Text)).ToString(".00");
            txtSubTotal_02.Text = (Convert.ToDouble(txtUnitPrice02.Text) * Convert.ToDouble(txtQty2.Text)).ToString(".00");
            txtSubTotal_03.Text = (Convert.ToDouble(txtUnitPrice03.Text) * Convert.ToDouble(txtQty3.Text)).ToString(".00");
            txtSubTotal_04.Text = (Convert.ToDouble(txtUnitPrice04.Text) * Convert.ToDouble(txtQty4.Text)).ToString(".00");
            txtSubTotal_05.Text = (Convert.ToDouble(txtUnitPrice05.Text) * Convert.ToDouble(txtQty5.Text)).ToString(".00");
            txtSubTotal_06.Text = (Convert.ToDouble(txtUnitPrice06.Text) * Convert.ToDouble(txtQty6.Text)).ToString(".00");
            txtCleaningTotal.Text = (Convert.ToDouble(txtSubTotal_01.Text) + Convert.ToDouble(txtSubTotal_02.Text) + Convert.ToDouble(txtSubTotal_03.Text) + Convert.ToDouble(txtSubTotal_04.Text) + Convert.ToDouble(txtSubTotal_05.Text) + Convert.ToDouble(txtSubTotal_06.Text)).ToString(".00");
            TxtTaxAmount.Text = (Convert.ToDouble(txtCleaningTotal.Text) * (Convert.ToDouble(TxtTaxRate.Text) / 100)).ToString(".00");
            TxtNetPrice.Text = (Convert.ToDouble(txtCleaningTotal.Text) + Convert.ToDouble(TxtTaxAmount.Text)).ToString(".00");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string same = "D:\\Visual Programming\\Clients Record\\" + txtCustomerName.Text.ToString().Replace(" ", "")+ ".txt";
            if(File.Exists(same))
            {
                same = "D:\\Visual Programming\\Clients Record\\" + txtCustomerName.Text.ToString().Replace(" ", "") + "_" + Services.Guid() + ".txt";
            }
            StreamWriter sw = new StreamWriter(same);
            sw.WriteLine("---------------------------------------------------------------");
            sw.WriteLine("Log Date:  " + DateTime.Now.ToString());
            sw.WriteLine("Customer Name:  " + txtCustomerName.Text);
            sw.WriteLine("Customer Phone:  " + txtCustomerPhone.Text);
            sw.WriteLine("Date Left:  " + dtpDateleft.Text);
            sw.WriteLine("Time Left:  " + dtpTimeLeft.Text);
            sw.WriteLine("Date Expected:  " + dtpDateExpected.Text);
            sw.WriteLine("Time Expected:  " + dptTimeExpected.Text);
            sw.WriteLine("Item Type:  " + cmbItemTypeName.Text);
            sw.WriteLine("Item sub catagory 1:  " + cmbitemSubCatagory1.Text);
            sw.WriteLine("Item sub catagory 2:  " + cmbitemSubCatagory2.Text);
            sw.WriteLine("Item sub catagory 3:  " + cmbitemSubCatagory3.Text);
            sw.WriteLine("Cleaning Total:  " + txtCleaningTotal.Text);
            sw.WriteLine("Tax Rate:  " + TxtTaxRate.Text + "%");
            sw.WriteLine("Tax Amount:  " + TxtTaxAmount.Text);
            sw.WriteLine("Net Price:  " + TxtNetPrice.Text);
            sw.WriteLine("--------------------------------------------------------------");
            sw.Close();
        }
    }
}