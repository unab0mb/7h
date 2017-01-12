/*
  This source is subject to the Microsoft Public License. See LICENSE.TXT for details.
  The original developer is Iros <irosff@outlook.com>
*/

namespace Iros._7th.Workshop {
    partial class fSettings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.bOK = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bLibrary = new System.Windows.Forms.Button();
            this.txtLibrary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clOptions = new System.Windows.Forms.CheckedListBox();
            this.txtFF7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bFF7 = new System.Windows.Forms.Button();
            this.txtAali = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bAali = new System.Windows.Forms.Button();
            this.txtAlsoLaunch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofExe = new System.Windows.Forms.OpenFileDialog();
            this.flBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSubscriptions = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMovie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bMovie = new System.Windows.Forms.Button();
            this.txtExtraFolders = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bOK);
            this.panel1.Controls.Add(this.bCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 629);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 96);
            this.panel1.TabIndex = 0;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(1264, 25);
            this.bOK.Margin = new System.Windows.Forms.Padding(6);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(150, 44);
            this.bOK.TabIndex = 1;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(1426, 25);
            this.bCancel.Margin = new System.Windows.Forms.Padding(6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(150, 44);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bLibrary
            // 
            this.bLibrary.Location = new System.Drawing.Point(720, 12);
            this.bLibrary.Margin = new System.Windows.Forms.Padding(6);
            this.bLibrary.Name = "bLibrary";
            this.bLibrary.Size = new System.Drawing.Size(52, 38);
            this.bLibrary.TabIndex = 3;
            this.bLibrary.Text = "...";
            this.bLibrary.UseVisualStyleBackColor = true;
            this.bLibrary.Click += new System.EventHandler(this.bLibrary_Click);
            // 
            // txtLibrary
            // 
            this.txtLibrary.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLibrary.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtLibrary.Location = new System.Drawing.Point(206, 12);
            this.txtLibrary.Margin = new System.Windows.Forms.Padding(6);
            this.txtLibrary.Name = "txtLibrary";
            this.txtLibrary.Size = new System.Drawing.Size(488, 31);
            this.txtLibrary.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Library Location:";
            // 
            // clOptions
            // 
            this.clOptions.FormattingEnabled = true;
            this.clOptions.Items.AddRange(new object[] {
            "Keep old mod versions after updating",
            "Automatically activate new mods",
            "Automatically import mods in library folder",
            "Check for updates to 7thHeaven automatically",
            "Bypass compatibility"});
            this.clOptions.Location = new System.Drawing.Point(206, 219);
            this.clOptions.Margin = new System.Windows.Forms.Padding(6);
            this.clOptions.Name = "clOptions";
            this.clOptions.Size = new System.Drawing.Size(566, 160);
            this.clOptions.TabIndex = 6;
            // 
            // txtFF7
            // 
            this.txtFF7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFF7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtFF7.Location = new System.Drawing.Point(206, 62);
            this.txtFF7.Margin = new System.Windows.Forms.Padding(6);
            this.txtFF7.Name = "txtFF7";
            this.txtFF7.Size = new System.Drawing.Size(488, 31);
            this.txtFF7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "FF7 Exe:";
            // 
            // bFF7
            // 
            this.bFF7.Location = new System.Drawing.Point(720, 62);
            this.bFF7.Margin = new System.Windows.Forms.Padding(6);
            this.bFF7.Name = "bFF7";
            this.bFF7.Size = new System.Drawing.Size(52, 38);
            this.bFF7.TabIndex = 7;
            this.bFF7.Text = "...";
            this.bFF7.UseVisualStyleBackColor = true;
            this.bFF7.Click += new System.EventHandler(this.bFF7_Click);
            // 
            // txtAali
            // 
            this.txtAali.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAali.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtAali.Location = new System.Drawing.Point(206, 112);
            this.txtAali.Margin = new System.Windows.Forms.Padding(6);
            this.txtAali.Name = "txtAali";
            this.txtAali.Size = new System.Drawing.Size(488, 31);
            this.txtAali.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Aali Modpath:";
            // 
            // bAali
            // 
            this.bAali.Location = new System.Drawing.Point(720, 112);
            this.bAali.Margin = new System.Windows.Forms.Padding(6);
            this.bAali.Name = "bAali";
            this.bAali.Size = new System.Drawing.Size(52, 38);
            this.bAali.TabIndex = 10;
            this.bAali.Text = "...";
            this.bAali.UseVisualStyleBackColor = true;
            this.bAali.Click += new System.EventHandler(this.bAali_Click);
            // 
            // txtAlsoLaunch
            // 
            this.txtAlsoLaunch.AcceptsReturn = true;
            this.txtAlsoLaunch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtAlsoLaunch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtAlsoLaunch.Location = new System.Drawing.Point(1016, 435);
            this.txtAlsoLaunch.Margin = new System.Windows.Forms.Padding(6);
            this.txtAlsoLaunch.Multiline = true;
            this.txtAlsoLaunch.Name = "txtAlsoLaunch";
            this.txtAlsoLaunch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAlsoLaunch.Size = new System.Drawing.Size(560, 170);
            this.txtAlsoLaunch.TabIndex = 15;
            this.txtAlsoLaunch.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(843, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Also Launch:";
            // 
            // ofExe
            // 
            this.ofExe.Filter = "Executable files|*.exe;*.bat";
            // 
            // txtSubscriptions
            // 
            this.txtSubscriptions.AcceptsReturn = true;
            this.txtSubscriptions.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSubscriptions.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtSubscriptions.Location = new System.Drawing.Point(1016, 12);
            this.txtSubscriptions.Margin = new System.Windows.Forms.Padding(6);
            this.txtSubscriptions.Multiline = true;
            this.txtSubscriptions.Name = "txtSubscriptions";
            this.txtSubscriptions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSubscriptions.Size = new System.Drawing.Size(562, 195);
            this.txtSubscriptions.TabIndex = 17;
            this.txtSubscriptions.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(832, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Subscriptions:";
            // 
            // txtMovie
            // 
            this.txtMovie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMovie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories;
            this.txtMovie.Location = new System.Drawing.Point(206, 163);
            this.txtMovie.Margin = new System.Windows.Forms.Padding(6);
            this.txtMovie.Name = "txtMovie";
            this.txtMovie.Size = new System.Drawing.Size(488, 31);
            this.txtMovie.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Movie Path:";
            // 
            // bMovie
            // 
            this.bMovie.Location = new System.Drawing.Point(720, 163);
            this.bMovie.Margin = new System.Windows.Forms.Padding(6);
            this.bMovie.Name = "bMovie";
            this.bMovie.Size = new System.Drawing.Size(52, 38);
            this.bMovie.TabIndex = 18;
            this.bMovie.Text = "...";
            this.bMovie.UseVisualStyleBackColor = true;
            this.bMovie.Click += new System.EventHandler(this.bMovie_Click);
            // 
            // txtExtraFolders
            // 
            this.txtExtraFolders.AcceptsReturn = true;
            this.txtExtraFolders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtExtraFolders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txtExtraFolders.Location = new System.Drawing.Point(1016, 219);
            this.txtExtraFolders.Margin = new System.Windows.Forms.Padding(6);
            this.txtExtraFolders.Multiline = true;
            this.txtExtraFolders.Name = "txtExtraFolders";
            this.txtExtraFolders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtExtraFolders.Size = new System.Drawing.Size(562, 204);
            this.txtExtraFolders.TabIndex = 22;
            this.txtExtraFolders.WordWrap = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(834, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Extra Folders:";
            // 
            // fSettings
            // 
            this.AcceptButton = this.bOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1600, 725);
            this.Controls.Add(this.txtExtraFolders);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMovie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bMovie);
            this.Controls.Add(this.txtSubscriptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAlsoLaunch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAali);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAali);
            this.Controls.Add(this.txtFF7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bFF7);
            this.Controls.Add(this.clOptions);
            this.Controls.Add(this.txtLibrary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bLibrary);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.fSettings_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bLibrary;
        private System.Windows.Forms.TextBox txtLibrary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clOptions;
        private System.Windows.Forms.TextBox txtFF7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bFF7;
        private System.Windows.Forms.TextBox txtAali;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAali;
        private System.Windows.Forms.TextBox txtAlsoLaunch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofExe;
        private System.Windows.Forms.FolderBrowserDialog flBrowser;
        private System.Windows.Forms.TextBox txtSubscriptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMovie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bMovie;
        private System.Windows.Forms.TextBox txtExtraFolders;
        private System.Windows.Forms.Label label7;
    }
}