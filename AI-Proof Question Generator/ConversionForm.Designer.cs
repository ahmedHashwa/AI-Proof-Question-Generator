namespace AIProofGen
{
    partial class ConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            Convert = new Button();
            FontSizeTextBox = new TextBox();
            CutOffIndexTextBox = new TextBox();
            AntiCheatingLabelsTextBox = new TextBox();
            label2 = new Label();
            PointsPerCharacterTrackBar = new TrackBar();
            label3 = new Label();
            PreviewPictureBox = new PictureBox();
            label4 = new Label();
            SourceTextBox = new TextBox();
            label5 = new Label();
            SetClipboardCheckBox = new CheckBox();
            CopyToClipboardButton = new Button();
            UseClipboardCheckBox = new CheckBox();
            UseGlobalKeyConvertToImageCheckBox = new CheckBox();
            UseGlobalKeyReplaceTextCheckBox = new CheckBox();
            PointsPerCharacterTextBox = new TextBox();
            label1 = new Label();
            label6 = new Label();
            FontSizeTrackBar = new TrackBar();
            CutOffIndexTrackBar = new TrackBar();
            AppNotifyIcon = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)PointsPerCharacterTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FontSizeTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CutOffIndexTrackBar).BeginInit();
            SuspendLayout();
            // 
            // Convert
            // 
            Convert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Convert.Location = new Point(12, 638);
            Convert.Name = "Convert";
            Convert.Size = new Size(361, 67);
            Convert.TabIndex = 0;
            Convert.Text = "Convert Text to Image";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // FontSizeTextBox
            // 
            FontSizeTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FontSizeTextBox.Location = new Point(308, 738);
            FontSizeTextBox.Name = "FontSizeTextBox";
            FontSizeTextBox.PlaceholderText = "Text Size";
            FontSizeTextBox.Size = new Size(125, 47);
            FontSizeTextBox.TabIndex = 1;
            FontSizeTextBox.Text = "24";
            FontSizeTextBox.TextAlign = HorizontalAlignment.Center;
            FontSizeTextBox.TextChanged += TextSizeTextBox_TextChanged;
            // 
            // CutOffIndexTextBox
            // 
            CutOffIndexTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CutOffIndexTextBox.Location = new Point(308, 919);
            CutOffIndexTextBox.Name = "CutOffIndexTextBox";
            CutOffIndexTextBox.PlaceholderText = "Cut off Index";
            CutOffIndexTextBox.Size = new Size(125, 47);
            CutOffIndexTextBox.TabIndex = 1;
            CutOffIndexTextBox.Text = "20";
            CutOffIndexTextBox.TextAlign = HorizontalAlignment.Center;
            CutOffIndexTextBox.TextChanged += CutOffIndexTextBox_TextChanged;
            // 
            // AntiCheatingLabelsTextBox
            // 
            AntiCheatingLabelsTextBox.Location = new Point(685, 105);
            AntiCheatingLabelsTextBox.Multiline = true;
            AntiCheatingLabelsTextBox.Name = "AntiCheatingLabelsTextBox";
            AntiCheatingLabelsTextBox.ScrollBars = ScrollBars.Both;
            AntiCheatingLabelsTextBox.Size = new Size(506, 348);
            AntiCheatingLabelsTextBox.TabIndex = 3;
            AntiCheatingLabelsTextBox.Text = "Don't cheat\r\nNo cheating\r\nDo it yourself\r\nBe honest\r\nDo your best\r\nProtect integrity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(685, 34);
            label2.Name = "label2";
            label2.Size = new Size(293, 41);
            label2.TabIndex = 4;
            label2.Text = "Anti-Cheating Labels";
            // 
            // PointsPerCharacterTrackBar
            // 
            PointsPerCharacterTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PointsPerCharacterTrackBar.Location = new Point(4, 1157);
            PointsPerCharacterTrackBar.Maximum = 50;
            PointsPerCharacterTrackBar.Name = "PointsPerCharacterTrackBar";
            PointsPerCharacterTrackBar.Size = new Size(557, 114);
            PointsPerCharacterTrackBar.TabIndex = 5;
            PointsPerCharacterTrackBar.Value = 15;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(4, 1103);
            label3.Name = "label3";
            label3.Size = new Size(283, 41);
            label3.TabIndex = 6;
            label3.Text = "Points Per Character";
            // 
            // PreviewPictureBox
            // 
            PreviewPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PreviewPictureBox.Location = new Point(1326, 105);
            PreviewPictureBox.Name = "PreviewPictureBox";
            PreviewPictureBox.Size = new Size(1201, 1115);
            PreviewPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            PreviewPictureBox.TabIndex = 7;
            PreviewPictureBox.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1326, 34);
            label4.Name = "label4";
            label4.Size = new Size(211, 41);
            label4.TabIndex = 4;
            label4.Text = "Preview Image";
            // 
            // SourceTextBox
            // 
            SourceTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SourceTextBox.Enabled = false;
            SourceTextBox.Location = new Point(12, 66);
            SourceTextBox.Multiline = true;
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.ScrollBars = ScrollBars.Both;
            SourceTextBox.Size = new Size(649, 552);
            SourceTextBox.TabIndex = 8;
            SourceTextBox.WordWrap = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 9);
            label5.Name = "label5";
            label5.Size = new Size(271, 41);
            label5.TabIndex = 9;
            label5.Text = "Convert this text or";
            // 
            // SetClipboardCheckBox
            // 
            SetClipboardCheckBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SetClipboardCheckBox.AutoSize = true;
            SetClipboardCheckBox.Checked = true;
            SetClipboardCheckBox.CheckState = CheckState.Checked;
            SetClipboardCheckBox.Location = new Point(398, 650);
            SetClipboardCheckBox.Name = "SetClipboardCheckBox";
            SetClipboardCheckBox.Size = new Size(236, 45);
            SetClipboardCheckBox.TabIndex = 10;
            SetClipboardCheckBox.Text = "Set Clipboard";
            SetClipboardCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyToClipboardButton
            // 
            CopyToClipboardButton.Location = new Point(1543, 25);
            CopyToClipboardButton.Name = "CopyToClipboardButton";
            CopyToClipboardButton.Size = new Size(308, 58);
            CopyToClipboardButton.TabIndex = 11;
            CopyToClipboardButton.Text = "Copy to Clipboard";
            CopyToClipboardButton.UseVisualStyleBackColor = true;
            CopyToClipboardButton.Click += CopyToClipboardButton_Click;
            // 
            // UseClipboardCheckBox
            // 
            UseClipboardCheckBox.AutoSize = true;
            UseClipboardCheckBox.Checked = true;
            UseClipboardCheckBox.CheckState = CheckState.Checked;
            UseClipboardCheckBox.Location = new Point(308, 12);
            UseClipboardCheckBox.Name = "UseClipboardCheckBox";
            UseClipboardCheckBox.Size = new Size(244, 45);
            UseClipboardCheckBox.TabIndex = 10;
            UseClipboardCheckBox.Text = "Use Clipboard";
            UseClipboardCheckBox.UseVisualStyleBackColor = true;
            UseClipboardCheckBox.CheckedChanged += UseClipboardCheckBox_CheckedChanged;
            // 
            // UseGlobalKeyConvertToImageCheckBox
            // 
            UseGlobalKeyConvertToImageCheckBox.Checked = true;
            UseGlobalKeyConvertToImageCheckBox.CheckState = CheckState.Checked;
            UseGlobalKeyConvertToImageCheckBox.Location = new Point(685, 459);
            UseGlobalKeyConvertToImageCheckBox.Name = "UseGlobalKeyConvertToImageCheckBox";
            UseGlobalKeyConvertToImageCheckBox.Size = new Size(492, 201);
            UseGlobalKeyConvertToImageCheckBox.TabIndex = 12;
            UseGlobalKeyConvertToImageCheckBox.Text = "Use Global Key (Play/Pause) to convert text to image replacing text with random text";
            UseGlobalKeyConvertToImageCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseGlobalKeyReplaceTextCheckBox
            // 
            UseGlobalKeyReplaceTextCheckBox.Location = new Point(685, 628);
            UseGlobalKeyReplaceTextCheckBox.Name = "UseGlobalKeyReplaceTextCheckBox";
            UseGlobalKeyReplaceTextCheckBox.Size = new Size(492, 201);
            UseGlobalKeyReplaceTextCheckBox.TabIndex = 12;
            UseGlobalKeyReplaceTextCheckBox.Text = "Use Global Key (Insert) to replace text with random text";
            UseGlobalKeyReplaceTextCheckBox.UseVisualStyleBackColor = true;
            // 
            // PointsPerCharacterTextBox
            // 
            PointsPerCharacterTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            PointsPerCharacterTextBox.Location = new Point(308, 1100);
            PointsPerCharacterTextBox.Name = "PointsPerCharacterTextBox";
            PointsPerCharacterTextBox.Size = new Size(125, 47);
            PointsPerCharacterTextBox.TabIndex = 1;
            PointsPerCharacterTextBox.Text = "15";
            PointsPerCharacterTextBox.TextAlign = HorizontalAlignment.Center;
            PointsPerCharacterTextBox.TextChanged += CutOffIndexTextBox_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(4, 741);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 6;
            label1.Text = "Font Size";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(4, 922);
            label6.Name = "label6";
            label6.Size = new Size(181, 41);
            label6.TabIndex = 6;
            label6.Text = "Cutoff Index";
            // 
            // FontSizeTrackBar
            // 
            FontSizeTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            FontSizeTrackBar.Location = new Point(4, 795);
            FontSizeTrackBar.Maximum = 50;
            FontSizeTrackBar.Name = "FontSizeTrackBar";
            FontSizeTrackBar.Size = new Size(557, 114);
            FontSizeTrackBar.TabIndex = 5;
            FontSizeTrackBar.Value = 24;
            // 
            // CutOffIndexTrackBar
            // 
            CutOffIndexTrackBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CutOffIndexTrackBar.Location = new Point(4, 976);
            CutOffIndexTrackBar.Maximum = 900;
            CutOffIndexTrackBar.Name = "CutOffIndexTrackBar";
            CutOffIndexTrackBar.Size = new Size(557, 114);
            CutOffIndexTrackBar.TabIndex = 5;
            CutOffIndexTrackBar.Value = 20;
            // 
            // AppNotifyIcon
            // 
            AppNotifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            AppNotifyIcon.Icon = (Icon)resources.GetObject("AppNotifyIcon.Icon");
            AppNotifyIcon.Text = "AI-Proof Question Generator App";
            AppNotifyIcon.Visible = true;
            AppNotifyIcon.MouseDoubleClick += AppNotifyIcon_MouseDoubleClick;
            // 
            // ConversionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2539, 1284);
            Controls.Add(UseGlobalKeyReplaceTextCheckBox);
            Controls.Add(UseGlobalKeyConvertToImageCheckBox);
            Controls.Add(CopyToClipboardButton);
            Controls.Add(UseClipboardCheckBox);
            Controls.Add(SetClipboardCheckBox);
            Controls.Add(label5);
            Controls.Add(SourceTextBox);
            Controls.Add(PreviewPictureBox);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(CutOffIndexTrackBar);
            Controls.Add(FontSizeTrackBar);
            Controls.Add(PointsPerCharacterTrackBar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(AntiCheatingLabelsTextBox);
            Controls.Add(PointsPerCharacterTextBox);
            Controls.Add(CutOffIndexTextBox);
            Controls.Add(FontSizeTextBox);
            Controls.Add(Convert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConversionForm";
            ShowInTaskbar = false;
            Text = "Convert Question Text to Image";
            Load += ConversionForm_Load;
            SizeChanged += ConversionForm_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)PointsPerCharacterTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)FontSizeTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)CutOffIndexTrackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Convert;
        private TextBox FontSizeTextBox;
        private TextBox CutOffIndexTextBox;
        private TextBox AntiCheatingLabelsTextBox;
        private Label label2;
        private TrackBar PointsPerCharacterTrackBar;
        private Label label3;
        private PictureBox PreviewPictureBox;
        private Label label4;
        private TextBox SourceTextBox;
        private Label label5;
        private CheckBox SetClipboardCheckBox;
        private Button CopyToClipboardButton;
        private CheckBox UseClipboardCheckBox;
        private CheckBox UseGlobalKeyConvertToImageCheckBox;
        private CheckBox UseGlobalKeyReplaceTextCheckBox;
        private TextBox PointsPerCharacterTextBox;
        private Label label1;
        private Label label6;
        private TrackBar FontSizeTrackBar;
        private TrackBar CutOffIndexTrackBar;
        private NotifyIcon AppNotifyIcon;
    }
}