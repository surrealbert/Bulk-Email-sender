using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net.Mime;

namespace Mensajería_Whatsapp
{
    public partial class Form1 : Form
    {
        public string filepath = null;
        private int CurrentIndex { get; set; }
        private string[] Emails { get; set; }
        private string[] Messages { get; set; }
        private string[] Content { get; set; }
        private string[] Subjects { get; set; }
        private int ElapsedTime { get; set; }

        private int[] FailedFlag = { 0, 0 };

        public Form1()
        {
            InitializeComponent();
            from_textbox.Text = ""; //Write sender Email
            cc_textbox.Text = ""; //Write cc
            pswd_textbox.Text = ""; //Write sender Email account password 
            cantidad_textbox.Text = "10"; //Write max amount of mails per sent
            delay_textbox.Text = "2"; //Write delay per sent email
            sheetName_textbox.Text = "Hoja 1"; //Write xls file sheet
            sheetName_textbox.Enabled = false;
            SendEmailBttn.Enabled = false;
        }

        private void GetTableData()
        {
            //Se debe especificar el protocolo de seguridad TLS 1.2 ya que se actualizó recientemente
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            if (string.IsNullOrEmpty(filepath) == false)
            {
                Microsoft.Office.Interop.Excel.Application tabla = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = tabla.Workbooks.Open(filepath.ToString());
                _Worksheet worksheet = workbook.Worksheets[1];

                int totalColumns = worksheet.UsedRange.Columns.Count;
                int totalRows = worksheet.UsedRange.Rows.Count;

                //Obtiene los datos de todas las celdas utilizadas en la tabla de Excel
                Emails = new string[totalRows - 1];
                Messages = new string[totalRows - 1];
                Content = new string[totalRows - 1];
                Subjects = new string[totalRows - 1];

                try
                {
                    for (int row = 1; row < totalRows; row++)
                    {

                        //Emails
                        var number_from_sheet = worksheet.Cells[row + 1, 1].value;
                        Emails[row - 1] = Regex.Replace(number_from_sheet, " ", "");
                        Console.WriteLine(Emails[row - 1]);

                        //Mensajes
                        var mensajes_from_sheet = worksheet.Cells[row + 1, 3].value;
                        //mensajes[row - 1] = Regex.Replace(mensajes_from_sheet, @"\r\n", "\\r\\n");
                        //mensajes[row - 1] = Regex.Replace(mensajes_from_sheet, @"\n", "<br>");
                        //mensajes[row - 1] = Regex.Replace(mensajes_from_sheet, @"\n", "<br>");
                        Messages[row - 1] = mensajes_from_sheet;

                        //Enlaces y contenido
                        if (worksheet.Cells[row + 1, 2].value != null)
                        {
                            Content[row - 1] = worksheet.Cells[row + 1, 2].value;
                        }
                        else
                        {
                            Content[row - 1] = "";
                        }

                        //Subject
                        var subjects_from_sheet = worksheet.Cells[row + 1, 4].value;
                        Subjects[row - 1] = Regex.Replace(subjects_from_sheet, @"\n", "\\r\\n");

                    }
                    workbook.Close();
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(workbook);
                    workbook = null;
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;
                    SendEmailBttn.Enabled = true;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    Console.WriteLine(e);
                    workbook.Close();
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(workbook);
                    workbook = null;
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(worksheet);
                    worksheet = null;
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            //Se debe especificar el protocolo de seguridad TLS 1.2 ya que se actualizó recientemente
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            if(string.IsNullOrEmpty(cantidad_textbox.Text)==true || string.IsNullOrEmpty(delay_textbox.Text) == true || string.IsNullOrEmpty(from_textbox.Text) == true || string.IsNullOrEmpty(cc_textbox.Text) == true)
            {
                MessageBox.Show("No dejar campos vacíos!");
            }
            else
            {
                // Se crea el request SMTP al servidor con el puerto especificado por el servicio
                var clientsmpt = new SmtpClient("smtp.ionos.com", 587);
                clientsmpt.UseDefaultCredentials = false;
                clientsmpt.Credentials = new System.Net.NetworkCredential(from_textbox.Text.ToString(), pswd_textbox.Text.ToString());
                clientsmpt.EnableSsl = true;

                string mail_from = from_textbox.Text;
                int max_amount = Int32.Parse(cantidad_textbox.Text);
                int delay = Int32.Parse(delay_textbox.Text);

                // Construye la estructura HTML del cuerpo del mensaje
                string body_start = "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\"><HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset='UTF-8'\"></HEAD><BODY>";
                string body_end = "</BODY></HTML>";
                ContentType mimeType = new System.Net.Mime.ContentType("text/html");

                int i = 0;
                foreach (var mail_rec in Emails)
                {
                    MailMessage Mail = new MailMessage();
                    Mail.From = new MailAddress(mail_from);
                    Mail.To.Add(mail_rec);
                    Mail.Subject = Subjects[i];
                    Mail.IsBodyHtml = true;

                    //Make carbon copy?
                    if (ccCheckBox.Checked == true)
                    {
                        Mail.CC.Add(cc_textbox.Text);
                    }


                    if (contentCheckBox.Checked)
                    {
                        LinkedResource LinkedImage = new LinkedResource(Content[i]);
                        LinkedImage.ContentId = "image";
                        LinkedImage.ContentType = new ContentType(MediaTypeNames.Image.Jpeg);
                        string mail_body = body_start + Messages[i] + "<br><br><img src='cid:" + Content[i] + "'>" + body_end;
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mail_body, mimeType);
                        htmlView.ContentType.CharSet = System.Text.Encoding.UTF8.WebName;
                        htmlView.LinkedResources.Add(LinkedImage);
                        Mail.AlternateViews.Add(htmlView);
                    }
                    else
                    {
                        AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body_start + Messages[i] + body_end, mimeType);
                        htmlView.ContentType.CharSet = System.Text.Encoding.UTF8.WebName;

                        Mail.AlternateViews.Add(htmlView);
                        //Mail.Body = htmlView;
                        //htmlView.Dispose();
                    }

                    try
                    {
                        clientsmpt.Send(Mail);
                        Mail.Dispose();
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        FailedFlag[0]++;
                        sent_failed_lbl.Text = "Enviados: " + FailedFlag[0] + "  Fallidos:" + FailedFlag[1];
                    }
                    catch (Exception ex)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = System.Drawing.Color.Red;
                        FailedFlag[1]++;
                        sent_failed_lbl.Text = "Enviados: " + FailedFlag[0] + "  Fallidos:" + FailedFlag[1];
                        Console.WriteLine("Exception caught in CreateTestMessage2(): {0}",
                            ex.ToString());
                    }

                    if ((i + 1) % max_amount == 0 &&  i < (Emails.Length - max_amount))
                    {
                        if (i+1 == max_amount) { timer1.Start();}
                        await Task.Delay(delay * 1000);
                        //MessageBox.Show(mensajes[i].ToString());
                    }
                    i++;
                }
                timer1.Stop();
                MessageBox.Show("Ha terminado el envío de correos");

            }         

        }

