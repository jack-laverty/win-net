namespace WinNetwork
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dev1LoadButton = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.dev1SaveButton = new System.Windows.Forms.Button();
            this.dev1RestartButton = new System.Windows.Forms.Button();
            this.panelChannelData = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dev1StatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelChannelData.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dev1LoadButton);
            this.panel1.Controls.Add(this.connectButton);
            this.panel1.Controls.Add(this.dev1SaveButton);
            this.panel1.Controls.Add(this.dev1RestartButton);
            this.panel1.Location = new System.Drawing.Point(4, 180);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 65);
            this.panel1.TabIndex = 27;
            // 
            // dev1LoadButton
            // 
            this.dev1LoadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.dev1LoadButton.Enabled = false;
            this.dev1LoadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dev1LoadButton.FlatAppearance.BorderSize = 0;
            this.dev1LoadButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.dev1LoadButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.dev1LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dev1LoadButton.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dev1LoadButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dev1LoadButton.Location = new System.Drawing.Point(357, 16);
            this.dev1LoadButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dev1LoadButton.Name = "dev1LoadButton";
            this.dev1LoadButton.Size = new System.Drawing.Size(100, 35);
            this.dev1LoadButton.TabIndex = 39;
            this.dev1LoadButton.Text = "Load";
            this.dev1LoadButton.UseVisualStyleBackColor = false;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.connectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.connectButton.FlatAppearance.BorderSize = 0;
            this.connectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.connectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.connectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectButton.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.connectButton.Location = new System.Drawing.Point(4, 16);
            this.connectButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 35);
            this.connectButton.TabIndex = 32;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // dev1SaveButton
            // 
            this.dev1SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.dev1SaveButton.Enabled = false;
            this.dev1SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dev1SaveButton.FlatAppearance.BorderSize = 0;
            this.dev1SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.dev1SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.dev1SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dev1SaveButton.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dev1SaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dev1SaveButton.Location = new System.Drawing.Point(242, 16);
            this.dev1SaveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dev1SaveButton.Name = "dev1SaveButton";
            this.dev1SaveButton.Size = new System.Drawing.Size(100, 35);
            this.dev1SaveButton.TabIndex = 38;
            this.dev1SaveButton.Text = "Save";
            this.dev1SaveButton.UseVisualStyleBackColor = false;
            this.dev1SaveButton.UseWaitCursor = true;
            // 
            // dev1RestartButton
            // 
            this.dev1RestartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.dev1RestartButton.Enabled = false;
            this.dev1RestartButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dev1RestartButton.FlatAppearance.BorderSize = 0;
            this.dev1RestartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(51)))));
            this.dev1RestartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(54)))), ((int)(((byte)(61)))));
            this.dev1RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dev1RestartButton.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dev1RestartButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dev1RestartButton.Location = new System.Drawing.Point(124, 16);
            this.dev1RestartButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dev1RestartButton.Name = "dev1RestartButton";
            this.dev1RestartButton.Size = new System.Drawing.Size(100, 35);
            this.dev1RestartButton.TabIndex = 37;
            this.dev1RestartButton.Text = "Restart";
            this.dev1RestartButton.UseVisualStyleBackColor = false;
            this.dev1RestartButton.Click += new System.EventHandler(this.dev1RestartButton_Click);
            // 
            // panelChannelData
            // 
            this.panelChannelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panelChannelData.Controls.Add(this.panel3);
            this.panelChannelData.Location = new System.Drawing.Point(753, 16);
            this.panelChannelData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelChannelData.Name = "panelChannelData";
            this.panelChannelData.Size = new System.Drawing.Size(488, 895);
            this.panelChannelData.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dev1StatusLabel);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(4, 26);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 278);
            this.panel3.TabIndex = 36;
            // 
            // dev1StatusLabel
            // 
            this.dev1StatusLabel.AutoSize = true;
            this.dev1StatusLabel.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dev1StatusLabel.ForeColor = System.Drawing.Color.Lime;
            this.dev1StatusLabel.Location = new System.Drawing.Point(93, 12);
            this.dev1StatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dev1StatusLabel.Name = "dev1StatusLabel";
            this.dev1StatusLabel.Size = new System.Drawing.Size(113, 23);
            this.dev1StatusLabel.TabIndex = 41;
            this.dev1StatusLabel.Text = "(Connected)";
            this.dev1StatusLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.dev1StatusLabel.Visible = false;
            this.dev1StatusLabel.Click += new System.EventHandler(this.dev1StatusLabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 40;
            this.label3.Text = "Device 1";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(128, 146);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(265, 24);
            this.textBox2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(4, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Bin Folder";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(128, 104);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(265, 24);
            this.textBox1.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(4, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "Log Folder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(38)))), ((int)(((byte)(45)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4.Location = new System.Drawing.Point(128, 60);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(265, 24);
            this.textBox4.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(4, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 28;
            this.label8.Text = "IP Address";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.textBoxStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxStatus.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxStatus.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxStatus.Location = new System.Drawing.Point(0, 42);
            this.textBoxStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(745, 890);
            this.textBoxStatus.TabIndex = 29;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1254, 928);
            this.Controls.Add(this.textBoxStatus);
            this.Controls.Add(this.panelChannelData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1272, 975);
            this.MinimumSize = new System.Drawing.Size(1272, 975);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinNetwork";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelChannelData.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelChannelData;
        public System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Button dev1LoadButton;
        private System.Windows.Forms.Button dev1SaveButton;
        private System.Windows.Forms.Button dev1RestartButton;
        private System.Windows.Forms.Button connectButton;
        private Panel panel3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox4;
        private Label label8;
        private Label dev1StatusLabel;
    }
}