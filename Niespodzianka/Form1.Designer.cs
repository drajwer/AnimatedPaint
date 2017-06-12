namespace Niespodzianka
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxColorPreview = new System.Windows.Forms.PictureBox();
            this.colorPreviewLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColorPickButton = new System.Windows.Forms.Button();
            this.circlesRadioButton = new System.Windows.Forms.RadioButton();
            this.linesRadioButton = new System.Windows.Forms.RadioButton();
            this.startingFrameListView = new System.Windows.Forms.ListView();
            this.startingFramePictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.endingFrameListView = new System.Windows.Forms.ListView();
            this.endingFramePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.animationPictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AnimationSpeedLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FPSCounterLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.StartAnimationButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingFramePictureBox)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endingFramePictureBox)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1020, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Starting frame";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.startingFrameListView, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.startingFramePictureBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1014, 540);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxColorPreview);
            this.panel2.Controls.Add(this.colorPreviewLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(763, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 24);
            this.panel2.TabIndex = 3;
            // 
            // pictureBoxColorPreview
            // 
            this.pictureBoxColorPreview.Location = new System.Drawing.Point(125, 3);
            this.pictureBoxColorPreview.Name = "pictureBoxColorPreview";
            this.pictureBoxColorPreview.Size = new System.Drawing.Size(100, 18);
            this.pictureBoxColorPreview.TabIndex = 1;
            this.pictureBoxColorPreview.TabStop = false;
            // 
            // colorPreviewLabel
            // 
            this.colorPreviewLabel.AutoSize = true;
            this.colorPreviewLabel.Location = new System.Drawing.Point(19, 6);
            this.colorPreviewLabel.Name = "colorPreviewLabel";
            this.colorPreviewLabel.Size = new System.Drawing.Size(71, 13);
            this.colorPreviewLabel.TabIndex = 0;
            this.colorPreviewLabel.Text = "Color preview";
            this.colorPreviewLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ColorPickButton);
            this.panel1.Controls.Add(this.circlesRadioButton);
            this.panel1.Controls.Add(this.linesRadioButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 24);
            this.panel1.TabIndex = 0;
            // 
            // ColorPickButton
            // 
            this.ColorPickButton.Location = new System.Drawing.Point(543, 1);
            this.ColorPickButton.Name = "ColorPickButton";
            this.ColorPickButton.Size = new System.Drawing.Size(75, 23);
            this.ColorPickButton.TabIndex = 2;
            this.ColorPickButton.Text = "Pick a Color";
            this.ColorPickButton.UseVisualStyleBackColor = true;
            this.ColorPickButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // circlesRadioButton
            // 
            this.circlesRadioButton.AutoSize = true;
            this.circlesRadioButton.Location = new System.Drawing.Point(299, 4);
            this.circlesRadioButton.Name = "circlesRadioButton";
            this.circlesRadioButton.Size = new System.Drawing.Size(84, 17);
            this.circlesRadioButton.TabIndex = 1;
            this.circlesRadioButton.Text = "Draw Circles";
            this.circlesRadioButton.UseVisualStyleBackColor = true;
            // 
            // linesRadioButton
            // 
            this.linesRadioButton.AutoSize = true;
            this.linesRadioButton.Checked = true;
            this.linesRadioButton.Location = new System.Drawing.Point(126, 4);
            this.linesRadioButton.Name = "linesRadioButton";
            this.linesRadioButton.Size = new System.Drawing.Size(78, 17);
            this.linesRadioButton.TabIndex = 0;
            this.linesRadioButton.TabStop = true;
            this.linesRadioButton.Text = "Draw Lines";
            this.linesRadioButton.UseVisualStyleBackColor = true;
            // 
            // startingFrameListView
            // 
            this.startingFrameListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingFrameListView.Location = new System.Drawing.Point(763, 33);
            this.startingFrameListView.Name = "startingFrameListView";
            this.startingFrameListView.Size = new System.Drawing.Size(248, 504);
            this.startingFrameListView.TabIndex = 4;
            this.startingFrameListView.UseCompatibleStateImageBehavior = false;
            // 
            // startingFramePictureBox
            // 
            this.startingFramePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startingFramePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startingFramePictureBox.Location = new System.Drawing.Point(3, 33);
            this.startingFramePictureBox.Name = "startingFramePictureBox";
            this.startingFramePictureBox.Size = new System.Drawing.Size(754, 504);
            this.startingFramePictureBox.TabIndex = 1;
            this.startingFramePictureBox.TabStop = false;
            this.startingFramePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 572);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1020, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ending frame";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.endingFrameListView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.endingFramePictureBox, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1020, 546);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // endingFrameListView
            // 
            this.endingFrameListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingFrameListView.Location = new System.Drawing.Point(768, 3);
            this.endingFrameListView.Name = "endingFrameListView";
            this.endingFrameListView.Size = new System.Drawing.Size(249, 540);
            this.endingFrameListView.TabIndex = 5;
            this.endingFrameListView.UseCompatibleStateImageBehavior = false;
            // 
            // endingFramePictureBox
            // 
            this.endingFramePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingFramePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endingFramePictureBox.Location = new System.Drawing.Point(3, 3);
            this.endingFramePictureBox.Name = "endingFramePictureBox";
            this.endingFramePictureBox.Size = new System.Drawing.Size(759, 540);
            this.endingFramePictureBox.TabIndex = 2;
            this.endingFramePictureBox.TabStop = false;
            this.endingFramePictureBox.Click += new System.EventHandler(this.endingFramePictureBox_Click);
            this.endingFramePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.endingFramePictureBox_Paint);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1020, 546);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Animation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.animationPictureBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1020, 546);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.animationPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.animationPictureBox.Location = new System.Drawing.Point(3, 44);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(759, 499);
            this.animationPictureBox.TabIndex = 1;
            this.animationPictureBox.TabStop = false;
            this.animationPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.animationPictureBox_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.AnimationSpeedLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 35);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ResetButton);
            this.panel4.Controls.Add(this.StartAnimationButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(768, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 499);
            this.panel4.TabIndex = 0;
            // 
            // AnimationSpeedLabel
            // 
            this.AnimationSpeedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnimationSpeedLabel.AutoSize = true;
            this.AnimationSpeedLabel.Location = new System.Drawing.Point(30, 5);
            this.AnimationSpeedLabel.Name = "AnimationSpeedLabel";
            this.AnimationSpeedLabel.Size = new System.Drawing.Size(85, 13);
            this.AnimationSpeedLabel.TabIndex = 0;
            this.AnimationSpeedLabel.Text = "Animation speed";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "FPS:";
            // 
            // FPSCounterLabel
            // 
            this.FPSCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FPSCounterLabel.AutoSize = true;
            this.FPSCounterLabel.Location = new System.Drawing.Point(125, 5);
            this.FPSCounterLabel.Name = "FPSCounterLabel";
            this.FPSCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FPSCounterLabel.Size = new System.Drawing.Size(0, 13);
            this.FPSCounterLabel.TabIndex = 2;
            this.FPSCounterLabel.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.FPSCounterLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(768, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(249, 35);
            this.panel5.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(132, 3);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(624, 45);
            this.trackBar1.TabIndex = 3;
            // 
            // StartAnimationButton
            // 
            this.StartAnimationButton.Location = new System.Drawing.Point(85, 54);
            this.StartAnimationButton.Name = "StartAnimationButton";
            this.StartAnimationButton.Size = new System.Drawing.Size(75, 23);
            this.StartAnimationButton.TabIndex = 4;
            this.StartAnimationButton.Text = "Start";
            this.StartAnimationButton.UseVisualStyleBackColor = true;
            this.StartAnimationButton.Click += new System.EventHandler(this.StartAnimationButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(85, 193);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 5;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorPreview)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startingFramePictureBox)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.endingFramePictureBox)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxColorPreview;
        private System.Windows.Forms.Label colorPreviewLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ColorPickButton;
        private System.Windows.Forms.RadioButton circlesRadioButton;
        private System.Windows.Forms.RadioButton linesRadioButton;
        private System.Windows.Forms.ListView startingFrameListView;
        private System.Windows.Forms.PictureBox startingFramePictureBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListView endingFrameListView;
        private System.Windows.Forms.PictureBox endingFramePictureBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox animationPictureBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FPSCounterLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label AnimationSpeedLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button StartAnimationButton;
    }
}

