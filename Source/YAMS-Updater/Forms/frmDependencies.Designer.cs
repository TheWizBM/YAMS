﻿namespace YAMS_Updater
{
    partial class frmDependencies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDependencies));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJDKDownload = new System.Windows.Forms.Button();
            this.btnJREDownload = new System.Windows.Forms.Button();
            this.lblJDK = new System.Windows.Forms.Label();
            this.lblJRE = new System.Windows.Forms.Label();
            this.icoJDK = new System.Windows.Forms.PictureBox();
            this.icoJRE = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timCheckUpdate = new System.Windows.Forms.Timer(this.components);
            this.btnComplete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMCClientSystem = new System.Windows.Forms.Label();
            this.lblMCClientLocal = new System.Windows.Forms.Label();
            this.btnCopyClient = new System.Windows.Forms.Button();
            this.btnDownloadClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.icoMCInSystem = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.icoMCInstalled = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoJDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoJRE)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoMCInSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMCInstalled)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnJDKDownload);
            this.groupBox1.Controls.Add(this.btnJREDownload);
            this.groupBox1.Controls.Add(this.lblJDK);
            this.groupBox1.Controls.Add(this.lblJRE);
            this.groupBox1.Controls.Add(this.icoJDK);
            this.groupBox1.Controls.Add(this.icoJRE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Java";
            // 
            // btnJDKDownload
            // 
            this.btnJDKDownload.Location = new System.Drawing.Point(578, 89);
            this.btnJDKDownload.Name = "btnJDKDownload";
            this.btnJDKDownload.Size = new System.Drawing.Size(95, 23);
            this.btnJDKDownload.TabIndex = 7;
            this.btnJDKDownload.Text = "Download JDK";
            this.btnJDKDownload.UseVisualStyleBackColor = true;
            this.btnJDKDownload.Visible = false;
            // 
            // btnJREDownload
            // 
            this.btnJREDownload.Location = new System.Drawing.Point(578, 15);
            this.btnJREDownload.Name = "btnJREDownload";
            this.btnJREDownload.Size = new System.Drawing.Size(95, 23);
            this.btnJREDownload.TabIndex = 6;
            this.btnJREDownload.Text = "Download JRE";
            this.btnJREDownload.UseMnemonic = false;
            this.btnJREDownload.UseVisualStyleBackColor = true;
            this.btnJREDownload.Visible = false;
            // 
            // lblJDK
            // 
            this.lblJDK.AutoSize = true;
            this.lblJDK.Location = new System.Drawing.Point(7, 126);
            this.lblJDK.Name = "lblJDK";
            this.lblJDK.Size = new System.Drawing.Size(13, 13);
            this.lblJDK.TabIndex = 5;
            this.lblJDK.Text = "2";
            // 
            // lblJRE
            // 
            this.lblJRE.AutoSize = true;
            this.lblJRE.Location = new System.Drawing.Point(7, 45);
            this.lblJRE.Name = "lblJRE";
            this.lblJRE.Size = new System.Drawing.Size(13, 13);
            this.lblJRE.TabIndex = 4;
            this.lblJRE.Text = "1";
            // 
            // icoJDK
            // 
            this.icoJDK.Image = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoJDK.InitialImage = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoJDK.Location = new System.Drawing.Point(206, 89);
            this.icoJDK.Name = "icoJDK";
            this.icoJDK.Size = new System.Drawing.Size(16, 16);
            this.icoJDK.TabIndex = 3;
            this.icoJDK.TabStop = false;
            // 
            // icoJRE
            // 
            this.icoJRE.Image = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoJRE.InitialImage = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoJRE.Location = new System.Drawing.Point(206, 15);
            this.icoJRE.Name = "icoJRE";
            this.icoJRE.Size = new System.Drawing.Size(16, 16);
            this.icoJRE.TabIndex = 2;
            this.icoJRE.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Java Development Kit (JDK)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Java Runtime Environment (JRE)";
            // 
            // timCheckUpdate
            // 
            this.timCheckUpdate.Enabled = true;
            this.timCheckUpdate.Interval = 10000;
            // 
            // btnComplete
            // 
            this.btnComplete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnComplete.Location = new System.Drawing.Point(572, 353);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(119, 26);
            this.btnComplete.TabIndex = 5;
            this.btnComplete.Text = "Continue Setup";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMCClientSystem);
            this.groupBox2.Controls.Add(this.lblMCClientLocal);
            this.groupBox2.Controls.Add(this.btnCopyClient);
            this.groupBox2.Controls.Add(this.btnDownloadClient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.icoMCInSystem);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.icoMCInstalled);
            this.groupBox2.Location = new System.Drawing.Point(12, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(679, 156);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minecraft Client";
            // 
            // lblMCClientSystem
            // 
            this.lblMCClientSystem.AutoSize = true;
            this.lblMCClientSystem.Location = new System.Drawing.Point(7, 118);
            this.lblMCClientSystem.Name = "lblMCClientSystem";
            this.lblMCClientSystem.Size = new System.Drawing.Size(13, 13);
            this.lblMCClientSystem.TabIndex = 14;
            this.lblMCClientSystem.Text = "2";
            // 
            // lblMCClientLocal
            // 
            this.lblMCClientLocal.AutoSize = true;
            this.lblMCClientLocal.Location = new System.Drawing.Point(7, 49);
            this.lblMCClientLocal.Name = "lblMCClientLocal";
            this.lblMCClientLocal.Size = new System.Drawing.Size(13, 13);
            this.lblMCClientLocal.TabIndex = 13;
            this.lblMCClientLocal.Text = "1";
            // 
            // btnCopyClient
            // 
            this.btnCopyClient.Location = new System.Drawing.Point(578, 85);
            this.btnCopyClient.Name = "btnCopyClient";
            this.btnCopyClient.Size = new System.Drawing.Size(95, 23);
            this.btnCopyClient.TabIndex = 12;
            this.btnCopyClient.Text = "Copy Client";
            this.btnCopyClient.UseMnemonic = false;
            this.btnCopyClient.UseVisualStyleBackColor = true;
            this.btnCopyClient.Visible = false;
            this.btnCopyClient.Click += new System.EventHandler(this.btnCopyClient_Click);
            // 
            // btnDownloadClient
            // 
            this.btnDownloadClient.Location = new System.Drawing.Point(578, 25);
            this.btnDownloadClient.Name = "btnDownloadClient";
            this.btnDownloadClient.Size = new System.Drawing.Size(95, 23);
            this.btnDownloadClient.TabIndex = 11;
            this.btnDownloadClient.Text = "Download Client";
            this.btnDownloadClient.UseMnemonic = false;
            this.btnDownloadClient.UseVisualStyleBackColor = true;
            this.btnDownloadClient.Visible = false;
            this.btnDownloadClient.Click += new System.EventHandler(this.btnDownloadClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Client installed in system profile";
            // 
            // icoMCInSystem
            // 
            this.icoMCInSystem.Image = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoMCInSystem.InitialImage = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoMCInSystem.Location = new System.Drawing.Point(206, 92);
            this.icoMCInSystem.Name = "icoMCInSystem";
            this.icoMCInSystem.Size = new System.Drawing.Size(16, 16);
            this.icoMCInSystem.TabIndex = 9;
            this.icoMCInSystem.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Client installed in your user";
            // 
            // icoMCInstalled
            // 
            this.icoMCInstalled.Image = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoMCInstalled.InitialImage = global::YAMS_Updater.Properties.Resources.cancel;
            this.icoMCInstalled.Location = new System.Drawing.Point(206, 25);
            this.icoMCInstalled.Name = "icoMCInstalled";
            this.icoMCInstalled.Size = new System.Drawing.Size(16, 16);
            this.icoMCInstalled.TabIndex = 4;
            this.icoMCInstalled.TabStop = false;
            // 
            // frmDependencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 391);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnComplete);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDependencies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prerequisites";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoJDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoJRE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icoMCInSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icoMCInstalled)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJDKDownload;
        private System.Windows.Forms.Button btnJREDownload;
        private System.Windows.Forms.Label lblJDK;
        private System.Windows.Forms.Label lblJRE;
        private System.Windows.Forms.PictureBox icoJDK;
        private System.Windows.Forms.PictureBox icoJRE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timCheckUpdate;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox icoMCInSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox icoMCInstalled;
        private System.Windows.Forms.Button btnCopyClient;
        private System.Windows.Forms.Button btnDownloadClient;
        private System.Windows.Forms.Label lblMCClientSystem;
        private System.Windows.Forms.Label lblMCClientLocal;

    }
}