namespace MiniPOS
{
    partial class MainForm
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
            this.buttonTable1 = new System.Windows.Forms.Button();
            this.buttonTable2 = new System.Windows.Forms.Button();
            this.buttonTable3 = new System.Windows.Forms.Button();
            this.buttonTable4 = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTable1
            // 
            this.buttonTable1.Location = new System.Drawing.Point(12, 12);
            this.buttonTable1.Name = "buttonTable1";
            this.buttonTable1.Size = new System.Drawing.Size(160, 128);
            this.buttonTable1.TabIndex = 0;
            this.buttonTable1.Text = "Table #1";
            this.buttonTable1.UseVisualStyleBackColor = true;
            this.buttonTable1.Click += new System.EventHandler(this.ButtonTable1_Click);
            // 
            // buttonTable2
            // 
            this.buttonTable2.Location = new System.Drawing.Point(178, 12);
            this.buttonTable2.Name = "buttonTable2";
            this.buttonTable2.Size = new System.Drawing.Size(160, 128);
            this.buttonTable2.TabIndex = 0;
            this.buttonTable2.Text = "Table #2";
            this.buttonTable2.UseVisualStyleBackColor = true;
            this.buttonTable2.Click += new System.EventHandler(this.ButtonTable2_Click);
            // 
            // buttonTable3
            // 
            this.buttonTable3.Location = new System.Drawing.Point(12, 146);
            this.buttonTable3.Name = "buttonTable3";
            this.buttonTable3.Size = new System.Drawing.Size(160, 128);
            this.buttonTable3.TabIndex = 0;
            this.buttonTable3.Text = "Table #3";
            this.buttonTable3.UseVisualStyleBackColor = true;
            this.buttonTable3.Click += new System.EventHandler(this.ButtonTable3_Click);
            // 
            // buttonTable4
            // 
            this.buttonTable4.Location = new System.Drawing.Point(178, 146);
            this.buttonTable4.Name = "buttonTable4";
            this.buttonTable4.Size = new System.Drawing.Size(160, 128);
            this.buttonTable4.TabIndex = 0;
            this.buttonTable4.Text = "Table #4";
            this.buttonTable4.UseVisualStyleBackColor = true;
            this.buttonTable4.Click += new System.EventHandler(this.ButtonTable4_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(263, 281);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "닫기";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 315);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonTable4);
            this.Controls.Add(this.buttonTable3);
            this.Controls.Add(this.buttonTable2);
            this.Controls.Add(this.buttonTable1);
            this.Name = "MainForm";
            this.Text = "MiniPOS";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTable1;
        private System.Windows.Forms.Button buttonTable2;
        private System.Windows.Forms.Button buttonTable3;
        private System.Windows.Forms.Button buttonTable4;
        private System.Windows.Forms.Button buttonClose;
    }
}

