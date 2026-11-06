namespace C__Level2
{
    partial class frmTest2
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
            this.ctrlCalculator1 = new C__Level2.ctrlCalculator();
            this.SuspendLayout();
            // 
            // ctrlCalculator1
            // 
            this.ctrlCalculator1.Location = new System.Drawing.Point(27, 51);
            this.ctrlCalculator1.Name = "ctrlCalculator1";
            this.ctrlCalculator1.Size = new System.Drawing.Size(694, 279);
            this.ctrlCalculator1.TabIndex = 0;
            this.ctrlCalculator1.OnCalculationCompleted += new System.EventHandler<C__Level2.ctrlCalculator.CalculationCompleteEventArgs>(this.ctrlCalculator1_OnCalculationCompleted_1);
            // 
            // frmTest2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 529);
            this.Controls.Add(this.ctrlCalculator1);
            this.Name = "frmTest2";
            this.Text = "frmTest2";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlCalculator ctrlCalculator1;
    }
}