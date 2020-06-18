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
            this.SuspendLayout();
            // 
            // label_Square
            // 
            this.label_Square.AutoSize = true;
            this.label_Square.Location = new System.Drawing.Point(195, 125);
            this.label_Square.Name = "label_Square";
            this.label_Square.Size = new System.Drawing.Size(181, 13);
            this.label_Square.TabIndex = 0;
            this.label_Square.Text = "Guess the Color of the Chess Square";
            // 
            // label_Coordinate
            // 
            this.label_Coordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label_Coordinate.Location = new System.Drawing.Point(229, 157);
            this.label_Coordinate.Name = "label_Coordinate";
            this.label_Coordinate.Size = new System.Drawing.Size(100, 50);
            this.label_Coordinate.TabIndex = 3;
            this.label_Coordinate.Text = "Ready?";
            this.label_Coordinate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(154, 66);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(251, 27);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label_Answer
            // 
            this.label_Answer.AutoSize = true;
            this.label_Answer.Location = new System.Drawing.Point(240, 336);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(68, 13);
            this.label_Answer.TabIndex = 5;
            this.label_Answer.Text = "Light or Dark";
            // 
            // button_Light
            // 
            this.button_Light.Location = new System.Drawing.Point(88, 236);
            this.button_Light.Name = "button_Light";
            this.button_Light.Size = new System.Drawing.Size(154, 39);
            this.button_Light.TabIndex = 6;
            this.button_Light.Text = "Light";
            this.button_Light.UseVisualStyleBackColor = true;
            this.button_Light.Click += new System.EventHandler(this.button_Light_Click);
            // 
            // button_Dark
            // 
            this.button_Dark.Location = new System.Drawing.Point(304, 236);
            this.button_Dark.Name = "button_Dark";
            this.button_Dark.Size = new System.Drawing.Size(154, 39);
            this.button_Dark.TabIndex = 7;
            this.button_Dark.Text = "Dark";
            this.button_Dark.UseVisualStyleBackColor = true;
            this.button_Dark.Click += new System.EventHandler(this.button_Dark_Click);
            // 
            // Dark_Light_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.button_Dark);
            this.Controls.Add(this.button_Light);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Coordinate);
            this.Controls.Add(this.label_Square);
            this.Name = "Dark_Light_Form";
            this.Text = "Form1";
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
    }
}

