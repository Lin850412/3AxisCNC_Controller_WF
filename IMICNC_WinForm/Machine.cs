using EtherCATSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMICNC_WinForm
{
    sealed class Machine : INotifyPropertyChanged
    {
        //Databinding
        public event PropertyChangedEventHandler PropertyChanged;

        //Singleton
        private static readonly Machine instance = new Machine();

        public static Machine Instance
        {
            get { return instance; }
        }


        //控制器IP
        private string controllerIP = "192.168.0.2";    
        public string ControllerIP
        {
            get { return controllerIP; }
            set { controllerIP = value; }
        }

        //EtherCAT Slave數
        private int slaveNum = 8;   
        public int SlaveNum
        {
            get { return slaveNum; }
            set { slaveNum = value; }
        }

        //控制器代號
        private int cardIndex = MCCL.CARDINDEX0;        
        public int CardIndex
        {
            get { return cardIndex; }
            set { cardIndex = value; }
        }

        //最大運動軸數
        private ushort maxAxis = 3;                     
        public ushort MaxAxis
        {
            get { return maxAxis; }
            set { maxAxis = value; }
        }

        //運動群
        private ushort Group { set; get; }

        //InterpoTime
        private int ipot = 1;
        public int IPOT
        {
            get { return ipot; }
            set { ipot = value; }
        }
        
        //最大速度
        private double machineMaxSpeed = 100;
        public double MachineMaxSpeed
        {
            get { return machineMaxSpeed; }
            set { machineMaxSpeed = value; }
        }



        //機台描述屬性
        //public Axis<double> MachanicalCoordinate = new Axis<double>();
        //public Axis<double> AbsoluteCoordinate = new Axis<double>();
        //public Axis<double> RelativeCoordinate = new Axis<double>();

        /// <summary>
        /// 建構子，欄位初始化
        /// </summary>
        private Machine()
        {
            //
        }

        public void ConnectController()
        {
            byte[] tmp = Encoding.ASCII.GetBytes(this.ControllerIP);
            int result = MCCL.MCC_Init(ref tmp[0], ref cardIndex, 8);
            if (result < 0)
            {
                Debug.WriteLine("Connect Error");
            }
            else if (result > 0)
            {
                Debug.WriteLine("Connect Sucessful");
            }
            else
            {
                Debug.WriteLine("result =" + result.ToString());
            }
        }

        public void DisConnectController()
        {
            try
            {
                MCCL.MCC_Close();
            }
                
            catch { }
        }

        public void SetParamSetMachineParameter()
        {
            MCCL.SYS_MAC_PARAM stMacParam = new MCCL.SYS_MAC_PARAM();
            MCCL.SYS_ENCODER_CONFIG stENCConfig = new MCCL.SYS_ENCODER_CONFIG();
            MCCL.SYS_HOME_CONFIG stHomeConfig = new MCCL.SYS_HOME_CONFIG();

            //MCCL物件參數初始化_機構參數
            stMacParam.wPosToEncoderDir = 0;
            stMacParam.dwPPR = 1048576;
            stMacParam.wRPM = 3000;
            stMacParam.dfPitch = 8.23;
            stMacParam.dfGearRatio = 1.0;
            stMacParam.dfHighLimit = 50000.0;
            stMacParam.dfLowLimit = -50000.0;
            stMacParam.dfHighLimitOffset = 0;
            stMacParam.dfLowLimitOffset = 0;
            stMacParam.wPulseMode = MCCL.DDA_FMT_PD;
            stMacParam.wPulseWidth = 100;
            stMacParam.wCommandMode = 0;
            stMacParam.wOverTravelUpSensorMode = 0;
            stMacParam.wOverTravelDownSensorMode = 0;

            for (ushort wChannel = 0; wChannel < MaxAxis; wChannel++)
            {
                MCCL.MCC_SetMacParam(ref stMacParam, wChannel, 0);
            }

            MCCL.MCC_CloseAllGroups();
            Group = (ushort)MCCL.MCC_CreateGroup(0, 1, 2, -1, -1, -1, -1, -1, CardIndex);

            if(Group<0)
            {
                Debug.WriteLine("Create Group Fail");
                MCCL.MCC_CloseAllGroups();
            }

            MCCL.MCC_SetSysMaxSpeed(MachineMaxSpeed);
        }

        public void StartController()
        {
            MCCL.SYS_CARD_CONFIG stCardConfig = new MCCL.SYS_CARD_CONFIG();
            stCardConfig.wCardType = 4;
            MCCL.ErrorCode eRet;
            eRet = MCCL.MCC_InitSystem(IPOT, ref stCardConfig, 1);
            if (eRet < 0)
            {
                MessageBox.Show("MCC_InitSystem Error :" + eRet.ToString());
                return;
            }
            else
            {
                // CmdQueueSize設定
                MCCL.MCC_SetCmdQueueSize(50000, 0);
                int sixe = MCCL.MCC_GetCmdQueueSize(0);
                MessageBox.Show("" + sixe.ToString());

                //座標軸設定
                //MCCL.MCC_SetIncrease(nGroupIndex);    //相對
                MCCL.MCC_SetAbsolute(Group);  //絕對
                int eerocode = MCCL.MCC_GetCoordType(Group);
                if (eerocode == 0)
                {
                    MessageBox.Show("IncreaseOpen");
                }
                else if (eerocode == 1)
                {
                    MessageBox.Show("AbsoluteOpen");
                }

                //DryRun設定  DryRun可
                //MCCL.MCC_EnableDryRun();
                MCCL.MCC_DisableDryRun();
                eerocode = MCCL.MCC_CheckDryRun();
                if (eerocode == 0)
                {
                    MessageBox.Show("dryrunopen");
                }
                else if (eerocode == 1)
                {
                    MessageBox.Show("dryrunclose");
                }

                //其他設定
                MCCL.MCC_SetUnit(MCCL.UNIT_MM, 0); // coordinate unit : mm

                // 4.過形成保護
                //MCCL.MCC_EnableLimitSwitchCheck();
                //MCCL.MCC_DisableLimitSwitchCheck();
                //MCCL.MCC_SetOverTravelCheck();
                //MCCL.MCC_GetOverTravelCheck();

                //硬體極限
                //MCCL.MCC_EnableLimitSwitchCheck(0);
                //開關平滑模式
                MCCL.MCC_EnableBlend(Group);
                //MCCL.MCC_DisableBlend(nGroupIndex);
                MCCL.MCC_CheckBlend(Group);

                // set line, arc and circle motion's accleration time
                MCCL.MCC_SetAccType('S', Group); //ST兩種模式而已
                MCCL.MCC_GetAccType(Group);
                MCCL.MCC_SetAccTime(200, Group); // set accleration time to be 300 ms
                MCCL.MCC_GetAccTime(Group);
                // set line, arc and circle motion's deceleration time
                MCCL.MCC_SetDecType('S', Group);
                MCCL.MCC_GetDecType(0);
                MCCL.MCC_SetDecTime(200, Group); // set decleration time to be 300 ms
                MCCL.MCC_GetDecTime(Group);

                MCCL.MCC_SetFeedSpeed(10, Group); //  set line, arc and circle motion's feed rate (unit : mm/sec)

                MCCL.MCC_SetPtPAccType('S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', Group);
                //MCCL.MCC_GetPtPAccType();
                //MCCL.MCC_SetPtPAccTime();
                //MCCL.MCC_GetPtPAccTime();
                MCCL.MCC_SetPtPDecType('S', 'S', 'S', 'S', 'S', 'S', 'S', 'S', Group);
                //MCCL.MCC_GetPtPDecType();
                //MCCL.MCC_SetPtPDecTime();
                //MCCL.MCC_GetPtPDecTime();

                MCCL.MCC_SetPtPSpeed(10, Group); //  set line, arc and circle motion's feed rate (unit : mm/sec)
                MCCL.MCC_GetPtPSpeed(Group);

                //MCCL.MCC_SetPGain(60, 60, 60, 60, 60, 60, 60, 60, 0); // set appropriate P Gain

            }
        }

        public void EndController()
        {

            MCCL.MCC_CloseAllGroups();
            MCCL.MCC_CloseSystem();
        }

        public void ServoOn()
        {
            for (ushort i = 0; i <= Instance.MaxAxis-1; i++)
            {
                MCCL.MCC_SetServoOn(i, 0);
            }
        }

        public static void ServoOff()
        {
            for (ushort i = 0; i <= Instance.MaxAxis - 1; i++)
            {
                MCCL.MCC_SetServoOff(i, 0);
            }
        }

        #region 主軸相關
        public void ClampTool()
        {
            short setValue = 1;
            uint Size = 2;
            IntPtr nTargetValue = Marshal.AllocHGlobal(2);
            Marshal.WriteInt16(nTargetValue, setValue);
            MCCL.MCC_EcatCoeSdoDownload(0, 0x2213, 0, nTargetValue, Size);
        }
        
        public void UnClampTool()
        {
            short setValue = 0;
            uint Size = 2;
            IntPtr nTargetValue = Marshal.AllocHGlobal(2);
            Marshal.WriteInt16(nTargetValue, setValue);
            MCCL.MCC_EcatCoeSdoDownload(0, 0x2213, 0, nTargetValue, Size);
        }
        
        public void SpindleOn()
        {
            short setValue = 0;
            uint Size = 2;
            IntPtr nTargetValue = Marshal.AllocHGlobal(2);
            Marshal.WriteInt16(nTargetValue, setValue);
            MCCL.MCC_EcatCoeSdoDownload(0, 0x2215, 0, nTargetValue, Size);
        }
        
        public void SpindleOff()
        {
            short setValue = 1;
            uint Size = 2;
            IntPtr nTargetValue = Marshal.AllocHGlobal(2);
            Marshal.WriteInt16(nTargetValue, setValue);
            MCCL.MCC_EcatCoeSdoDownload(0, 0x2215, 0, nTargetValue, Size);
        }
        
        public void ToolRPMChange(float num)
        {
            //0~10?
            //MCCL.MCC_EcatSetDacOutputValue(4, 1, num);
        }
        #endregion

        public void MCC_GoHome()
        {
            //只有XYZ需GOHOME
            MCCL.MCC_EcatSetHomeAxis(1, 1, 1, 0, 0, 0, 0, 0);

            for (int i = 0; i < Instance.MaxAxis; i++)
            {
                MCCL.MCC_EcatSetHomeMode(28, i);
                MCCL.MCC_EcatSetHomeSwitchSpeed(1000, i);
                MCCL.MCC_EcatSetHomeZeroSpeed(50, i);
            }

            MCCL.MCC_EcatHome();
        }

        public void MCC_AbortMotionEx()
        {
            MCCL.MCC_AbortMotionEx(200, 0);
        }

        public void JogSpace(sbyte axis, sbyte direction)
        {
            MCCL.MCC_JogSpace(direction, 10, (char)axis, 0);
        }

        public void JogConti(sbyte axis, sbyte direction)
        {
            MCCL.MCC_JogConti(direction, 10, (char)axis, 0);
        }

        public void MCC_DefineMachining()
        {
            for (ushort i = 0; i < MaxAxis; i++)
            {
                MCCL.MCC_DefineOrigin(i, Group);
            }
        }


        // MCCL Get Data Variable
        public static Axis<double> CurRefPos = new Axis<double>();
        public static Axis<double> CurPos = new Axis<double>();
        public static Axis<double> speed = new Axis<double>();
        public static Axis<int> ENCValue = new Axis<int>();
        public static Axis<int> PulsePos = new Axis<int>();
        public static Axis<ushort> PositiveLimitSwitchStatus = new Axis<ushort>();
        public static Axis<ushort> NegativeLimitSwitchStatus = new Axis<ushort>();
        public static Axis<ushort> HomeSensorStatus = new Axis<ushort>();
        public static double CurFeedSpeed;
        public static ushort EmgcStopStatus = 0;
        public static string Error;
        // Coordinate System Variable
        private Axis<double> machanicalCoordinate = new Axis<double>();
        public Axis<double> MachanicalCoordinate
        {
            get { return machanicalCoordinate; }
            set
            {
                machanicalCoordinate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("MachanicalCoordinate"));
            }
        }
        private Axis<double> absoluteCoordinate = new Axis<double>();
        public Axis<double> AbsoluteCoordinate
        {
            get { return absoluteCoordinate; }
            set
            {
                absoluteCoordinate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("AbsoluteCoordinate"));
            }
        }
        private Axis<double> relativeCoordinate = new Axis<double>();
        public Axis<double> RelativeCoordinate
        {
            get { return relativeCoordinate; }
            set
            {
                relativeCoordinate = value;
                PropertyChanged(this, new PropertyChangedEventArgs("RelativeCoordinate"));
            }
        }
        /// <summary>
        /// 從MCCL獲取資訊
        /// </summary>
        /// <returns></returns>
        public void GetMCCLData()
        {
            MCCL.MCC_GetCurRefPos(ref CurRefPos.X, ref CurRefPos.Y, ref CurRefPos.Z,
                                          ref CurRefPos.U, ref CurRefPos.V, ref CurRefPos.W,
                                          ref CurRefPos.A, ref CurRefPos.B, 0);

            MCCL.MCC_GetCurPos(ref CurPos.X, ref CurPos.Y, ref CurPos.Z,
                               ref CurPos.U, ref CurPos.V, ref CurPos.W,
                               ref CurPos.A, ref CurPos.B, 0);

            MCCL.MCC_GetSpeed(ref speed.X, ref speed.Y, ref speed.Z,
                              ref speed.U, ref speed.V, ref speed.W,
                              ref speed.A, ref speed.B, 0);


            MCCL.MCC_GetENCValue(ref ENCValue.X, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.Y, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.Z, 2, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.U, 3, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.V, 4, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.W, 5, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.A, 6, MCCL.CARDINDEX0);
            MCCL.MCC_GetENCValue(ref ENCValue.B, 7, MCCL.CARDINDEX0);

            MCCL.MCC_GetPulsePos(ref PulsePos.X, ref PulsePos.Y, ref PulsePos.Z,
                                 ref PulsePos.U, ref PulsePos.V, ref PulsePos.W,
                                 ref PulsePos.A, ref PulsePos.B, 0);

            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.X, 0, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.Y, 0, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.Z, 0, 2, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.U, 0, 3, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.V, 0, 4, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.W, 0, 5, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.A, 0, 6, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref PositiveLimitSwitchStatus.B, 0, 7, MCCL.CARDINDEX0);

            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.X, 1, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.Y, 1, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.Z, 1, 2, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.U, 1, 3, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.V, 1, 4, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.W, 1, 5, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.A, 1, 6, MCCL.CARDINDEX0);
            MCCL.MCC_GetLimitSwitchStatus(ref NegativeLimitSwitchStatus.B, 1, 7, MCCL.CARDINDEX0);

            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.X, 0, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.Y, 1, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.Z, 2, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.U, 3, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.V, 4, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.W, 5, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.A, 6, MCCL.CARDINDEX0);
            MCCL.MCC_GetHomeSensorStatus(ref HomeSensorStatus.B, 7, MCCL.CARDINDEX0);


            //進給率
            CurFeedSpeed = MCCL.MCC_GetCurFeedSpeed(0);

            MCCL.MCC_GetEmgcStopStatus(ref EmgcStopStatus, MCCL.CARDINDEX0);
            Error = MCCL.MCC_GetErrorCode(0).ToString();
            //MCCL.MCC_GetErrorCount();

            UpdateCoordinateSystem();
        }

        private void UpdateCoordinateSystem()
        {
            absoluteCoordinate = CurPos;
            //
            machanicalCoordinate = ChangeType(ENCValue);
            relativeCoordinate = CurPos;

            Debug.WriteLine(ENCValue.X);
            Debug.WriteLine(ENCValue.Y);
            Debug.WriteLine(ENCValue.Z);
            Debug.WriteLine(machanicalCoordinate.X);
            Debug.WriteLine(machanicalCoordinate.Y);
            Debug.WriteLine(machanicalCoordinate.Z);
        }

        private Axis<double> ChangeType(Axis<int> Source)
        {
            Axis<double> END = new Axis<double>();
            END.X = (double)Source.X / 100000 * 0.78484;
            END.Y = (double)Source.Y / 100000 * 0.78484;
            END.Z = (double)Source.Z / 100000 * 0.78484;
            END.U = (double)Source.U / 100000 * 0.78484;
            END.V = (double)Source.V / 100000 * 0.78484;
            END.W = (double)Source.W / 100000 * 0.78484;
            END.A = (double)Source.A / 100000 * 0.78484;
            END.B = (double)Source.B / 100000 * 0.78484;
            return END;
        }
    }
}