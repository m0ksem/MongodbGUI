namespace Mongodb_gui
{
    partial class ConnectForm
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
            this.useIPAndPortPanel = new System.Windows.Forms.Panel();
            this.useURLButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Header = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portBox = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.useURLPanel = new System.Windows.Forms.Panel();
            this.useIPAndPort = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.useIPAndPortPanel.SuspendLayout();
            this.useURLPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // useIPAndPortPanel
            // 
            this.useIPAndPortPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.useIPAndPortPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.useIPAndPortPanel.Controls.Add(this.useURLButton);
            this.useIPAndPortPanel.Controls.Add(this.button1);
            this.useIPAndPortPanel.Controls.Add(this.Header);
            this.useIPAndPortPanel.Controls.Add(this.label2);
            this.useIPAndPortPanel.Controls.Add(this.portBox);
            this.useIPAndPortPanel.Controls.Add(this.ipBox);
            this.useIPAndPortPanel.Controls.Add(this.label1);
            this.useIPAndPortPanel.Location = new System.Drawing.Point(12, 12);
            this.useIPAndPortPanel.Name = "useIPAndPortPanel";
            this.useIPAndPortPanel.Size = new System.Drawing.Size(392, 134);
            this.useIPAndPortPanel.TabIndex = 6;
            // 
            // useURLButton
            // 
            this.useURLButton.BackColor = System.Drawing.Color.MediumAquamarine;
            this.useURLButton.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.useURLButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useURLButton.ForeColor = System.Drawing.Color.White;
            this.useURLButton.Location = new System.Drawing.Point(222, 103);
            this.useURLButton.Name = "useURLButton";
            this.useURLButton.Size = new System.Drawing.Size(75, 23);
            this.useURLButton.TabIndex = 7;
            this.useURLButton.Text = "Use URL";
            this.useURLButton.UseVisualStyleBackColor = false;
            this.useURLButton.Click += new System.EventHandler(this.useURLButton_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(303, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.Location = new System.Drawing.Point(165, 9);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(69, 20);
            this.Header.TabIndex = 4;
            this.Header.Text = "Connect";
            this.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server IP";
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.Location = new System.Drawing.Point(68, 68);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(302, 20);
            this.portBox.TabIndex = 3;
            this.portBox.Text = "27017";
            // 
            // ipBox
            // 
            this.ipBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ipBox.Location = new System.Drawing.Point(68, 42);
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(302, 20);
            this.ipBox.TabIndex = 2;
            this.ipBox.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server port";
            // 
            // useURLPanel
            // 
            this.useURLPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.useURLPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.useURLPanel.Controls.Add(this.useIPAndPort);
            this.useURLPanel.Controls.Add(this.button3);
            this.useURLPanel.Controls.Add(this.label3);
            this.useURLPanel.Controls.Add(this.label4);
            this.useURLPanel.Controls.Add(this.urlBox);
            this.useURLPanel.Location = new System.Drawing.Point(12, 12);
            this.useURLPanel.Name = "useURLPanel";
            this.useURLPanel.Size = new System.Drawing.Size(392, 134);
            this.useURLPanel.TabIndex = 0;
            this.useURLPanel.Visible = false;
            // 
            // useIPAndPort
            // 
            this.useIPAndPort.BackColor = System.Drawing.Color.MediumAquamarine;
            this.useIPAndPort.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.useIPAndPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.useIPAndPort.ForeColor = System.Drawing.Color.White;
            this.useIPAndPort.Location = new System.Drawing.Point(199, 103);
            this.useIPAndPort.Name = "useIPAndPort";
            this.useIPAndPort.Size = new System.Drawing.Size(98, 23);
            this.useIPAndPort.TabIndex = 7;
            this.useIPAndPort.Text = "Use IP and Port";
            this.useIPAndPort.UseVisualStyleBackColor = false;
            this.useIPAndPort.Click += new System.EventHandler(this.useIPAndPort_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(303, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Connect";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(165, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Connect";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Connection URL";
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(95, 42);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(275, 20);
            this.urlBox.TabIndex = 2;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(416, 159);
            this.Controls.Add(this.useIPAndPortPanel);
            this.Controls.Add(this.useURLPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to database";
            this.useIPAndPortPanel.ResumeLayout(false);
            this.useIPAndPortPanel.PerformLayout();
            this.useURLPanel.ResumeLayout(false);
            this.useURLPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel useIPAndPortPanel;
        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portBox;
        private System.Windows.Forms.TextBox ipBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button useURLButton;
        private System.Windows.Forms.Panel useURLPanel;
        private System.Windows.Forms.Button useIPAndPort;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox urlBox;
    }
}