using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using MetroFramework.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json.Linq;
using System.Security;
using System.Security.Permissions;
using System.Threading;

namespace Downloads
{
    public partial class Form1 : Form
    {


        private static Random random = new Random();
         
        private string file = "";
        private string fname = "";
        private string FolderName = "";
        private string Destinationpath = "";
        JArray jsonArray;
       
        private string Url = "";
         
         
        StreamWriter w;
        public Form1()
        {
            InitializeComponent();


            this.SetStyle(ControlStyles.SupportsTransparentBackColor, false);
            this.TransparencyKey = Color.FromKnownColor(KnownColor.Control);
            this.Update();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;


            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;


        }

        // public static Uri url = new Uri("");


        //browse click
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                string[] f = file.Split('\\');
                fname = f[(f.Length) - 1];
                
                if (System.IO.Path.GetExtension(fname).Equals(".json", StringComparison.InvariantCultureIgnoreCase))
                {
                    lb_error.Text = "";
                    txtSourceFileName.Text = fname.ToString();
                    button1.Text = "Uploaded";
                    
                    StreamReader sr = new StreamReader(file);
                    string text = System.IO.File.ReadAllText(file);
                    var serializer = new JsonSerializer();
                    //  var final = serializer.Deserialize(file);
                    using (var re = File.OpenText(file))

                    using (var reader = new JsonTextReader(re))
                    {

                        var entries = serializer.Deserialize(reader);
                        //  richTextBox1.Text = entries.ToString();
                        var myJsonString = JsonConvert.SerializeObject(entries);
                        jsonArray = JArray.Parse(myJsonString);
                        lb_totalCount.Text = Convert.ToString(jsonArray.Count);
                        //lb_ReamngCount.Text = Convert.ToString(jsonArray.Count);
                    }
                }
                else
                {
                    lb_error.Text = "*Invalid Format";
                }

               


            }
        }


        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void Btn_dwnld_Click(object sender, EventArgs e)
        {
            //backgroundWorker1.RunWorkerAsync(2000);


            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.  
            DialogResult result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtdestinationfolder.Text = folderDlg.SelectedPath;
                Destinationpath = folderDlg.SelectedPath;
                Environment.SpecialFolder root = folderDlg.RootFolder;
            }


        }

        private void download(string url, string ExamCode, string path)
        {
            if (url != "" && !string.IsNullOrEmpty(url))
            {
                string secondResult = "";
                HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
                HtmlAgilityPack.HtmlDocument docx = web.Load(url);
                var client = new WebClient();
                var Html = docx.Text;
               

                var gettingVideoUrl = docx.DocumentNode.SelectNodes("//*[@id=\"examinfo-url\"]");

                foreach (var node in gettingVideoUrl)
                {
                    var clipurl = node.OuterHtml;
                    var start = clipurl.IndexOf("value") + 7;
                    secondResult = clipurl.Substring(start);
                    secondResult = secondResult.TrimEnd('>');
                    secondResult = secondResult.TrimEnd('"');

                    secondResult = Convert.ToString(secondResult.ToString());
                }
                if (secondResult != null || string.IsNullOrEmpty(secondResult))
                {

                    XmlDocument doc = new XmlDocument();
                    doc.Load(secondResult);

                    try
                    {

                        XmlNode fileNode = doc.FirstChild;
                        var t = fileNode.InnerText;
                        List<string> keyValuePairs = t.Split('>').ToList();
                        var Webcam = keyValuePairs[6].TrimEnd();
                        var WebcamClip = Webcam.Split('<')[0];
                        //path = "D:9b729347-ZZZZ-454e-8e9a-0a5fc03431a1";
                        var savingpath = path + "\\" + ExamCode + "WebcamClip.mp4";
                        client.DownloadFile(WebcamClip, savingpath);
                        backgroundWorker1.ReportProgress(progressBar1.Value + 1);
                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                        {
                            Log(ExamCode+"WebcamClip.mp4" + " " + "Downloaded", w);
                        }
                        savingpath = "";
                        var ScreenCam = keyValuePairs[11].TrimEnd();
                        var ScreenCamClip = ScreenCam.Split('<')[0];
                        savingpath = path + "\\" + ExamCode + "ScreenCamClip.mp4";
                         client.DownloadFile(ScreenCamClip, savingpath );
                        backgroundWorker1.ReportProgress(progressBar1.Value + 1);
                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                        {
                            Log(ExamCode+"ScreenCamClip.mp4" + " " + "Downloaded", w);
                        }
                    }
                    catch (Exception ex)
                    {
                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                        {
                            Log(ex.Message.ToString(), w);
                        }
                    }

                }

                List<string> imgScrs = new List<string>();
                //var Img_tags = docx.DocumentNode.SelectNodes(@"//img[@src]");

                foreach (HtmlNode img in docx.DocumentNode.SelectNodes("//img"))
                {
                    HtmlAttribute att = img.Attributes["src"];
                    imgScrs.Add(att.Value);
                }
                for (int i = 0; i < imgScrs.Count; i++)
                {

                    var filename = string.Concat(ExamCode, RandomString(2));
                    filename = string.Concat(filename, ".jpg");
                    if (imgScrs[i].Contains("logo.gif") || imgScrs[i].Contains("ajax.gif"))
                    {
                        //at i=0 its logo 
                    }
                    else
                    {
                        if (!Uri.IsWellFormedUriString(imgScrs[i], UriKind.Absolute))
                        {
                            imgScrs[i] = imgScrs[i].Split('/')[2];
                            imgScrs[i] = string.Concat("https://www.remoteproctor.com/AdminSite/", imgScrs[i]);
                        }
                        var savePath = path + "\\" + filename;
                        File.WriteAllBytes(savePath, client.DownloadData(imgScrs[i]));
                        backgroundWorker1.ReportProgress(progressBar1.Value+1);
                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                        {
                            Log(filename + " " + "Downloaded", w);
                        }
                    }

                }


            }
            else
            {

                MessageBox.Show("something went wrong please try again ");
                using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                {
                    Log("something went wrong please try again", w);
                }
                return;
            }

        }


        private void txtSourceFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtdestinationfolder.Text == "" || string.IsNullOrEmpty(txtdestinationfolder.Text))
            {
                MessageBox.Show("Please Select Destination Folder");
                return;
            }
            button1.Enabled = false;
            btn_select.Enabled = false;
            progressBar1.Maximum = 100;

            progressBar1.Step = 1;
            
            progressBar1.Value = 1;
            resultLabel.Text = 0 + "%";
            if (backgroundWorker1.IsBusy != true)
            {
                btnCancel.Enabled = true;
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

           

            if (worker.CancellationPending == true)
            {
                e.Cancel = true;
                //break;
            }
            else
            {

                // Perform a time consuming operation and report progress.

                if (System.IO.Path.GetExtension(fname).Equals(".json", StringComparison.InvariantCultureIgnoreCase))
                {
                    string line;
                    try
                    {
                        StreamReader sr = new StreamReader(file);

                        //Read the first line of text
                        line = sr.ReadLine();
                        //Pass the file path and file name to the StreamReader constructor
                        string text = System.IO.File.ReadAllText(file);
                        var serializer = new JsonSerializer();
                        //  var final = serializer.Deserialize(file);
                        using (var re = File.OpenText(file))

                        using (var reader = new JsonTextReader(re))
                        {

                            var entries = serializer.Deserialize(reader);
                            // richTextBox1.Text = entries.ToString();
                            var myJsonString = JsonConvert.SerializeObject(entries);
                            JArray jsonArray = JArray.Parse(myJsonString);
                            var totalCount = jsonArray.Count;
                            decimal count = jsonArray.Count;
                            decimal div_count = count / 100;
                            int a = Convert.ToInt32(div_count * 100);
                            a = a * 10;
                            using (w= File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                            {
                                Log("File Created", w);
                                        }
                            for (int j = 0; j <= jsonArray.Count; j++)
                            {
                                
                                lb_totalCount.Text = Convert.ToString(jsonArray.Count);
                                if (totalCount != j) //index out of range
                                {
                                    var order_obj = JObject.Parse(jsonArray[j].ToString());
                                    Url = order_obj["VideoReviewLink"].ToString();
                                    var SsiRecordLocator = order_obj["SsiRecordLocator"].ToString();
                                    var difference = Convert.ToInt32(jsonArray.Count) - j;
                                    if (Destinationpath != "")
                                    {
                                        FolderName = Path.Combine(Destinationpath, SsiRecordLocator);
                                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                                        {
                                            Log("Folder Created"+" " + FolderName, w);
                                        }
                                        
                                        
                                    }
                                    else
                                    {

                                    }

                                    var targetLocation = System.IO.Directory.CreateDirectory(FolderName);
                                    

                                    if (worker.CancellationPending == true)
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                    download(Convert.ToString(Url), SsiRecordLocator, Convert.ToString(FolderName));
                                    if (worker.CancellationPending == true)
                                    {
                                        e.Cancel = true;
                                        break;
                                    }
                                }
                                if (j == 0)
                                {
                                    backgroundWorker1.ReportProgress(a);
                                }
                                else
                                {
                                    backgroundWorker1.ReportProgress(a+a);
                                }
                                // System.Threading.Thread.Sleep(20);


                            }

                        }

                        //close the file
                        sr.Close();
                        Console.ReadLine();


                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "Unable to connect to the remote server")
                        {
                            MessageBox.Show("Downloading fail. Please check your internet connection. ");
                            txtdestinationfolder.Text = "";
                            txtSourceFileName.Text = "";
                            button2.Enabled = false;
                            button1.Enabled = true;
                            btn_select.Enabled = true;
                        }
                        else
                        {
                            //richTextBox1.Text = ex.Message;
                        }
                        using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                        {
                            Log(ex.Message.ToString(), w);
                        }

                    }

                }


            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Maximum = 100;
            
                progressBar1.Value = e.ProgressPercentage;
                resultLabel.Text = (e.ProgressPercentage.ToString() + "%");
            
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
                txtdestinationfolder.Text = "";
                txtSourceFileName.Text = "";
                button2.Enabled = false;
                button1.Enabled = true;
                btn_select.Enabled = true;
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
                using (w = File.AppendText(Path.Combine(Destinationpath, "log.txt")))
                {
                    Log("Error: " + e.Error.Message.ToString(), w);
                }
                }
            else
            {
                progressBar1.Value = 100;
                resultLabel.Text = "Done!";
                txtdestinationfolder.Text = "";
                txtSourceFileName.Text = "";
                button2.Enabled = false;
                button1.Enabled = true;
                btn_select.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {

                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                txtdestinationfolder.Text = "";
                txtSourceFileName.Text = "";
                button2.Enabled = false;
                button1.Enabled = true;
                btn_select.Enabled = true;
                MessageBox.Show("Cancel Downloading");
            }

            btnCancel.Enabled = false;
        }

        static private void Log(string msg, TextWriter w)
        {
            try
            {
                w.Write(Environment.NewLine);
                w.Write("[{0} {1}]", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.Write("\t");
                w.WriteLine(" {0}", msg);
                w.WriteLine("-----------------------");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + "" + "Please Contact D4done.com");
                //Handle
            }
        }
    }



}








