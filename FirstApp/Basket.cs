using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Basket : Form
    {
        public Basket()
        {
            InitializeComponent();
        }

         static public  int   count = 0;
        public static string[] nrVid;
        public static DataSet dsCards;

        private void Basket_Load(object sender, EventArgs e)
        {
            count = 0;
            
            try
            {

            dsCards = new DataSet();
            string sql = @"Select * FROM cards";
            SqlDataAdapter da = new SqlDataAdapter(sql,MainForm.connString);
            da.Fill(dsCards,"AllInfoOfCards");

                sql = @"SELECT * FROM users where loginn='" + Autentification.sessionUser + "'";
                da = new SqlDataAdapter(sql, MainForm.connString);
                da.Fill(dsCards, "SessionUser");

                foreach (DataRow dr in dsCards.Tables["SessionUser"].Rows)
            {
                if (dr[1].ToString().Equals(Autentification.sessionUser))
                {
                    nrVid = dr[5].ToString().Trim().Split(' ');
                }
            }
            
                
                foreach (string str in nrVid )
                {
                    count++;
                }


                

    
            Panel[] panels = new Panel[count];
            PictureBox[] pb = new PictureBox[count];
            Label[] labels = new Label[count];
            Button[] bt = new Button[count];
                Label[] dLabels = new Label[count];


                for (int i = 0; i < count; i++)
                {
                    foreach (DataRow dr in dsCards.Tables["AllInfoOfCards"].Rows)
                    {
                        
                        if (dr[0].ToString().Equals(nrVid[i]))
                        {
                            
                        
                                panels[i] = new Panel();
                                labels[i] = new Label();
                                pb[i] = new PictureBox();
                                bt[i] = new Button();
                                dLabels[i] = new Label();
                            panels[i].Name = "Panel" + i;

                            if (i == 0)
                                {
                                    panels[i].SetBounds(12, 13, 663, 94);

                                }
                                else
                                {
                                   
                                    panels[i].SetBounds(12, panels[i-1].Location.Y+94  + 10, 663, 94);

                                }
                                
                                //panels[i].BackColor = ColorTranslator.FromHtml("23; 28; 30");
                                panels[i].Visible = true;

                                pb[i].SetBounds(3, 3, 97, 85);
                                pb[i].BackgroundImage = Image.FromFile(dr[7].ToString());
                                pb[i].BackgroundImageLayout = ImageLayout.Stretch;
                                pb[i].Visible = true;


                         labels[i].Location = new Point(137, 13);
                         labels[i].AutoSize = true;
                         labels[i].Visible = true;
                         labels[i].Text = dr[1].ToString();

                            dLabels[i].SetBounds(110,40,420,50);
                            dLabels[i].AutoSize = false;
                            dLabels[i].Visible = true;
                            dLabels[i].Font = new Font(dLabels[i].Font.Name, 8);
                            dLabels[i].Text = dr[2].ToString();
   
                            bt[i].SetBounds(590, 26, 50, 37);
                            //bt[i].BackColor = ColorTranslator.FromHtml("23; 28; 30");
                            bt[i].FlatStyle = FlatStyle.Flat;
                            bt[i].FlatAppearance.BorderSize = 0;
                            bt[i].Visible = true;
                            bt[i].Text = "x";
                            bt[i].Name = "Button" + dr[0].ToString(); ;
                            bt[i].Click += bt_Click;

                                panels[i].Controls.Add(pb[i]);
                                panels[i].Controls.Add(labels[i]);
                                panels[i].Controls.Add(bt[i]);
                            panels[i].Controls.Add(dLabels[i]);

                            panel.Controls.Add(panels[i]);

                        }
                    }
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace,ex.Message);
            }
        }
        
        private void bt_Click(object sender , EventArgs ev)
        {
            Button btb = (Button)sender;
            string  str = btb.Name.Replace("Button","");
            string newBasket = "";
            for (int i=0;i<count;i++)
            {
                
                if (!nrVid[i].Equals(str) )
                {
                    newBasket += " "+nrVid[i];
                }
                
            }


            using (SqlConnection connection = new SqlConnection(Autentification.connString))
            {
                connection.Open();
                try
                {
                    SqlCommand command1 = new SqlCommand("UPDATE users set basket ='" + newBasket + "' where loginn='" + Autentification.sessionUser + "'",connection);
                    SqlDataReader dr1 = command1.ExecuteReader();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }

            Basket bs = new Basket();
            Hide();
            bs.ShowDialog();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Shoppingcart sp = new Shoppingcart();
            Hide();
            sp.ShowDialog();
            


   
        }

        private void Basket_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
