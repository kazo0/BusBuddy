using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;


namespace WindowsApplication3
{
    public partial class frmBusBuddy : Form
    {
        public frmBusBuddy()
        {
            InitializeComponent();

        }


        private void btnSrch_Click(object sender, EventArgs e)
        {
            for (int index = panel1.Controls.Count - 1; index >= 0; index--)
                // Remove the controls.
                panel1.Controls.RemoveAt(index);
            string dir = (string)drpDir.SelectedItem;
            //dir = dir.Substring(0, 1);
            string url = "http://m.stm.info/en/schedules/bus/" + txtNumber.Text + "/stops?direction=" + dir;
            string sourceCode = WorkerClass.getStopCodes(url);
            //string[] times = sourceCode.Split(' ');
            //StreamWriter sw = new StreamWriter("website.txt");
            // sw.Write(sourceCode);
            // sw.Close();

            //txtTime1.Text = times[0];
            //txtTime2.Text = times[1];
            //txtTime3.Text = times[2];
            tabs.SelectedIndex = 1;
            string[] a = sourceCode.Split('\n');
            int num = a.Length;
            string code = "";
            LinkLabel[] links = new LinkLabel[num];
            //build the linklabel properties
            for (int i = 0; i < num - 1; i++)
            {
                links[i] = new LinkLabel();
                links[i].Click += new System.EventHandler(this.linkLabel_Click);
                var pattern = @"\(\d+\)";
                var matches = Regex.Matches(a[i], pattern);
                foreach (Match m in matches)
                {
                    code = m.Groups[0].ToString();
                }
                //remove brackets around bus stop code
                if (code.Length > 2)
                {
                    code = code.Substring(1, code.Length - 2);
                }
                //The Tag property is "busCode|busLineNumber
                links[i].Tag = code + "|" + txtNumber.Text + "|" + dir;
                links[i].Text = a[i];
                links[i].AutoSize = true;
                Point p = new Point(0, 0);
                if (i > 0)
                {
                    p.X = 0;
                    p.Y = links[i - 1].Location.Y + 15;
                }
                links[i].Location = p;
               

                panel1.Controls.Add(links[i]);
            }
            //a[0].to
            //lblStops.Text = ;

        }

        private void linkLabel_Click(object sender, EventArgs e)
        {
            LinkLabel linklbl = sender as LinkLabel;
            for (int index = panel3.Controls.Count - 1; index >= 0; index--)
                // Remove the controls.
                panel3.Controls.RemoveAt(index);
            string code = linklbl.Tag.ToString().Split('|')[0];
            string num = linklbl.Tag.ToString().Split('|')[1];
            string dir = linklbl.Tag.ToString().Split('|')[2];
            txtNumber.Text = num;
            
            string url = "http://m.stm.info/en/schedules/bus/" + num + "/stops/" + code + "/arrivals?limit=5&direction=" + dir;
            string source = WorkerClass.getTimes(url, num);
            string[] times = source.Split(' ');
            times = WorkerClass.englishifyTimes(times);
            lblTime1.Text = times[0];
            lblTime2.Text = times[1];
            lblTime3.Text = times[2];
            lblStop.Text = linklbl.Text.Split('|')[0];
            tabs.SelectedIndex = 2;
            /*
            string[] alts = WorkerClass.getAlts(code, num);
            if (!(alts == null))
            {
                LinkLabel[] links = new LinkLabel[alts.Length];
                for (int i = 0; i < alts.Length; i++)
                {
                    links[i] = new LinkLabel();
                    links[i].Click += new System.EventHandler(this.linkLabel_Click);
                    links[i].Tag = code + "|" + alts[i];
                    links[i].Text = "Ligne " + alts[i];
                    links[i].AutoSize = true;
                    Point p = new Point(0, 0);
                    if (i > 0)
                    {
                        p.X = 0;
                        p.Y = links[i - 1].Location.Y + 15;
                    }
                    links[i].Location = p;


                    panel3.Controls.Add(links[i]);
                }
            }*/


            string urlLoc1 = linklbl.Text.Split('[')[0];
            string urlLoc = urlLoc1.Remove(urlLoc1.Length - 3, 3);
            //string f = urlLoc.Replace(' ', '+');
            string go = Uri.EscapeUriString(urlLoc);
            string Url2 = "http://maps.googleapis.com/maps/api/streetview?size=400x400&location=" + go + "&fov=110&sensor=false";
            string Url = "http://maps.googleapis.com/maps/api/staticmap?center=" + go + "&zoom=14&size=240x240&maptype=roadmap&markers=red%7C" + go + "&sensor=false";
            webBrowser1.Navigate(Url);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!WorkerClass.checkFave(lblStop.Text))
            {
                StreamWriter sw = new StreamWriter("faves.txt", true);
                string[] str = lblStop.Text.Split('[');
                // string tag = str[1].Remove(str[1].Length - 1, 1) + "|" + txtNumber.Text;
                string fave = lblStop.Text + "|" + txtNumber.Text;
                sw.WriteLine(fave);
                sw.Close();
                button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete));
            }
            else
            {
                WorkerClass.delFave(lblStop.Text);
                button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add));
            }

        }
        private void tabs_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (tabs.SelectedIndex == 3)
            {
                for (int index = panel2.Controls.Count - 1; index >= 0; index--)
                    // Remove the controls.
                    panel2.Controls.RemoveAt(index);

                string faves = "";
                StreamReader sr = new StreamReader("faves.txt");
                while (!sr.EndOfStream)
                {
                    faves += sr.ReadLine();
                    if (!sr.EndOfStream)
                    {
                        faves += "^";
                    }

                }
                
                sr.Close();
                if (!(faves == ""))
                {
                    string[] lines = faves.Split('^');

                    int num = lines.Length;
                    LinkLabel[] links = new LinkLabel[num];
                    for (int i = 0; i < num; i++)
                    {
                        links[i] = new LinkLabel();
                        links[i].Click += new System.EventHandler(this.linkLabel_Click);
                        string[] str = lines[i].Split('[');
                        string goodStr = str[1].Replace("]", "");
                        links[i].Tag = goodStr;
                        links[i].Text = lines[i];
                        links[i].AutoSize = true;
                        Point p = new Point(0, 0);
                        if (i > 0)
                        {
                            p.X = 0;
                            p.Y = links[i - 1].Location.Y + 15;
                        }
                        links[i].Location = p;
                        panel2.Controls.Add(links[i]);
                    }
                }
            }
            if (tabs.SelectedIndex == 2)
            {
                if (WorkerClass.checkFave(lblStop.Text))
                {
                    button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.delete));
                }
                else
                {
                    button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add));
                }
               
            }
        }

        private void frmBusBuddy_Load(object sender, EventArgs e)
        {
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.add));
        }


    }
}