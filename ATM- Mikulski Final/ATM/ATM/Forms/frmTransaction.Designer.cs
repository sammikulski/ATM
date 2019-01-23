namespace ATM.Forms
{
    partial class frmTransaction
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
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.btnSavingsWithdrawal = new System.Windows.Forms.Button();
            this.btnSavingsBalance = new System.Windows.Forms.Button();
            this.btnTransferSavingsToChecking = new System.Windows.Forms.Button();
            this.btnCheckingDeposit = new System.Windows.Forms.Button();
            this.btnCheckingWithdrawal = new System.Windows.Forms.Button();
            this.btnCheckingBalance = new System.Windows.Forms.Button();
            this.btnTransferCheckingToSavings = new System.Windows.Forms.Button();
            this.lblWelcomeMsg2 = new System.Windows.Forms.Label();
            this.lblTransactionPage = new System.Windows.Forms.Label();
            this.lblSelectATransaction = new System.Windows.Forms.Label();
            this.lblSelectAmount = new System.Windows.Forms.Label();
            this.txtTransactionAmount = new System.Windows.Forms.TextBox();
            this.btnOkAmount = new System.Windows.Forms.Button();
            this.lblYouSelected = new System.Windows.Forms.Label();
            this.txtConfirmAmount = new System.Windows.Forms.TextBox();
            this.btnYesProcess = new System.Windows.Forms.Button();
            this.btnNoSelectAgain = new System.Windows.Forms.Button();
            this.lblCorrectMarked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.Location = new System.Drawing.Point(72, 162);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(156, 23);
            this.btnSavingsDeposit.TabIndex = 0;
            this.btnSavingsDeposit.Text = "Savings Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnSavingsWithdrawal
            // 
            this.btnSavingsWithdrawal.Location = new System.Drawing.Point(72, 207);
            this.btnSavingsWithdrawal.Name = "btnSavingsWithdrawal";
            this.btnSavingsWithdrawal.Size = new System.Drawing.Size(156, 23);
            this.btnSavingsWithdrawal.TabIndex = 1;
            this.btnSavingsWithdrawal.Text = "Savings Withdrawl";
            this.btnSavingsWithdrawal.UseVisualStyleBackColor = true;
            this.btnSavingsWithdrawal.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnSavingsBalance
            // 
            this.btnSavingsBalance.Location = new System.Drawing.Point(72, 252);
            this.btnSavingsBalance.Name = "btnSavingsBalance";
            this.btnSavingsBalance.Size = new System.Drawing.Size(156, 23);
            this.btnSavingsBalance.TabIndex = 2;
            this.btnSavingsBalance.Text = "Savings Balance";
            this.btnSavingsBalance.UseVisualStyleBackColor = true;
            this.btnSavingsBalance.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnTransferSavingsToChecking
            // 
            this.btnTransferSavingsToChecking.Location = new System.Drawing.Point(72, 297);
            this.btnTransferSavingsToChecking.Name = "btnTransferSavingsToChecking";
            this.btnTransferSavingsToChecking.Size = new System.Drawing.Size(156, 23);
            this.btnTransferSavingsToChecking.TabIndex = 3;
            this.btnTransferSavingsToChecking.Text = "Transfer Savings to Checking";
            this.btnTransferSavingsToChecking.UseVisualStyleBackColor = true;
            this.btnTransferSavingsToChecking.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnCheckingDeposit
            // 
            this.btnCheckingDeposit.Location = new System.Drawing.Point(279, 162);
            this.btnCheckingDeposit.Name = "btnCheckingDeposit";
            this.btnCheckingDeposit.Size = new System.Drawing.Size(156, 23);
            this.btnCheckingDeposit.TabIndex = 4;
            this.btnCheckingDeposit.Text = "Checking Deposit";
            this.btnCheckingDeposit.UseVisualStyleBackColor = true;
            this.btnCheckingDeposit.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnCheckingWithdrawal
            // 
            this.btnCheckingWithdrawal.Location = new System.Drawing.Point(279, 207);
            this.btnCheckingWithdrawal.Name = "btnCheckingWithdrawal";
            this.btnCheckingWithdrawal.Size = new System.Drawing.Size(156, 23);
            this.btnCheckingWithdrawal.TabIndex = 5;
            this.btnCheckingWithdrawal.Text = "Checking Withdrawal";
            this.btnCheckingWithdrawal.UseVisualStyleBackColor = true;
            this.btnCheckingWithdrawal.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnCheckingBalance
            // 
            this.btnCheckingBalance.Location = new System.Drawing.Point(279, 252);
            this.btnCheckingBalance.Name = "btnCheckingBalance";
            this.btnCheckingBalance.Size = new System.Drawing.Size(156, 23);
            this.btnCheckingBalance.TabIndex = 6;
            this.btnCheckingBalance.Text = "Checking Balance";
            this.btnCheckingBalance.UseVisualStyleBackColor = true;
            this.btnCheckingBalance.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // btnTransferCheckingToSavings
            // 
            this.btnTransferCheckingToSavings.Location = new System.Drawing.Point(279, 297);
            this.btnTransferCheckingToSavings.Name = "btnTransferCheckingToSavings";
            this.btnTransferCheckingToSavings.Size = new System.Drawing.Size(156, 23);
            this.btnTransferCheckingToSavings.TabIndex = 7;
            this.btnTransferCheckingToSavings.Text = "Transfer Checking to Savings";
            this.btnTransferCheckingToSavings.UseVisualStyleBackColor = true;
            this.btnTransferCheckingToSavings.Click += new System.EventHandler(this.transactionEvent_Click);
            // 
            // lblWelcomeMsg2
            // 
            this.lblWelcomeMsg2.AutoSize = true;
            this.lblWelcomeMsg2.Font = new System.Drawing.Font("Brush Script MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMsg2.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblWelcomeMsg2.Location = new System.Drawing.Point(116, 9);
            this.lblWelcomeMsg2.Name = "lblWelcomeMsg2";
            this.lblWelcomeMsg2.Size = new System.Drawing.Size(274, 59);
            this.lblWelcomeMsg2.TabIndex = 9;
            this.lblWelcomeMsg2.Text = "Mikulski Bank";
            // 
            // lblTransactionPage
            // 
            this.lblTransactionPage.AutoSize = true;
            this.lblTransactionPage.Font = new System.Drawing.Font("Perpetua", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactionPage.Location = new System.Drawing.Point(152, 68);
            this.lblTransactionPage.Name = "lblTransactionPage";
            this.lblTransactionPage.Size = new System.Drawing.Size(202, 31);
            this.lblTransactionPage.TabIndex = 10;
            this.lblTransactionPage.Text = "Transaction Page";
            // 
            // lblSelectATransaction
            // 
            this.lblSelectATransaction.AutoSize = true;
            this.lblSelectATransaction.Font = new System.Drawing.Font("Perpetua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectATransaction.Location = new System.Drawing.Point(170, 129);
            this.lblSelectATransaction.Name = "lblSelectATransaction";
            this.lblSelectATransaction.Size = new System.Drawing.Size(167, 22);
            this.lblSelectATransaction.TabIndex = 11;
            this.lblSelectATransaction.Text = "Select a Transaction...";
            // 
            // lblSelectAmount
            // 
            this.lblSelectAmount.AutoSize = true;
            this.lblSelectAmount.Font = new System.Drawing.Font("Perpetua", 11.5F);
            this.lblSelectAmount.Location = new System.Drawing.Point(12, 369);
            this.lblSelectAmount.Name = "lblSelectAmount";
            this.lblSelectAmount.Size = new System.Drawing.Size(280, 18);
            this.lblSelectAmount.TabIndex = 12;
            this.lblSelectAmount.Text = "Select an Amount in Dollars (No Punctuation)";
            this.lblSelectAmount.Visible = false;
            // 
            // txtTransactionAmount
            // 
            this.txtTransactionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransactionAmount.Location = new System.Drawing.Point(298, 366);
            this.txtTransactionAmount.Name = "txtTransactionAmount";
            this.txtTransactionAmount.Size = new System.Drawing.Size(100, 24);
            this.txtTransactionAmount.TabIndex = 13;
            this.txtTransactionAmount.Visible = false;
            // 
            // btnOkAmount
            // 
            this.btnOkAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkAmount.Location = new System.Drawing.Point(422, 364);
            this.btnOkAmount.Name = "btnOkAmount";
            this.btnOkAmount.Size = new System.Drawing.Size(47, 28);
            this.btnOkAmount.TabIndex = 14;
            this.btnOkAmount.Text = "OK";
            this.btnOkAmount.UseVisualStyleBackColor = true;
            this.btnOkAmount.Visible = false;
            this.btnOkAmount.Click += new System.EventHandler(this.btnOkAmount_Click);
            // 
            // lblYouSelected
            // 
            this.lblYouSelected.AutoSize = true;
            this.lblYouSelected.Font = new System.Drawing.Font("Perpetua", 11.5F);
            this.lblYouSelected.Location = new System.Drawing.Point(26, 434);
            this.lblYouSelected.Name = "lblYouSelected";
            this.lblYouSelected.Size = new System.Drawing.Size(85, 18);
            this.lblYouSelected.TabIndex = 15;
            this.lblYouSelected.Text = "You Selected";
            this.lblYouSelected.Visible = false;
            // 
            // txtConfirmAmount
            // 
            this.txtConfirmAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmAmount.Location = new System.Drawing.Point(125, 431);
            this.txtConfirmAmount.Name = "txtConfirmAmount";
            this.txtConfirmAmount.Size = new System.Drawing.Size(91, 24);
            this.txtConfirmAmount.TabIndex = 16;
            this.txtConfirmAmount.Visible = false;
            // 
            // btnYesProcess
            // 
            this.btnYesProcess.BackColor = System.Drawing.Color.Chartreuse;
            this.btnYesProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYesProcess.Location = new System.Drawing.Point(48, 471);
            this.btnYesProcess.Name = "btnYesProcess";
            this.btnYesProcess.Size = new System.Drawing.Size(180, 33);
            this.btnYesProcess.TabIndex = 17;
            this.btnYesProcess.Text = "Yes - Process Request";
            this.btnYesProcess.UseVisualStyleBackColor = false;
            this.btnYesProcess.Visible = false;
            this.btnYesProcess.Click += new System.EventHandler(this.btnYesProcess_Click);
            // 
            // btnNoSelectAgain
            // 
            this.btnNoSelectAgain.BackColor = System.Drawing.Color.Red;
            this.btnNoSelectAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoSelectAgain.Location = new System.Drawing.Point(279, 471);
            this.btnNoSelectAgain.Name = "btnNoSelectAgain";
            this.btnNoSelectAgain.Size = new System.Drawing.Size(180, 33);
            this.btnNoSelectAgain.TabIndex = 18;
            this.btnNoSelectAgain.Text = "No - Select Again";
            this.btnNoSelectAgain.UseVisualStyleBackColor = false;
            this.btnNoSelectAgain.Visible = false;
            this.btnNoSelectAgain.Click += new System.EventHandler(this.btnNoSelectAgain_Click);
            // 
            // lblCorrectMarked
            // 
            this.lblCorrectMarked.AutoSize = true;
            this.lblCorrectMarked.Font = new System.Drawing.Font("Perpetua", 11.5F);
            this.lblCorrectMarked.Location = new System.Drawing.Point(226, 434);
            this.lblCorrectMarked.Name = "lblCorrectMarked";
            this.lblCorrectMarked.Size = new System.Drawing.Size(279, 18);
            this.lblCorrectMarked.TabIndex = 19;
            this.lblCorrectMarked.Text = "And the Marked Transaction. Is This Correct?";
            this.lblCorrectMarked.Visible = false;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(507, 524);
            this.Controls.Add(this.lblCorrectMarked);
            this.Controls.Add(this.btnNoSelectAgain);
            this.Controls.Add(this.btnYesProcess);
            this.Controls.Add(this.txtConfirmAmount);
            this.Controls.Add(this.lblYouSelected);
            this.Controls.Add(this.btnOkAmount);
            this.Controls.Add(this.txtTransactionAmount);
            this.Controls.Add(this.lblSelectAmount);
            this.Controls.Add(this.lblSelectATransaction);
            this.Controls.Add(this.lblTransactionPage);
            this.Controls.Add(this.lblWelcomeMsg2);
            this.Controls.Add(this.btnTransferCheckingToSavings);
            this.Controls.Add(this.btnCheckingBalance);
            this.Controls.Add(this.btnCheckingWithdrawal);
            this.Controls.Add(this.btnCheckingDeposit);
            this.Controls.Add(this.btnTransferSavingsToChecking);
            this.Controls.Add(this.btnSavingsBalance);
            this.Controls.Add(this.btnSavingsWithdrawal);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Name = "frmTransaction";
            this.Text = "Transaction Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.Button btnSavingsWithdrawal;
        private System.Windows.Forms.Button btnSavingsBalance;
        private System.Windows.Forms.Button btnTransferSavingsToChecking;
        private System.Windows.Forms.Button btnCheckingDeposit;
        private System.Windows.Forms.Button btnCheckingWithdrawal;
        private System.Windows.Forms.Button btnCheckingBalance;
        private System.Windows.Forms.Button btnTransferCheckingToSavings;
        private System.Windows.Forms.Label lblWelcomeMsg2;
        private System.Windows.Forms.Label lblTransactionPage;
        private System.Windows.Forms.Label lblSelectATransaction;
        private System.Windows.Forms.Label lblSelectAmount;
        private System.Windows.Forms.TextBox txtTransactionAmount;
        private System.Windows.Forms.Button btnOkAmount;
        private System.Windows.Forms.Label lblYouSelected;
        private System.Windows.Forms.TextBox txtConfirmAmount;
        private System.Windows.Forms.Button btnYesProcess;
        private System.Windows.Forms.Button btnNoSelectAgain;
        private System.Windows.Forms.Label lblCorrectMarked;
    }
}