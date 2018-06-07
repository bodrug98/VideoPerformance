using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;
using Xceed.Words.NET;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FirstApp
{
    public partial class Shoppingcart : Form
    {
        public Shoppingcart()
        {
            InitializeComponent();
        }

        private string fileName = @"Receipt.docx";

        private void Shoppingcart_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private string fullname="";
        public static string selectedCards;

        private void fullnameTb_Leave(object sender, EventArgs e)
        {
            fullnameL.Text = "";
               ////fullname validation
            if (Regex.IsMatch(fullnameTb.Text, "^([a-zA-Z]{2,}\\s[a-zA-z]{1,}'?-?[a-zA-Z]{2,}\\s?([a-zA-Z]{1,})?)",RegexOptions.IgnoreCase))
            {

                fullname = fullnameTb.Text.Trim();
                fullnameL.Text = "";
                fullnameTb.WithError = false;

            }
            else 
            {
                fullnameTb.WithError = true;
                fullnameL.Text = "*";

            }

            

        }
        private string city = "";
        private void cityTb_Leave(object sender, EventArgs e)
        {
            cityL.Text = "";
            ////city validation
            if (Regex.IsMatch(cityTb.Text, @"^[a-zA-Z]*$"))
            {

                city = cityTb.Text.Trim();
                cityTb.WithError = false;
                cityL.Text = "";

            }
            else
            {
                cityTb.WithError = true;
                cityL.Text = "*";

            }
        }
        private string cardnumber = "";


        private string  security = "";
        private void securityTb_Leave(object sender, EventArgs e)
        {
            securityL.Text = "";
            ////security code validation
            if (Regex.IsMatch(securityTb.Text, @"^\d+$") && securityTb.Text.Trim().Length==3)
            {

                security = securityTb.Text.Trim();
                securityTb.WithError = false;
                securityL.Text = "";

            }
            else
            {
                securityTb.WithError = true;
                securityL.Text = "*";

            }
        }

        private string name = "";
        private void nameTb_Leave(object sender, EventArgs e)
        {
            nameL.Text = "";
            ////fullname validation
            if (Regex.IsMatch(nameTb.Text, @"^[a-zA-Z]*$"))
            {

                name = nameTb.Text.Trim();
                nameTb.WithError = false;
                nameL.Text = "";

            }
            else
            {
                nameTb.WithError = true;
                nameL.Text = "*";

            }
        }
        private string surname = "";
        private void surnameTb_Leave(object sender, EventArgs e)
        {
            surnameL.Text = "";
            ////lastname validation
            if (Regex.IsMatch(surnameTb.Text, @"^[a-zA-Z]*$", RegexOptions.IgnoreCase))
            {

                surname = surnameTb.Text.Trim();
                surnameTb.WithError = false;
                surnameL.Text = "";

            }
            else
            {
                surnameTb.WithError = true;
                surnameL.Text = "*";

            }
        }
        private int month=0;
        private void validitymTb_Leave(object sender, EventArgs e)
        {
            //// code validation
            string validiymText = validitymTb.Text.Trim();
            if (Regex.IsMatch(validiymText, @"^\d+$"))
            {
                month = int.Parse(validiymText);
                if (month<=12)
                {
                    validitymTb.WithError = false;
                }
                else
                {
                    month = 1;
                    validitymTb.Text = 1.ToString() ;

                }
                

            }  else
            {
                validitymTb.WithError = true;

            }
        }

        private int year=0;
        private void validitiyTb_Leave(object sender, EventArgs e)
        {
            string validityText = validitiyTb.Text.Trim();


            if (Regex.IsMatch(validityText, @"^\d+$"))
            {
                year = int.Parse(validityText);
                if (year>=DateTime.Now.Year && year <=2030)
                {
                    validitiyTb.WithError = false;
                }
                else
                {
                    year = DateTime.Now.Year;
                    validitiyTb.Text = DateTime.Now.Year.ToString();
                    //validitiyTb.WithError = true;

                }


            }
            else
            {
                validitiyTb.WithError = true;

            }
        }

        private void addressTb_Click(object sender, EventArgs e)
        {
            addressL.Text = "";
        }

        private string address = "";
        private void addressTb_Leave(object sender, EventArgs e)
        {
            
            string addressTbText = addressTb.Text.Trim();
            if (addressTbText.Length!=0)
            {
                addressTb.WithError = false;
                addressL.Text = "";
                address = addressTbText;
            }
            else
            {
                addressL.Text = "*";
                addressTb.WithError = true;
            }
        }

        private string postcode = "";
        private void postcodeTb_Leave(object sender, EventArgs e)
        {
            codeL.Text = "";
            string postCodeText = postcodeTb.Text.Trim();
            if (postCodeText.Length != 0)
            {
                postcodeTb.WithError = false;
                codeL.Text = "";
                postcode = postCodeText;
            }
            else
            {
                codeL.Text = "*";
                postcodeTb.WithError = true;
            }
        }

        private string phone = "";

        private void phonetb_Leave(object sender, EventArgs e)
        {
            if (phonetb.Text.Trim().Length != 0)
            {
                phonetb.WithError = false;
                phoneL.Text = "";
                phone = phonetb.Text.Trim();
            }
            else
            {
                phoneL.Text = "*";
                phonetb.WithError = true;
            }
        }

        private void cardnumbreTb_Leave(object sender, EventArgs e)
        {
            carnumberL.Text = "";
            string cardnumberTbText = cardnumbreTb.Text.Trim();
            ////city validation
            if (Regex.IsMatch(cardnumberTbText, @"^\d+$"))
            {

                cardnumber = cardnumberTbText;
                cardnumbreTb.WithError = false;
                carnumberL.Text = "";

            }
            else
            {
                cardnumbreTb.WithError = true;
                carnumberL.Text = "*";

            }
        }

        private string  country="";

        private void button2_Click(object sender, EventArgs e)
        {
            if (fullname=="")
            {
                fullnameTb.WithError = true;
                fullnameL.Text = "*";
            }

            if (city=="")
            {
                cityTb.WithError = true;
                cityL.Text = "*";
            }

            if (address == "")
            {
                addressTb.WithError = true;
                addressL.Text = "*";
            }

            if (postcode == "")
            {
                postcodeTb.WithError = true;
                codeL.Text = "*";
            }

            if (phone == "")
            {
                phonetb.WithError = true;
                phoneL.Text = "*";
            }

            if (cardnumber == "")
            {
                cardnumbreTb.WithError = true;
                carnumberL.Text = "*";
            }

            if (year == 0)
            {
                validitiyTb.WithError = true;
            }

            if (month == 0)
            {
                validitymTb.WithError = true;
            }

            if (security == "")
            {
                securityTb.WithError = true;
                securityL.Text = "*";
            }

            if (name == "")
            {
                nameTb.WithError = true;
                nameL.Text = "*";
            }

            if (surname == "")
            {
                surnameTb.WithError = true;
                surnameL.Text = "*";
            }

            if (countryTb.SelectedItem!=null)
            {
                country = countryTb.SelectedItem.ToString();
                countryL.Text = "";
            }
            else
            {
                countryL.Text = "*";
                country = "";
            }

            if (!fullnameTb.WithError && countryL.Text!=null && !cityTb.WithError && !addressTb.WithError
                    && !postcodeTb.WithError && !phonetb.WithError && !cardnumbreTb.WithError
                    && !validitymTb.WithError && !validitiyTb.WithError && !securityTb.WithError
                    && !nameTb.WithError && !surnameTb.WithError)
            {
                
                try
                {

                    string cardsStr = "";
                    for (int i=0;i<Basket.count;i++)
                    {
                        cardsStr += Basket.nrVid[i]+" ";
                    }
      
                    DateTime time = DateTime.Now;
                    string format = "yyyy-MM-dd";
                    string acum = time.ToString(format);
                    string cardList = "";
                    double sumaTotala = 0;
                    string adresa = country + "," + city + "," + address;

                    DataSet dsCards = new DataSet();
                    string sql = @"Select * FROM cards";
                    SqlDataAdapter da = new SqlDataAdapter(sql, MainForm.connString);
                    da.Fill(dsCards, "AllInfoOfCards");

                    for (int i = 0; i < Basket.count; i++)
                    {
                        foreach (DataRow dr in dsCards.Tables["AllInfoOfCards"].Rows)
                        {
                            if (dr[0].ToString().Equals(Basket.nrVid[i].ToString()))
                            {
                                cardList += dr[1].ToString() + "   -   " + dr[9].ToString() + Environment.NewLine;
                                sumaTotala += int.Parse(dr[9].ToString());
                            }
                        }
                    }


                     using (SqlConnection connection = new SqlConnection(Autentification.connString))
                    {
                        connection.Open();
                        try
                        {

                            SqlCommand command1 = new SqlCommand("INsert into commands(iduser, produse, data,adresa) " +
                                           "values('1','" + cardsStr + "','" + acum + "','" + adresa + "')", connection);
                            SqlDataReader dr1 = command1.ExecuteReader();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }

                    }

                    

                   this.createDocxFile(acum,cardList,adresa,sumaTotala);
                    this.sendMail();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message+" "+ex.StackTrace);
                }



                
            }


        }

        private  void sendMail()
        {
            if (createdDocx)
            {
                try
                {

                    System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                    mail.From = new MailAddress("mihai.bodrug.98@gmail.com");
                    mail.To.Add(new MailAddress("mihai.bodrug.98@gmail.com"));
                    mail.Subject = "Receipt";
                    mail.Body = "dfgfdg";
                    mail.Attachments.Add(new Attachment(fileName));

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential("mihai.bodrug.98@gmail.com", "023662239m");
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mail);
                    mail.Dispose();



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
        private bool createdDocx;

        private void createDocxFile(string acum, string cardList, string adresa,double sumaTotala)
        {
            try
            {
                // Create a document in memory:
                var doc = DocX.Create(fileName);

                var titluFormat = new Formatting();
                titluFormat.FontFamily = new Xceed.Words.NET.Font("Arial");
                titluFormat.Size = 20;
                titluFormat.Bold = true;
                titluFormat.Position = 100;
                doc.InsertParagraph("Receipt", false, titluFormat);

                var infoFormat = new Formatting();
                infoFormat.FontFamily = new Xceed.Words.NET.Font("Arial");
                infoFormat.Size = 14;


                var headerFormat = new Formatting();
                headerFormat.Size = 14;
                headerFormat.Bold = true;

                var formatT = new Formatting();
                formatT.Size = 14;


                Xceed.Words.NET.Table t = doc.AddTable(4, 2);
                t.Rows[0].Cells[0].Paragraphs.First().Append("User  ", headerFormat);
                t.Rows[1].Cells[0].Paragraphs.First().Append("Date  ", headerFormat);
                t.Rows[2].Cells[0].Paragraphs.First().Append("Products  ", headerFormat);
                t.Rows[3].Cells[0].Paragraphs.First().Append("Address  ", headerFormat);

                t.Rows[0].Cells[1].Paragraphs.First().Append(fullname, formatT);
                t.Rows[1].Cells[1].Paragraphs.First().Append(acum, formatT);
                t.Rows[2].Cells[1].Paragraphs.First().Append(cardList, formatT);
                t.Rows[3].Cells[1].Paragraphs.First().Append(adresa, formatT);

                t.SetColumnWidth(1, 5000);
                t.SetColumnWidth(0, 5000);

                t.SetTableCellMargin(TableCellMarginType.top, 1000);
                t.SetTableCellMargin(TableCellMarginType.left, 1000);
                var sumaFormat = new Formatting();
                sumaFormat.FontFamily = new Xceed.Words.NET.Font("Arial");
                sumaFormat.Size = 17;
                titluFormat.Bold = true;

                doc.InsertTable(t);
                doc.InsertParagraph(Environment.NewLine + Environment.NewLine + " Total amount " + sumaTotala + " lei", false, sumaFormat);

                // Save to the output directory:
                doc.Save();

                createdDocx = true;
            }
            catch (Exception ex)
            {
                createdDocx = false;
            }
        }
    }
}
