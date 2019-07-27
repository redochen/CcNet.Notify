using System;
using System.Drawing;
using System.Windows.Forms;
using CcNet.Utils;
using CcNet.Utils.Extensions;
using CcNet.Utils.Forms;

namespace CcNet.NotifySvc
{
    public partial class FrmMain : ImageForm
    {
        private bool m_IsRunning = false;
        private int m_AnimHeight = 0;
        private const int m_HeightStep = 100;
        private int m_MaxHeight = 0;

        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            m_MaxHeight = pnlConsole.Height;
            Init();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_IsRunning)
            {
                MessageBox.Show("请先停止服务后再退出");
                e.Cancel = true;
                return;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Visible == false)
            {
                this.Visible = true;
                this.notifyIcon.Visible = false;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Minimized;
            if (this.WindowState == FormWindowState.Normal)
            {
                this.notifyIcon.Visible = true;
                this.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if (m_AnimHeight == 0)
            {
                m_AnimHeight = pnlConsole.Visible ? -m_MaxHeight : m_MaxHeight;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (m_AnimHeight > 0) //显示
            {
                pnlConsole.Visible = true;
                m_AnimHeight -= m_HeightStep;
                if (m_AnimHeight <= 0)
                {
                    m_AnimHeight = 0;
                    btnVisible.Text = "∧";
                }

                this.ResizeCtrl(0, m_HeightStep);
            }
            else if (m_AnimHeight < 0) //隐藏
            {
                m_AnimHeight += m_HeightStep;
                if (m_AnimHeight >= 0)
                {
                    m_AnimHeight = 0;
                    btnVisible.Text = "∨";
                    pnlConsole.Visible = false;
                }

                this.ResizeCtrl(0, -m_HeightStep);
            }
        }

        private void btnOperate_Click(object sender, EventArgs e)
        {
            if (m_IsRunning)
            {
                if (MessageBox.Show("您确定要停止服务吗？", "确认",
                    MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }

                WriteLine(StopServer().GetValue("服务已停止"));
            }
            else
            {
                WriteLine(StartServer().GetValue("服务已启动"));
            }

            m_IsRunning = RpcService.Singleton.IsStarted;
            ChangeButtonStyle();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeginMove();
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            OnMove();
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EndMove();
            }
        }

        private void Init()
        {
            cbProtocols.BindData("http", "tcp4");
            cbProtocols.AutoFitItemHeight();
            cbProtocols.SelectedIndex = 0;

            cbNotifiers.BindData("DingTalkNotifier");
            cbNotifiers.AutoFitItemHeight();
            cbNotifiers.SelectedIndex = 0;
        }

        private void ChangeButtonStyle()
        {
            if (m_IsRunning)
            {
                btnOperate.Text = "停止";
                btnOperate.Appearances.Appearance.BackColorStart =
                    btnOperate.Appearances.Appearance.BackColorEnd = Color.Green;

                cbProtocols.Enabled = txtPort.Enabled = cbNotifiers.Enabled = false;
            }
            else
            {
                btnOperate.Text = "启动";
                btnOperate.Appearances.Appearance.BackColorStart =
                    btnOperate.Appearances.Appearance.BackColorEnd = Color.Red;
            }
        }

        private string StartServer()
        {
            var protocol = cbProtocols.GetSelectedText<string>();
            var port = txtPort.Text.ToInt();
            if (port < 80 || port > 35565)
            {
                return "启动服务失败：端口号应在80 ~ 35565之间";
            }

            return RpcService.Singleton.Start(protocol, port,
                cbNotifiers.GetSelectedText<string>(),
                writeLog: (level, msg) => WriteLine($"[{level.GetValue()}] {msg.GetValue()}"));
        }

        private string StopServer() => RpcService.Singleton.Stop();

        private void WriteLine(string text)
        {
            if (!text.IsValid())
            {
                return;
            }

            var time = DateTime.Now.ToString("MM-dd HH:mm:ss");
            txtConsole.Text = $"[{time}] {text}{Chars.换行符.ToString()}{txtConsole.Text}";
        }
    }
}