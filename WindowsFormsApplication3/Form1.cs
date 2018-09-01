using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Vehicle car = new Vehicle
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                EngineSize = txtEngineSize.Text,
                Price = txtPrice.Text
            };

            ListViewItem lvi = new ListViewItem();
            lvi.Tag = car;
            lvi.SubItems.Add(car.Model);
            lvi.SubItems.Add(car.EngineSize);
            lvi.SubItems.Add(car.Price);
            lvi.Text = car.Make;
            listView1.Items.Add(lvi);
            txtMake.Text = String.Empty;
            txtModel.Text = String.Empty;
            txtEngineSize.Text = String.Empty;
            txtPrice.Text = String.Empty;
        }

        private void lstVehicles_Click(object sender, EventArgs e)
        {
            Vehicle v = listView1.FocusedItem.Tag as Vehicle;
            if (v != null)
            {
                txtMake.Text = v.Make;
                txtModel.Text = v.Model;
                txtEngineSize.Text = v.EngineSize;
                txtPrice.Text = v.Price;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
