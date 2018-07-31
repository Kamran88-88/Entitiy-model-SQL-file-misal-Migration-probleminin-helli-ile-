using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Entitiy_model db=new Entitiy_model())
            {
                User user = new User() { Name=textBox1.Text,Surname=textBox2.Text};
                var users = db.Users.Add(user);
                db.SaveChanges();
            }

            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Entitiy_model db = new Entitiy_model())
            {
                var user = db.Users.First();
                textBox1.Text = user.Name;
                textBox2.Text = user.Surname;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Entitiy_model db = new Entitiy_model())
            {
                var user = db.Users.First();
                  user.Name= textBox1.Text;
                  user.Surname= textBox2.Text;
                db.SaveChanges();
            }
            textBox1.Clear();
            textBox2.Clear();
            MessageBox.Show("Changes are saved");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Entitiy_model db1=new Entitiy_model())
            {
                Worker worker = new Worker() { Phone = maskedTextBox1.Text, Mail = textBox4.Text };
                var work = db1.Workers.Add(worker);
                db1.SaveChanges();
            }
            maskedTextBox1.Clear();
            textBox4.Clear();
        }
    }
}
