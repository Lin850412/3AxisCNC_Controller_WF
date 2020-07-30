using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace IMICNC_WinForm
{
    public partial class Information : UserControl
    {/*

        DataTable MachineTable;
        string cnstr = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                    " AttachDbFilename = |DataDirectory|MachineParameter.mdf;" +
                    "Integrated Security = True";

        public Information()
        {
            InitializeComponent();
        }
        private void Information_Load(object sender, EventArgs e)
        {
            DealData();
        }

        #region 方法
        void DealData()
        {
            //使用using建立sqlconnection物件
            using (SqlConnection MachineDBcn = new SqlConnection())
            {
                //連接在地資料庫
                MachineDBcn.ConnectionString = cnstr;

                //建立datast物件
                DataSet MachineDataSet = new DataSet();

                //建立sqldataadapter物件並取出資料表
                SqlDataAdapter MachineData = new SqlDataAdapter
                    ("SELECT * FROM MachineParameter", MachineDBcn);

                //將資料表所有資料填入ToolDataSet物件
                MachineData.Fill(MachineDataSet, "MachineParameter");

                //宣告DataTable物件，並讓該物件存放DataSet中的資料表的DataTable
                MachineTable = MachineDataSet.Tables["MachineParameter"];

                cboSelectMachine.DataSource = MachineDataSet;
                cboSelectMachine.DisplayMember = "MachineParameter.機台名稱";
            }
        }

        void SaveData()
        {
            using (SqlConnection MachineDBcn = new SqlConnection())
            {
                //連接在地資料庫
                MachineDBcn.ConnectionString = cnstr;
                MachineDBcn.Open();
                string sqlStr = "INSERT INTO MachineParameter(機台名稱,方向調整參數,RPM," +
                    "PPR,導螺桿間隙值,齒輪箱減速比,正方向邊界,負方向邊界,脈波輸出格式,脈波輸出寬度," +
                    "加速時間,減速時間)VALUES('" + txtMachineName.Text.Replace("'", "''") +
                    "','" + txtPosToEncoder.Text.Replace("'", "''") + "','" + txtRPM.Text.Replace("'", "''") +
                    "','" + txtPPR.Text.Replace("'", "''") + "','" + txtPitch.Text.Replace("'", "''") +
                    "','" + txtGearRatio.Text.Replace("'", "''") + "','" + txtHightLimit.Text.Replace("'", "''") +
                    "','" + txtLowLimit.Text.Replace("'", "''") + "','" + txtPulseMode.Text.Replace("'", "''") +
                    "','" + txtPulseWidth.Text.Replace("'", "''") + "','" + txtHighSpeed.Text.Replace("'", "''") +
                    "'," + txtLowSpeed.Text.Replace("'", "''") + ")";


                //發送sql指令
                SqlCommand Cmd = new SqlCommand(sqlStr, MachineDBcn);
                Cmd.ExecuteNonQuery();
                DealData();
            }
        }
        void DeleteData()
        {
            using (SqlConnection MachineDBcn = new SqlConnection())
            {
                MachineDBcn.ConnectionString = cnstr;
                MachineDBcn.Open();
                string sqlStr = "DELETE FROM MachineParameter WHERE 機台名稱 = '" +
                    txtMachineName.Text.Replace("'", "''") + "'";

                SqlCommand Cmd = new SqlCommand(sqlStr, MachineDBcn);
                Cmd.ExecuteNonQuery();
                DealData();
            }
        }

        void ShowData()
        {
            txtMachineName.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["機台名稱"].ToString();
            txtPosToEncoder.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["方向調整參數"].ToString();
            txtRPM.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["RPM"].ToString();
            txtPPR.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["PPR"].ToString();
            txtPitch.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["導螺桿間隙值"].ToString();
            txtGearRatio.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["齒輪箱減速比"].ToString();
            txtHightLimit.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["正方向邊界"].ToString();
            txtLowLimit.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["負方向邊界"].ToString();
            txtPulseMode.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["脈波輸出格式"].ToString();
            txtPulseWidth.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["脈波輸出寬度"].ToString();
            txtCommand.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["運動命令輸出"].ToString();
            txtHighSpeed.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["加速時間"].ToString();
            txtLowSpeed.Text = MachineTable.Rows[cboSelectMachine.SelectedIndex]["減速時間"].ToString();
        }

        void ClearData()
        {
            txtMachineName.Text = "";
            txtPosToEncoder.Text = "";
            txtRPM.Text = "";
            txtPPR.Text = "";
            txtPitch.Text = "";
            txtGearRatio.Text = "";
            txtHightLimit.Text = "";
            txtLowLimit.Text = "";
            txtPulseWidth.Text = "";
            txtPulseMode.Text = "";
            txtCommand.Text = "";
            txtHighSpeed.Text = "";
            txtLowSpeed.Text = "";
        }

        #endregion
        #region Button
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSaveMachine_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void btnClearMachine_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnDeleteMachine_Click(object sender, EventArgs e)
        {
            DeleteData();
        }
        private void cboSelectMachine_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        #endregion


    }
}
*/