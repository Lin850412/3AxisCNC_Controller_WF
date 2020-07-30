using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Diagnostics;

namespace IMICNC_WinForm
{
    public partial class GCode : UserControl
    {
        public delegate void UserComfirmEventHandler(string[] code);
        //宣告一事件
        public event UserComfirmEventHandler UserComfirmEvent;
        //上述事件委派出去的方法

        public GCode()
        {
            InitializeComponent();
        }
        public void UpDateUI()
        {
            Lb_AX.Text = (MCCLManager.machanicalCoordinate.X).ToString("##00.00");
            Lb_AY.Text = (MCCLManager.machanicalCoordinate.Y).ToString("##00.00");
            Lb_AZ.Text = (MCCLManager.machanicalCoordinate.Z).ToString("##00.00");
            Lb_BX.Text = (MCCLManager.absoluteCoordinate.X).ToString("##00.00");
            Lb_BY.Text = (MCCLManager.absoluteCoordinate.Y).ToString("##00.00");
            Lb_BZ.Text = (MCCLManager.absoluteCoordinate.Z).ToString("##00.00");
        }

        //弄懂
        private void Btn_LoadFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog op = new OpenFileDialog();
                if (op.ShowDialog() == DialogResult.OK)
                {
                    string FilePath = op.FileName, FileName = Path.GetFileName(FilePath);

                    StreamReader sr = new StreamReader(op.FileName);
                    string result = sr.ReadToEnd();
                    rtxtGCode.Text = result;
                    sr.Close();
                    txtFilePlace.Text = FilePath;
                    txtFileName.Text = FileName;
          
                }
            }
            catch {}
        }

        private void Btn_ConfirmFile_Click(object sender, EventArgs e)
        {
            UserComfirmEvent(rtxtGCode.Lines);
            //Debug.Print(UserComfirmEvent.ToString());
        }
    }

}
