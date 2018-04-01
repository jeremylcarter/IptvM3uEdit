namespace IptvM3uEdit.WinUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnParse = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParsedContent = new System.Windows.Forms.TextBox();
            this.lblLines = new System.Windows.Forms.Label();
            this.lblGroups = new System.Windows.Forms.Label();
            this.checkedListBoxGroups = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chkOutputSelected = new System.Windows.Forms.CheckBox();
            this.chkAdjustUSACA = new System.Windows.Forms.CheckBox();
            this.chkPrefixGroupToName = new System.Windows.Forms.CheckBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.txtGroupPrefixes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtExport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnParse
            // 
            this.btnParse.Location = new System.Drawing.Point(437, 26);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(75, 23);
            this.btnParse.TabIndex = 0;
            this.btnParse.Text = "Parse file";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.btnParse_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(111, 28);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(320, 20);
            this.txtFile.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File location";
            // 
            // txtParsedContent
            // 
            this.txtParsedContent.Location = new System.Drawing.Point(12, 91);
            this.txtParsedContent.Multiline = true;
            this.txtParsedContent.Name = "txtParsedContent";
            this.txtParsedContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParsedContent.Size = new System.Drawing.Size(518, 367);
            this.txtParsedContent.TabIndex = 3;
            // 
            // lblLines
            // 
            this.lblLines.AutoSize = true;
            this.lblLines.Location = new System.Drawing.Point(12, 75);
            this.lblLines.Name = "lblLines";
            this.lblLines.Size = new System.Drawing.Size(64, 13);
            this.lblLines.TabIndex = 4;
            this.lblLines.Text = "Parsed lines";
            // 
            // lblGroups
            // 
            this.lblGroups.AutoSize = true;
            this.lblGroups.Location = new System.Drawing.Point(533, 75);
            this.lblGroups.Name = "lblGroups";
            this.lblGroups.Size = new System.Drawing.Size(75, 13);
            this.lblGroups.TabIndex = 6;
            this.lblGroups.Text = "Parsed groups";
            // 
            // checkedListBoxGroups
            // 
            this.checkedListBoxGroups.FormattingEnabled = true;
            this.checkedListBoxGroups.Location = new System.Drawing.Point(536, 91);
            this.checkedListBoxGroups.Name = "checkedListBoxGroups";
            this.checkedListBoxGroups.Size = new System.Drawing.Size(252, 364);
            this.checkedListBoxGroups.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(680, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sel all";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(731, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Unsel all";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chkOutputSelected
            // 
            this.chkOutputSelected.AutoSize = true;
            this.chkOutputSelected.Checked = true;
            this.chkOutputSelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutputSelected.Location = new System.Drawing.Point(13, 465);
            this.chkOutputSelected.Name = "chkOutputSelected";
            this.chkOutputSelected.Size = new System.Drawing.Size(158, 17);
            this.chkOutputSelected.TabIndex = 10;
            this.chkOutputSelected.Text = "Only output selected groups";
            this.chkOutputSelected.UseVisualStyleBackColor = true;
            // 
            // chkAdjustUSACA
            // 
            this.chkAdjustUSACA.AutoSize = true;
            this.chkAdjustUSACA.Checked = true;
            this.chkAdjustUSACA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdjustUSACA.Location = new System.Drawing.Point(177, 465);
            this.chkAdjustUSACA.Name = "chkAdjustUSACA";
            this.chkAdjustUSACA.Size = new System.Drawing.Size(194, 17);
            this.chkAdjustUSACA.TabIndex = 11;
            this.chkAdjustUSACA.Text = "Change Tvg-ID US/CA -> USA#CA";
            this.chkAdjustUSACA.UseVisualStyleBackColor = true;
            // 
            // chkPrefixGroupToName
            // 
            this.chkPrefixGroupToName.AutoSize = true;
            this.chkPrefixGroupToName.Checked = true;
            this.chkPrefixGroupToName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrefixGroupToName.Location = new System.Drawing.Point(370, 464);
            this.chkPrefixGroupToName.Name = "chkPrefixGroupToName";
            this.chkPrefixGroupToName.Size = new System.Drawing.Size(142, 17);
            this.chkPrefixGroupToName.TabIndex = 12;
            this.chkPrefixGroupToName.Text = "Prefix group title to name";
            this.chkPrefixGroupToName.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(712, 465);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // txtGroupPrefixes
            // 
            this.txtGroupPrefixes.Location = new System.Drawing.Point(96, 488);
            this.txtGroupPrefixes.Name = "txtGroupPrefixes";
            this.txtGroupPrefixes.Size = new System.Drawing.Size(434, 20);
            this.txtGroupPrefixes.TabIndex = 14;
            this.txtGroupPrefixes.Text = "24/7, UK, USA/CA, US/CA, CA French";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Group prefixes:";
            // 
            // txtExport
            // 
            this.txtExport.Location = new System.Drawing.Point(15, 514);
            this.txtExport.Multiline = true;
            this.txtExport.Name = "txtExport";
            this.txtExport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtExport.Size = new System.Drawing.Size(773, 158);
            this.txtExport.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.Controls.Add(this.txtExport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGroupPrefixes);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.chkPrefixGroupToName);
            this.Controls.Add(this.chkAdjustUSACA);
            this.Controls.Add(this.chkOutputSelected);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxGroups);
            this.Controls.Add(this.lblGroups);
            this.Controls.Add(this.lblLines);
            this.Controls.Add(this.txtParsedContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnParse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParsedContent;
        private System.Windows.Forms.Label lblLines;
        private System.Windows.Forms.Label lblGroups;
        private System.Windows.Forms.CheckedListBox checkedListBoxGroups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkOutputSelected;
        private System.Windows.Forms.CheckBox chkAdjustUSACA;
        private System.Windows.Forms.CheckBox chkPrefixGroupToName;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TextBox txtGroupPrefixes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExport;
    }
}

