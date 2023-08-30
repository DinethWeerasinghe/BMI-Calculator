namespace BIM_Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_male = new System.Windows.Forms.Button();
            this.btn_female = new System.Windows.Forms.Button();
            this.lbl_bmiCalculator = new System.Windows.Forms.Label();
            this.lbl_help = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_male
            // 
            this.btn_male.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_male.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_male.Location = new System.Drawing.Point(307, 172);
            this.btn_male.Name = "btn_male";
            this.btn_male.Size = new System.Drawing.Size(150, 50);
            this.btn_male.TabIndex = 0;
            this.btn_male.Text = "Male";
            this.btn_male.UseVisualStyleBackColor = false;
            this.btn_male.Click += new System.EventHandler(this.btn_male_Click);
            // 
            // btn_female
            // 
            this.btn_female.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_female.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_female.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_female.Location = new System.Drawing.Point(307, 267);
            this.btn_female.Name = "btn_female";
            this.btn_female.Size = new System.Drawing.Size(150, 50);
            this.btn_female.TabIndex = 0;
            this.btn_female.Text = "Female";
            this.btn_female.UseVisualStyleBackColor = false;
            this.btn_female.Click += new System.EventHandler(this.btn_female_Click);
            // 
            // lbl_bmiCalculator
            // 
            this.lbl_bmiCalculator.AutoSize = true;
            this.lbl_bmiCalculator.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bmiCalculator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_bmiCalculator.Location = new System.Drawing.Point(207, 70);
            this.lbl_bmiCalculator.Name = "lbl_bmiCalculator";
            this.lbl_bmiCalculator.Size = new System.Drawing.Size(341, 46);
            this.lbl_bmiCalculator.TabIndex = 1;
            this.lbl_bmiCalculator.Text = "BMI Calculator";
            // 
            // lbl_help
            // 
            this.lbl_help.AutoSize = true;
            this.lbl_help.Location = new System.Drawing.Point(29, 409);
            this.lbl_help.Name = "lbl_help";
            this.lbl_help.Size = new System.Drawing.Size(29, 13);
            this.lbl_help.TabIndex = 2;
            this.lbl_help.Text = "Help";
            this.lbl_help.Click += new System.EventHandler(this.lbl_help_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_help);
            this.Controls.Add(this.lbl_bmiCalculator);
            this.Controls.Add(this.btn_female);
            this.Controls.Add(this.btn_male);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_male;
        private System.Windows.Forms.Button btn_female;
        private System.Windows.Forms.Label lbl_bmiCalculator;
        private System.Windows.Forms.Label lbl_help;
    }
}

