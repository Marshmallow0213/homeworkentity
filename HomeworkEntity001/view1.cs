using HomeworkEntity001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkEntity001
{
    public partial class view1 : Form
    {
        public view1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel key = new ContactsModel();
            var conID = key.ContactsTable.ToList();
            if (conID.Any((x) => x.Product_ID == textBox1.Text))
            {
                dataGridView1.DataSource = conID;
            }
            else
            {
                MessageBox.Show("無法查詢");
            }
        }
    }
}
