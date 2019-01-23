namespace ATM.Forms
{
    partial class frmAccountLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLookup));
            this.lblWelcomeMsg2 = new System.Windows.Forms.Label();
            this.lblWelcomeMsg1 = new System.Windows.Forms.Label();
            this.picBoxATM = new System.Windows.Forms.PictureBox();
            this.lblDirectionsAcctNum = new System.Windows.Forms.Label();
            this.txtAccountNum = new System.Windows.Forms.TextBox();
            this.btnFindMe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxATM)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeMsg2
            // 
            this.lblWelcomeMsg2.AutoSize = true;
            this.lblWelcomeMsg2.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcomeMsg2.Location = new System.Drawing.Point(61, 113);
            this.lblWelcomeMsg2.Name = "lblWelcomeMsg2";
            this.lblWelcomeMsg2.Size = new System.Drawing.Size(274, 59);
            this.lblWelcomeMsg2.TabIndex = 9;
            this.lblWelcomeMsg2.Text = "Mikulski Bank";
            // 
            // lblWelcomeMsg1
            // 
            this.lblWelcomeMsg1.AutoSize = true;
            this.lblWelcomeMsg1.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg1.ForeColor = System.Drawing.Color.Maroon;
            this.lblWelcomeMsg1.Location = new System.Drawing.Point(112, 42);
            this.lblWelcomeMsg1.Name = "lblWelcomeMsg1";
            this.lblWelcomeMsg1.Size = new System.Drawing.Size(176, 31);
            this.lblWelcomeMsg1.TabIndex = 10;
            this.lblWelcomeMsg1.Text = "Welcome to";
            // 
            // picBoxATM
            // 
            this.picBoxATM.Image = ((System.Drawing.Image)(resources.GetObject("picBoxATM.Image")));
            this.picBoxATM.Location = new System.Drawing.Point(365, 12);
            this.picBoxATM.Name = "picBoxATM";
            this.picBoxATM.Size = new System.Drawing.Size(144, 172);
            this.picBoxATM.TabIndex = 12;
            this.picBoxATM.TabStop = false;
            // 
            // lblDirectionsAcctNum
            // 
            this.lblDirectionsAcctNum.AutoSize = true;
            this.lblDirectionsAcctNum.Font = new System.Drawing.Font("Perpetua", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionsAcctNum.Location = new System.Drawing.Point(12, 231);
            this.lblDirectionsAcctNum.Name = "lblDirectionsAcctNum";
            this.lblDirectionsAcctNum.Size = new System.Drawing.Size(541, 20);
            this.lblDirectionsAcctNum.TabIndex = 13;
            this.lblDirectionsAcctNum.Text = "Enter Your FIVE DIGIT Account Number in the Box below. Then press Find Me";
            // 
            // txtAccountNum
            // 
            this.txtAccountNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNum.Location = new System.Drawing.Point(152, 292);
            this.txtAccountNum.Name = "txtAccountNum";
            this.txtAccountNum.Size = new System.Drawing.Size(100, 29);
            this.txtAccountNum.TabIndex = 14;
            // 
            // btnFindMe
            // 
            this.btnFindMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindMe.Location = new System.Drawing.Point(318, 289);
            this.btnFindMe.Name = "btnFindMe";
            this.btnFindMe.Size = new System.Drawing.Size(95, 37);
            this.btnFindMe.TabIndex = 15;
            this.btnFindMe.Text = "Find Me";
            this.btnFindMe.UseVisualStyleBackColor = true;
            this.btnFindMe.Click += new System.EventHandler(this.btnFindMe_Click);
            // 
            // frmAccountLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(575, 344);
            this.Controls.Add(this.btnFindMe);
            this.Controls.Add(this.txtAccountNum);
            this.Controls.Add(this.lblDirectionsAcctNum);
            this.Controls.Add(this.picBoxATM);
            this.Controls.Add(this.lblWelcomeMsg1);
            this.Controls.Add(this.lblWelcomeMsg2);
            this.Name = "frmAccountLookup";
            this.Text = "Enter Account Number";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxATM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMsg2;
        private System.Windows.Forms.Label lblWelcomeMsg1;
        private System.Windows.Forms.PictureBox picBoxATM;
        private System.Windows.Forms.Label lblDirectionsAcctNum;
        private System.Windows.Forms.TextBox txtAccountNum;
        private System.Windows.Forms.Button btnFindMe;
    }
}