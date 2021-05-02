
namespace GetItDoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStoreInfo = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.txbInfo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(291, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GET IT DONE!";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStoreInfo
            // 
            this.btnStoreInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStoreInfo.Location = new System.Drawing.Point(105, 361);
            this.btnStoreInfo.Name = "btnStoreInfo";
            this.btnStoreInfo.Size = new System.Drawing.Size(75, 23);
            this.btnStoreInfo.TabIndex = 2;
            this.btnStoreInfo.Text = "Store Info";
            this.btnStoreInfo.UseVisualStyleBackColor = false;
            this.btnStoreInfo.Click += new System.EventHandler(this.btnStoreInfo_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnView.Location = new System.Drawing.Point(213, 361);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txbInfo
            // 
            this.txbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txbInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txbInfo.Location = new System.Drawing.Point(81, 44);
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.Size = new System.Drawing.Size(635, 311);
            this.txbInfo.TabIndex = 4;
            this.txbInfo.Text = "TASK TO GET DONE : \r\n\r\n\r\n\r\nDETAILS ABOUT TASK :\r\n\r\n\r\n\r\nPRIORITY LEVEL :\r\n\r\n\r\n\r\nDA" +
    "TE TO COMPLETE BY :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnStoreInfo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStoreInfo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.TextBox txbInfo;
    }
}

