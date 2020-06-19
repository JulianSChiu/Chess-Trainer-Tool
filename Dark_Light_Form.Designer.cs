namespace Chess_Trainer_Tool
{
    partial class Dark_Light_Form
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
            this.label_Square = new System.Windows.Forms.Label();
            this.label_Coordinate = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Answer = new System.Windows.Forms.Label();
            this.button_Light = new System.Windows.Forms.Button();
            this.button_Dark = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Square
            // 
            this.label_Square.AutoSize = true;
            this.label_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label_Square.Location = new System.Drawing.Point(58, 22);
            this.label_Square.Name = "label_Square";
            this.label_Square.Size = new System.Drawing.Size(409, 29);
            this.label_Square.TabIndex = 0;
            this.label_Square.Text = "Guess the Color of the Chess Square";
            this.label_Square.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Coordinate
            // 
            this.label_Coordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Coordinate.Location = new System.Drawing.Point(191, 26);
            this.label_Coordinate.Name = "label_Coordinate";
            this.label_Coordinate.Size = new System.Drawing.Size(100, 50);
            this.label_Coordinate.TabIndex = 3;
            this.label_Coordinate.Text = "Ready?";
            this.label_Coordinate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(135, 67);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(251, 27);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Answer
            // 
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Answer.Location = new System.Drawing.Point(145, 98);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(193, 67);
            this.label_Answer.TabIndex = 5;
            this.label_Answer.Text = "Light or Dark";
            this.label_Answer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Light
            // 
            this.button_Light.Location = new System.Drawing.Point(35, 193);
            this.button_Light.Name = "button_Light";
            this.button_Light.Size = new System.Drawing.Size(178, 47);
            this.button_Light.TabIndex = 6;
            this.button_Light.Text = "Light";
            this.button_Light.UseVisualStyleBackColor = true;
            this.button_Light.Click += new System.EventHandler(this.button_Light_Click);
            // 
            // button_Dark
            // 
            this.button_Dark.Location = new System.Drawing.Point(268, 193);
            this.button_Dark.Name = "button_Dark";
            this.button_Dark.Size = new System.Drawing.Size(178, 47);
            this.button_Dark.TabIndex = 7;
            this.button_Dark.Text = "Dark";
            this.button_Dark.UseVisualStyleBackColor = true;
            this.button_Dark.Click += new System.EventHandler(this.button_Dark_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Dark);
            this.groupBox1.Controls.Add(this.button_Light);
            this.groupBox1.Controls.Add(this.label_Answer);
            this.groupBox1.Controls.Add(this.label_Coordinate);
            this.groupBox1.Location = new System.Drawing.Point(24, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 276);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // Dark_Light_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Square);
            this.Controls.Add(this.button_Start);
            this.Name = "Dark_Light_Form";
            this.Text = "Guess the Color";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Square;
        private System.Windows.Forms.Label label_Coordinate;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.Button button_Light;
        private System.Windows.Forms.Button button_Dark;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

