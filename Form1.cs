using System;
using System.IO;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace UserAgentFinder
{
    public partial class Form1 : Form
    {
        public static string J2J2;

        public Form1()
        {
            InitializeComponent();

            J2J2 = PHPH("Win32_Processor", "ProcessorId");

            textBox1.Text = XXXX();
            textBox2.Text = J2J2 + Environment.UserName + WXWX();

            //textBox3.Text = xXxX("/LEVEL/5/VIN=/CALID=/REV=/ALGO=", XXXX());
            //textBox3.Text = xXxX("/version", XXXX());
            textBox3.Text = xXxX("/LEVEL/5/VIN=/CALID=/REV=/ALGO=", XXXX());

            TestString(textBox3.Text);
        }

        private void TestString(string A_1)
        {
            int qYAqYA = 0;
            int QYAQYA = 0;
            int rYArYA = 0;
            int RYARYA = 0;
            int sYAsYA = 0;
            int SYASYA = 0;
            int tYAtYA = 0;
            int TYATYA = 0;
            int uYAuYA = 0;
            int UYAUYA = 0;
            int vYAvYA = 0;
            int VYAVYA = 0;
            int wYAwYA = 0;
            int WYAWYA = 0;
            int xYAxYA = 0;
            int XYAXYA = 0;
            int yYAyYA = 0;
            int YYAYYA = 0;

            string[] array = A_1.Split(new char[]
            {
                '/'
            });
            try
            {
                qYAqYA = int.Parse(array[0]);  //213
                QYAQYA = int.Parse(array[1]);  //243
                rYArYA = int.Parse(array[2]);  //14
                RYARYA = int.Parse(array[3]);  //27
                sYAsYA = int.Parse(array[4]);  //159
                SYASYA = int.Parse(array[5]);  //117
                tYAtYA = int.Parse(array[6]);  //223
                TYATYA = int.Parse(array[7]);  //185
                uYAuYA = int.Parse(array[8]);  //250
                UYAUYA = int.Parse(array[9]);  //196
                vYAvYA = int.Parse(array[10]); //246
                VYAVYA = int.Parse(array[11]); //164
                wYAwYA = int.Parse(array[12]); //124
                WYAWYA = int.Parse(array[13]); //117
                xYAxYA = int.Parse(array[14]); //19
                XYAXYA = int.Parse(array[15]); //146
                yYAyYA = int.Parse(array[16]); //58
                YYAYYA = int.Parse(array[17]); //100
                //bebe = new AxAx();
                //bebe.rZrZ.Start();
                qYAqYA = yYAyYA + YYAYYA - RYARYA;  //58 + 100 - 27		= 131
                sYAsYA = QYAQYA - rYArYA - RYARYA;  //243 - 14 - 27		= 202
                rYArYA = rYArYA + yYAyYA - SYASYA;  //14 + 58 - 117		= -45
                RYARYA = YYAYYA - WYAWYA + rYArYA;  //100 - 117 + -45	= -62
                QYAQYA = WYAWYA - RYARYA + rYArYA;  //117 - -62 + -45	= 10
                TYATYA = TYATYA - uYAuYA + wYAwYA;  //185 - 250 + 124	= 59
                vYAvYA = sYAsYA - xYAxYA + 255;          //202 - 19 + 255	= 438
                WYAWYA = sYAsYA - 255 + QYAQYA;          //202 - 255 + 10	= -43

                if (QYAQYA == 0
                    && rYArYA == 0
                    && RYARYA == 0
                    && sYAsYA == 0
                    && SYASYA == 0
                    && tYAtYA == 0
                    && TYATYA == 0
                    && uYAuYA == 0
                    && UYAUYA == 0
                    && vYAvYA == 0
                    && VYAVYA == 0
                    && wYAwYA == 0
                    && WYAWYA == 0)
                {
                    A_1 = "License Key accepted";
                    //5YA5YA.hYAhYA = true;
                }
                else
                {
                    A_1 = "License expired";
                    //5YA5YA.hYAhYA = false;
                }
            }
            catch
            {
                A_1 = "Failed to unlock security there is something wrong with your license key.";
            }

            MessageBox.Show(A_1);
        }

        //#########################################

        public static string xXxX(string A_0, string A_1)
        {
            string text = "";
            bool nYnY = false;  //Offline

            if (!nYnY)
            {
                //A_0 = "/version"
                //A_0 = "/Updates/" + Environment.UserName + "[" + this.NlNl.uHuH + "]:" + AxAx.I2I2 + ":" + AxAx.j2j2 + ":" + AxAx.J2J2
                //A_0 = "/LEVEL/" + A_1.ToString() + "/VIN=" + this.vRvR.Text + "/CALID=" + this.6R6R.Text + "/REV=" + A_2 + "/ALGO=" + A_3
                //A_0 = "/LEVEL/5/VIN=/CALID=/REV=/ALGO=" <--####### TRY SEND THIS COMMAND TO RECEIVE POSSIBLE COMMAND ARRAY??

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://vip.hondatuningsuite.com" + A_0);
                httpWebRequest.UserAgent = A_1;
                httpWebRequest.Timeout = 8000;
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Stream responseStream = httpWebResponse.GetResponseStream();
                StreamReader streamReader = new StreamReader(responseStream);
                char[] array = new char[512];
                for (int i = streamReader.Read(array, 0, 512); i > 0; i = streamReader.Read(array, 0, 512))
                {
                    string str = new string(array, 0, i);
                    text += str;
                }
                streamReader.Close();
                responseStream.Close();
                httpWebResponse.Close();
            }
            return text;
        }

        //#########################################

        public static string PHPH(string A_0, string A_1)
        {
            string text = "";
            ManagementClass managementClass = new ManagementClass(A_0);
            ManagementObjectCollection instances = managementClass.GetInstances();
            foreach (ManagementBaseObject managementBaseObject in instances)
            {
                ManagementObject managementObject = (ManagementObject)managementBaseObject;
                if (text == "")
                {
                    try
                    {
                        text = managementObject[A_1].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
            }
            return text;
        }

        public static string WXWX()
        {
            return DateTime.Today.Hour.ToString() + DateTime.Today.Minute.ToString();
        }

        public static string XXXX()         //GetUserAgent
        {
            //AxAx.J2J2 = pHpH.PHPH("Win32_Processor", "ProcessorId");
            //return DateTime.Today.Hour.ToString() + DateTime.Today.Minute.ToString();

            //"6E3-FEBF-BAF3-33C4-FBFF"
            //BFEBFBFF000506E3
            Console.WriteLine(J2J2);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(WXWX());

            MD5 md = MD5.Create();
            //byte[] bytes = Encoding.ASCII.GetBytes(J2J2 + Environment.UserName + WXWX());
            byte[] bytes = Encoding.ASCII.GetBytes(J2J2 + "doug" + WXWX());
            byte[] array = md.ComputeHash(bytes);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                stringBuilder.Append(array[i].ToString("X2"));
            }
            return stringBuilder.ToString();
        }
    }
}