        private void width_column()
        {
            DataGridViewColumn column = dataGridView1.Columns[3];
            column.Width = 500;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog select_file = new OpenFileDialog();
            select_file.InitialDirectory = "D:";
            select_file.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

            if (select_file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filepath = select_file.FileName;
                //string filepath = "D:\\Windows Libraries\\Desktop\\test.xls";
                Microsoft.Office.Interop.Excel.Application tabla = new Microsoft.Office.Interop.Excel.Application();
                Workbook workbook = tabla.Workbooks.Open(filepath.ToString());
                _Worksheet worksheet = workbook.Worksheets[1];

                System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =  " + filepath + "" + @"; Extended Properties=""Excel 12.0;HDR=Yes;IMEX=1;ImportMixedTypes=Text;TypeGuessRows=0""";
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand("select * from ["+sheetName_textbox.Text+"$]", conn);
                DataSet stats = new DataSet();
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                adapter.Fill(stats);

                dataGridView1.DataSource = stats.Tables[0];
                width_column();
                workbook.Close();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(workbook);
                workbook = null;
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(worksheet);
                worksheet = null;

                SendEmailBttn.Enabled = true;
                GetTableData();
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filepath = "";
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            SendEmailBttn.Enabled = false;
            FailedFlag[0] = 0;
            FailedFlag[1] = 0;
            ElapsedTime = 0;
            sent_failed_lbl.Text = "";
            timer_label.Text = "Tiempo(s): ";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (sheetName_textbox.Enabled == false) { sheetName_textbox.Enabled = true; }
            else { sheetName_textbox.Enabled = false; }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ElapsedTime%Int32.Parse(delay_textbox.Text)==0){ ElapsedTime = 0; }
            ElapsedTime++;
            timer_label.Text = "Tiempo(s): "+ElapsedTime.ToString();
        }
    }
}
