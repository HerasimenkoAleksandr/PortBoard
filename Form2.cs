using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortBoard
{
    public partial class Form2 : Form
    {
        Form1 form1 = null;
        public int radioButton_Select;
        public Form2(Form1 obj)
        {
            InitializeComponent();
            form1 = obj;
            timer1.Start();

        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            //label1.Text=dt.ToString();
            label1.Text = radioButton_Select.ToString();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           switch (radioButton_Select)
            {
                case 1:
                    {
                        Form3 form3 = new Form3(this);
                        this.Hide();
                        form3.ShowDialog();
                       this.Show();
                        break;
                    }
                case 2:
                    {
                        Form3 form3 = new Form3(this);
                        this.Hide();
                        form3.ShowDialog();
                        this.Show();
                        break;
                    }
                case 3:
                    {
                        Form3 form3 = new Form3(this);
                        this.Hide();
                        form3.ShowDialog();
                        this.Show();
                        break;
                    }
                case 4:
                    {
                        Form3 form3 = new Form3(this);
                        this.Hide();
                        form3.ShowDialog();
                        this.Show();
                        break;
                    }


            }
           
        }
    }
}
