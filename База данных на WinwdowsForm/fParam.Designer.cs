namespace База_данных_на_WinwdowsForm
{
    partial class fParam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listLinkIN = new System.Windows.Forms.ListBox();
            this.btnСhoiceBD_IN = new System.Windows.Forms.Button();
            this.listLinkOUT = new System.Windows.Forms.ListBox();
            this.btnСhoiceBD_OUT = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnОК = new System.Windows.Forms.Button();
            this.btnAnnulment = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.CheckBoxIMAGE = new System.Windows.Forms.CheckBox();
            this.CheckBoxDEAL = new System.Windows.Forms.CheckBox();
            this.CheckBoxTRANSFER = new System.Windows.Forms.CheckBox();
            this.CheckBoxF_PATH = new System.Windows.Forms.CheckBox();
            this.listBoxCOPY = new System.Windows.Forms.ListBox();
            this.BtnLinkCOPY = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listLinkIN
            // 
            this.listLinkIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLinkIN.FormattingEnabled = true;
            this.listLinkIN.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.listLinkIN.Location = new System.Drawing.Point(3, 3);
            this.listLinkIN.Name = "listLinkIN";
            this.listLinkIN.Size = new System.Drawing.Size(489, 49);
            this.listLinkIN.TabIndex = 0;
            // 
            // btnСhoiceBD_IN
            // 
            this.btnСhoiceBD_IN.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnСhoiceBD_IN.Location = new System.Drawing.Point(3, 58);
            this.btnСhoiceBD_IN.Name = "btnСhoiceBD_IN";
            this.btnСhoiceBD_IN.Size = new System.Drawing.Size(130, 49);
            this.btnСhoiceBD_IN.TabIndex = 4;
            this.btnСhoiceBD_IN.Text = "Выбрать БД_IN";
            this.btnСhoiceBD_IN.UseVisualStyleBackColor = true;
            this.btnСhoiceBD_IN.Click += new System.EventHandler(this.BtnСhoiceBD_IN_Click);
            // 
            // listLinkOUT
            // 
            this.listLinkOUT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLinkOUT.FormattingEnabled = true;
            this.listLinkOUT.Location = new System.Drawing.Point(3, 113);
            this.listLinkOUT.Name = "listLinkOUT";
            this.listLinkOUT.Size = new System.Drawing.Size(489, 49);
            this.listLinkOUT.TabIndex = 5;
            // 
            // btnСhoiceBD_OUT
            // 
            this.btnСhoiceBD_OUT.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnСhoiceBD_OUT.Location = new System.Drawing.Point(3, 168);
            this.btnСhoiceBD_OUT.Name = "btnСhoiceBD_OUT";
            this.btnСhoiceBD_OUT.Size = new System.Drawing.Size(130, 49);
            this.btnСhoiceBD_OUT.TabIndex = 6;
            this.btnСhoiceBD_OUT.Text = "Выбрать БД_OUT";
            this.btnСhoiceBD_OUT.UseVisualStyleBackColor = true;
            this.btnСhoiceBD_OUT.Click += new System.EventHandler(this.BtnСhoiceBD_OUT_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnСhoiceBD_IN, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnСhoiceBD_OUT, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listLinkOUT, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listLinkIN, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCOPY, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BtnLinkCOPY, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28733F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28732F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28447F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28176F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 387);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnAnnulment);
            this.flowLayoutPanel2.Controls.Add(this.btnОК);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 333);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(489, 51);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // btnОК
            // 
            this.btnОК.Location = new System.Drawing.Point(291, 3);
            this.btnОК.Name = "btnОК";
            this.btnОК.Size = new System.Drawing.Size(92, 23);
            this.btnОК.TabIndex = 2;
            this.btnОК.Text = "OK";
            this.btnОК.UseVisualStyleBackColor = true;
            this.btnОК.Click += new System.EventHandler(this.BtnОК_Click);
            // 
            // btnAnnulment
            // 
            this.btnAnnulment.Location = new System.Drawing.Point(389, 3);
            this.btnAnnulment.Name = "btnAnnulment";
            this.btnAnnulment.Size = new System.Drawing.Size(97, 23);
            this.btnAnnulment.TabIndex = 3;
            this.btnAnnulment.Text = "Отмена";
            this.btnAnnulment.UseVisualStyleBackColor = true;
            this.btnAnnulment.Click += new System.EventHandler(this.BtnAnnulment_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxIMAGE);
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxDEAL);
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxTRANSFER);
            this.flowLayoutPanel1.Controls.Add(this.CheckBoxF_PATH);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(14, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 23);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // CheckBoxIMAGE
            // 
            this.CheckBoxIMAGE.AutoSize = true;
            this.CheckBoxIMAGE.Dock = System.Windows.Forms.DockStyle.Left;
            this.CheckBoxIMAGE.Location = new System.Drawing.Point(3, 3);
            this.CheckBoxIMAGE.Name = "CheckBoxIMAGE";
            this.CheckBoxIMAGE.Size = new System.Drawing.Size(55, 17);
            this.CheckBoxIMAGE.TabIndex = 11;
            this.CheckBoxIMAGE.Text = "Image";
            this.CheckBoxIMAGE.UseVisualStyleBackColor = true;
            this.CheckBoxIMAGE.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // CheckBoxDEAL
            // 
            this.CheckBoxDEAL.AutoSize = true;
            this.CheckBoxDEAL.Location = new System.Drawing.Point(64, 3);
            this.CheckBoxDEAL.Name = "CheckBoxDEAL";
            this.CheckBoxDEAL.Size = new System.Drawing.Size(48, 17);
            this.CheckBoxDEAL.TabIndex = 8;
            this.CheckBoxDEAL.Text = "Deal";
            this.CheckBoxDEAL.UseVisualStyleBackColor = true;
            this.CheckBoxDEAL.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // CheckBoxTRANSFER
            // 
            this.CheckBoxTRANSFER.AutoSize = true;
            this.CheckBoxTRANSFER.Location = new System.Drawing.Point(118, 3);
            this.CheckBoxTRANSFER.Name = "CheckBoxTRANSFER";
            this.CheckBoxTRANSFER.Size = new System.Drawing.Size(65, 17);
            this.CheckBoxTRANSFER.TabIndex = 9;
            this.CheckBoxTRANSFER.Text = "Transfer";
            this.CheckBoxTRANSFER.UseVisualStyleBackColor = true;
            this.CheckBoxTRANSFER.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // CheckBoxF_PATH
            // 
            this.CheckBoxF_PATH.AutoSize = true;
            this.CheckBoxF_PATH.Location = new System.Drawing.Point(189, 3);
            this.CheckBoxF_PATH.Name = "CheckBoxF_PATH";
            this.CheckBoxF_PATH.Size = new System.Drawing.Size(59, 17);
            this.CheckBoxF_PATH.TabIndex = 10;
            this.CheckBoxF_PATH.Text = "F_path";
            this.CheckBoxF_PATH.UseVisualStyleBackColor = true;
            this.CheckBoxF_PATH.CheckedChanged += new System.EventHandler(this.CheckBox_Click);
            // 
            // listBoxCOPY
            // 
            this.listBoxCOPY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCOPY.FormattingEnabled = true;
            this.listBoxCOPY.Location = new System.Drawing.Point(3, 223);
            this.listBoxCOPY.Name = "listBoxCOPY";
            this.listBoxCOPY.Size = new System.Drawing.Size(489, 49);
            this.listBoxCOPY.TabIndex = 15;
            // 
            // BtnLinkCOPY
            // 
            this.BtnLinkCOPY.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLinkCOPY.Location = new System.Drawing.Point(3, 278);
            this.BtnLinkCOPY.Name = "BtnLinkCOPY";
            this.BtnLinkCOPY.Size = new System.Drawing.Size(130, 49);
            this.BtnLinkCOPY.TabIndex = 16;
            this.BtnLinkCOPY.Text = "Копирование";
            this.BtnLinkCOPY.UseVisualStyleBackColor = true;
            // 
            // fParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 387);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(511, 426);
            this.MinimumSize = new System.Drawing.Size(511, 426);
            this.Name = "fParam";
            this.Text = "Настройки";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listLinkIN;
        private System.Windows.Forms.Button btnСhoiceBD_IN;
        private System.Windows.Forms.ListBox listLinkOUT;
        private System.Windows.Forms.Button btnСhoiceBD_OUT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxCOPY;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnОК;
        private System.Windows.Forms.Button btnAnnulment;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox CheckBoxIMAGE;
        private System.Windows.Forms.CheckBox CheckBoxDEAL;
        private System.Windows.Forms.CheckBox CheckBoxTRANSFER;
        private System.Windows.Forms.CheckBox CheckBoxF_PATH;
        private System.Windows.Forms.Button BtnLinkCOPY;
    }
}