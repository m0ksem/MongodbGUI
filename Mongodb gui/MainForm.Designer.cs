namespace Mongodb_gui
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.databaseComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.collectionsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CollectionView = new System.Windows.Forms.TreeView();
            this.editPanel = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ValueEditTextBox = new System.Windows.Forms.TextBox();
            this.NameEditTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NameEditLable = new System.Windows.Forms.Label();
            this.changeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NotificationPanel = new System.Windows.Forms.Panel();
            this.Description = new System.Windows.Forms.Label();
            this.NotificationText = new System.Windows.Forms.Label();
            this.addNewObject = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.editPanel.SuspendLayout();
            this.NotificationPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.databaseComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.collectionsComboBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Name = "panel1";
            // 
            // databaseComboBox
            // 
            resources.ApplyResources(this.databaseComboBox, "databaseComboBox");
            this.databaseComboBox.BackColor = System.Drawing.Color.White;
            this.databaseComboBox.FormattingEnabled = true;
            this.databaseComboBox.Name = "databaseComboBox";
            this.databaseComboBox.SelectedIndexChanged += new System.EventHandler(this.databaseComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // collectionsComboBox
            // 
            resources.ApplyResources(this.collectionsComboBox, "collectionsComboBox");
            this.collectionsComboBox.BackColor = System.Drawing.Color.White;
            this.collectionsComboBox.FormattingEnabled = true;
            this.collectionsComboBox.Name = "collectionsComboBox";
            this.collectionsComboBox.SelectedIndexChanged += new System.EventHandler(this.collectionsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // CollectionView
            // 
            resources.ApplyResources(this.CollectionView, "CollectionView");
            this.CollectionView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CollectionView.Name = "CollectionView";
            this.CollectionView.ShowNodeToolTips = true;
            this.CollectionView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.CollectionView_AfterSelect);
            // 
            // editPanel
            // 
            resources.ApplyResources(this.editPanel, "editPanel");
            this.editPanel.Controls.Add(this.Refresh);
            this.editPanel.Controls.Add(this.searchButton);
            this.editPanel.Controls.Add(this.removeButton);
            this.editPanel.Controls.Add(this.addButton);
            this.editPanel.Controls.Add(this.button1);
            this.editPanel.Controls.Add(this.ValueEditTextBox);
            this.editPanel.Controls.Add(this.NameEditTextBox);
            this.editPanel.Controls.Add(this.label5);
            this.editPanel.Controls.Add(this.NameEditLable);
            this.editPanel.Controls.Add(this.changeTypeComboBox);
            this.editPanel.Controls.Add(this.label3);
            this.editPanel.Name = "editPanel";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.ForeColor = System.Drawing.SystemColors.Control;
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.removeButton, "removeButton");
            this.removeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.removeButton.Name = "removeButton";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.addButton, "addButton");
            this.addButton.ForeColor = System.Drawing.SystemColors.Control;
            this.addButton.Name = "addButton";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ValueEditTextBox
            // 
            resources.ApplyResources(this.ValueEditTextBox, "ValueEditTextBox");
            this.ValueEditTextBox.Name = "ValueEditTextBox";
            // 
            // NameEditTextBox
            // 
            resources.ApplyResources(this.NameEditTextBox, "NameEditTextBox");
            this.NameEditTextBox.Name = "NameEditTextBox";
            this.NameEditTextBox.TextChanged += new System.EventHandler(this.NameEditTextBox_TextChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // NameEditLable
            // 
            resources.ApplyResources(this.NameEditLable, "NameEditLable");
            this.NameEditLable.Name = "NameEditLable";
            // 
            // changeTypeComboBox
            // 
            resources.ApplyResources(this.changeTypeComboBox, "changeTypeComboBox");
            this.changeTypeComboBox.FormattingEnabled = true;
            this.changeTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("changeTypeComboBox.Items"),
            resources.GetString("changeTypeComboBox.Items1")});
            this.changeTypeComboBox.Name = "changeTypeComboBox";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // NotificationPanel
            // 
            resources.ApplyResources(this.NotificationPanel, "NotificationPanel");
            this.NotificationPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.NotificationPanel.Controls.Add(this.Description);
            this.NotificationPanel.Controls.Add(this.NotificationText);
            this.NotificationPanel.Name = "NotificationPanel";
            // 
            // Description
            // 
            resources.ApplyResources(this.Description, "Description");
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Name = "Description";
            // 
            // NotificationText
            // 
            resources.ApplyResources(this.NotificationText, "NotificationText");
            this.NotificationText.ForeColor = System.Drawing.Color.White;
            this.NotificationText.Name = "NotificationText";
            // 
            // addNewObject
            // 
            resources.ApplyResources(this.addNewObject, "addNewObject");
            this.addNewObject.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.addNewObject.ForeColor = System.Drawing.SystemColors.Control;
            this.addNewObject.Name = "addNewObject";
            this.addNewObject.UseVisualStyleBackColor = false;
            this.addNewObject.Click += new System.EventHandler(this.addNewObject_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.NotificationPanel);
            this.panel2.Controls.Add(this.editPanel);
            this.panel2.Controls.Add(this.addNewObject);
            this.panel2.Controls.Add(this.CollectionView);
            this.panel2.Name = "panel2";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.MediumSeaGreen;
            resources.ApplyResources(this.Refresh, "Refresh");
            this.Refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.Refresh.Name = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editPanel.ResumeLayout(false);
            this.editPanel.PerformLayout();
            this.NotificationPanel.ResumeLayout(false);
            this.NotificationPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox databaseComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox collectionsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView CollectionView;
        private System.Windows.Forms.Panel editPanel;
        private System.Windows.Forms.ComboBox changeTypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NameEditLable;
        private System.Windows.Forms.TextBox ValueEditTextBox;
        private System.Windows.Forms.TextBox NameEditTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel NotificationPanel;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.Label NotificationText;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addNewObject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button Refresh;
    }
}

