namespace LendingNotesTools
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.GroupBoxNoteLoads = new System.Windows.Forms.GroupBox();
            this.LabelRowCount = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.TextBoxOpenfile = new System.Windows.Forms.TextBox();
            this.PanelMiddle = new System.Windows.Forms.Panel();
            this.DataGridViewNotes = new System.Windows.Forms.DataGridView();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.DataGridViewBottom = new System.Windows.Forms.DataGridView();
            this.PanelTop.SuspendLayout();
            this.GroupBoxNoteLoads.SuspendLayout();
            this.PanelMiddle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNotes)).BeginInit();
            this.PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.GroupBoxNoteLoads);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1436, 54);
            this.PanelTop.TabIndex = 0;
            // 
            // GroupBoxNoteLoads
            // 
            this.GroupBoxNoteLoads.Controls.Add(this.LabelRowCount);
            this.GroupBoxNoteLoads.Controls.Add(this.ButtonStart);
            this.GroupBoxNoteLoads.Controls.Add(this.ButtonOpen);
            this.GroupBoxNoteLoads.Controls.Add(this.TextBoxOpenfile);
            this.GroupBoxNoteLoads.Dock = System.Windows.Forms.DockStyle.Left;
            this.GroupBoxNoteLoads.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxNoteLoads.Name = "GroupBoxNoteLoads";
            this.GroupBoxNoteLoads.Size = new System.Drawing.Size(934, 54);
            this.GroupBoxNoteLoads.TabIndex = 3;
            this.GroupBoxNoteLoads.TabStop = false;
            this.GroupBoxNoteLoads.Text = "File Control";
            // 
            // LabelRowCount
            // 
            this.LabelRowCount.AutoSize = true;
            this.LabelRowCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.LabelRowCount.Location = new System.Drawing.Point(794, 23);
            this.LabelRowCount.Name = "LabelRowCount";
            this.LabelRowCount.Size = new System.Drawing.Size(137, 20);
            this.LabelRowCount.TabIndex = 2;
            this.LabelRowCount.Text = "Number of Lines : 0";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonStart.Location = new System.Drawing.Point(556, 23);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(94, 28);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonOpen.Location = new System.Drawing.Point(462, 23);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(94, 28);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Select";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // TextBoxOpenfile
            // 
            this.TextBoxOpenfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.TextBoxOpenfile.Location = new System.Drawing.Point(3, 23);
            this.TextBoxOpenfile.Margin = new System.Windows.Forms.Padding(1);
            this.TextBoxOpenfile.Name = "TextBoxOpenfile";
            this.TextBoxOpenfile.Size = new System.Drawing.Size(459, 27);
            this.TextBoxOpenfile.TabIndex = 0;
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.Controls.Add(this.DataGridViewNotes);
            this.PanelMiddle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMiddle.Location = new System.Drawing.Point(0, 54);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(1436, 588);
            this.PanelMiddle.TabIndex = 1;
            // 
            // DataGridViewNotes
            // 
            this.DataGridViewNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewNotes.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewNotes.Name = "DataGridViewNotes";
            this.DataGridViewNotes.RowHeadersWidth = 30;
            this.DataGridViewNotes.RowTemplate.Height = 29;
            this.DataGridViewNotes.Size = new System.Drawing.Size(1436, 588);
            this.DataGridViewNotes.TabIndex = 0;
            this.DataGridViewNotes.Visible = false;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.DataGridViewBottom);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBottom.Location = new System.Drawing.Point(0, 642);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(1436, 145);
            this.PanelBottom.TabIndex = 2;
            // 
            // DataGridViewBottom
            // 
            this.DataGridViewBottom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridViewBottom.Location = new System.Drawing.Point(0, 0);
            this.DataGridViewBottom.Name = "DataGridViewBottom";
            this.DataGridViewBottom.RowHeadersWidth = 51;
            this.DataGridViewBottom.RowTemplate.Height = 29;
            this.DataGridViewBottom.Size = new System.Drawing.Size(1436, 145);
            this.DataGridViewBottom.TabIndex = 0;
            this.DataGridViewBottom.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 753);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelMiddle);
            this.Controls.Add(this.PanelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelTop.ResumeLayout(false);
            this.GroupBoxNoteLoads.ResumeLayout(false);
            this.GroupBoxNoteLoads.PerformLayout();
            this.PanelMiddle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewNotes)).EndInit();
            this.PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.TextBox TextBoxOpenfile;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label LabelRowCount;
        private System.Windows.Forms.Panel PanelMiddle;
        private System.Windows.Forms.DataGridView DataGridViewNotes;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.DataGridView DataGridViewBottom;
        private System.Windows.Forms.GroupBox GroupBoxNoteLoads;
    }
}

