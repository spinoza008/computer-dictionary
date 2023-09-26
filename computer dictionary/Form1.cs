using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace computer_dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // a variable whose values is set to true if a new record is being genereated. it is used to determine how to repond to user clicking of the cancek menu item.
        bool isNew;
        private void ComboBoxShowAll()
        {
            cboHeadword.DataBindings.Clear();
            var query = from word in fOLDOCDataSet.FOLDOC.AsEnumerable()
                        orderby word.Headword
                        select word;
            cboHeadword.DisplayMember = "Headword";
            cboHeadword.ValueMember = "Key";
            cboHeadword.DataSource = query.ToList();
        }
        private void EditingMode()
        {
            splitContainer1.Panel1Collapsed = true;
            doneToolStripMenuItem.Enabled = false;
            newToolStripMenuItem.Enabled = false;
            editToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Visible = false;
            doneToolStripMenuItem.Visible = true;
            cancelToolStripMenuItem.Visible = true;
            txtHeadword.TabStop = true;
            rtbDefinition.TabStop = true;
            txtHeadword.ReadOnly = false;
            rtbDefinition.ReadOnly = false;
            txtHeadword.Focus();
        }
        private void SearchingMode()
        {
            splitContainer1.Panel1Collapsed = false;
            doneToolStripMenuItem.Enabled = true;
            newToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = true;
            deleteToolStripMenuItem.Visible = true;
            doneToolStripMenuItem.Visible = false;
            cancelToolStripMenuItem.Visible = false;
            txtHeadword.TabStop = false;
            rtbDefinition.TabStop = false;
            txtHeadword.ReadOnly = true;
            rtbDefinition.ReadOnly = true;
            isNew = false;
            ComboBoxShowAll();
            cboHeadword.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fOLDOCDataSet.FOLDOC' table. You can move, or remove it, as needed.
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
            this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
            ComboBoxShowAll();
        }

        private void cboHeadword_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHeadword.SelectedValue!=null)
            {
                try
                {
                    int index = fOLDOCBindingSource.Find("Key", cboHeadword.SelectedValue);
                    fOLDOCBindingSource.Position = index;
                }
                catch (Exception x)
                {
                    MessageBox.Show(x.Message);
                }
            }
        }

        private void btnSeartWithSeach_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
                if (cboHeadword.Text.Trim().Length > 0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                            where word.Headword.ToUpper().StartsWith(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word;
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "Key";
                cboHeadword.DataSource = query.ToList();
            }
            else
                ComboBoxShowAll();
        }

        private void cboHeadword_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSeartWithSeach.PerformClick();
        }

        private void btnEndwith_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
            if(cboHeadword.Text.Trim().Length>0)
            {
                var query= from word in fOLDOCDataSet.FOLDOC
                           where word.Headword.ToUpper().EndsWith(cboHeadword.Text.ToUpper())
                           orderby word.Headword
                            select word;
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "Key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            cboHeadword.DataBindings.Clear();
            if (cboHeadword.Text.Trim().Length>0)
            {
                var query= from word in fOLDOCDataSet.FOLDOC
                           where word.Headword.ToUpper().Contains(cboHeadword.Text.ToUpper())
                            orderby word.Headword
                            select word;
                cboHeadword.DisplayMember = "Headword";
              cboHeadword.ValueMember = "Key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void btnAnywhere_Click(object sender, EventArgs e)
        {
            if (cboHeadword.Text.Trim().Length>0)
            {
                var query = from word in fOLDOCDataSet.FOLDOC
                    where word.Headword.ToUpper().Contains(cboHeadword.Text.ToUpper())||
                     word.Definition.ToUpper().Contains(cboHeadword.Text.ToUpper())
                     orderby word.Headword
                    select word;
                cboHeadword.DisplayMember = "Headword";
                cboHeadword.ValueMember = "Key";
                cboHeadword.DataSource = query.ToList();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = true;
            cboHeadword.DataBindings.Clear();
            fOLDOCBindingSource.AddNew();
            EditingMode();
        }


        private void newToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            isNew = true;
            cboHeadword.DataBindings.Clear();
            fOLDOCBindingSource.AddNew();
            EditingMode();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isNew = false;
                int currentPosition = fOLDOCBindingSource.Position;
            cboHeadword.DataBindings.Clear();
            fOLDOCBindingSource.Position = currentPosition;
            EditingMode();

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentPosition = fOLDOCBindingSource.Position;
            if (currentPosition > -1)
            {
                string currentHeadword = cboHeadword.Text;
                DialogResult = MessageBox.Show("Do you really want to delete" + currentHeadword + "?", "confirm deletetion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.Yes)
                {
                    try
                    {
                        fOLDOCBindingSource.RemoveCurrent();
                        fOLDOCBindingSource.EndEdit();
                        fOLDOCTableAdapter.Update(fOLDOCDataSet.FOLDOC);
                        this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
                        ComboBoxShowAll();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(currentHeadword + @"not removed." + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show(currentHeadword + "not removed.Operation cancelled by user");
                }
            }
        }
                private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                fOLDOCBindingSource.RemoveCurrent();

            }
            SearchingMode();
            ComboBoxShowAll();
        }

        private void doneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtHeadword.Text.Trim().Length == 0 || rtbDefinition.Text.Trim().Length == 0)
            {
                MessageBox.Show(@"Headword and/or Defination not entered yet.", "Missing information reminder");
            }
            else
            {
                this.Validate();
                this.fOLDOCBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.fOLDOCDataSet);
                if (isNew)
                    this.fOLDOCTableAdapter.Fill(this.fOLDOCDataSet.FOLDOC);
                SearchingMode();
                ComboBoxShowAll();
            }

       }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
