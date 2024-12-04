using Microsoft.VisualBasic.ApplicationServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using Selenium.Extensions;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using WinFormsApp1.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Keys = OpenQA.Selenium.Keys;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Google.Authenticator;
using OtpNet;
using Base32Encoding = Google.Authenticator.Base32Encoding;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.InteropServices;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            SetUpChromeDriver();
            chkSaveLogin.Checked = Properties.Settings.Default.isChecked;


        }

        private void SetUpChromeDriver()
        {
            new DriverManager().SetUpDriver(new ChromeConfig());
        }
        ChromeHepler chromeHepler = null;
        public string layMa2Fa(string ma2FaChu)
        {
            // Mã 2FA chữ
            string twoFactorCode = ma2FaChu;

            // Tạo một đối tượng OTP từ mã 2FA chữ
            var otp = new Totp(Base32Encoding.ToBytes(twoFactorCode));

            // Lấy mã OTP
            return otp.ComputeTotp();

        }

        private async void button1_Click(object sender, EventArgs e)
        {

            int giaTri = 0;
            if (!int.TryParse(txtJobsNumber.Text, out giaTri))
            {
                MessageBox.Show("Vui lòng nhập lại số lần lặp lại job");
                return;
            }

            string[] danhSachLinkBaiViet = rtbLinkBaiCanGhim.Text.Split("\n");
            string[] cookie = txtUidPassProxy2Fa.Text.Split("\n");
            string[] accountInfo = txtUidPassProxy2Fa.Text.Split("|");
            string profileName = "Profile Dung";
            string pathProfile = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + profileName;
            ChromeHepler chromeHepler = new ChromeHepler();
            string uid = accountInfo[0];
            string userName = accountInfo[0];
            string password = accountInfo[1];
            string ma2FaChu = accountInfo[2];
            int delayInSecondsChangeLink = (int)numericUpDown1.Value;
            int delayInSecondsRepeatJob = (int)numericUpDown2.Value;
            Thread.Sleep(5000);
            Thread.Sleep(5000);
            pathProfile = pathProfile + "\\" + uid;
            if (await chromeHepler.OpenDriver(pathProfile, isShowImage: true, 500, 500) == null)
            {
                MessageBox.Show(chromeHepler.ErrorMessage);
                return;
            }
            chromeHepler.GoToUrl("https://facebook.com");
            chromeHepler.AddCookie("https://facebook.com", cookie[0]);
            chromeHepler.GoToUrl("https://facebook.com");
            if (chromeHepler.FindElementExist(By.Id("email"), 30))
            {
                string ma2Fa = layMa2Fa(ma2FaChu);
                string pageSource = chromeHepler.chrome.PageSource;
                chromeHepler.SendKeys(By.Id("email"), userName);
                chromeHepler.Delay(1, 5);
                chromeHepler.SendKeys(By.Id("pass"), password);
                chromeHepler.Delay(1, 5);
                chromeHepler.Click(By.Name("login"));
                chromeHepler.Delay(1, 5);
                if (pageSource.Contains("Try Another Way"))
                {
                    chromeHepler.Click(By.CssSelector("div[role='none'][data-visualcompletion=\"ignore\"]"));
                    chromeHepler.Delay(1, 5);
                    chromeHepler.Click(By.CssSelector("div[id=':r4:']"));
                    chromeHepler.Delay(1, 5);
                    chromeHepler.Click(By.CssSelector("div[role='none']"));
                    chromeHepler.Delay(1, 5);
                    chromeHepler.SendKeys(By.CssSelector("[label='Code']"), ma2Fa);
                    chromeHepler.Delay(1, 5);
                    chromeHepler.Click(By.CssSelector("div[role='none']"));
                }
            }            
            int timeSleep = 0;
            while (timeSleep < giaTri)
            {
                
                for (int i = 0; i < danhSachLinkBaiViet.Length; i++)
                {
                    if (danhSachLinkBaiViet[i] == "")
                    {
                        return;
                    }
                    string ariaLabelActionElement = "[aria-label=\"Actions for this post\"]";
                    string ariaLabelActionElementVn = "[aria-label=\"Hành động với bài viết này\"]";
                    string clickPinAndUnpin = "div[role='menuitem'][tabindex='0']";
                    bool isHaveElement = false;
                    bool isHaveElementVn = false;
                    for (int i2 = 0; i2 < 3; i2++)
                    {

                        chromeHepler.GoToUrl(danhSachLinkBaiViet[i]);
                        chromeHepler.Delay(1, 5);
                        IWebElement webElement = chromeHepler.FindElement(By.CssSelector(ariaLabelActionElement));
                        chromeHepler.FindElement(By.CssSelector(ariaLabelActionElementVn));
                        if (webElement != null)
                        {
                            isHaveElement = true;                           
                            break;
                        }
                        if (chromeHepler.FindElement(By.CssSelector(ariaLabelActionElementVn)) != null)
                        {
                            isHaveElementVn = true;
                            break;
                        }
                        chromeHepler.FindElement(By.CssSelector(ariaLabelActionElementVn));                       
                        chromeHepler.Delay(1, 5);
                    }
                    if (!isHaveElement)
                    {
                        if (!isHaveElementVn)
                        {
                            MessageBox.Show("Khong tim thay nut click action sau 3 lan thu");
                            continue;
                        }
                        chromeHepler.Click(By.CssSelector(ariaLabelActionElementVn));
                        chromeHepler.Delay(1, 5);
                        string source = chromeHepler.chrome.PageSource;
                        if (source.Contains("Ghim vào phần Đáng chú ý"))
                        {
                            chromeHepler.Click(By.CssSelector(clickPinAndUnpin));
                            Thread.Sleep(delayInSecondsChangeLink * 1000);
                        }
                        else if (source.Contains("Bỏ ghim khỏi phần Đáng chú ý"))
                        {
                            chromeHepler.Click(By.CssSelector(clickPinAndUnpin));
                            Thread.Sleep(4000);
                            chromeHepler.Click(By.CssSelector(ariaLabelActionElementVn));
                            Thread.Sleep(2000);
                            chromeHepler.Click(By.CssSelector(clickPinAndUnpin));
                            Thread.Sleep(delayInSecondsChangeLink * 1000);
                        }
                    }
                    else
                    {
                        chromeHepler.Delay(1, 5);
                        var elements = chromeHepler.chrome.FindElements(By.CssSelector(ariaLabelActionElement));
                        foreach (var element in elements)
                        {
                            try
                            {
                                element.Click();
                            }
                            catch
                            {

                            }
                        }
                        chromeHepler.Delay(1, 5);                        
                        bool checkPin = chromeHepler.FindElementExist(By.XPath("//span[text()='Pin to Featured']"), 2);                        
                        if (checkPin)
                        {
                            var pins = chromeHepler.chrome.FindElements(By.XPath("//span[text()='Pin to Featured']"));
                            foreach (var pin in pins)
                            {
                                try
                                {
                                    pin.Click();
                                }
                                catch (Exception ex)
                                {
                                    
                                }

                            }
                            Thread.Sleep(delayInSecondsChangeLink * 1000);
                        }
                        else
                        {
                            var unPins = chromeHepler.chrome.FindElements(By.XPath("//span[text()='Unpin from Featured']"));
                            foreach (var unpin in unPins)
                            {
                                try
                                {
                                    unpin.Click();
                                }
                                catch (Exception ex)
                                {
                                    
                                }

                            }
                            chromeHepler.Delay(1, 5);                           
                            foreach (var element in elements)
                            {
                                try
                                {
                                    element.Click();
                                }
                                catch
                                {

                                }
                            }
                            chromeHepler.Delay(1, 5);
                            var pins = chromeHepler.chrome.FindElements(By.XPath("//span[text()='Pin to Featured']"));
                            foreach (var pin in pins)
                            {                               
                                    pin.Click();                                                               
                            }
                            Thread.Sleep(delayInSecondsChangeLink * 1000);
                        }
                    }
                }
                timeSleep++;
                Thread.Sleep(delayInSecondsRepeatJob * 1000);

            }
            
            chromeHepler.Quit();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtProxy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            chromeHepler.Quit();
        }
        private void buttonGetTime_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ NumericUdpDown
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


            // Chờ trong số giây đã nhập

        }

        private void txtUidPassProxy2Fa_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("savedLoginInput.txt", txtUidPassProxy2Fa.Text.Trim());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {


            // Chờ trong số giây đã nhập

        }
        public string checkFileExist(string nameFile, string inputText)
        {
            if (chkSaveLogin.Checked)
            {

                if (!string.IsNullOrEmpty(inputText))
                {
                    File.WriteAllText(nameFile, inputText);
                    return inputText;
                }
                // Đọc nội dung từ tệp "savedInput.txt"
                string inputFromFile = File.ReadAllText(nameFile);
                return inputFromFile;
            }
            return string.Empty;
        }
        private void cbSaveLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkSaveLogin.CheckedChanged += cbSaveLogin_CheckedChanged;
            Properties.Settings.Default.isChecked = chkSaveLogin.Checked;
            Properties.Settings.Default.Save();
            txtUidPassProxy2Fa.Text = checkFileExist("savedLoginInput.txt", txtUidPassProxy2Fa.Text.Trim());
            txtDuongDanThuMucProfiles.Text = checkFileExist("savedProfileLink.txt", txtDuongDanThuMucProfiles.Text.Trim());
            rtbLinkBaiCanGhim.Text = checkFileExist("savedLinkBaiCanGhim.txt", rtbLinkBaiCanGhim.Text.Trim());
        }

        private void chkSaveLinkProfile_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void txtDuongDanThuMucProfiles_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("savedProfileLink.txt", txtDuongDanThuMucProfiles.Text.Trim());
        }

        private void rtbLinkBaiCanGhim_TextChanged(object sender, EventArgs e)
        {
            File.WriteAllText("savedLinkBaiCanGhim.txt", rtbLinkBaiCanGhim.Text.Trim());
        }
    }
}