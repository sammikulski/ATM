namespace ATM
{
    partial class frmNameAndPin
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
            this.lblNameAndPin = new System.Windows.Forms.Label();
            this.lblDirectionsNameAndPin = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPin = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.btnNamePinOk = new System.Windows.Forms.Button();
            this.lblWelcomeMsg2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameAndPin
            // 
            this.lblNameAndPin.AutoSize = true;
            this.lblNameAndPin.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAndPin.Location = new System.Drawing.Point(203, 65);
            this.lblNameAndPin.Name = "lblNameAndPin";
            this.lblNameAndPin.Size = new System.Drawing.Size(182, 24);
            this.lblNameAndPin.TabIndex = 1;
            this.lblNameAndPin.Text = "Name and Pin Entry";
            // 
            // lblDirectionsNameAndPin
            // 
            this.lblDirectionsNameAndPin.AutoSize = true;
            this.lblDirectionsNameAndPin.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionsNameAndPin.Location = new System.Drawing.Point(92, 132);
            this.lblDirectionsNameAndPin.Name = "lblDirectionsNameAndPin";
            this.lblDirectionsNameAndPin.Size = new System.Drawing.Size(405, 33);
            this.lblDirectionsNameAndPin.TabIndex = 2;
            this.lblDirectionsNameAndPin.Text = "Enter Name and Pin and Press OK...";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(260, 190);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 24);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblPin
            // 
            this.lblPin.AutoSize = true;
            this.lblPin.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.Location = new System.Drawing.Point(121, 240);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(201, 24);
            this.lblPin.TabIndex = 4;
            this.lblPin.Text = "PIN (a 4 Digit Number):";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(327, 186);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(141, 29);
            this.txtName.TabIndex = 5;
            // 
            // txtPin
            // 
            this.txtPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPin.Location = new System.Drawing.Point(327, 236);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(100, 29);
            this.txtPin.TabIndex = 6;
            // 
            // btnNamePinOk
            // 
            this.btnNamePinOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNamePinOk.Location = new System.Drawing.Point(257, 294);
            this.btnNamePinOk.Name = "btnNamePinOk";
            this.btnNamePinOk.Size = new System.Drawing.Size(75, 28);
            this.btnNamePinOk.TabIndex = 7;
            this.btnNamePinOk.Text = "OK";
            this.btnNamePinOk.UseVisualStyleBackColor = true;
            this.btnNamePinOk.Click += new System.EventHandler(this.btnNamePinOk_Click);
            // 
            // lblWelcomeMsg2
            // 
            this.lblWelcomeMsg2.AutoSize = true;
            this.lblWelcomeMsg2.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcomeMsg2.Location = new System.Drawing.Point(157, 6);
            this.lblWelcomeMsg2.Name = "lblWelcomeMsg2";
            this.lblWelcomeMsg2.Size = new System.Drawing.Size(274, 59);
            this.lblWelcomeMsg2.TabIndex = 8;
            this.lblWelcomeMsg2.Text = "Mikulski Bank";
            // 
            // frmNameAndPin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(589, 348);
            this.Controls.Add(this.lblWelcomeMsg2);
            this.Controls.Add(this.btnNamePinOk);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblPin);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDirectionsNameAndPin);
            this.Controls.Add(this.lblNameAndPin);
            this.Name = "frmNameAndPin";
            this.Text = "Name and Pin Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNameAndPin;
        private System.Windows.Forms.Label lblDirectionsNameAndPin;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.Button btnNamePinOk;
        private System.Windows.Forms.Label lblWelcomeMsg2;
    }
}

