namespace TreatEnumsFlags
{
    partial class form1
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
            this.myControl1 = new TreatEnumsFlags.MyControl();
            this.SuspendLayout();
            // 
            // myControl1
            // 
            this.myControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.myControl1.Location = new System.Drawing.Point(181, 79);
            //this.myControl1.MyFlagsYay = TreatEnumsFlags.MyControl.MyFlags.None;
            this.myControl1.Name = "myControl1";
            this.myControl1.Size = new System.Drawing.Size(101, 92);
            this.myControl1.TabIndex = 0;
            this.myControl1.Text = "myControl1";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 334);
            this.Controls.Add(this.myControl1);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private MyControl myControl1;
    }
}

