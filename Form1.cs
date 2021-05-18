using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Net;
using Newtonsoft.Json;

namespace LOL_Little_Book
{
    public partial class Form1 : Form
    {
        string gamestats = "https://127.0.0.1:2999/liveclientdata/activeplayername";
        string playerlist = "https://127.0.0.1:2999/liveclientdata/playerlist";
        JArray player;
        string myteam;
        int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }
  
        private void Form1_Load(object sender, EventArgs e)
        { 

                using (StreamReader sr = new StreamReader("./Data/action.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        action.Items.Add(line);
                    }
                }
            Thread th = new Thread(run);
            th.IsBackground = true;
            th.Start();
        }
        void run()
        {
            while (true)
            {
                if (flag == 0)
                {
                    if (httpsreq(gamestats) != "")
                        flag = 1;
                }
                else if (flag==1)
                {
                    player = (JArray)JsonConvert.DeserializeObject(httpsreq(playerlist));
                    myteam = httpsreq(gamestats);
                    myteam = myteam.Substring(1, myteam.Length - 2);
                    for (int i=0;i< player.Count; i++)
                    {
                        if (player[i]["summonerName"].ToString() == myteam)
                            myteam = player[i]["team"].ToString();
                        string _name = player[i]["summonerName"].ToString();
                        string text = File.ReadAllText("Data\\AllUser.txt");
                        if(text.Contains(_name + " 作为"))
                        {
                            string oldline="",line;
                            StreamReader file =new StreamReader("Data\\AllUser.txt");
                            while ((line = file.ReadLine()) != null)
                            {
                                if(line.Contains(_name + " 作为"))
                                {
                                    oldline = line;
                                    string re = line.Substring(line.Length - 9, 9);
                                    int count=int.Parse(System.Text.RegularExpressions.Regex.Replace(re, @"[^0-9]+", ""));
                                    line=line.Replace(re, re.Replace(count.ToString(), (count + 1).ToString()));
                                     
                                    break;
                                }
                            }
                            file.Close();
                            if (line != "")
                                text.Replace(oldline, line);
                            info.Text = line + "\r\n" + info.Text;
                        }
                        name.Items.Add(_name);
                    }
                    state.Text = "正在游戏中";
                    flag = 2;
                }
                else
                {
                    if (httpsreq(gamestats) != "")
                        Thread.Sleep(15000);
                    else
                    {
                        state.Text = "未进行";
                        name.Items.Clear();
                        flag = 0;
                    }
                }
                Thread.Sleep(1000);
            }
        }
        string httpsreq(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                ServicePointManager.ServerCertificateValidationCallback = (sender, certificate, chain, sslPolicyErrors) => true;
                request.Method = "GET";
                request.Timeout = 3000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                return (new StreamReader(response.GetResponseStream())).ReadToEnd();
            }
            catch (WebException ex)
            {
                return "";
            }
        }

        private void name_SelectedIndexChanged(object sender, EventArgs e)
        {
            hero.Text = player[name.SelectedIndex]["championName"].ToString();
            if (name.Items.Count == 8)
            {
                team.Text = "狗对手";
            }
            else
            {
                if (myteam == player[name.SelectedIndex]["team"].ToString())
                    team.Text = "猪队友";
                else
                    team.Text = "狗对手";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("Data\\AllUser.txt");
            string _name = name.SelectedItem.ToString();
            if (_name == "") return;
            if (!text.Contains(_name + " 作为")) 
            { 
                File.AppendAllText("Data\\AllUser.txt", DateTime.Now.ToShortDateString().ToString()+":"+_name + " 作为 "+ team.Text+"玩 "+hero.Text+ selecta() + " 这是第1次遇到\r\n");
                info.Text = _name + "添加成功！\r\n" + info.Text;
                //string line = name.Text + " 作为 " + team.Text + "玩 " + hero.Text + selecta() + " 这是第1次遇到";
                //string re = line.Substring(line.Length - 9, 9);
                //int count = int.Parse(System.Text.RegularExpressions.Regex.Replace(re, @"[^0-9]+", ""));
                //line = line.Replace(re, re.Replace(count.ToString(), (count + 1).ToString()));
                //info.Text += line;
            }
            else
            {
                info.Text = "此人在小本本里了，可恶，真是带恶人\r\n" + info.Text;
            }
        }
        string selecta()
        {
            string res = "";
            bool flag = false;
            for(int i=0;i< action.Items.Count; i++)
            {
                if (action.GetItemChecked(i))
                {
                    string rv = action.GetItemText(action.Items[i]);
                    res +=(flag?"还":" ")+rv;
                    flag = true;
                }
            }
            return res;
        }
    }
}
