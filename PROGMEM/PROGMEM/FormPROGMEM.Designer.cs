namespace PROGMEM
{
    partial class FormPROGMEM
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
            rtDataInput = new RichTextBox();
            rtDataOutput = new RichTextBox();
            btnProgmemArrayWork = new Button();
            lblteDataInputLength = new Label();
            lblDataOutputLength = new Label();
            teDataInputLength = new TextBox();
            teDataOutputLength = new TextBox();
            btnClearInputData = new Button();
            btnLoadInputData = new Button();
            btnSaveFile = new Button();
            cbGZip = new CheckBox();
            rbEncode = new RadioButton();
            rbDecode = new RadioButton();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            cleadToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            closeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // rtDataInput
            // 
            rtDataInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtDataInput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtDataInput.Location = new Point(12, 61);
            rtDataInput.Name = "rtDataInput";
            rtDataInput.ReadOnly = true;
            rtDataInput.Size = new Size(382, 356);
            rtDataInput.TabIndex = 0;
            rtDataInput.Text = "";
            // 
            // rtDataOutput
            // 
            rtDataOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            rtDataOutput.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtDataOutput.Location = new Point(454, 61);
            rtDataOutput.Name = "rtDataOutput";
            rtDataOutput.ReadOnly = true;
            rtDataOutput.Size = new Size(334, 356);
            rtDataOutput.TabIndex = 1;
            rtDataOutput.Text = "";
            // 
            // btnProgmemArrayWork
            // 
            btnProgmemArrayWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProgmemArrayWork.Location = new Point(400, 161);
            btnProgmemArrayWork.Name = "btnProgmemArrayWork";
            btnProgmemArrayWork.Size = new Size(48, 59);
            btnProgmemArrayWork.TabIndex = 2;
            btnProgmemArrayWork.Text = ">>";
            btnProgmemArrayWork.UseVisualStyleBackColor = true;
            // 
            // lblteDataInputLength
            // 
            lblteDataInputLength.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblteDataInputLength.AutoSize = true;
            lblteDataInputLength.Location = new Point(12, 426);
            lblteDataInputLength.Name = "lblteDataInputLength";
            lblteDataInputLength.Size = new Size(44, 15);
            lblteDataInputLength.TabIndex = 3;
            lblteDataInputLength.Text = "Length";
            // 
            // lblDataOutputLength
            // 
            lblDataOutputLength.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblDataOutputLength.AutoSize = true;
            lblDataOutputLength.Location = new Point(454, 426);
            lblDataOutputLength.Name = "lblDataOutputLength";
            lblDataOutputLength.Size = new Size(44, 15);
            lblDataOutputLength.TabIndex = 4;
            lblDataOutputLength.Text = "Length";
            // 
            // teDataInputLength
            // 
            teDataInputLength.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            teDataInputLength.Location = new Point(62, 423);
            teDataInputLength.Name = "teDataInputLength";
            teDataInputLength.ReadOnly = true;
            teDataInputLength.Size = new Size(100, 23);
            teDataInputLength.TabIndex = 5;
            // 
            // teDataOutputLength
            // 
            teDataOutputLength.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            teDataOutputLength.Location = new Point(504, 423);
            teDataOutputLength.Name = "teDataOutputLength";
            teDataOutputLength.ReadOnly = true;
            teDataOutputLength.Size = new Size(100, 23);
            teDataOutputLength.TabIndex = 6;
            // 
            // btnClearInputData
            // 
            btnClearInputData.Location = new Point(204, 32);
            btnClearInputData.Name = "btnClearInputData";
            btnClearInputData.Size = new Size(113, 23);
            btnClearInputData.TabIndex = 7;
            btnClearInputData.Text = "Clear input data";
            btnClearInputData.UseVisualStyleBackColor = true;
            // 
            // btnLoadInputData
            // 
            btnLoadInputData.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoadInputData.BackgroundImageLayout = ImageLayout.Zoom;
            btnLoadInputData.ImageAlign = ContentAlignment.MiddleLeft;
            btnLoadInputData.Location = new Point(75, 32);
            btnLoadInputData.Name = "btnLoadInputData";
            btnLoadInputData.Size = new Size(113, 23);
            btnLoadInputData.TabIndex = 8;
            btnLoadInputData.Text = "Load input data";
            btnLoadInputData.UseVisualStyleBackColor = true;
            // 
            // btnSaveFile
            // 
            btnSaveFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveFile.BackgroundImageLayout = ImageLayout.Zoom;
            btnSaveFile.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveFile.Location = new Point(626, 32);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(147, 23);
            btnSaveFile.TabIndex = 9;
            btnSaveFile.Text = "Save input data";
            btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // cbGZip
            // 
            cbGZip.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbGZip.AutoSize = true;
            cbGZip.Location = new Point(400, 247);
            cbGZip.Name = "cbGZip";
            cbGZip.Size = new Size(48, 19);
            cbGZip.TabIndex = 10;
            cbGZip.Text = "gzip";
            cbGZip.UseVisualStyleBackColor = true;
            // 
            // rbEncode
            // 
            rbEncode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbEncode.AutoSize = true;
            rbEncode.Checked = true;
            rbEncode.Location = new Point(453, 32);
            rbEncode.Name = "rbEncode";
            rbEncode.Size = new Size(64, 19);
            rbEncode.TabIndex = 11;
            rbEncode.TabStop = true;
            rbEncode.Text = "encode";
            rbEncode.UseVisualStyleBackColor = true;
            // 
            // rbDecode
            // 
            rbDecode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            rbDecode.AutoSize = true;
            rbDecode.Location = new Point(523, 32);
            rbDecode.Name = "rbDecode";
            rbDecode.Size = new Size(64, 19);
            rbDecode.TabIndex = 12;
            rbDecode.Text = "decode";
            rbDecode.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 13;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, cleadToolStripMenuItem, saveToolStripMenuItem, toolStripMenuItem1, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(180, 22);
            loadToolStripMenuItem.Text = "Load";
            // 
            // cleadToolStripMenuItem
            // 
            cleadToolStripMenuItem.Name = "cleadToolStripMenuItem";
            cleadToolStripMenuItem.Size = new Size(180, 22);
            cleadToolStripMenuItem.Text = "Clead";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(180, 22);
            saveToolStripMenuItem.Text = "Save";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            // 
            // FormPROGMEM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rbDecode);
            Controls.Add(rbEncode);
            Controls.Add(cbGZip);
            Controls.Add(btnSaveFile);
            Controls.Add(btnLoadInputData);
            Controls.Add(btnClearInputData);
            Controls.Add(teDataOutputLength);
            Controls.Add(teDataInputLength);
            Controls.Add(lblDataOutputLength);
            Controls.Add(lblteDataInputLength);
            Controls.Add(btnProgmemArrayWork);
            Controls.Add(rtDataOutput);
            Controls.Add(rtDataInput);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPROGMEM";
            Text = "PROGMEM array generator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtDataInput;
        private RichTextBox rtDataOutput;
        private Button btnProgmemArrayWork;
        private Label lblteDataInputLength;
        private Label lblDataOutputLength;
        private TextBox teDataInputLength;
        private TextBox teDataOutputLength;
        private Button btnClearInputData;
        private Button btnLoadInputData;
        private Button btnSaveFile;
        private CheckBox cbGZip;
        private RadioButton rbEncode;
        private RadioButton rbDecode;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem cleadToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}