using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        public static string newPass="";
        public MainForm f = new MainForm();
        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                

                Image img = Image.FromFile("Images/userAvatar.png");
                pictureBox1.Image = img;
                foreach (DataRow dr in MainForm.ds.Tables["SessionUser"].Rows)
                {


                    textBox1.Text = dr[3].ToString();
                    textBox2.Text = dr[2].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool validNick = false;
            string nickName = "";
            if (textBox1.Text.Length < 5 || textBox1.Text.Length > 15)
            {
                label5.Text = "*  nickname";
                validNick = false;


            }
            else if (textBox2.Text == "" || textBox2.Text == "Nickname")
            {
                label5.Text = "* required";
                validNick = false;


            }
            else
            {
                nickName = textBox1.Text.Trim();
                label5.Text = "";
                validNick = true;
            }

            bool validEmail = false;
            string email = "";
            if (textBox2.Text != "" && textBox2.Text != "Email")
            {
                if (Regex.IsMatch(textBox2.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    email = textBox2.Text.Trim();
                    label4.Text = "";
                    validEmail = true;
                }
                else
                {
                    label4.Text = "*invalid";
                    validEmail = false;

                }
            }
            else
            {
                label4.Text = "* required";
                validEmail = false;

            }

            if (validEmail && validNick)
            {
                using (SqlConnection connection = new SqlConnection(Autentification.connString))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command1;
                        if (newPass!="")
                        {
                             command1 = new SqlCommand("update users set email='"+email+"',nickname='"+nickName+"',pass='" +newPass+"' where loginn='"+Autentification.sessionUser+"'", connection);

                        }
                        else
                        {
                            command1 = new SqlCommand("update users set email='" + email + "',nickname='" + nickName + "' where loginn='" + Autentification.sessionUser + "'", connection);

                        }
                        SqlDataReader dr1 = command1.ExecuteReader();
                        
                        
                        Hide();
                        f.ShowDialog();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Password psw = new Password();
            psw.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f.Show();
            Close();
        }
    }
}
