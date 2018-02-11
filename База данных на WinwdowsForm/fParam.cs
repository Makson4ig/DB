using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace База_данных_на_WinwdowsForm
{
    public partial class fParam : Form
    {
        public string FileName_IN, FileName_OUT, FileName_TXT;
        public bool chkDEAL, chkTRANSFER, chkF, chkIMAGE, btnCheck;
        public bool[] CounterChk = new bool[4];

        public fParam()
        {
            InitializeComponent();
        }

        private void BtnAnnulment_Click(object sender, EventArgs e)
        {
            listLinkIN.Items.Clear();
            listLinkOUT.Items.Clear();
            listBoxCOPY.Items.Clear();
            this.Hide();
        }
        private void BtnСhoiceBD_IN_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fbd_IN = new OpenFileDialog();
                if (fbd_IN.ShowDialog() == DialogResult.OK)
                {
                    listLinkIN.Items.Clear();
                    FileName_IN = fbd_IN.FileName;
                    listLinkIN.Items.Add(FileName_IN);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception");
            }
        }
        private void BtnСhoiceBD_OUT_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fbd_OUT = new OpenFileDialog();

                if (fbd_OUT.ShowDialog() == DialogResult.OK)
                {
                    listLinkOUT.Items.Clear();
                    FileName_OUT = fbd_OUT.FileName;
                    listLinkOUT.Items.Add(FileName_OUT);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception");
            }

        }
        private void BtnLinkCOPY_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog LinkCopyTXT = new OpenFileDialog();
                if (LinkCopyTXT.ShowDialog() == DialogResult.OK)
                {
                    listBoxCOPY.Items.Clear();
                    FileName_TXT = LinkCopyTXT.FileName;
                    listBoxCOPY.Items.Add(FileName_TXT);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception");
            }
        }
        private void BtnОК_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void CheckBox_Click(object sender, EventArgs e)
        {
            CheckBox[] boxes = new CheckBox[] { CheckBoxDEAL, CheckBoxIMAGE, CheckBoxF_PATH, CheckBoxTRANSFER };

            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].Checked)
                {
                    CounterChk[i] = true;
                }
            }

        }

    }
}
