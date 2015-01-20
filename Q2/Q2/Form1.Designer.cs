namespace Q2
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
            this.txtCreditCardNumber = new System.Windows.Forms.TextBox();
            this.lblCreditCardNumber = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblIndustry = new System.Windows.Forms.Label();
            this.lblIssuer = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblValidOrInvalid = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtEncrypted = new System.Windows.Forms.TextBox();
            this.lblEncryptPrompt = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtDecrypted = new System.Windows.Forms.TextBox();
            this.lblDecryptPrompt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCreditCardNumber
            // 
            this.txtCreditCardNumber.Location = new System.Drawing.Point(23, 50);
            this.txtCreditCardNumber.Name = "txtCreditCardNumber";
            this.txtCreditCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtCreditCardNumber.TabIndex = 6;
            // 
            // lblCreditCardNumber
            // 
            this.lblCreditCardNumber.AutoSize = true;
            this.lblCreditCardNumber.Location = new System.Drawing.Point(20, 25);
            this.lblCreditCardNumber.Name = "lblCreditCardNumber";
            this.lblCreditCardNumber.Size = new System.Drawing.Size(252, 13);
            this.lblCreditCardNumber.TabIndex = 1;
            this.lblCreditCardNumber.Text = "Please enter your credit card number for information:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(143, 48);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblIndustry
            // 
            this.lblIndustry.AutoSize = true;
            this.lblIndustry.Location = new System.Drawing.Point(20, 132);
            this.lblIndustry.Name = "lblIndustry";
            this.lblIndustry.Size = new System.Drawing.Size(47, 13);
            this.lblIndustry.TabIndex = 3;
            this.lblIndustry.Text = "Industry:";
            // 
            // lblIssuer
            // 
            this.lblIssuer.AutoSize = true;
            this.lblIssuer.Location = new System.Drawing.Point(20, 163);
            this.lblIssuer.Name = "lblIssuer";
            this.lblIssuer.Size = new System.Drawing.Size(93, 13);
            this.lblIssuer.TabIndex = 4;
            this.lblIssuer.Text = "Credit Card Issuer:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(20, 192);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(90, 13);
            this.lblAccountNumber.TabIndex = 5;
            this.lblAccountNumber.Text = "Account Number:";
            // 
            // lblValidOrInvalid
            // 
            this.lblValidOrInvalid.AutoSize = true;
            this.lblValidOrInvalid.Location = new System.Drawing.Point(20, 87);
            this.lblValidOrInvalid.Name = "lblValidOrInvalid";
            this.lblValidOrInvalid.Size = new System.Drawing.Size(0, 13);
            this.lblValidOrInvalid.TabIndex = 7;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(143, 77);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 8;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtEncrypted
            // 
            this.txtEncrypted.Location = new System.Drawing.Point(23, 252);
            this.txtEncrypted.Name = "txtEncrypted";
            this.txtEncrypted.Size = new System.Drawing.Size(195, 20);
            this.txtEncrypted.TabIndex = 9;
            // 
            // lblEncryptPrompt
            // 
            this.lblEncryptPrompt.AutoSize = true;
            this.lblEncryptPrompt.Location = new System.Drawing.Point(20, 223);
            this.lblEncryptPrompt.Name = "lblEncryptPrompt";
            this.lblEncryptPrompt.Size = new System.Drawing.Size(153, 13);
            this.lblEncryptPrompt.TabIndex = 10;
            this.lblEncryptPrompt.Text = "Encrypted Credit Card Number:";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(235, 252);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 11;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtDecrypted
            // 
            this.txtDecrypted.Location = new System.Drawing.Point(23, 329);
            this.txtDecrypted.Name = "txtDecrypted";
            this.txtDecrypted.Size = new System.Drawing.Size(195, 20);
            this.txtDecrypted.TabIndex = 12;
            // 
            // lblDecryptPrompt
            // 
            this.lblDecryptPrompt.AutoSize = true;
            this.lblDecryptPrompt.Location = new System.Drawing.Point(20, 302);
            this.lblDecryptPrompt.Name = "lblDecryptPrompt";
            this.lblDecryptPrompt.Size = new System.Drawing.Size(154, 13);
            this.lblDecryptPrompt.TabIndex = 13;
            this.lblDecryptPrompt.Text = "Decrypted Credit Card Number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 376);
            this.Controls.Add(this.lblDecryptPrompt);
            this.Controls.Add(this.txtDecrypted);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.lblEncryptPrompt);
            this.Controls.Add(this.txtEncrypted);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblValidOrInvalid);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.lblIssuer);
            this.Controls.Add(this.lblIndustry);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblCreditCardNumber);
            this.Controls.Add(this.txtCreditCardNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCreditCardNumber;
        private System.Windows.Forms.Label lblCreditCardNumber;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblIndustry;
        private System.Windows.Forms.Label lblIssuer;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblValidOrInvalid;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtEncrypted;
        private System.Windows.Forms.Label lblEncryptPrompt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtDecrypted;
        private System.Windows.Forms.Label lblDecryptPrompt;
    }
}

