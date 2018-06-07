using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FirstApp
{
    public partial class Autentification : Form
    {
        public Autentification()
        {
            InitializeComponent();
            ActiveControl = label1;

        }

        static public string connString = @"server=PC-33-30\SQLEXPRESS;Database=videoWorld;trusted_connection=True;";
        public  DataSet ds;

        private void Autentification_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Login")
            {
                textBox1.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        public static string sessionUser;

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text!="" && textBox1.Text != "Login" && textBox2.Text != "Password")
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT loginn,pass,id from users", connString);
                ds = new DataSet();
                da.Fill(ds, "currentUser");
                foreach (DataRow r in ds.Tables["currentUser"].Rows)
                {
                    if (textBox1.Text.Equals(r[0]))
                    {
                        if (textBox2.Text.Equals(r[1]))
                        {
                            sessionUser = r[0].ToString().Trim();
                            Hide();
                            MainForm mf = new MainForm();
                            mf.Show();

                        }
                        else
                        {
                            label4.ForeColor = Color.Red;
                            label4.Text = "* invalid login or password";
                        }
                            
                    }
                    else
                    {
                        label4.ForeColor = Color.Red;
                        label4.Text = "* invalid login or password";
                    }
                }
            }
            else
            {
                label4.ForeColor = Color.Red;
                label4.Text = "* the fields are required !";
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Hide();
            Register rg = new Register();
            rg.ShowDialog();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Login";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Password";
                textBox2.ForeColor = Color.Gray;

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        int xMouse;
        int yMouse;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        Point downPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (downPoint == Point.Empty)
            {
                return;
            }
            Point location = new Point(
                this.Left + e.X - downPoint.X,
                this.Top + e.Y - downPoint.Y);
            this.Location = location;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                return;
            }
            downPoint = Point.Empty;
        }
    }
}
