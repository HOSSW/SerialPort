namespace WindowsFormsApp1
{
    partial class BodyMotherboard
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
            this.Led = new System.Windows.Forms.Button();
            this.Beep = new System.Windows.Forms.Button();
            this.NineAxes = new System.Windows.Forms.Button();
            this.Motor = new System.Windows.Forms.Button();
            this.FootMotor_1 = new System.Windows.Forms.Button();
            this.FootMotor_2 = new System.Windows.Forms.Button();
            this.FootMotor_3 = new System.Windows.Forms.Button();
            this.FootMotor_4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Led
            // 
            this.Led.Location = new System.Drawing.Point(13, 13);
            this.Led.Name = "Led";
            this.Led.Size = new System.Drawing.Size(75, 23);
            this.Led.TabIndex = 0;
            this.Led.Text = "灯板";
            this.Led.UseVisualStyleBackColor = true;
            // 
            // Beep
            // 
            this.Beep.Location = new System.Drawing.Point(150, 13);
            this.Beep.Name = "Beep";
            this.Beep.Size = new System.Drawing.Size(75, 23);
            this.Beep.TabIndex = 1;
            this.Beep.Text = "蜂鸣器";
            this.Beep.UseVisualStyleBackColor = true;
            // 
            // NineAxes
            // 
            this.NineAxes.Location = new System.Drawing.Point(297, 13);
            this.NineAxes.Name = "NineAxes";
            this.NineAxes.Size = new System.Drawing.Size(75, 23);
            this.NineAxes.TabIndex = 2;
            this.NineAxes.Text = "九轴校准";
            this.NineAxes.UseVisualStyleBackColor = true;
            // 
            // Motor
            // 
            this.Motor.Location = new System.Drawing.Point(461, 13);
            this.Motor.Name = "Motor";
            this.Motor.Size = new System.Drawing.Size(75, 23);
            this.Motor.TabIndex = 3;
            this.Motor.Text = "震动马达";
            this.Motor.UseVisualStyleBackColor = true;
            // 
            // FootMotor_1
            // 
            this.FootMotor_1.Location = new System.Drawing.Point(13, 75);
            this.FootMotor_1.Name = "FootMotor_1";
            this.FootMotor_1.Size = new System.Drawing.Size(75, 23);
            this.FootMotor_1.TabIndex = 4;
            this.FootMotor_1.Text = "脚电机一";
            this.FootMotor_1.UseVisualStyleBackColor = true;
            // 
            // FootMotor_2
            // 
            this.FootMotor_2.Location = new System.Drawing.Point(95, 74);
            this.FootMotor_2.Name = "FootMotor_2";
            this.FootMotor_2.Size = new System.Drawing.Size(75, 23);
            this.FootMotor_2.TabIndex = 5;
            this.FootMotor_2.Text = "脚电机二";
            this.FootMotor_2.UseVisualStyleBackColor = true;
            // 
            // FootMotor_3
            // 
            this.FootMotor_3.Location = new System.Drawing.Point(177, 74);
            this.FootMotor_3.Name = "FootMotor_3";
            this.FootMotor_3.Size = new System.Drawing.Size(75, 23);
            this.FootMotor_3.TabIndex = 6;
            this.FootMotor_3.Text = "脚电机三";
            this.FootMotor_3.UseVisualStyleBackColor = true;
            // 
            // FootMotor_4
            // 
            this.FootMotor_4.Location = new System.Drawing.Point(259, 74);
            this.FootMotor_4.Name = "FootMotor_4";
            this.FootMotor_4.Size = new System.Drawing.Size(75, 23);
            this.FootMotor_4.TabIndex = 7;
            this.FootMotor_4.Text = "脚电机四";
            this.FootMotor_4.UseVisualStyleBackColor = true;
            // 
            // BodyMotherboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(548, 298);
            this.Controls.Add(this.FootMotor_4);
            this.Controls.Add(this.FootMotor_3);
            this.Controls.Add(this.FootMotor_2);
            this.Controls.Add(this.FootMotor_1);
            this.Controls.Add(this.Motor);
            this.Controls.Add(this.NineAxes);
            this.Controls.Add(this.Beep);
            this.Controls.Add(this.Led);
            this.Name = "BodyMotherboard";
            this.Text = "BodyMotherboard";
            this.Load += new System.EventHandler(this.BodyMotherboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Led;
        private System.Windows.Forms.Button Beep;
        private System.Windows.Forms.Button NineAxes;
        private System.Windows.Forms.Button Motor;
        private System.Windows.Forms.Button FootMotor_1;
        private System.Windows.Forms.Button FootMotor_2;
        private System.Windows.Forms.Button FootMotor_3;
        private System.Windows.Forms.Button FootMotor_4;
    }
}