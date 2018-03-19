namespace RestClientForm
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
            this.txtRestURI = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.cmdReceive = new System.Windows.Forms.Button();
            this.labelRequestURI = new System.Windows.Forms.Label();
            this.labelResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRestURI
            // 
            this.txtRestURI.Location = new System.Drawing.Point(112, 31);
            this.txtRestURI.Name = "txtRestURI";
            this.txtRestURI.Size = new System.Drawing.Size(289, 20);
            this.txtRestURI.TabIndex = 0;
            // 
            // txtResponse
            // 
            this.txtResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResponse.Location = new System.Drawing.Point(112, 57);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(389, 297);
            this.txtResponse.TabIndex = 1;
            // 
            // cmdReceive
            // 
            this.cmdReceive.Location = new System.Drawing.Point(426, 28);
            this.cmdReceive.Name = "cmdReceive";
            this.cmdReceive.Size = new System.Drawing.Size(75, 23);
            this.cmdReceive.TabIndex = 2;
            this.cmdReceive.Text = "Receive";
            this.cmdReceive.UseVisualStyleBackColor = true;
            this.cmdReceive.Click += new System.EventHandler(this.cmdReceive_Click);
            // 
            // labelRequestURI
            // 
            this.labelRequestURI.AutoSize = true;
            this.labelRequestURI.Location = new System.Drawing.Point(12, 38);
            this.labelRequestURI.Name = "labelRequestURI";
            this.labelRequestURI.Size = new System.Drawing.Size(84, 13);
            this.labelRequestURI.TabIndex = 3;
            this.labelRequestURI.Text = "Requested URI:";
            // 
            // labelResponse
            // 
            this.labelResponse.AutoSize = true;
            this.labelResponse.Location = new System.Drawing.Point(12, 60);
            this.labelResponse.Name = "labelResponse";
            this.labelResponse.Size = new System.Drawing.Size(58, 13);
            this.labelResponse.TabIndex = 3;
            this.labelResponse.Text = "Response:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 383);
            this.Controls.Add(this.labelResponse);
            this.Controls.Add(this.labelRequestURI);
            this.Controls.Add(this.cmdReceive);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURI);
            this.Name = "Form1";
            this.Text = "Rest Client Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURI;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Button cmdReceive;
        private System.Windows.Forms.Label labelRequestURI;
        private System.Windows.Forms.Label labelResponse;
    }
}

