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

namespace IMICNC_WinForm
{
    public partial class Monitor : UserControl
    {
        Pen pen = new Pen(Color.Black);
        Point draw_o = new Point(0, 0);
        Point draw_p;
        List<Point> recoder = new List<Point>();
        List<double> recoder_z = new List<double>();

        Bitmap Image;
        double temp_x = 0, temp_y = 0;

        public Monitor()
        {
            InitializeComponent();
        }

        public void UpdateUI()
        {
            Lb_AX.Text = (MCCLManager.machanicalCoordinate.X).ToString("##00.00");
            Lb_AY.Text = (MCCLManager.machanicalCoordinate.Y).ToString("##00.00");
            Lb_AZ.Text = (MCCLManager.machanicalCoordinate.Z).ToString("##00.00");
            Lb_BX.Text = (MCCLManager.absoluteCoordinate.X).ToString("##00.00");
            Lb_BY.Text = (MCCLManager.absoluteCoordinate.Y).ToString("##00.00");
            Lb_BZ.Text = (MCCLManager.absoluteCoordinate.Z).ToString("##00.00");

            Draw(Convert.ToDouble(Lb_BX.Text), Convert.ToDouble(Lb_BY.Text), Convert.ToDouble(Lb_BZ.Text));

        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            Image = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        }

        private void Draw(double x, double y, double z)
        {
            Graphics g = Graphics.FromImage(Image);

            if ((temp_x != x) || (temp_y != y))
            {
                draw_p = new Point((int)x * 3, (int)y * 3);
                recoder.Add(draw_p);
                recoder_z.Add(z);

                if (z <= 0)
                {
                    pen.Color = Color.Red;
                    g.DrawLine(pen, draw_o, draw_p);
                }
                else
                {
                    pen.Color = Color.Black;
                    g.DrawLine(pen, draw_o, draw_p);
                }

                draw_o = draw_p;
                temp_x = x;
                temp_y = y;
                pictureBox1.Image = Image;
                pictureBox1.Refresh();
            }
        }
        public void GCodeDisplay(string[] code)
        {
            CodeList.Items.Clear();
            CodeList.Items.AddRange(code);
        }

        //開始加工
        private void Btn_StartCode_Click(object sender, EventArgs e)
        {
            StreamWriter SaveFile = new StreamWriter(@"C:\Users\Lin\Desktop\GG.txt");
            foreach (var item in CodeList.Items)
            {
                SaveFile.WriteLine(item.ToString());
            }
            SaveFile.Close();

            string TxtPath = @"C:\Users\Lin\Desktop\GG.txt";
            String FilePath = TxtPath;

            StringBuilder InFilePath = new StringBuilder(FilePath);

            CompilerAndInterpreter.Compile(InFilePath);


            int strIndex = FilePath.Trim().LastIndexOf('.');
            StringBuilder OutFilePath = new StringBuilder(FilePath.Substring(0, strIndex) + "Intermediate.txt");
            CompilerAndInterpreter.readFile(OutFilePath/*中間語言的路徑*/);
            //key
            CompilerAndInterpreter.InterpretAll(0, 0, 0);

            MessageBox.Show("Done");
        }

    }
}
