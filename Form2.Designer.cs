namespace C__Level2
{
    partial class Form2
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
            this.btnSendDataBack = new System.Windows.Forms.Button();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSendDataBack
            // 
            this.btnSendDataBack.Location = new System.Drawing.Point(502, 97);
            this.btnSendDataBack.Name = "btnSendDataBack";
            this.btnSendDataBack.Size = new System.Drawing.Size(147, 50);
            this.btnSendDataBack.TabIndex = 0;
            this.btnSendDataBack.Text = "Send data back";
            this.btnSendDataBack.UseVisualStyleBackColor = true;
            this.btnSendDataBack.Click += new System.EventHandler(this.btnSendDataBack_Click);
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(277, 111);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(141, 22);
            this.txtPersonID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.Location = new System.Drawing.Point(165, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "PersonID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.btnSendDataBack);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendDataBack;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label1;
    }
}