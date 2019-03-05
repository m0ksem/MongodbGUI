namespace Mongodb_gui
{
    partial class ViewCollection
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.NotificationText = new System.Windows.Forms.Label();
            this.editPanel = new System.Windows.Forms.Panel();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ValueEditTextBox = new System.Windows.Forms.TextBox();
            this.NameEditTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameEditLable = new System.Windows.Forms.Label();
            this.changeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addNewObject = new System.Windows.Forms.Button();
            this.CollectionView = new System.Windows.Forms.TreeView();
            this.okay = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.NotificationPanel.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NotificationPanel);
            this.panel2.Controls.Add(this.editPanel);
            this.panel2.Controls.Add(this.addNewObject);
            this.panel2.Controls.Add(this.CollectionView);
            this.panel2.Location = new System.Drawing.Point(8, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 492);
            this.panel2.TabIndex = 11;
            // 
            // NotificationPanel
            // 
            this.NotificationPanel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NotificationPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NotificationPanel.Controls.Add(this.Description);
            this.NotificationPanel.Controls.Add(this.NotificationText);
            this.NotificationPanel.Location = new System.Drawing.Point(164, 421);
            this.NotificationPanel.Name = "NotificationPanel";
            this.NotificationPanel.Size = new System.Drawing.Size(337, 61);
            this.NotificationPanel.TabIndex = 5;
            this.NotificationPanel.Visible = false;
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Description.Location = new System.Drawing.Point(11, 34);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(147, 13);
            this.Description.TabIndex = 1;
            this.Description.Text = "AAAAAAAAAAAAAAAAAAAA";
            // 
            // NotificationText
            // 
            this.NotificationText.AutoSize = true;
            this.NotificationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.NotificationText.ForeColor = System.Drawing.Color.White;
            this.NotificationText.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NotificationText.Location = new System.Drawing.Point(11, 11);
            this.NotificationText.Name = "NotificationText";
            this.NotificationText.Size = new System.Drawing.Size(80, 15);
            this.NotificationText.TabIndex = 0;
            this.NotificationText.Text = "Notification";
            // 
            // editPanel
            // 
            this.editPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editPanel.Controls.Add(this.removeButton);
            this.editPanel.Controls.Add(this.addButton);
            this.editPanel.Controls.Add(this.button1);
            this.editPanel.Controls.Add(this.ValueEditTextBox);
            this.editPanel.Controls.Add(this.NameEditTextBox);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.NameEditLable);
            this.editPanel.Controls.Add(this.changeTypeComboBox);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Location = new System.Drawing.Point(15, 6);
            this.editPanel.Name = "editPanel";
            this.editPanel.Size = new System.Drawing.Size(629, 45);
            this.editPanel.TabIndex = 4;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.removeButton.Enabled = false;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.removeButton.Location = new System.Drawing.Point(549, 14);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addButton.Enabled = false;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addButton.Location = new System.Drawing.Point(468, 14);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(387, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ValueEditTextBox
            // 
            this.ValueEditTextBox.Enabled = false;
            this.ValueEditTextBox.Location = new System.Drawing.Point(260, 16);
            this.ValueEditTextBox.Name = "ValueEditTextBox";
            this.ValueEditTextBox.Size = new System.Drawing.Size(121, 20);
            this.ValueEditTextBox.TabIndex = 5;
            // 
            // NameEditTextBox
            // 
            this.NameEditTextBox.Enabled = false;
            this.NameEditTextBox.Location = new System.Drawing.Point(133, 16);
            this.NameEditTextBox.Name = "NameEditTextBox";
            this.NameEditTextBox.Size = new System.Drawing.Size(121, 20);
            this.NameEditTextBox.TabIndex = 4;
            this.NameEditTextBox.Click += new System.EventHandler(this.NameEditTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(257, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Value";
            // 
            // NameEditLable
            // 
            this.NameEditLable.AutoSize = true;
            this.NameEditLable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameEditLable.Location = new System.Drawing.Point(133, 0);
            this.NameEditLable.Name = "NameEditLable";
            this.NameEditLable.Size = new System.Drawing.Size(35, 13);
            this.NameEditLable.TabIndex = 2;
            this.NameEditLable.Text = "Name";
            // 
            // changeTypeComboBox
            // 
            this.changeTypeComboBox.Enabled = false;
            this.changeTypeComboBox.FormattingEnabled = true;
            this.changeTypeComboBox.Items.AddRange(new object[] {
            "String",
            "Int32"});
            this.changeTypeComboBox.Location = new System.Drawing.Point(6, 16);
            this.changeTypeComboBox.Name = "changeTypeComboBox";
            this.changeTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.changeTypeComboBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Type";
            // 
            // addNewObject
            // 
            this.addNewObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewObject.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addNewObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addNewObject.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewObject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.addNewObject.Location = new System.Drawing.Point(553, 446);
            this.addNewObject.Name = "addNewObject";
            this.addNewObject.Size = new System.Drawing.Size(95, 36);
            this.addNewObject.TabIndex = 9;
            this.addNewObject.Text = "New Object";
            this.addNewObject.UseVisualStyleBackColor = false;
            this.addNewObject.Click += new System.EventHandler(this.addNewObject_Click);
            // 
            // CollectionView
            // 
            this.CollectionView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CollectionView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CollectionView.Location = new System.Drawing.Point(15, 61);
            this.CollectionView.Margin = new System.Windows.Forms.Padding(15);
            this.CollectionView.Name = "CollectionView";
            this.CollectionView.ShowNodeToolTips = true;
            this.CollectionView.Size = new System.Drawing.Size(629, 414);
            this.CollectionView.TabIndex = 0;
            this.CollectionView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CollectionView_AfterSelect);
            // 
            // okay
            // 
            this.okay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okay.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.okay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.okay.FlatAppearance.BorderSize = 0;
            this.okay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okay.ForeColor = System.Drawing.Color.White;
            this.okay.Location = new System.Drawing.Point(594, 520);
            this.okay.Name = "okay";
            this.okay.Size = new System.Drawing.Size(75, 23);
            this.okay.TabIndex = 12;
            this.okay.Text = "OK";
            this.okay.UseVisualStyleBackColor = false;
            this.okay.Click += new System.EventHandler(this.okay_Click);
            // 
            // ViewCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(679, 551);
            this.Controls.Add(this.okay);
            this.Controls.Add(this.panel2);
            this.Name = "ViewCollection";
            this.Text = "ViewCollection";
            this.Load += new System.EventHandler(this.ViewCollection_Load);
            this.panel2.ResumeLayout(false);
            this.NotificationPanel.ResumeLayout(false);
            this.NotificationPanel.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel NotificationPanel;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label NotificationText;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ValueEditTextBox;
        private System.Windows.Forms.TextBox NameEditTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameEditLable;
        private System.Windows.Forms.ComboBox changeTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addNewObject;
        private System.Windows.Forms.TreeView CollectionView;
        private System.Windows.Forms.Button okay;
    }
}