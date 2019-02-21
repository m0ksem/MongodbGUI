namespace Mongodb_gui
{
    partial class Add
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
            this.okay = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.AddToArrayPanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputValueForArrayElement = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddDocumentPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.documentPropertyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.documentPropertyValue = new System.Windows.Forms.TextBox();
            this.AddToArrayPanel.SuspendLayout();
            this.AddDocumentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okay
            // 
            this.okay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.okay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.okay.FlatAppearance.BorderSize = 0;
            this.okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay.ForeColor = System.Drawing.Color.White;
            this.okay.Location = new System.Drawing.Point(187, 112);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.TabIndex = 6;
            this.okay.Text = "Add";
            this.okay.UseVisualStyleBackColor = false;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // cancel
            // 
            this.cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel.BackColor = System.Drawing.Color.MediumAquamarine;
            this.cancel.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.ForeColor = System.Drawing.Color.White;
            this.cancel.Location = new System.Drawing.Point(106, 112);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // AddToArrayPanel
            // 
            this.AddToArrayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToArrayPanel.Controls.Add(this.label2);
            this.AddToArrayPanel.Controls.Add(this.inputValueForArrayElement);
            this.AddToArrayPanel.Controls.Add(this.label1);
            this.AddToArrayPanel.Controls.Add(this.comboBox1);
            this.AddToArrayPanel.Location = new System.Drawing.Point(12, 12);
            this.AddToArrayPanel.Name = "AddToArrayPanel";
            this.AddToArrayPanel.Size = new System.Drawing.Size(247, 90);
            this.AddToArrayPanel.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "String",
            "Int32",
            "Array",
            "Document"});
            this.comboBox1.Location = new System.Drawing.Point(48, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(184, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "String";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type";
            // 
            // inputValueForArrayElement
            // 
            this.inputValueForArrayElement.Location = new System.Drawing.Point(48, 35);
            this.inputValueForArrayElement.Name = "inputValueForArrayElement";
            this.inputValueForArrayElement.Size = new System.Drawing.Size(184, 20);
            this.inputValueForArrayElement.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // AddDocumentPanel
            // 
            this.AddDocumentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDocumentPanel.Controls.Add(this.documentPropertyValue);
            this.AddDocumentPanel.Controls.Add(this.label3);
            this.AddDocumentPanel.Controls.Add(this.documentPropertyName);
            this.AddDocumentPanel.Controls.Add(this.label4);
            this.AddDocumentPanel.Controls.Add(this.comboBox2);
            this.AddDocumentPanel.Controls.Add(this.label5);
            this.AddDocumentPanel.Location = new System.Drawing.Point(12, 12);
            this.AddDocumentPanel.Name = "AddDocumentPanel";
            this.AddDocumentPanel.Size = new System.Drawing.Size(247, 90);
            this.AddDocumentPanel.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // documentPropertyName
            // 
            this.documentPropertyName.Location = new System.Drawing.Point(48, 35);
            this.documentPropertyName.Name = "documentPropertyName";
            this.documentPropertyName.Size = new System.Drawing.Size(184, 20);
            this.documentPropertyName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Type";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "String",
            "Int32",
            "Array",
            "Document"});
            this.comboBox2.Location = new System.Drawing.Point(48, 8);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(184, 21);
            this.comboBox2.TabIndex = 0;
            this.comboBox2.Text = "String";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Value";
            // 
            // documentPropertyValue
            // 
            this.documentPropertyValue.Location = new System.Drawing.Point(48, 61);
            this.documentPropertyValue.Name = "documentPropertyValue";
            this.documentPropertyValue.Size = new System.Drawing.Size(184, 20);
            this.documentPropertyValue.TabIndex = 4;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 144);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.AddToArrayPanel);
            this.Controls.Add(this.AddDocumentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.AddToArrayPanel.ResumeLayout(false);
            this.AddToArrayPanel.PerformLayout();
            this.AddDocumentPanel.ResumeLayout(false);
            this.AddDocumentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okay;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel AddToArrayPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputValueForArrayElement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel AddDocumentPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox documentPropertyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox documentPropertyValue;
        private System.Windows.Forms.Label label5;
    }
}