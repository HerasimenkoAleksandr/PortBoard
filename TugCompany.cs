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
    public partial class TugCompany : Form
    {
        Form2 form2 = null;
        public TugCompany(Form2 obj)
        {
            InitializeComponent();
            Text = "Буксирная компания";
            form2 = obj;
        }

    }
}
