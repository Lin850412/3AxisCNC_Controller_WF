using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMICNC_WinForm
{
    public partial class Coordinate : UserControl
    {
        public Coordinate()
        {
            InitializeComponent();
        }

        public void UpdateUI()
        {
            //機械、絕對、相對座標顯示
            Lb_AX.Text = (MCCLManager.machanicalCoordinate.X).ToString("##00.00");
            Lb_AY.Text = (MCCLManager.machanicalCoordinate.Y).ToString("##00.00");
            Lb_AZ.Text = (MCCLManager.machanicalCoordinate.Z).ToString("##00.00");
            Lb_BX.Text = (MCCLManager.absoluteCoordinate.X).ToString("##00.00");
            Lb_BY.Text = (MCCLManager.absoluteCoordinate.Y).ToString("##00.00");
            Lb_BZ.Text = (MCCLManager.absoluteCoordinate.Z).ToString("##00.00");
            Lb_CX.Text = (MCCLManager.relativeCoordinate.X).ToString("##00.00");
            Lb_CY.Text = (MCCLManager.relativeCoordinate.Y).ToString("##00.00");
            Lb_CZ.Text = (MCCLManager.relativeCoordinate.Z).ToString("##00.00");
        }

        private void Coordinate_Load(object sender, EventArgs e)
        {

        }
    }
}
