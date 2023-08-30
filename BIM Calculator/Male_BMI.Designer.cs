namespace BIM_Calculator
{
    partial class Male_BMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Male_BMI));
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.lbl_Height = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.btn_calculateBMI = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.txt_height = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_BMI = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_BMI_value = new System.Windows.Forms.Label();
            this.lbl_status_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(264, 62);
            this.lbl_Weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(65, 20);
            this.lbl_Weight.TabIndex = 0;
            this.lbl_Weight.Text = "Weight";
            // 
            // lbl_Height
            // 
            this.lbl_Height.AutoSize = true;
            this.lbl_Height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Height.Location = new System.Drawing.Point(264, 102);
            this.lbl_Height.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Height.Name = "lbl_Height";
            this.lbl_Height.Size = new System.Drawing.Size(62, 20);
            this.lbl_Height.TabIndex = 0;
            this.lbl_Height.Text = "Height";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_age.Location = new System.Drawing.Point(264, 143);
            this.lbl_age.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(41, 20);
            this.lbl_age.TabIndex = 0;
            this.lbl_age.Text = "Age";
            // 
            // btn_calculateBMI
            // 
            this.btn_calculateBMI.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_calculateBMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculateBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calculateBMI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_calculateBMI.Location = new System.Drawing.Point(294, 221);
            this.btn_calculateBMI.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_calculateBMI.Name = "btn_calculateBMI";
            this.btn_calculateBMI.Size = new System.Drawing.Size(219, 47);
            this.btn_calculateBMI.TabIndex = 1;
            this.btn_calculateBMI.Text = "Calculate BMI";
            this.btn_calculateBMI.UseVisualStyleBackColor = false;
            this.btn_calculateBMI.Click += new System.EventHandler(this.btn_calculateBMI_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Location = new System.Drawing.Point(571, 227);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(93, 35);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_weight
            // 
            this.txt_weight.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weight.Location = new System.Drawing.Point(397, 56);
            this.txt_weight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(116, 26);
            this.txt_weight.TabIndex = 2;
            // 
            // txt_height
            // 
            this.txt_height.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_height.Location = new System.Drawing.Point(397, 96);
            this.txt_height.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_height.Name = "txt_height";
            this.txt_height.Size = new System.Drawing.Size(116, 26);
            this.txt_height.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.Location = new System.Drawing.Point(397, 137);
            this.txt_age.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(116, 26);
            this.txt_age.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(136, 227);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(93, 35);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_BMI
            // 
            this.lbl_BMI.AutoSize = true;
            this.lbl_BMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BMI.Location = new System.Drawing.Point(222, 317);
            this.lbl_BMI.Name = "lbl_BMI";
            this.lbl_BMI.Size = new System.Drawing.Size(37, 18);
            this.lbl_BMI.TabIndex = 4;
            this.lbl_BMI.Text = "BMI";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(222, 377);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(56, 18);
            this.lbl_status.TabIndex = 4;
            this.lbl_status.Text = "Status";
            // 
            // lbl_BMI_value
            // 
            this.lbl_BMI_value.AutoSize = true;
            this.lbl_BMI_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BMI_value.Location = new System.Drawing.Point(353, 317);
            this.lbl_BMI_value.Name = "lbl_BMI_value";
            this.lbl_BMI_value.Size = new System.Drawing.Size(0, 18);
            this.lbl_BMI_value.TabIndex = 5;
            // 
            // lbl_status_value
            // 
            this.lbl_status_value.AutoSize = true;
            this.lbl_status_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status_value.Location = new System.Drawing.Point(353, 378);
            this.lbl_status_value.Name = "lbl_status_value";
            this.lbl_status_value.Size = new System.Drawing.Size(0, 18);
            this.lbl_status_value.TabIndex = 5;
            // 
            // Male_BMI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_status_value);
            this.Controls.Add(this.lbl_BMI_value);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_BMI);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_height);
            this.Controls.Add(this.txt_weight);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_calculateBMI);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_Height);
            this.Controls.Add(this.lbl_Weight);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Male_BMI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.Label lbl_Height;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Button btn_calculateBMI;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.TextBox txt_height;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_BMI;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_BMI_value;
        private System.Windows.Forms.Label lbl_status_value;
    }
}