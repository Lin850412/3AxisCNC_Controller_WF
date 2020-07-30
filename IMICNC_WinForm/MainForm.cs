using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EtherCATSeries;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Diagnostics;

namespace IMICNC_WinForm
{
    public partial class MainForm : Form
    {

        bool ToolStatus_Picture = true;
        bool ServerStatus_Picture = true;
        float SpeedValue = 0;
        float FeedSpeedValue = 0;

        Coordinate coordinate;
        GCode gCode;
        Information information;
        Monitor monitor;
        Tool tool;

        public static Axis<ushort> PositiveLimitSwitchStatus = new Axis<ushort>();
        public static Axis<ushort> NegativeLimitSwitchStatus = new Axis<ushort>();

        public MainForm()
        {
            InitializeComponent();

            coordinate = new Coordinate();
            gCode = new GCode();
            information = new Information();
            monitor = new Monitor();
            tool = new Tool();

            gCode.UserComfirmEvent += new GCode.UserComfirmEventHandler(this.ComfirmGCode);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CBox_JOG.SelectedIndex = 0;
            MCCL.MCC_EnableLimitSwitchCheck(0);

            //連線EMP-Z
            MCCLManager.ConnectEMPZ();
            PB_PowerLight.Image = Image.FromFile(Application.StartupPath + "\\Picture\\Power_Light2.png");

            //執行緒
            bgwThred.RunWorkerAsync();

            //將所有分頁加載入MainPanel
            MainPanel.Controls.Add(coordinate);
            MainPanel.Controls.Add(gCode);
            MainPanel.Controls.Add(information);
            MainPanel.Controls.Add(monitor);
            MainPanel.Controls.Add(tool);

            //顯示所有分頁
            coordinate.Show();
            gCode.Show();
            information.Show();
            monitor.Show();
            tool.Show();

            //僅先顯示coordinate頁面
            coordinate.Visible = true;
            gCode.Visible = false;
            information.Visible = false;
            monitor.Visible = false;
            tool.Visible = false;
        }

        private void UpdatUI()
        {
            Lb_Time.Text = DateTime.Now.ToString();
            Lb_Speed.Text = (SpeedValue).ToString("##00000");
            Lb_FeedSpeed.Text = (FeedSpeedValue).ToString("##00000");
            LimitStatus();

        }

        private void ComfirmGCode(string[] code)
        {
            coordinate.Visible = false;
            gCode.Visible = false;
            information.Visible = false;
            monitor.Visible = true;
            tool.Visible = false;
            monitor.GCodeDisplay(code);
        }

        #region GoTo
        private void Btn_GoToCoordinate_Click(object sender, EventArgs e)
        {
            coordinate.Visible = true;
            gCode.Visible = false;
            information.Visible = false;
            monitor.Visible = false;
            tool.Visible = false;
        }

        private void Btn_GoToCode_Click(object sender, EventArgs e)
        {
            coordinate.Visible = false;
            gCode.Visible = true;
            information.Visible = false;
            monitor.Visible = false;
            tool.Visible = false;
        }

        private void Btn_GoToMonitor_Click(object sender, EventArgs e)
        {
            coordinate.Visible = false;
            gCode.Visible = false;
            information.Visible = false;
            monitor.Visible = true;
            tool.Visible = false;
        }

        private void Btn_GoToParrameter_Click(object sender, EventArgs e)
        {
            coordinate.Visible = false;
            gCode.Visible = false;
            information.Visible = false;
            monitor.Visible = false;
            tool.Visible = true;
        }

        private void Btn_GoToInformation_Click(object sender, EventArgs e)
        {
            coordinate.Visible = false;
            gCode.Visible = false;
            information.Visible = true;
            monitor.Visible = false;
            tool.Visible = false;
        }
        #endregion

        #region bgwThread執行緒

        private void bgwThred_DoWork(object sender, DoWorkEventArgs e)
        {
            //Reciev work here
            while (true)
            {
                Thread.Sleep(10);
                if (bgwThred.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    //dowork here
                    MCCLManager.GetMCCLData();

                    DateTime.Now.ToShortDateString();
                    DateTime.Now.ToString("HH:mm:ss");

                    bgwThred.ReportProgress(1);
                }

            }
        }
        private void bgwThred_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.UpdatUI();
            //更新座標值
            coordinate.UpdateUI();
            monitor.UpdateUI();
            gCode.UpDateUI();

            double i = MCCLManager.machanicalCoordinate.X;
        }

        #endregion

