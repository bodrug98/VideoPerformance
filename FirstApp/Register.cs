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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Autentification af = new Autentification();
            af.Show();
            Close();
        }




        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nickname")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Nickname";
                textBox3.ForeColor = Color.Gray;
            }
        }





        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Email")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Login")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Email";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Login";
                textBox6.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Password")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
                textBox5.PasswordChar = '*';
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Confirm the password")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
                textBox7.PasswordChar = '*';
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Password";
                textBox5.ForeColor = Color.Gray;

            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Confirm the password";
                textBox7.ForeColor = Color.Gray;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /////////Login validation
            bool validLogin = false;
            string login = "";
            if (textBox6.Text.Length < 5 || textBox6.Text.Length > 15)
            {
                loginLabel.Text = "* invalid login";
                validLogin = false;

            }
            else if (textBox6.Text == "" || textBox6.Text == "Login")
            {
                loginLabel.Text = "* the field is required";
                validLogin = false;

            }
            else
            {
                login = textBox6.Text;
                loginLabel.Text = "";
                validLogin = true;
            }

            /////////Email validation

            bool validEmail = false;
            string email = "";
            if (textBox4.Text != "" && textBox4.Text != "Email")
            {
                if (Regex.IsMatch(textBox4.Text,
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    email = textBox4.Text;
                    emailLabel.Text = "";
                    validEmail = true;
                }
                else
                {
                    emailLabel.Text = "* email is invalid";
                    validEmail = false;

                }
            }
            else
            {
                emailLabel.Text = "* the fiels is required";
                validEmail = false;

            }

            /////////Nick validation


            bool validNick = false;
            string nickName = "";
            if (textBox3.Text.Length < 5 || textBox3.Text.Length > 15)
            {
                nickLabel.Text = "* invalid nickname";
                validNick = false;


            }
            else if (textBox3.Text == "" || textBox3.Text == "Nickname")
            {
                nickLabel.Text = "* the field is required";
                validNick = false;


            }
            else
            {
                nickName = textBox3.Text;
                nickLabel.Text = "";
                validNick = true;
            }

            /////////Password validation

            bool validPass = false;
            string pass = "";
            if (textBox5.Text.Length < 5 || textBox5.Text.Length > 15)
            {
                passLabel.Text = "* invalid password";
                validPass = false;

            }
            else if (textBox5.Text == "" || textBox5.Text == "Password")
            {
                passLabel.Text = "* the field is required";
                validPass = false;

            }
            else
            {
                pass = textBox5.Text;
                passLabel.Text = "";
                validPass = true;
            }

            /////////Password confirmation validation

            bool validPass2 = false;

            if (textBox7.Text != "" && textBox7.Text != "Confirm the password")
            {
                if (textBox7.Text != textBox5.Text)
                {
                    pass2Label.Text = "* the password is different";
                    validPass2 = false;

                }
                else
                {
                    validPass2 = true;
                }

            }
            else
            {
                pass2Label.Text = "* the field is required";
                validPass2 = false;

            }




            using (SqlConnection connection = new SqlConnection(Autentification.connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT loginn FROM Users", connection);
                SqlDataReader dr = command.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        if (dr[0].ToString().Equals(textBox6.Text))
                        {
                            validNick = false;
                            loginLabel.Text = "* login already exists";



                        }
                    }
                }
            }





            if (validEmail && validLogin && validNick && validPass && validPass2)
            {

                using (SqlConnection connection = new SqlConnection(Autentification.connString))
                {
                                connection.Open();
                                try
                                {
                                    SqlCommand command1 = new SqlCommand("INsert into users(loginn, email, nickname,pass) " +
                                                   "values('" + login + "','" + email + "','" + nickName + "','" + pass + "')", connection);
                                    SqlDataReader dr1 = command1.ExecuteReader();
                                    MainForm f = new MainForm();

                                    Autentification.sessionUser = login.Trim();
                                    f.Show();
                                    Close();

                                    
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);

                                }

                }
            }
        }








        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public SqlDataAdapter da;
        public DataSet ds;

        private void Register_Load(object sender, EventArgs e)
        {
            

        }
    }
}

        
 

