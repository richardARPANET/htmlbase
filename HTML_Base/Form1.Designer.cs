namespace HTML_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lstOutput = new System.Windows.Forms.ListBox();
            this.checkJquery = new System.Windows.Forms.CheckBox();
            this.checkJqueryUi = new System.Windows.Forms.CheckBox();
            this.checkModernizr = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.OliveDrab;
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.ForeColor = System.Drawing.Color.White;
            this.btnSelect.Location = new System.Drawing.Point(12, 12);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(126, 28);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select folder";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBuild.FlatAppearance.BorderSize = 0;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.ForeColor = System.Drawing.Color.White;
            this.btnBuild.Location = new System.Drawing.Point(144, 12);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(128, 28);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Build";
            this.btnBuild.UseVisualStyleBackColor = false;
            this.btnBuild.Visible = false;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.Location = new System.Drawing.Point(12, 46);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(260, 43);
            this.lstOutput.TabIndex = 2;
            // 
            // checkJquery
            // 
            this.checkJquery.AutoSize = true;
            this.checkJquery.Checked = true;
            this.checkJquery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkJquery.Location = new System.Drawing.Point(12, 96);
            this.checkJquery.Name = "checkJquery";
            this.checkJquery.Size = new System.Drawing.Size(54, 17);
            this.checkJquery.TabIndex = 3;
            this.checkJquery.Text = "jquery";
            this.checkJquery.UseVisualStyleBackColor = true;
            this.checkJquery.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkJqueryUi
            // 
            this.checkJqueryUi.AutoSize = true;
            this.checkJqueryUi.Checked = true;
            this.checkJqueryUi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkJqueryUi.Location = new System.Drawing.Point(100, 96);
            this.checkJqueryUi.Name = "checkJqueryUi";
            this.checkJqueryUi.Size = new System.Drawing.Size(65, 17);
            this.checkJqueryUi.TabIndex = 4;
            this.checkJqueryUi.Text = "jquery ui";
            this.checkJqueryUi.UseVisualStyleBackColor = true;
            // 
            // checkModernizr
            // 
            this.checkModernizr.AutoSize = true;
            this.checkModernizr.Checked = true;
            this.checkModernizr.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkModernizr.Location = new System.Drawing.Point(201, 96);
            this.checkModernizr.Name = "checkModernizr";
            this.checkModernizr.Size = new System.Drawing.Size(71, 17);
            this.checkModernizr.TabIndex = 5;
            this.checkModernizr.Text = "modernizr";
            this.checkModernizr.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 119);
            this.Controls.Add(this.checkModernizr);
            this.Controls.Add(this.checkJqueryUi);
            this.Controls.Add(this.checkJquery);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnSelect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTML Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox lstOutput;
        private System.Windows.Forms.CheckBox checkJquery;
        private System.Windows.Forms.CheckBox checkJqueryUi;
        private System.Windows.Forms.CheckBox checkModernizr;
    }
}