        #region 開關
        private void PB_Start_Click(object sender, EventArgs e)
        {
            MCCLManager.ConnectEMPZ();
            MCCLManager.SetMachineParameter();
            MCCLManager.StartEMPZ();
            MCCLManager.ServoOn();
            ServerStatus_Picture = true;
            ServerStatus();
            PB_PowerLight.Image = Image.FromFile(Application.StartupPath + "\\Picture\\Power_Light2.png");
        }

        private void PB_Stop_Click(object sender, EventArgs e)
        {
            MCCLManager.ServoOff();
            MCCLManager.SpindleOff();
            ServerStatus_Picture = false;
            ServerStatus();
        }

        private void BtnEGS_Click(object sender, EventArgs e)
        {
            MCCLManager.ServoOff();
            MCCLManager.EndEMPZ();
            MCCLManager.DisConnectEMPZ();
            MCCLManager.SpindleOff();
            ServerStatus_Picture = false;
            ServerStatus();
            PB_PowerLight.Image = Image.FromFile(Application.StartupPath + "\\Picture\\Power_Light.png");
        }

        private void ServerStatus()
        {
            if (ServerStatus_Picture)
            {
                PB_Start.Image = Image.FromFile(Application.StartupPath + "\\Picture\\START2.png");
                PB_Stop.Image = Image.FromFile(Application.StartupPath + "\\Picture\\STOP.png");
            }
            else
            {
                PB_Start.Image = Image.FromFile(Application.StartupPath + "\\Picture\\START.png");
                PB_Stop.Image = Image.FromFile(Application.StartupPath + "\\Picture\\STOP2.png");
            }
        }

        #endregion

        #region 主軸
        private void Btn_SpindleRun_Click(object sender, EventArgs e)
        {
            if (MCCLManager.isSpindleOn == false)
            {
                MCCLManager.SpindleOn();
                SpeedValue = 5000;
            }
            else
            {
                MessageBox.Show("Have on");
            }
        }

        private void Btn_SpindleStop_Click(object sender, EventArgs e)
        {
            if (MCCLManager.isSpindleOn == true)
            {
                MCCLManager.SpindleOff();
                SpeedValue = 0;
            }
            else
            {
                MessageBox.Show("Have off");
            }
        }


        #endregion

        #region JOG Contiune

