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
            this.LabelRowCount = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.TextBoxOpenfile = new System.Windows.Forms.TextBox();
            this.PanelBottom = new System.Windows.Forms.Panel();
            this.PanelResultBottom = new System.Windows.Forms.Panel();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.PanelTop.SuspendLayout();
            this.PanelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // PanelTop
            // 
            this.PanelTop.Controls.Add(this.LabelRowCount);
            this.PanelTop.Controls.Add(this.ButtonStart);
            this.PanelTop.Controls.Add(this.ButtonOpen);
            this.PanelTop.Controls.Add(this.TextBoxOpenfile);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(800, 125);
            this.PanelTop.TabIndex = 0;
            // 
            // LabelRowCount
            // 
            this.LabelRowCount.AutoSize = true;
            this.LabelRowCount.Location = new System.Drawing.Point(31, 68);
            this.LabelRowCount.Name = "LabelRowCount";
            this.LabelRowCount.Size = new System.Drawing.Size(137, 20);
            this.LabelRowCount.TabIndex = 2;
            this.LabelRowCount.Text = "Number of Lines : 0";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(636, 12);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(94, 29);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(527, 12);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(94, 29);
            this.ButtonOpen.TabIndex = 1;
            this.ButtonOpen.Text = "Select";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // TextBoxOpenfile
            // 
            this.TextBoxOpenfile.Location = new System.Drawing.Point(31, 12);
            this.TextBoxOpenfile.Name = "TextBoxOpenfile";
            this.TextBoxOpenfile.Size = new System.Drawing.Size(459, 27);
            this.TextBoxOpenfile.TabIndex = 0;
            // 
            // PanelBottom
            // 
            this.PanelBottom.Controls.Add(this.PanelResultBottom);
            this.PanelBottom.Controls.Add(this.TextBoxResult);
            this.PanelBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBottom.Location = new System.Drawing.Point(0, 125);
            this.PanelBottom.Name = "PanelBottom";
            this.PanelBottom.Size = new System.Drawing.Size(800, 526);
            this.PanelBottom.TabIndex = 0;
            // 
            // PanelResultBottom
            // 
            this.PanelResultBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelResultBottom.Location = new System.Drawing.Point(0, 491);
            this.PanelResultBottom.Name = "PanelResultBottom";
            this.PanelResultBottom.Size = new System.Drawing.Size(800, 35);
            this.PanelResultBottom.TabIndex = 1;
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxResult.Location = new System.Drawing.Point(0, 0);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxResult.Size = new System.Drawing.Size(800, 491);
            this.TextBoxResult.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 651);
            this.Controls.Add(this.PanelBottom);
            this.Controls.Add(this.PanelTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelBottom.ResumeLayout(false);
            this.PanelBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.TextBox TextBoxOpenfile;
        private System.Windows.Forms.Panel PanelBottom;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Panel PanelResultBottom;
        private System.Windows.Forms.Label LabelRowCount;
    }
}

