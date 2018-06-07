using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {

            
        }

        private bool editedPass = false;
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in MainForm.ds.Tables["SessionUser"].Rows)
            {
                if (dr[4].ToString().Equals(currentBox1.Text.Trim()))
                {
                    label5.Text = "* invalid";
                    string pass = "";
                    if (textBox2.Text.Length < 5 || textBox2.Text.Length > 15)
                    {
                        label6.Text = "* invalid";

                    }
                    else if (textBox2.Text == "" )
                    {
                        label6.Text = "* the field is required";
                    }
                    else
                    {
                        pass = textBox2.Text;
                        label6.Text = "";
                    }

                    if (textBox3.Text != "" )
                    {
                        if (textBox3.Text != textBox2.Text)
                        {
                            label7.Text = "* the password is different";

                        }
                        else
                        {
                            editedPass = true;
                        }
                        
                    }
                    else
                    {
                        label7.Text = "* the field is required";

                    }

                }
                else
                {
                    label5.Text = "* invalid";
                }



            }

            if (editedPass)
            {
                Profile.newPass = textBox3.Text.Trim();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
