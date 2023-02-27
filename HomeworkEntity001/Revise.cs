using HomeworkEntity001.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkEntity001
{
    public partial class Revise : Form
    {
        public Revise()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel key = new ContactsModel();
            var conID = key.ContactsTable.ToList();
            if(conID.Any((x) => x.Product_ID == textBox1.Text))
            {
                var datan = key.ContactsTable.Where((x) => x.Product_ID == textBox1.Text).ToList();
                foreach(var item in datan)
                {
                    item.Product_Name = textBox2.Text;
                    item.Count = textBox2.Text;
                    item.Price = textBox2.Text;
                    item.Product_Category = textBox2.Text;
                }
                key.SaveChanges();
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失敗");
            }
        }
    }
}
