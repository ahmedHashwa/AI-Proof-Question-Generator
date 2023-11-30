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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversionForm));
            Convert = new Button();
            TextSizeTextBox = new TextBox();
            CutOffIndexTextBox = new TextBox();
            label1 = new Label();
            AntiCheatingLabels = new TextBox();
            label2 = new Label();
            PointsPerCharacterTrackBar = new TrackBar();
            label3 = new Label();
            PreviewPictureBox = new PictureBox();
            label4 = new Label();
            PointsPerCharacterLabel = new Label();
            SourceTextBox = new TextBox();
            label5 = new Label();
            SetClipboardCheckBox = new CheckBox();
            CopyToClipboardButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PointsPerCharacterTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).BeginInit();
            SuspendLayout();
            // 
            // Convert
            // 
            Convert.Location = new Point(12, 190);
            Convert.Name = "Convert";
            Convert.Size = new Size(361, 67);
            Convert.TabIndex = 0;
            Convert.Text = "Convert Text to Image";
            Convert.UseVisualStyleBackColor = true;
            Convert.Click += Convert_Click;
            // 
            // TextSizeTextBox
            // 
            TextSizeTextBox.Location = new Point(12, 283);
            TextSizeTextBox.Name = "TextSizeTextBox";
            TextSizeTextBox.PlaceholderText = "Text Size";
            TextSizeTextBox.Size = new Size(250, 47);
            TextSizeTextBox.TabIndex = 1;
            TextSizeTextBox.Text = "24";
            TextSizeTextBox.TextChanged += TextSizeTextBox_TextChanged;
            // 
            // CutOffIndexTextBox
            // 
            CutOffIndexTextBox.Location = new Point(359, 283);
            CutOffIndexTextBox.Name = "CutOffIndexTextBox";
            CutOffIndexTextBox.PlaceholderText = "Cut off Index";
            CutOffIndexTextBox.Size = new Size(250, 47);
            CutOffIndexTextBox.TabIndex = 1;
            CutOffIndexTextBox.Text = "20";
            CutOffIndexTextBox.TextChanged += CutOffIndexTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 361);
            label1.Name = "label1";
            label1.Size = new Size(657, 41);
            label1.TabIndex = 2;
            label1.Text = "Shortcut key is Play/Pause , PageUp/Down, Next";
            // 
            // AntiCheatingLabels
            // 
            AntiCheatingLabels.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            AntiCheatingLabels.Location = new Point(685, 105);
            AntiCheatingLabels.Multiline = true;
            AntiCheatingLabels.Name = "AntiCheatingLabels";
            AntiCheatingLabels.Size = new Size(506, 333);
            AntiCheatingLabels.TabIndex = 3;
            AntiCheatingLabels.Text = "Don't cheat\r\nNo cheating\r\nDo it yourself\r\nBe honest\r\nDo your best\r\nProtect integrity";
            AntiCheatingLabels.TextChanged += AntiCheatingLabels_TextChanged;
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
            PointsPerCharacterTrackBar.Location = new Point(4, 511);
            PointsPerCharacterTrackBar.Maximum = 50;
            PointsPerCharacterTrackBar.Name = "PointsPerCharacterTrackBar";
            PointsPerCharacterTrackBar.Size = new Size(557, 114);
            PointsPerCharacterTrackBar.TabIndex = 5;
            PointsPerCharacterTrackBar.Scroll += PointsPerCharacterTrackBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 444);
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
            PreviewPictureBox.Size = new Size(1201, 478);
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
            // PointsPerCharacterLabel
            // 
            PointsPerCharacterLabel.AutoSize = true;
            PointsPerCharacterLabel.Location = new Point(278, 444);
            PointsPerCharacterLabel.Name = "PointsPerCharacterLabel";
            PointsPerCharacterLabel.Size = new Size(50, 41);
            PointsPerCharacterLabel.TabIndex = 6;
            PointsPerCharacterLabel.Text = "15";
            // 
            // SourceTextBox
            // 
            SourceTextBox.Location = new Point(12, 66);
            SourceTextBox.Multiline = true;
            SourceTextBox.Name = "SourceTextBox";
            SourceTextBox.Size = new Size(649, 118);
            SourceTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 9);
            label5.Name = "label5";
            label5.Size = new Size(235, 41);
            label5.TabIndex = 9;
            label5.Text = "Convert this text";
            // 
            // SetClipboardCheckBox
            // 
            SetClipboardCheckBox.AutoSize = true;
            SetClipboardCheckBox.Checked = true;
            SetClipboardCheckBox.CheckState = CheckState.Checked;
            SetClipboardCheckBox.Location = new Point(398, 202);
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
            // ConversionForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2539, 647);
            Controls.Add(CopyToClipboardButton);
            Controls.Add(SetClipboardCheckBox);
            Controls.Add(label5);
            Controls.Add(SourceTextBox);
            Controls.Add(PreviewPictureBox);
            Controls.Add(PointsPerCharacterLabel);
            Controls.Add(label3);
            Controls.Add(PointsPerCharacterTrackBar);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(AntiCheatingLabels);
            Controls.Add(label1);
            Controls.Add(CutOffIndexTextBox);
            Controls.Add(TextSizeTextBox);
            Controls.Add(Convert);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ConversionForm";
            Text = "Convert Question Text to Image";
            Load += ConversionForm_Load;
            ((System.ComponentModel.ISupportInitialize)PointsPerCharacterTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)PreviewPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Convert;
        private TextBox TextSizeTextBox;
        private TextBox CutOffIndexTextBox;
        private Label label1;
        private TextBox AntiCheatingLabels;
        private Label label2;
        private TrackBar PointsPerCharacterTrackBar;
        private Label label3;
        private PictureBox PreviewPictureBox;
        private Label label4;
        private Label PointsPerCharacterLabel;
        private TextBox SourceTextBox;
        private Label label5;
        private CheckBox SetClipboardCheckBox;
        private Button CopyToClipboardButton;
    }
}