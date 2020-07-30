using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMICNC_WinForm
{
    public partial class Tool : UserControl
    {
        public Tool()
        {
            InitializeComponent();
        }

        DataTable ToolDataTable;
        string cnstr = @"Data Source = (LocalDB)\MSSQLLocalDB;" +
                    " AttachDbFilename = |DataDirectory|ToolDB.mdf;" +
                    "Integrated Security = True";

        private void Tool_Load(object sender, EventArgs e)
        {
            //CB_ToolSelect.SelectedIndex = 0;
            DealData();
        }

        #region 方法

        void DealData()
        {
            //使用using建立sqlconnection物件
            using (SqlConnection ToolDBcn = new SqlConnection())
            {
                //連接在地資料庫
                ToolDBcn.ConnectionString = cnstr;

                //建立datast物件
                DataSet ToolDataSet = new DataSet();

                //建立sqldataadapter物件並取出資料表
                SqlDataAdapter ToolData = new SqlDataAdapter
                    ("SELECT * FROM ToolManager", ToolDBcn);

                //將資料表所有資料填入ToolDataSet物件
                ToolData.Fill(ToolDataSet, "ToolManager");

                //宣告DataTable物件，並讓該物件存放DataSet中的資料表的DataTable
                ToolDataTable = ToolDataSet.Tables["ToolManager"];

                //計算所有筆數
                //Count = ToolDataTable.Rows.Count;
                //
                CB_ToolSelect.DataSource = ToolDataSet;
                CB_ToolSelect.DisplayMember = "ToolManager.編號";
            }
        }

        void SaveData()
        {
            using (SqlConnection ToolDBcn = new SqlConnection())
            {
                //連接在地資料庫
                ToolDBcn.ConnectionString = cnstr;
                ToolDBcn.Open();
                string sqlStr = "INSERT INTO ToolManager(編號,刀具名稱,刀具型別," +
                    "累積使用時間,預測換刀時間)VALUES('" + Txt_ID.Text.Replace("'", "''") + "','" +
                    Txt_Name.Text.Replace("'", "''") + "','" + Txt_Type.Text.Replace("'", "''") +
                    "','" + Txt_UsedTime.Text.Replace("'", "''") + "'," + Txt_PredictTime.Text.Replace("'", "''") + ")";

                //發送sql指令
                SqlCommand Cmd = new SqlCommand(sqlStr, ToolDBcn);
                Cmd.ExecuteNonQuery();
                DealData();
            }

        }

        void DeleteData()
        {
            using (SqlConnection ToolDBcn = new SqlConnection())
            {
                ToolDBcn.ConnectionString = cnstr;
                ToolDBcn.Open();
                string sqlStr = "DELETE FROM ToolManager WHERE 編號 = '" +
                    Txt_ID.Text.Replace("'", "''") + "'";

                SqlCommand Cmd = new SqlCommand(sqlStr,ToolDBcn);
                Cmd.ExecuteNonQuery();
                DealData();
            }
        }
        void ShowData()
        {
            Txt_ID.Text = ToolDataTable.Rows[CB_ToolSelect.SelectedIndex]["編號"].ToString();
            Txt_Name.Text = ToolDataTable.Rows[CB_ToolSelect.SelectedIndex]["刀具名稱"].ToString();
            Txt_Type.Text = ToolDataTable.Rows[CB_ToolSelect.SelectedIndex]["刀具型別"].ToString();
            Txt_UsedTime.Text = ToolDataTable.Rows[CB_ToolSelect.SelectedIndex]["累積使用時間"].ToString();
            Txt_PredictTime.Text = ToolDataTable.Rows[CB_ToolSelect.SelectedIndex]["預測換刀時間"].ToString();
        }
        void ClearData()
        {
            Txt_ID.Text = "";
            Txt_Name.Text = "";
            Txt_PredictTime.Text = "";
            Txt_Type.Text = "";
            Txt_UsedTime.Text = "";
        }
        #endregion

        #region Button
        //查詢
        private void CB_ToolSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        //清空text
        private void Btn_ToolAdd_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //儲存
        private void Btn_ToolSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }
        //清除
        private void Btn_ToolClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }
        //刪除
        private void Btn_ToolDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        #endregion


    }
}
