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
using FontAwesome.Net;

namespace FirstApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static public string connString = @"server=PC-33-30\SQLEXPRESS;Database=videoWorld;trusted_connection=True;";
        public static DataSet ds;
        private SqlDataAdapter da;
        private bool selctedNvidia;
        public static int newNotif;

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           selctedNvidia = true;

            menuPanel.Height = 0;
            label1.Text = DateTime.Today.ToString("D");
            label2.Text = DateTime.Now.ToShortTimeString();

            try
            {
                ds = new DataSet();
                string sql1 = @"SELECT name FROM cards where idProd=1";
                da = new SqlDataAdapter(sql1, connString);
                da.Fill(ds, "DenumiriNvidia");
                sql1 = @"SELECT * FROM cards where idProd=1";
                da = new SqlDataAdapter(sql1, connString);
                da.Fill(ds,"AllInfoNvidia");
                sql1 = @"SELECT name FROM cards where idProd=2";
                da = new SqlDataAdapter(sql1, connString);
                da.Fill(ds, "DenumiriAmd");
                sql1 = @"SELECT * FROM cards where idProd=2";
                da = new SqlDataAdapter(sql1, connString);
                da.Fill(ds, "AllInfoAmd");
                sql1 = @"SELECT * FROM users where loginn='"+Autentification.sessionUser+"'";
                da = new SqlDataAdapter(sql1, connString);
                da.Fill(ds, "SessionUser");
                
               label13.Text = ds.Tables["SessionUser"].Rows[0][3].ToString();

                DataTable dt = ds.Tables[0];
                metroGrid1.DataSource = ds.Tables[0];
                

            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString());
            }

            foreach (DataRow dr in ds.Tables["AllInfoNvidia"].Rows)
            {
                if (dr[0].ToString().Equals("1"))
                {
                    Image img = Image.FromFile(dr[7].ToString());
                    pictureBox3.Image = img;
                    label3.Text = dr[2].ToString();
                    label12.Text = dr[3].ToString();
                    label11.Text = dr[4].ToString();
                    label10.Text = dr[5].ToString();
                    label9.Text = dr[6].ToString();
                    label18.Text = dr[9].ToString() + "UE";
                }

            }

            if (newNotif == 0)
            {
                hideNotifications();
                basketNotif.BackColor = Color.Transparent;
                basketNotif.Text = "";
            }

        }
        private int selctedItem=0;
        public void showNotifications()
        {
            
                notificationLabel.BackColor = Color.Orange;
                notificationLabel.Text = newNotif.ToString();
                notificationLabel.Location = new Point(940, 5);
            
            
        }
        public void  hideNotifications()
        {
            notificationLabel.BackColor = Color.Transparent;
            notificationLabel.Text = "";
            notificationLabel.Location = new Point(880, 5);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            newNotif++;
            if (menuOpen)
            {
                basketNotif.Text = newNotif.ToString();
                basketNotif.BackColor = Color.Orange;
            }
            else
            {
                showNotifications();
            }
                        
            if (metroGrid1.SelectedRows.Count != 0)
            {
                using (SqlConnection connection = new SqlConnection(Autentification.connString))
                {
                    connection.Open();
                    try
                    {
                        SqlCommand command1 = new SqlCommand("update users set basket=basket+' "+(selctedItem)+"' where loginn='"
                            +Autentification.sessionUser+"'", connection);
                        SqlDataReader dr1 = command1.ExecuteReader();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }

                }
            }
        }
        private bool menuOpen;
        private void menuButton_Click(object sender, EventArgs e)
        {
       
            if (menuPanel.Height == 0)
            {
                
                timer1.Start();
                menuOpen = true;
                
            }
            else
            {
                
                timer2.Start();
                menuOpen = false;
            }
            if (menuOpen)
            {
                if (newNotif!=0)
                {
                    hideNotifications();
                    basketNotif.BackColor = Color.Orange;
                    basketNotif.Text = newNotif.ToString();
                }
                
            }
            else
            {
                if (newNotif != 0)
                {
                    showNotifications();
                    basketNotif.BackColor = Color.Transparent;
                    basketNotif.Text = "";
                }
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuPanel.Height < Height && !timer2.Enabled)
            {
                menuPanel.Height += 10;
            }
            else
            {
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (menuPanel.Height >0 && !timer1.Enabled)
            {
                menuPanel.Height -= 10;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {

            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X<button6.Location.X)
            {
                panel2.Location =new Point(panel2.Location.X+10,panel2.Location.Y);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            selctedNvidia = false;
            if (timer5.Enabled == true)
            {
                timer5.Enabled = false;
                
            }
            timer4.Start();
            metroGrid1.DataSource = null;
            metroGrid1.DataSource = ds.Tables["DenumiriAmd"];
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (panel2.Location.X > button5.Location.X)
            {
                panel2.Location = new Point(panel2.Location.X - 10, panel2.Location.Y);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            selctedNvidia = true;
            if (timer4.Enabled == true)
            {
                timer4.Enabled = false;

            }
            timer5.Start();

            metroGrid1.DataSource = null;
            metroGrid1.DataSource = ds.Tables["DenumiriNvidia"];
        }

        private void metroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (selctedNvidia)
            {
                foreach (DataRow dr in ds.Tables["AllInfoNvidia"].Rows)
                {
                    if (dr[1].ToString().Equals(metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        Image img = Image.FromFile(dr[7].ToString());
                        pictureBox3.Image = img;
                        label3.Text = dr[2].ToString();
                        label12.Text = dr[3].ToString();
                        label11.Text = dr[4].ToString();
                        label10.Text = dr[5].ToString();
                        label9.Text = dr[6].ToString();
                        label18.Text = dr[9].ToString()+"UE";

                        selctedItem = (int)dr[0];
                    }

                }
            }
            else
            {
                foreach (DataRow dr in ds.Tables["AllInfoAmd"].Rows)
                {
                    if (dr[1].ToString().Equals(metroGrid1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()))
                    {
                        Image img = Image.FromFile(dr[7].ToString());
                        pictureBox3.Image = img;
                        label3.Text = dr[2].ToString();
                        label12.Text = dr[3].ToString();
                        label11.Text = dr[4].ToString();
                        label10.Text = dr[5].ToString();
                        label9.Text = dr[6].ToString();
                        label18.Text = dr[9].ToString() + "UE";

                        selctedItem = (int)dr[0];
                    }

                }
            }

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Autentification.sessionUser = "";
            Autentification at = new Autentification();
            at.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm.newNotif = 0;
            hideNotifications();
            basketNotif.Text = "";
            basketNotif.BackColor = Color.Transparent;
            Basket bs = new Basket();
            bs.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile pf = new Profile();
            Hide();
            pf.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ok.ru");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com");
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
