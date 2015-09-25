namespace NetflixChecker
{
    partial class frmMain
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
            this.webNetflix = new System.Windows.Forms.WebBrowser();
            this.btnCheckAccount = new System.Windows.Forms.Button();
            this.lblThing = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblWorking = new System.Windows.Forms.Label();
            this.txtWorkingAccounts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webNetflix
            // 
            this.webNetflix.Location = new System.Drawing.Point(12, 140);
            this.webNetflix.MinimumSize = new System.Drawing.Size(20, 20);
            this.webNetflix.Name = "webNetflix";
            this.webNetflix.Size = new System.Drawing.Size(920, 417);
            this.webNetflix.TabIndex = 0;
            this.webNetflix.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webNetflix_DocumentCompleted);
            // 
            // btnCheckAccount
            // 
            this.btnCheckAccount.Location = new System.Drawing.Point(145, 85);
            this.btnCheckAccount.Name = "btnCheckAccount";
            this.btnCheckAccount.Size = new System.Drawing.Size(267, 39);
            this.btnCheckAccount.TabIndex = 5;
            this.btnCheckAccount.Text = "Check Accounts";
            this.btnCheckAccount.UseVisualStyleBackColor = true;
            this.btnCheckAccount.Click += new System.EventHandler(this.btnCheckAccount_Click);
            // 
            // lblThing
            // 
            this.lblThing.AutoSize = true;
            this.lblThing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThing.Location = new System.Drawing.Point(788, 36);
            this.lblThing.Name = "lblThing";
            this.lblThing.Size = new System.Drawing.Size(67, 24);
            this.lblThing.TabIndex = 6;
            this.lblThing.Text = "Result:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(870, 36);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 20);
            this.lblResult.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(122, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(413, 20);
            this.txtFileName.TabIndex = 8;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(11, 23);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 23);
            this.btnOpen.TabIndex = 9;
            this.btnOpen.Text = "Open Text File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblWorking
            // 
            this.lblWorking.AutoSize = true;
            this.lblWorking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorking.Location = new System.Drawing.Point(969, 108);
            this.lblWorking.Name = "lblWorking";
            this.lblWorking.Size = new System.Drawing.Size(140, 16);
            this.lblWorking.TabIndex = 10;
            this.lblWorking.Text = "Working Accounts: 0/0";
            // 
            // txtWorkingAccounts
            // 
            this.txtWorkingAccounts.Location = new System.Drawing.Point(963, 140);
            this.txtWorkingAccounts.Multiline = true;
            this.txtWorkingAccounts.Name = "txtWorkingAccounts";
            this.txtWorkingAccounts.Size = new System.Drawing.Size(277, 417);
            this.txtWorkingAccounts.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "By Discordian (nulled.io) 2015";
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(841, 573);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(91, 23);
            this.btnDebug.TabIndex = 13;
            this.btnDebug.Text = "Debug Logout";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 603);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtWorkingAccounts);
            this.Controls.Add(this.lblWorking);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblThing);
            this.Controls.Add(this.btnCheckAccount);
            this.Controls.Add(this.webNetflix);
            this.Name = "frmMain";
            this.Text = "Discordian\'s Awesome Netflix Checker";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webNetflix;
        private System.Windows.Forms.Button btnCheckAccount;
        private System.Windows.Forms.Label lblThing;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblWorking;
        private System.Windows.Forms.TextBox txtWorkingAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebug;
    }
}

