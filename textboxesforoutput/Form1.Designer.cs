namespace textboxesforoutput
{
    partial class textboxesforoutput
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
            this.txtboxInput = new System.Windows.Forms.TextBox();
            this.btnFormat = new System.Windows.Forms.Button();
            this.txtboxoutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxInput
            // 
            this.txtboxInput.Location = new System.Drawing.Point(425, 28);
            this.txtboxInput.Name = "txtboxInput";
            this.txtboxInput.Size = new System.Drawing.Size(207, 20);
            this.txtboxInput.TabIndex = 0;
            // 
            // btnFormat
            // 
            this.btnFormat.Location = new System.Drawing.Point(453, 93);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(159, 47);
            this.btnFormat.TabIndex = 1;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFormat_MouseClick);
            // 
            // txtboxoutput
            // 
            this.txtboxoutput.Location = new System.Drawing.Point(434, 199);
            this.txtboxoutput.Name = "txtboxoutput";
            this.txtboxoutput.ReadOnly = true;
            this.txtboxoutput.Size = new System.Drawing.Size(206, 20);
            this.txtboxoutput.TabIndex = 2;
            // 
            // textboxesforoutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 591);
            this.Controls.Add(this.txtboxoutput);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.txtboxInput);
            this.Name = "textboxesforoutput";
            this.Text = "Text Boxes For Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxInput;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.TextBox txtboxoutput;
    }
}

