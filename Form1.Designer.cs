namespace frmMDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            mnuForm = new ToolStripMenuItem();
            mnuFromMax = new ToolStripMenuItem();
            mnuFormMin = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            mnuCloseForm = new ToolStripMenuItem();
            mnuCloseAllForm = new ToolStripMenuItem();
            toolStripMenuItem8 = new ToolStripSeparator();
            mnuFormExit = new ToolStripMenuItem();
            mnuFormA = new ToolStripMenuItem();
            mnuFormB = new ToolStripMenuItem();
            mnuFormC = new ToolStripMenuItem();
            จดเรยงฟอรมToolStripMenuItem = new ToolStripMenuItem();
            mnuFormatVertical = new ToolStripMenuItem();
            mnuFormatHorizontal = new ToolStripMenuItem();
            mnuFormatNarmal = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuForm, mnuFormA, mnuFormB, mnuFormC, จดเรยงฟอรมToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuForm
            // 
            mnuForm.DropDownItems.AddRange(new ToolStripItem[] { mnuFromMax, mnuFormMin, toolStripMenuItem2, toolStripMenuItem1, mnuCloseForm, mnuCloseAllForm, toolStripMenuItem8, mnuFormExit });
            mnuForm.Font = new Font("TH SarabunPSK", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuForm.Name = "mnuForm";
            mnuForm.Size = new Size(44, 22);
            mnuForm.Text = "ฟอร์ม";
            // 
            // mnuFromMax
            // 
            mnuFromMax.Name = "mnuFromMax";
            mnuFromMax.Size = new Size(144, 22);
            mnuFromMax.Text = "ขยาย";
            mnuFromMax.Click += mnuFromMax_Click;
            // 
            // mnuFormMin
            // 
            mnuFormMin.Name = "mnuFormMin";
            mnuFormMin.Size = new Size(144, 22);
            mnuFormMin.Text = "ย่อ";
            mnuFormMin.Click += mnuFormMin_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(144, 22);
            toolStripMenuItem2.Text = "ปรับเป็นปกติ";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(141, 6);
            // 
            // mnuCloseForm
            // 
            mnuCloseForm.Name = "mnuCloseForm";
            mnuCloseForm.Size = new Size(144, 22);
            mnuCloseForm.Text = "ปิดฟอร์ม";
            mnuCloseForm.Click += mnuCloseForm_Click;
            // 
            // mnuCloseAllForm
            // 
            mnuCloseAllForm.Name = "mnuCloseAllForm";
            mnuCloseAllForm.Size = new Size(144, 22);
            mnuCloseAllForm.Text = "ปิดฟอร์มทั้งหมด";
            mnuCloseAllForm.Click += mnuCloseAllForm_Click;
            // 
            // toolStripMenuItem8
            // 
            toolStripMenuItem8.Name = "toolStripMenuItem8";
            toolStripMenuItem8.Size = new Size(141, 6);
            // 
            // mnuFormExit
            // 
            mnuFormExit.Name = "mnuFormExit";
            mnuFormExit.Size = new Size(144, 22);
            mnuFormExit.Text = "ปิดโปรแกรม";
            mnuFormExit.Click += mnuFormExit_Click;
            // 
            // mnuFormA
            // 
            mnuFormA.Name = "mnuFormA";
            mnuFormA.Size = new Size(73, 22);
            mnuFormA.Text = "เปิดฟอร์ม A";
            mnuFormA.Click += mnuFormA_Click;
            // 
            // mnuFormB
            // 
            mnuFormB.Name = "mnuFormB";
            mnuFormB.Size = new Size(72, 22);
            mnuFormB.Text = "เปิดฟอร์ม B";
            mnuFormB.Click += mnuFormB_Click;
            // 
            // mnuFormC
            // 
            mnuFormC.Name = "mnuFormC";
            mnuFormC.Size = new Size(73, 22);
            mnuFormC.Text = "เปิดฟอร์ม C";
            mnuFormC.Click += mnuFormC_Click;
            // 
            // จดเรยงฟอรมToolStripMenuItem
            // 
            จดเรยงฟอรมToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuFormatVertical, mnuFormatHorizontal, mnuFormatNarmal });
            จดเรยงฟอรมToolStripMenuItem.Name = "จดเรยงฟอรมToolStripMenuItem";
            จดเรยงฟอรมToolStripMenuItem.Size = new Size(77, 22);
            จดเรยงฟอรมToolStripMenuItem.Text = "จัดเรียงฟอร์ม";
            // 
            // mnuFormatVertical
            // 
            mnuFormatVertical.Name = "mnuFormatVertical";
            mnuFormatVertical.Size = new Size(180, 22);
            mnuFormatVertical.Text = "จัดเรียงแนวตั้ง";
            mnuFormatVertical.Click += mnuFormatVertical_Click;
            // 
            // mnuFormatHorizontal
            // 
            mnuFormatHorizontal.Name = "mnuFormatHorizontal";
            mnuFormatHorizontal.Size = new Size(180, 22);
            mnuFormatHorizontal.Text = "จัดเรียงแนวนอน";
            mnuFormatHorizontal.Click += mnuFormatHorizontal_Click;
            // 
            // mnuFormatNarmal
            // 
            mnuFormatNarmal.Name = "mnuFormatNarmal";
            mnuFormatNarmal.Size = new Size(180, 22);
            mnuFormatNarmal.Text = "จัดเรียงปกติ";
            mnuFormatNarmal.Click += mnuFormatNarmal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(menuStrip1);
            Font = new Font("TH SarabunPSK", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ทดสอบ MDI Form";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuForm;
        private ToolStripMenuItem mnuFromMax;
        private ToolStripMenuItem mnuFormMin;
        private ToolStripMenuItem mnuFormExit;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuFormA;
        private ToolStripMenuItem mnuFormB;
        private ToolStripMenuItem mnuFormC;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem จดเรยงฟอรมToolStripMenuItem;
        private ToolStripMenuItem mnuFormatVertical;
        private ToolStripMenuItem mnuFormatHorizontal;
        private ToolStripMenuItem mnuCloseForm;
        private ToolStripMenuItem mnuCloseAllForm;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem mnuFormatNarmal;
    }
}