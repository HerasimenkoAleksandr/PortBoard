using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace PortBoard
{
    public partial class Form1 : Form
    {
        Form2 form2 = null;
       
        public Form1()
        {
            InitializeComponent();
            Text = "Вход";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2 = new Form2(this);
            this.Hide();
            form2.radioButton_Select = GetRadioButton_Select();
            form2.ShowDialog();


        }

        public int GetRadioButton_Select()
        {
            int  button_select=0;
            if (radioButton1.Checked) { button_select = 1; }
            if (radioButton2.Checked) { button_select = 2; }
            if (radioButton3.Checked) { button_select =3;  }
            if (radioButton4.Checked) { button_select = 4; }
            
            return button_select;
        }

    
    }
}