        private void PB_JogX1_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 0, direction = 1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }
            //更換圖片
            PB_JogX1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD2.png");
        }

        private void PB_JogX2_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 0, direction = -1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }

            PB_JogX2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE2.png");
        }

        private void PB_JogY1_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 1, direction = 1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }
            PB_JogY1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD2.png");
        }

        private void PB_JogY2_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 1, direction = -1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }
            PB_JogY2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE2.png");
        }

        private void PB_JogZ1_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 2, direction = 1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }
            PB_JogZ1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD2.png");
        }

        private void PB_JogZ2_MouseDown(object sender, MouseEventArgs e)
        {
            sbyte axis = 2, direction = -1;
            if (CBox_JOG.SelectedIndex == 0)
            {
                MCCLManager.JogConti(axis, direction);
            }
            PB_JogZ2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE2.png");
        }

        private void PB_JogX1_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            //換回圖片
            PB_JogX1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD.png");
        }

        private void PB_JogX2_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            PB_JogX2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE.png");
        }

        private void PB_JogY1_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            PB_JogY1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD.png");
        }

        private void PB_JogY2_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            PB_JogY2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE.png");
        }

        private void PB_JogZ1_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            PB_JogZ1.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD.png");
        }

        private void PB_JogZ2_MouseUp(object sender, MouseEventArgs e)
        {
            JogMouseUp();
            PB_JogZ2.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE.png");
        }

        private void JogMouseUp()
        {
            if (CBox_JOG.SelectedIndex == 0)
                MCCLManager.MCC_AbortMotionEx();
        }

        #endregion

        #region JOG Space
        private void PB_JogX1_Click(object sender, EventArgs e)
        {
            sbyte axis = 0, direction = 1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }

        private void PB_JogX2_Click(object sender, EventArgs e)
        {
            sbyte axis = 0, direction = -1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }

        private void PB_JogY1_Click(object sender, EventArgs e)
        {
            sbyte axis = 1, direction = 1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }

        private void PB_JogY2_Click(object sender, EventArgs e)
        {
            sbyte axis = 1, direction = -1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }

        private void PB_JogZ1_Click(object sender, EventArgs e)
        {
            sbyte axis = 2, direction = 1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }

        private void PB_JogZ2_Click(object sender, EventArgs e)
        {
            sbyte axis = 2, direction = -1;
            if (CBox_JOG.SelectedIndex == 1)
            {
                MCCLManager.JogSpace(axis, direction);
            }
        }
        #endregion

        #region Machining
        private void Btn_GoHome_Click(object sender, EventArgs e)
        {
            MCCLManager.MCC_GoHome();
        }

        private void Btn_DefineMachining_Click(object sender, EventArgs e)
        {
            MCCLManager.MCC_DefineMachining();
        }
        #endregion

        #region Speed

        private void PB_SpeedAdd_Click(object sender, EventArgs e)
        {
            SpeedValue += 1000;
        }

        private void PB_SpeedRed_Click(object sender, EventArgs e)
        {
            SpeedValue -= 1000;
        }

        private void PB_RateAdd_Click(object sender, EventArgs e)
        {
            FeedSpeedValue += 10;
        }

        private void PB_RateRed_Click(object sender, EventArgs e)
        {
            FeedSpeedValue -= 10;
        }
        
        private void Lb_Speed_TextChanged(object sender, EventArgs e)
        {
            MCCLManager.ToolRPMChange(SpeedValue / 5000);
        }

        private void Lb_FeedSpeed_TextChanged(object sender, EventArgs e)
        {
            //MCCLManager.SetFeedSpeed(FeedSpeedValue / 60);
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {
            MCCLManager.ToolRPMChange(Convert.ToInt32(Txt_Speed.Text) / 5000);
            SpeedValue = Convert.ToInt32(Txt_Speed.Text);
        }

        private void btnFeedSpeed_Click(object sender, EventArgs e)
        {
            //MCCLManager.SetFeedSpeed(Convert.ToInt32(Txt_FeedSpeed.Text) / 60);
            //FeedSpeedValue = Convert.ToInt32(Txt_FeedSpeed.Text);
        }


        #region 處理按鈕的圖片
        private void PB_SpeedAdd_MouseDown(object sender, MouseEventArgs e)
        {
            PB_SpeedAdd.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD2.png");
        }

        private void PB_SpeedRed_MouseDown(object sender, MouseEventArgs e)
        {
            PB_SpeedRed.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE2.png");
        }

        private void PB_RateAdd_MouseDown(object sender, MouseEventArgs e)
        {
            PB_RateAdd.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD2.png");
        }

        private void PB_RateRed_MouseDown(object sender, MouseEventArgs e)
        {

            PB_RateRed.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE2.png");
        }

        private void PB_SpeedAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PB_SpeedAdd.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD.png");
        }

        private void PB_SpeedRed_MouseUp(object sender, MouseEventArgs e)
        {
            PB_SpeedRed.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE.png");
        }

        private void PB_RateAdd_MouseUp(object sender, MouseEventArgs e)
        {
            PB_RateAdd.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ADD.png");
        }

        private void PB_RateRed_MouseUp(object sender, MouseEventArgs e)
        {
            PB_RateRed.Image = Image.FromFile(Application.StartupPath + "\\Picture\\REDUCE.png");
        }
        #endregion
        #endregion

        #region 刀具夾緊

        private void PB_ToolClamp_Click(object sender, EventArgs e)
        {
            MCCLManager.ClampTool();
            //夾緊刀具
            ToolStatus_Picture = true;
            StatusDisplay();
        }

        private void PB_ToolRelease_Click(object sender, EventArgs e)
        {
            MCCLManager.UnClampTool();
            //鬆開刀具
            ToolStatus_Picture = false;
            StatusDisplay();
        }

        private void StatusDisplay()
        {
            if (ToolStatus_Picture)
            {
                PB_ToolClamp.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ToolClamp2.png");
                PB_ToolRelease.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ToolRelease.png");
            }
            else
            {
                PB_ToolClamp.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ToolClamp.png");
                PB_ToolRelease.Image = Image.FromFile(Application.StartupPath + "\\Picture\\ToolRelease2.png");
            }
        }


















        #endregion
        
        #region LimitLight
        private void LimitStatus()
        {
            //MCCL.MCC_EnableLimitSwitchCheck();
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.X, 0, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.Y, 0, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.Z, 0, 2, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.X, 1, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.Y, 1, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.Z, 1, 2, MCCL.CARDINDEX0);
            Debug.Print("limit-:" + PositiveLimitSwitchStatus.X.ToString());

            if (PositiveLimitSwitchStatus.X != 0)
            {
                PB_LimitX.Image = Image.FromFile(Application.StartupPath + "\\Picture\\Limit_Light2.png");
                Debug.Print("Y");
            }
            else
            {
                PB_LimitX.Image = Image.FromFile(Application.StartupPath + "\\Picture\\Limit_Light.png");
                Debug.Print("N");
            }


        }
        #endregion
    
    }
}