using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Kalkulator
{

    public partial class Form1 : Form
    {

        int operacija = 0;//operacija
        int count = 0;
        string a = "0";
        string progress = "";
        char last = '!';
        char lastsign = '?';
        double firstnumber = 0;
        double secondnumber = 0;
        double result = 0;
        public Form1()
        {
            InitializeComponent();
            txtbox1.Text = a;
        }
        
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void zerobutton_Click(object sender, EventArgs e)
            {
                if (a != "0")
                {
                    a += 0;
                    progress += 0;
                    txtbox1.Text = a;
                    progresstxtbox.Text = progress;
                }
                else { }
            }

        private void onebutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "1";
                    progress += 1;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 1;
                    progress += 1;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void twobutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "2";
                    progress += 2;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 2;
                    progress += 2;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void threebutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "3";
                    progress += 3;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 3;
                    progress += 3;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void fourbutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "4";
                    progress += 4;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 4;
                    progress += 4;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void fivebutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "5";
                    progress += 5;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 5;
                    progress += 5;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void sixbutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "6";
                    progress += 6;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 6;
                    progress += 6;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void sevenbutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "7";
                    progress += 7;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 7;
                    progress += 7;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void eightbutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "8";
                    progress += 8;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 8;
                    progress += 8;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void ninebutton_Click(object sender, EventArgs e)
            {
                if (a == "0")
                {
                    a = "9";
                    progress += 9;
                    txtbox1.Text = a;
                }
                else
                {
                    a += 9;
                    progress += 9;
                    txtbox1.Text = a;
                }
                progresstxtbox.Text = progress;
            }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                last = progress[progress.Length - 2];
                if (last == ';' || last == '+' || last == '-' || last == '*' || last == '/')
                {
                    progress += "0";
                }
                
            }
            catch { }
            try
            {
                last = progress[progress.Length - 1];
            }
            catch
            {
                progress += "0";
            }
            if (last == ',') {
            }
            else {
                a += ',';
                progress += ",";
            }   
            txtbox1.Text = a;
            progresstxtbox.Text = progress;
        }

        private void plusbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operacija = 1;
                if (firstnumber == 0)
                {
                    firstnumber = Convert.ToDouble(a);
                }
                else
                {
                    if (lastsign == '+')
                    {
                        firstnumber = firstnumber + Convert.ToDouble(a);
                    }
                    else if (lastsign == '-')
                    {
                        firstnumber = firstnumber - Convert.ToDouble(a);
                    }
                    else if (lastsign == '*')
                    {
                        firstnumber = firstnumber * Convert.ToDouble(a);
                    }
                    else if (lastsign == '/')
                    {
                        firstnumber = firstnumber / Convert.ToDouble(a);
                    }
                    else if (lastsign == '!')
                    {
                        firstnumber = firstnumber + Convert.ToDouble(a);
                    }
                    else
                    {
                        MessageBox.Show("lastsign = narobe");
                    }
                }
                a = "0";
                txtbox1.Text = Convert.ToString(firstnumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Ni dovoljeno!");
            }
            try
            {
                last = progress[progress.Length - 2];
            }
            catch { }
            if(last == '+' || last == '-' || last == '*' || last == '/' || last == '!')
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == '1' || last == '2' || last == '3' || last == '4' || last == '5' || last == '6' || last == '7' || last == '8' || last == '9' || last == '0')
                {
                    progress += " + ";
                    count++;
                }
            }
            else
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == ',')
                {
                    progress += "0 + ";
                }
                else
                {
                    progress += " + ";
                    count++;
                }
            }
            progresstxtbox.Text = progress;
            lastsign = '+';
        }

        private void minusbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operacija = 2;
                if (firstnumber == 0)
                {
                    firstnumber = Convert.ToDouble(a);
                }
                else
                {
                    if (lastsign == '+')
                    {
                        firstnumber = firstnumber + Convert.ToDouble(a);
                    }
                    else if (lastsign == '-')
                    {
                        firstnumber = firstnumber - Convert.ToDouble(a);
                    }
                    else if (lastsign == '*')
                    {
                        firstnumber = firstnumber * Convert.ToDouble(a);
                    }
                    else if (lastsign == '/')
                    {
                        firstnumber = firstnumber / Convert.ToDouble(a);
                    }
                    else if (lastsign == '!')
                    {
                        firstnumber = firstnumber - Convert.ToDouble(a);
                    }
                    else
                    {
                        MessageBox.Show("lastsign = narobe");
                    }
                }
                a = "0";
                txtbox1.Text = Convert.ToString(firstnumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Ni dovoljeno!");
            }
            try
            {
                last = progress[progress.Length - 2];
            }
            catch { }
            //MessageBox.Show(Convert.ToString(last));
            if (last == '+' || last == '-' || last == '*' || last == '/' || last == '!')
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == '1' || last == '2' || last == '3' || last == '4' || last == '5' || last == '6' || last == '7' || last == '8' || last == '9' || last == '0')
                {
                    progress += " - ";
                    count++;
                }
            }
            else
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == ',')
                {
                    progress += "0 - ";
                }
                else
                {
                    progress += " - ";
                    count++;
                }
            }
            progresstxtbox.Text = progress;
            lastsign = '-';
        }

        private void timesbutton_Click(object sender, EventArgs e)
        {
            try
            {
                operacija = 3;
                if (firstnumber == 0)
                {
                    firstnumber = Convert.ToDouble(a);
                }
                else
                {
                    if (lastsign == '+')
                    {
                        firstnumber = firstnumber + Convert.ToDouble(a);
                    }
                    else if (lastsign == '-')
                    {
                        firstnumber = firstnumber - Convert.ToDouble(a);
                    }
                    else if (lastsign == '*')
                    {
                        firstnumber = firstnumber * Convert.ToDouble(a);
                    }
                    else if (lastsign == '/')
                    {
                        firstnumber = firstnumber / Convert.ToDouble(a);
                    }
                    else if (lastsign == '!')
                    {
                        firstnumber = firstnumber * Convert.ToDouble(a);
                    }
                    else
                    {
                        MessageBox.Show("lastsign = narobe");
                    }
                }
                a = "0";
                txtbox1.Text = Convert.ToString(firstnumber);

            }
            catch (Exception)
            {
                MessageBox.Show("Ni dovoljeno!");
            }
            try
            {
                last = progress[progress.Length - 2];
            }
            catch { }
            if (last == '+' || last == '-' || last == '*' || last == '/' || last == '!')
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == '1' || last == '2' || last == '3' || last == '4' || last == '5' || last == '6' || last == '7' || last == '8' || last == '9' || last == '0')
                {
                    progress += " * ";
                    count++;
                }
            }
            else
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == ',')
                {
                    progress += "0 * ";
                }
                else
                {
                    progress += " * ";
                    count++;
                }
            }
            progresstxtbox.Text = progress;
            lastsign = '*';
        }

        private void dividebutton_Click(object sender, EventArgs e)
        {
            try
            {
                operacija = 4;
                if (firstnumber == 0)
                {
                    firstnumber = Convert.ToDouble(a);
                }
                else
                {
                    if(lastsign == '+')
                    {
                        firstnumber = firstnumber + Convert.ToDouble(a);
                    }
                    else if (lastsign == '-')
                    {
                        firstnumber = firstnumber - Convert.ToDouble(a);
                    }
                    else if (lastsign == '*')
                    {
                        firstnumber = firstnumber * Convert.ToDouble(a);
                    }
                    else if (lastsign == '/')
                    {
                        firstnumber = firstnumber / Convert.ToDouble(a);
                    }
                    else if (lastsign == '!')
                    {
                        firstnumber = firstnumber / Convert.ToDouble(a);
                    }
                    else
                    {
                        MessageBox.Show("lastsign = narobe");
                    }
                }
                a = "0";
                txtbox1.Text = Convert.ToString(firstnumber);
            }
            catch (Exception)
            {
                MessageBox.Show("Ni dovoljeno!");
            }
            try
            {
                last = progress[progress.Length - 2];
            }
            catch { }
            if (last == '+' || last == '-' || last == '*' || last == '/' || last == '!')
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == '1' || last == '2' || last == '3' || last == '4' || last == '5' || last == '6' || last == '7' || last == '8' || last == '9' || last == '0')
                {
                    progress += " / ";
                    count++;
                }
            }
            else
            {
                try
                {
                    last = progress[progress.Length - 1];
                }
                catch { }
                if (last == ',')
                {
                    progress += "0 / ";
                }
                else
                {
                    progress += " / ";
                    count++;
                }
            }
            progresstxtbox.Text = progress;
            lastsign = '/';
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            result = 0;
            firstnumber = 0;
            secondnumber = 0;
            a = "0";
            txtbox1.Text = a;
            progress = "";
            progresstxtbox.Text = progress;
        }

        private void equalsbutton_Click(object sender, EventArgs e)
        {
            try
            {
                secondnumber = Convert.ToDouble(a);
            }
            catch (Exception){ }
            a = "0";
            switch (operacija)
            {
                case 1:
                    result = firstnumber + secondnumber;
                    break;
                case 2:
                    result = firstnumber - secondnumber;
                    break;
                case 3:
                    result = firstnumber * secondnumber;
                    break;
                case 4:
                    result = firstnumber / secondnumber;
                    break;
                default:
                    break;
            }
            //MessageBox.Show(Convert.ToString(result));
            if (operacija != 0)
            {
                progress += " = ";
                txtbox1.Text = Convert.ToString(result);
                progress += result + "; ";
            }
            else { }
            result = 0;
            firstnumber = 0;
            secondnumber = 0;
            progresstxtbox.Text = progress;
        }

        private void signednumberbutton_Click(object sender, EventArgs e)
        {
            try
            {
                last = progress[progress.Length - 1];
            }
            catch { }
            if (a == "0")
            {
                a = "-";
                progress += '-';
                txtbox1.Text = a;
            }
            else
            {
                if (last == '-' || last == '1' || last == '2' || last == '3' || last == '4' || last == '5' || last == '6' || last == '7' || last == '8' || last == '9' || last == '0') { }
                else
                {
                    a += '-';
                    progress += '-';
                    txtbox1.Text = a;
                }
            }
            progresstxtbox.Text = progress;
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}


//različne operacije skupi ne dela če je več števil **FIXED**
//+/-/*// na začetku ne napise u progress bar **FIXED**
//dodat da lahka napises negativno stevilo **FIXED**
//vejica fix da jih ne bo pisal u nedogled  **FIXED**
//če prvo napišeš kr vejico nej u progress bar napise 0 ker zdej napiše sam ,6 + 3 = 3,6    RAČUNA PROU **FIXED**
//BONUS:    mogoč bi lahk probu da če prtisneš '=' lahk še vsejen naprej računaš npr.: 3 + 6 = 9 / 3 = 3 
//če napišem 3,6 + 2, pa kliknem operacijo kr računa **FIXED** zdej napiše 0 pa vsejen računa **FIXED**
//custom design **FIXED**kinda**
