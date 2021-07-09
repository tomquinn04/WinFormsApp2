
namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkToDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteExistingRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(148, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 27);
            this.textBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Customer Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(148, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(406, 27);
            this.textBox3.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(279, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 143);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(542, 144);
            this.listBox1.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.customersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linkToDatabaseToolStripMenuItem,
            this.closeDatabaseToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // linkToDatabaseToolStripMenuItem
            // 
            this.linkToDatabaseToolStripMenuItem.Name = "linkToDatabaseToolStripMenuItem";
            this.linkToDatabaseToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.linkToDatabaseToolStripMenuItem.Text = "Link to database";
            this.linkToDatabaseToolStripMenuItem.Click += new System.EventHandler(this.linkToDatabaseToolStripMenuItem_Click);
            // 
            // closeDatabaseToolStripMenuItem
            // 
            this.closeDatabaseToolStripMenuItem.Name = "closeDatabaseToolStripMenuItem";
            this.closeDatabaseToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.closeDatabaseToolStripMenuItem.Text = "Close database";
            this.closeDatabaseToolStripMenuItem.Click += new System.EventHandler(this.closeDatabaseToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewRecordToolStripMenuItem,
            this.displayAllRecordsToolStripMenuItem,
            this.updateCustomersToolStripMenuItem,
            this.deleteExistingRecordToolStripMenuItem});
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            // 
            // createNewRecordToolStripMenuItem
            // 
            this.createNewRecordToolStripMenuItem.Name = "createNewRecordToolStripMenuItem";
            this.createNewRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.createNewRecordToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.createNewRecordToolStripMenuItem.Text = "Create new record";
            // 
            // displayAllRecordsToolStripMenuItem
            // 
            this.displayAllRecordsToolStripMenuItem.Name = "displayAllRecordsToolStripMenuItem";
            this.displayAllRecordsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.displayAllRecordsToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.displayAllRecordsToolStripMenuItem.Text = "Display all records";
            // 
            // updateCustomersToolStripMenuItem
            // 
            this.updateCustomersToolStripMenuItem.Name = "updateCustomersToolStripMenuItem";
            this.updateCustomersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateCustomersToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.updateCustomersToolStripMenuItem.Text = "Update customers";
            this.updateCustomersToolStripMenuItem.Click += new System.EventHandler(this.updateCustomersToolStripMenuItem_Click);
            // 
            // deleteExistingRecordToolStripMenuItem
            // 
            this.deleteExistingRecordToolStripMenuItem.Name = "deleteExistingRecordToolStripMenuItem";
            this.deleteExistingRecordToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deleteExistingRecordToolStripMenuItem.Size = new System.Drawing.Size(291, 26);
            this.deleteExistingRecordToolStripMenuItem.Text = "Delete existing record";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 298);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "tom\'s magical database";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolStripMenuItem linkToDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewRecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteExistingRecordToolStripMenuItem;
    }
}

