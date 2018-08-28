using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ToolGroup;

namespace SharpAOI
{
    public partial class mainForm : Form
    {
        Splasher sp = new Splasher();
        public mainForm()
        {
            this.sp.Show("準備中...");
            InitializeComponent();
            this.ObjectArray();
        }

        private void mainForm_Shown(object sender, EventArgs e)
        {
            this.sp.Close();
            //this.WindowState = FormWindowState.Maximized;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //toolblock變數
            CogToolBlock tbLensTray = new CogToolBlock();
            
            string s;
            //sp.mStatus = "開啟Lens萃盤檢測工具...";
            //s = string.Concat(System.IO.Directory.GetCurrentDirectory().ToString(), "\\TB\\" + "LensTray" + ".vpp");
            //tbLensTray = (CogToolBlock)CogSerializer.LoadObjectFromFile(s);
        }

        private RadioButton[] stage_radiobutton, mes_radiobutton;
        private void ObjectArray()
        {
            this.stage_radiobutton = new RadioButton[3] { this.firstStageRadioButton, this.secondStageRadioButton, this.thirdStageRadioButton };
            this.mes_radiobutton = new RadioButton[2] { this.mesYesRadioButton, this.mesNoRadioButton };
        }
    }
}
