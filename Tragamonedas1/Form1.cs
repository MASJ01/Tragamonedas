using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tragamonedas1
{
    public partial class Form1 : Form
    {
        int progress;
        public Form1()
        {
            InitializeComponent();
            progress = 0; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progress += 10;

            if (progress < 110)
            {
                pgbcarga.Value = progress;
            }
            else
            {
                timer1.Stop();
                this.Hide();
                Form2 mostrar = new Form2();
                mostrar.Show(); 
            }

        }
    }
}
