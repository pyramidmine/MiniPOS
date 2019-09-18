namespace MiniPOS
{
    partial class PayForm
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
            this.groupBoxPaymentType = new System.Windows.Forms.GroupBox();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonCreditCard = new System.Windows.Forms.RadioButton();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxPaymentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPaymentType
            // 
            this.groupBoxPaymentType.Controls.Add(this.radioButtonCash);
            this.groupBoxPaymentType.Controls.Add(this.radioButtonCreditCard);
            this.groupBoxPaymentType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPaymentType.Name = "groupBoxPaymentType";
            this.groupBoxPaymentType.Size = new System.Drawing.Size(175, 72);
            this.groupBoxPaymentType.TabIndex = 0;
            this.groupBoxPaymentType.TabStop = false;
            this.groupBoxPaymentType.Text = "결제 방식";
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(6, 42);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCash.TabIndex = 1;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "현금";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // radioButtonCreditCard
            // 
            this.radioButtonCreditCard.AutoSize = true;
            this.radioButtonCreditCard.Location = new System.Drawing.Point(6, 20);
            this.radioButtonCreditCard.Name = "radioButtonCreditCard";
            this.radioButtonCreditCard.Size = new System.Drawing.Size(71, 16);
            this.radioButtonCreditCard.TabIndex = 0;
            this.radioButtonCreditCard.TabStop = true;
            this.radioButtonCreditCard.Text = "신용카드";
            this.radioButtonCreditCard.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(31, 103);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 1;
            this.buttonOK.Text = "결제";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(112, 103);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "취소";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 138);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBoxPaymentType);
            this.Name = "PayForm";
            this.Text = "Pay";
            this.groupBoxPaymentType.ResumeLayout(false);
            this.groupBoxPaymentType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPaymentType;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.RadioButton radioButtonCreditCard;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}