namespace HashAttack
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.lblString1 = new System.Windows.Forms.Label();
            this.lblString2 = new System.Windows.Forms.Label();
            this.lblHashOut = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(41, 34);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(141, 20);
            this.tbInput.TabIndex = 0;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(222, 34);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(111, 20);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Collide!";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // lblString1
            // 
            this.lblString1.AutoSize = true;
            this.lblString1.Location = new System.Drawing.Point(38, 106);
            this.lblString1.Name = "lblString1";
            this.lblString1.Size = new System.Drawing.Size(40, 13);
            this.lblString1.TabIndex = 2;
            this.lblString1.Text = "String1";
            // 
            // lblString2
            // 
            this.lblString2.AutoSize = true;
            this.lblString2.Location = new System.Drawing.Point(38, 178);
            this.lblString2.Name = "lblString2";
            this.lblString2.Size = new System.Drawing.Size(40, 13);
            this.lblString2.TabIndex = 3;
            this.lblString2.Text = "String2";
            // 
            // lblHashOut
            // 
            this.lblHashOut.AutoSize = true;
            this.lblHashOut.Location = new System.Drawing.Point(38, 260);
            this.lblHashOut.Name = "lblHashOut";
            this.lblHashOut.Size = new System.Drawing.Size(74, 13);
            this.lblHashOut.TabIndex = 4;
            this.lblHashOut.Text = "Colliding Hash";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(38, 343);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 13);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "Time Taken";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 523);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblHashOut);
            this.Controls.Add(this.lblString2);
            this.Controls.Add(this.lblString1);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tbInput);
            this.Name = "Form1";
            this.Text = "Hash Attack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Label lblString1;
        private System.Windows.Forms.Label lblString2;
        private System.Windows.Forms.Label lblHashOut;
        private System.Windows.Forms.Label lblTime;
    }
}

