namespace ATM.Forms
{
    partial class frmTransactionComplete
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
            this.lblWelcomeMsg2 = new System.Windows.Forms.Label();
            this.lblEndOfTransaction = new System.Windows.Forms.Label();
            this.lblTransactionIsComplete = new System.Windows.Forms.Label();
            this.lblSeeBalancesQuestion = new System.Windows.Forms.Label();
            this.lblYourBalancesAre = new System.Windows.Forms.Label();
            this.lblAnotherTransaction = new System.Windows.Forms.Label();
            this.lblCheckingBalance = new System.Windows.Forms.Label();
            this.lblSavingsBalance = new System.Windows.Forms.Label();
            this.txtCheckingBal = new System.Windows.Forms.TextBox();
            this.txtSavingsBal = new System.Windows.Forms.TextBox();
            this.btnYesBalance = new System.Windows.Forms.Button();
            this.btnNoNewTransaction = new System.Windows.Forms.Button();
            this.btnYesAnotherTransaction = new System.Windows.Forms.Button();
            this.btnNoBalance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeMsg2
            // 
            this.lblWelcomeMsg2.AutoSize = true;
            this.lblWelcomeMsg2.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcomeMsg2.Location = new System.Drawing.Point(164, 9);
            this.lblWelcomeMsg2.Name = "lblWelcomeMsg2";
            this.lblWelcomeMsg2.Size = new System.Drawing.Size(274, 59);
            this.lblWelcomeMsg2.TabIndex = 10;
            this.lblWelcomeMsg2.Text = "Mikulski Bank";
            // 
            // lblEndOfTransaction
            // 
            this.lblEndOfTransaction.AutoSize = true;
            this.lblEndOfTransaction.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndOfTransaction.Location = new System.Drawing.Point(210, 68);
            this.lblEndOfTransaction.Name = "lblEndOfTransaction";
            this.lblEndOfTransaction.Size = new System.Drawing.Size(173, 24);
            this.lblEndOfTransaction.TabIndex = 9;
            this.lblEndOfTransaction.Text = "End of Transactiom";
            // 
            // lblTransactionIsComplete
            // 
            this.lblTransactionIsComplete.AutoSize = true;
            this.lblTransactionIsComplete.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionIsComplete.Location = new System.Drawing.Point(172, 123);
            this.lblTransactionIsComplete.Name = "lblTransactionIsComplete";
            this.lblTransactionIsComplete.Size = new System.Drawing.Size(259, 24);
            this.lblTransactionIsComplete.TabIndex = 11;
            this.lblTransactionIsComplete.Text = "Your Transaction is Complete!";
            // 
            // lblSeeBalancesQuestion
            // 
            this.lblSeeBalancesQuestion.AutoSize = true;
            this.lblSeeBalancesQuestion.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeBalancesQuestion.Location = new System.Drawing.Point(-2, 208);
            this.lblSeeBalancesQuestion.Name = "lblSeeBalancesQuestion";
            this.lblSeeBalancesQuestion.Size = new System.Drawing.Size(313, 24);
            this.lblSeeBalancesQuestion.TabIndex = 12;
            this.lblSeeBalancesQuestion.Text = "Would you like to see your balances?";
            // 
            // lblYourBalancesAre
            // 
            this.lblYourBalancesAre.AutoSize = true;
            this.lblYourBalancesAre.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYourBalancesAre.Location = new System.Drawing.Point(55, 313);
            this.lblYourBalancesAre.Name = "lblYourBalancesAre";
            this.lblYourBalancesAre.Size = new System.Drawing.Size(238, 24);
            this.lblYourBalancesAre.TabIndex = 13;
            this.lblYourBalancesAre.Text = "Your updated balances are:";
            this.lblYourBalancesAre.Visible = false;
            // 
            // lblAnotherTransaction
            // 
            this.lblAnotherTransaction.AutoSize = true;
            this.lblAnotherTransaction.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnotherTransaction.Location = new System.Drawing.Point(-2, 387);
            this.lblAnotherTransaction.Name = "lblAnotherTransaction";
            this.lblAnotherTransaction.Size = new System.Drawing.Size(314, 24);
            this.lblAnotherTransaction.TabIndex = 14;
            this.lblAnotherTransaction.Text = "Would you like another transaction?";
            this.lblAnotherTransaction.Visible = false;
            // 
            // lblCheckingBalance
            // 
            this.lblCheckingBalance.AutoSize = true;
            this.lblCheckingBalance.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckingBalance.Location = new System.Drawing.Point(325, 279);
            this.lblCheckingBalance.Name = "lblCheckingBalance";
            this.lblCheckingBalance.Size = new System.Drawing.Size(90, 24);
            this.lblCheckingBalance.TabIndex = 15;
            this.lblCheckingBalance.Text = "Checking:";
            this.lblCheckingBalance.Visible = false;
            // 
            // lblSavingsBalance
            // 
            this.lblSavingsBalance.AutoSize = true;
            this.lblSavingsBalance.Font = new System.Drawing.Font("Perpetua", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSavingsBalance.Location = new System.Drawing.Point(479, 279);
            this.lblSavingsBalance.Name = "lblSavingsBalance";
            this.lblSavingsBalance.Size = new System.Drawing.Size(78, 24);
            this.lblSavingsBalance.TabIndex = 16;
            this.lblSavingsBalance.Text = "Savings:";
            this.lblSavingsBalance.Visible = false;
            // 
            // txtCheckingBal
            // 
            this.txtCheckingBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheckingBal.Location = new System.Drawing.Point(320, 313);
            this.txtCheckingBal.Name = "txtCheckingBal";
            this.txtCheckingBal.Size = new System.Drawing.Size(100, 24);
            this.txtCheckingBal.TabIndex = 17;
            this.txtCheckingBal.Visible = false;
            // 
            // txtSavingsBal
            // 
            this.txtSavingsBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSavingsBal.Location = new System.Drawing.Point(468, 313);
            this.txtSavingsBal.Name = "txtSavingsBal";
            this.txtSavingsBal.Size = new System.Drawing.Size(100, 24);
            this.txtSavingsBal.TabIndex = 18;
            this.txtSavingsBal.Visible = false;
            // 
            // btnYesBalance
            // 
            this.btnYesBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnYesBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesBalance.Location = new System.Drawing.Point(334, 204);
            this.btnYesBalance.Name = "btnYesBalance";
            this.btnYesBalance.Size = new System.Drawing.Size(73, 33);
            this.btnYesBalance.TabIndex = 20;
            this.btnYesBalance.Text = "Yes";
            this.btnYesBalance.UseVisualStyleBackColor = false;
            this.btnYesBalance.Click += new System.EventHandler(this.btnYesBalance_Click);
            // 
            // btnNoNewTransaction
            // 
            this.btnNoNewTransaction.BackColor = System.Drawing.Color.Red;
            this.btnNoNewTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoNewTransaction.Location = new System.Drawing.Point(482, 383);
            this.btnNoNewTransaction.Name = "btnNoNewTransaction";
            this.btnNoNewTransaction.Size = new System.Drawing.Size(73, 33);
            this.btnNoNewTransaction.TabIndex = 23;
            this.btnNoNewTransaction.Text = "No";
            this.btnNoNewTransaction.UseVisualStyleBackColor = false;
            this.btnNoNewTransaction.Visible = false;
            this.btnNoNewTransaction.Click += new System.EventHandler(this.btnNoNewTransaction_Click);
            // 
            // btnYesAnotherTransaction
            // 
            this.btnYesAnotherTransaction.BackColor = System.Drawing.Color.Chartreuse;
            this.btnYesAnotherTransaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesAnotherTransaction.Location = new System.Drawing.Point(334, 383);
            this.btnYesAnotherTransaction.Name = "btnYesAnotherTransaction";
            this.btnYesAnotherTransaction.Size = new System.Drawing.Size(73, 33);
            this.btnYesAnotherTransaction.TabIndex = 22;
            this.btnYesAnotherTransaction.Text = "Yes";
            this.btnYesAnotherTransaction.UseVisualStyleBackColor = false;
            this.btnYesAnotherTransaction.Visible = false;
            this.btnYesAnotherTransaction.Click += new System.EventHandler(this.btnYesAnotherTransaction_Click);
            // 
            // btnNoBalance
            // 
            this.btnNoBalance.BackColor = System.Drawing.Color.Transparent;
            this.btnNoBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoBalance.Location = new System.Drawing.Point(482, 204);
            this.btnNoBalance.Name = "btnNoBalance";
            this.btnNoBalance.Size = new System.Drawing.Size(73, 33);
            this.btnNoBalance.TabIndex = 24;
            this.btnNoBalance.Text = "No";
            this.btnNoBalance.UseVisualStyleBackColor = false;
            this.btnNoBalance.Click += new System.EventHandler(this.btnNoBalance_Click);
            // 
            // frmTransactionComplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.btnNoBalance);
            this.Controls.Add(this.btnNoNewTransaction);
            this.Controls.Add(this.btnYesAnotherTransaction);
            this.Controls.Add(this.btnYesBalance);
            this.Controls.Add(this.txtSavingsBal);
            this.Controls.Add(this.txtCheckingBal);
            this.Controls.Add(this.lblSavingsBalance);
            this.Controls.Add(this.lblCheckingBalance);
            this.Controls.Add(this.lblAnotherTransaction);
            this.Controls.Add(this.lblYourBalancesAre);
            this.Controls.Add(this.lblSeeBalancesQuestion);
            this.Controls.Add(this.lblTransactionIsComplete);
            this.Controls.Add(this.lblWelcomeMsg2);
            this.Controls.Add(this.lblEndOfTransaction);
            this.Name = "frmTransactionComplete";
            this.Text = "Transaction Complete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeMsg2;
        private System.Windows.Forms.Label lblEndOfTransaction;
        private System.Windows.Forms.Label lblTransactionIsComplete;
        private System.Windows.Forms.Label lblSeeBalancesQuestion;
        private System.Windows.Forms.Label lblYourBalancesAre;
        private System.Windows.Forms.Label lblAnotherTransaction;
        private System.Windows.Forms.Label lblCheckingBalance;
        private System.Windows.Forms.Label lblSavingsBalance;
        private System.Windows.Forms.TextBox txtCheckingBal;
        private System.Windows.Forms.TextBox txtSavingsBal;
        private System.Windows.Forms.Button btnYesBalance;
        private System.Windows.Forms.Button btnNoNewTransaction;
        private System.Windows.Forms.Button btnYesAnotherTransaction;
        private System.Windows.Forms.Button btnNoBalance;
    }
}