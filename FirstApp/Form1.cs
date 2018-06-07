using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        Autentification mf = new Autentification();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            
            timer1.Start();

        }
        int count = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count == 14)
            {
                timer1.Stop();
                Hide();
                mf.Show();
                
            }
            count++;
                
        }




       
    }
}
