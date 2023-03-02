using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioProject
{
    public partial class RadioControlCenter : Form
    {
        private MakeMovable _move;
        public RadioControlCenter()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            _move = new MakeMovable(this);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL",EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg,int wParam,int lParam);


        private void RadioControlCenter_Load(object sender, EventArgs e)
        {
            CreateChannels();
        }

        public Button btn;
        private void CreateChannels()
        {
            int channelCount = RadioStations.stations.Count();
            int row = channelCount / 4;
            if(channelCount% 4 != 0) 
            {
                row++;
            }

            for (int i=0,k=0;i<row && k<channelCount;i++)
            {
                for(int j = 0; j < 4; j++,k++)
                {
                    btn = new Button();
                    btn.Width = 130;
                    btn.Height = 111;
                    if (k < channelCount)
                    {
                        btn.BackgroundImage = Image.FromFile(getImageLink(k));
                    }
                    else
                      break;
    
                    btn.TabIndex = k;
                    btn.BackColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackgroundImageLayout= ImageLayout.Stretch;
                    btn.Anchor= AnchorStyles.None;
                    btn.Top = i * 111;
                    btn.Left = j * 130;
                    btn.MouseClick += PlayChannel;
                    flowLayoutPanel1.Controls.Add(btn);
                }
            }

            if(row > 3)
            {
                //ChannelPanel.AutoScroll= true;
                this.Height += 250;
                //this.MinimumSize=new Size(this.Width,this.Height);
                //this.Height +=170;
            }

            
        }



        private void PlayChannel(object sender, MouseEventArgs e)
        {
            Button btn=sender as Button;
            if (RadioStations.stations.ContainsKey(btn.TabIndex))
            {
                axWindowsMediaPlayer1.URL = RadioStations.stations[btn.TabIndex];
            }
        }

        internal string getImageLink(int index)
        {
            string res="";
            foreach(var imagelink in RadioStations.stationsImage)
            {
                if (imagelink.Item1 == index)
                {
                    res = imagelink.Item3;
                }
            }
            return res;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            //if(WindowState== FormWindowState.Normal) {
            //WindowState= FormWindowState.Maximized;
            //}
            //else
            //{
            //    WindowState= FormWindowState.Normal;
            //}

            WindowState = this.WindowState ^ FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Maximized:WindowState= FormWindowState.Minimized; break;
                case FormWindowState.Normal:WindowState= FormWindowState.Minimized;break;
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private const int cGrip = 16;
        private const int cCaption = 64;

        protected override void OnPaint(PaintEventArgs e)
        {
           Rectangle rc=new Rectangle(ClientSize.Width-cGrip,ClientSize.Height-cGrip,cGrip,cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics,BackColor,rc);
        }
        protected override void WndProc(ref Message m)
        {
            if(m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2; 
                    return;
                }
                if(pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) 
                { 
                    m.Result= (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }


    }
}
