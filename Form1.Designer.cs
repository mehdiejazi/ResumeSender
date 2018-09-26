namespace ResumeSender
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
            this.lstTo = new System.Windows.Forms.ListBox();
            this.btnTo = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAttachments = new System.Windows.Forms.ListBox();
            this.btnAttachments = new System.Windows.Forms.Button();
            this.myProgressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.myBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBody = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 14;
            this.lstTo.Location = new System.Drawing.Point(17, 210);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(196, 186);
            this.lstTo.TabIndex = 5;
            // 
            // btnTo
            // 
            this.btnTo.Location = new System.Drawing.Point(17, 402);
            this.btnTo.Name = "btnTo";
            this.btnTo.Size = new System.Drawing.Size(87, 25);
            this.btnTo.TabIndex = 4;
            this.btnTo.Text = "To(s)";
            this.btnTo.UseVisualStyleBackColor = true;
            this.btnTo.Click += new System.EventHandler(this.btnTo_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(511, 402);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(87, 25);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(76, 66);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(521, 22);
            this.txtSubject.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Subject";
            // 
            // lstAttachments
            // 
            this.lstAttachments.FormattingEnabled = true;
            this.lstAttachments.ItemHeight = 14;
            this.lstAttachments.Location = new System.Drawing.Point(222, 210);
            this.lstAttachments.Name = "lstAttachments";
            this.lstAttachments.Size = new System.Drawing.Size(376, 186);
            this.lstAttachments.TabIndex = 7;
            // 
            // btnAttachments
            // 
            this.btnAttachments.Location = new System.Drawing.Point(222, 402);
            this.btnAttachments.Name = "btnAttachments";
            this.btnAttachments.Size = new System.Drawing.Size(100, 25);
            this.btnAttachments.TabIndex = 6;
            this.btnAttachments.Text = "Attachment(s)";
            this.btnAttachments.UseVisualStyleBackColor = true;
            this.btnAttachments.Click += new System.EventHandler(this.btnAttachments_Click);
            // 
            // myProgressBar
            // 
            this.myProgressBar.Location = new System.Drawing.Point(14, 433);
            this.myProgressBar.Name = "myProgressBar";
            this.myProgressBar.Size = new System.Drawing.Size(525, 25);
            this.myProgressBar.TabIndex = 9;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(547, 437);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(26, 14);
            this.lblProgress.TabIndex = 8;
            this.lblProgress.Text = "0/0";
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "openFileDialog1";
            // 
            // myBackgroundWorker
            // 
            this.myBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.myBackgroundWorker_DoWork);
            this.myBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.myBackgroundWorker_ProgressChanged);
            this.myBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.myBackgroundWorker_RunWorkerCompleted);
            // 
            // myTimer
            // 
            this.myTimer.Enabled = true;
            this.myTimer.Interval = 1000;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(14, 94);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(34, 14);
            this.lblBody.TabIndex = 9;
            this.lblBody.Text = "Body";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(17, 111);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(580, 93);
            this.txtBody.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(521, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Mehdi Ejazi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(521, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.myProgressBar);
            this.Controls.Add(this.btnAttachments);
            this.Controls.Add(this.lstAttachments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnTo);
            this.Controls.Add(this.lstTo);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTo;
        private System.Windows.Forms.Button btnTo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAttachments;
        private System.Windows.Forms.Button btnAttachments;
        private System.Windows.Forms.ProgressBar myProgressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.ComponentModel.BackgroundWorker myBackgroundWorker;
        private System.Windows.Forms.Timer myTimer;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
    }
}

