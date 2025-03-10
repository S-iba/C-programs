namespace P1T2
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.cmbChoice = new System.Windows.Forms.ComboBox();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.ForeColor = System.Drawing.Color.IndianRed;
            this.lblRadius.Location = new System.Drawing.Point(81, 33);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(86, 13);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Enter raius (cm): ";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(176, 228);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // cmbChoice
            // 
            this.cmbChoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbChoice.FormattingEnabled = true;
            this.cmbChoice.Items.AddRange(new object[] {
            "Circumference",
            "Area of a circle",
            "Area of a sphere"});
            this.cmbChoice.Location = new System.Drawing.Point(84, 106);
            this.cmbChoice.Name = "cmbChoice";
            this.cmbChoice.Size = new System.Drawing.Size(192, 21);
            this.cmbChoice.TabIndex = 3;
            this.cmbChoice.Text = "Select what to calculate";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(176, 26);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 20);
            this.txtRadius.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblAnswer.Location = new System.Drawing.Point(173, 175);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(32, 18);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "???";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 297);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.cmbChoice);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblRadius);
            this.Name = "Form1";
            this.Text = "P1T2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cmbChoice;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblAnswer;
    }
}

