using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group6Cafe
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Products_Click(object sender, EventArgs e)
        {
                Products obj = new Products();
                obj.Show();
                this.Hide();
            }
    
        private void Branch_Click(object sender, EventArgs e)
        {
            Branch obj = new Branch();
            obj.Show();
            this.Hide();
        }
        private void Customers_Click(object sender, EventArgs e)
        {
            Customers obj = new Customers();
            obj.Show();
            this.Hide();
        }
        private void Employee_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.Show();
            this.Hide();
        }
        private void Manager_Click(object sender, EventArgs e)
        {
            Manager obj = new Manager();
            obj.Show();
            this.Hide();
        }
        private void Owner_Click(object sender, EventArgs e)
        {
            Owner obj = new Owner();
            obj.Show();
            this.Hide();
        }
        private void Supplier_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier();
            obj.Show();
            this.Hide();
        }
    }
}
