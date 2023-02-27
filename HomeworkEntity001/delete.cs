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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeworkEntity001
{
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactsModel key = new ContactsModel();
            var conID = key.ContactsTable.ToList();
            if (conID.Any((x) => x.Product_ID == textBox1.Text))
            {
                
                foreach (var item in conID)
                {
                    key.ContactsTable.Remove(item);
                }
                key.SaveChanges();
                MessageBox.Show("成功刪除");
            }
            else
            {
                MessageBox.Show("刪除失敗");
            }
        }
    }
}
