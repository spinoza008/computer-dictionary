namespace computer_dictionary
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cboHeadword = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSeartWithSeach = new System.Windows.Forms.Button();
            this.btnEndwith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnAnywhere = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbDefinition = new System.Windows.Forms.RichTextBox();
            this.txtHeadword = new System.Windows.Forms.TextBox();
            this.fOLDOCDataSet = new computer_dictionary.FOLDOCDataSet();
            this.fOLDOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOLDOCTableAdapter = new computer_dictionary.FOLDOCDataSetTableAdapters.FOLDOCTableAdapter();
            this.tableAdapterManager = new computer_dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cboHeadword);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbDefinition);
            this.splitContainer1.Panel2.Controls.Add(this.txtHeadword);
            this.splitContainer1.Size = new System.Drawing.Size(922, 514);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 0;
            // 
            // cboHeadword
            // 
            this.cboHeadword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboHeadword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboHeadword.FormattingEnabled = true;
            this.cboHeadword.Location = new System.Drawing.Point(0, 0);
            this.cboHeadword.Name = "cboHeadword";
            this.cboHeadword.Size = new System.Drawing.Size(722, 210);
            this.cboHeadword.TabIndex = 1;
            this.cboHeadword.SelectedIndexChanged += new System.EventHandler(this.cboHeadword_SelectedIndexChanged);
            this.cboHeadword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboHeadword_KeyUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSeartWithSeach);
            this.flowLayoutPanel1.Controls.Add(this.btnEndwith);
            this.flowLayoutPanel1.Controls.Add(this.btnContains);
            this.flowLayoutPanel1.Controls.Add(this.btnAnywhere);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(722, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 210);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSeartWithSeach
            // 
            this.btnSeartWithSeach.Location = new System.Drawing.Point(3, 3);
            this.btnSeartWithSeach.Name = "btnSeartWithSeach";
            this.btnSeartWithSeach.Size = new System.Drawing.Size(184, 38);
            this.btnSeartWithSeach.TabIndex = 1;
            this.btnSeartWithSeach.Text = "*Search";
            this.btnSeartWithSeach.UseVisualStyleBackColor = true;
            this.btnSeartWithSeach.Click += new System.EventHandler(this.btnSeartWithSeach_Click);
            // 
            // btnEndwith
            // 
            this.btnEndwith.Location = new System.Drawing.Point(3, 47);
            this.btnEndwith.Name = "btnEndwith";
            this.btnEndwith.Size = new System.Drawing.Size(184, 41);
            this.btnEndwith.TabIndex = 0;
            this.btnEndwith.Text = "*EndWith";
            this.btnEndwith.UseVisualStyleBackColor = true;
            this.btnEndwith.Click += new System.EventHandler(this.btnEndwith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(3, 94);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(184, 43);
            this.btnContains.TabIndex = 2;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnAnywhere
            // 
            this.btnAnywhere.Location = new System.Drawing.Point(3, 143);
            this.btnAnywhere.Name = "btnAnywhere";
            this.btnAnywhere.Size = new System.Drawing.Size(184, 36);
            this.btnAnywhere.TabIndex = 3;
            this.btnAnywhere.Text = "Anywhere Search";
            this.btnAnywhere.UseVisualStyleBackColor = true;
            this.btnAnywhere.Click += new System.EventHandler(this.btnAnywhere_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastNameToolStripMenuItem,
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.doneToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lastNameToolStripMenuItem
            // 
            this.lastNameToolStripMenuItem.Name = "lastNameToolStripMenuItem";
            this.lastNameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.lastNameToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.doneToolStripMenuItem.Text = "Done";
            this.doneToolStripMenuItem.Click += new System.EventHandler(this.doneToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // rtbDefinition
            // 
            this.rtbDefinition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Definition", true));
            this.rtbDefinition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDefinition.Location = new System.Drawing.Point(0, 20);
            this.rtbDefinition.Name = "rtbDefinition";
            this.rtbDefinition.Size = new System.Drawing.Size(922, 280);
            this.rtbDefinition.TabIndex = 0;
            this.rtbDefinition.Text = "";
            // 
            // txtHeadword
            // 
            this.txtHeadword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fOLDOCBindingSource, "Headword", true));
            this.txtHeadword.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHeadword.Location = new System.Drawing.Point(0, 0);
            this.txtHeadword.Name = "txtHeadword";
            this.txtHeadword.Size = new System.Drawing.Size(922, 20);
            this.txtHeadword.TabIndex = 1;
            // 
            // fOLDOCDataSet
            // 
            this.fOLDOCDataSet.DataSetName = "FOLDOCDataSet";
            this.fOLDOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fOLDOCBindingSource
            // 
            this.fOLDOCBindingSource.DataMember = "FOLDOC";
            this.fOLDOCBindingSource.DataSource = this.fOLDOCDataSet;
            // 
            // fOLDOCTableAdapter
            // 
            this.fOLDOCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FOLDOCTableAdapter = this.fOLDOCTableAdapter;
            this.tableAdapterManager.UpdateOrder = computer_dictionary.FOLDOCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 538);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOLDOCBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSeartWithSeach;
        private System.Windows.Forms.Button btnEndwith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnAnywhere;
        private System.Windows.Forms.ComboBox cboHeadword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.TextBox txtHeadword;
        private System.Windows.Forms.RichTextBox rtbDefinition;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private FOLDOCDataSet fOLDOCDataSet;
        private System.Windows.Forms.BindingSource fOLDOCBindingSource;
        private FOLDOCDataSetTableAdapters.FOLDOCTableAdapter fOLDOCTableAdapter;
        private FOLDOCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

