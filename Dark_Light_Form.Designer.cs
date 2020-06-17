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
            this.radioButton_Light = new System.Windows.Forms.RadioButton();
            this.radioButton_Dark = new System.Windows.Forms.RadioButton();
            this.label_Coordinate = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.label_Answer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Square
            // 
            this.label_Square.AutoSize = true;
            this.label_Square.Location = new System.Drawing.Point(239, 128);
            this.label_Square.Name = "label_Square";
            this.label_Square.Size = new System.Drawing.Size(73, 13);
            this.label_Square.TabIndex = 0;
            this.label_Square.Text = "Chess Square";
            // 
            // radioButton_Light
            // 
            this.radioButton_Light.AutoSize = true;
            this.radioButton_Light.Location = new System.Drawing.Point(163, 231);
            this.radioButton_Light.Name = "radioButton_Light";
            this.radioButton_Light.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Light.TabIndex = 1;
            this.radioButton_Light.TabStop = true;
            this.radioButton_Light.Text = "Light";
            this.radioButton_Light.UseVisualStyleBackColor = true;
            // 
            // radioButton_Dark
            // 
            this.radioButton_Dark.AutoSize = true;
            this.radioButton_Dark.Location = new System.Drawing.Point(366, 231);
            this.radioButton_Dark.Name = "radioButton_Dark";
            this.radioButton_Dark.Size = new System.Drawing.Size(48, 17);
            this.radioButton_Dark.TabIndex = 2;
            this.radioButton_Dark.TabStop = true;
            this.radioButton_Dark.Text = "Dark";
            this.radioButton_Dark.UseVisualStyleBackColor = true;
            // 
            // label_Coordinate
            // 
            this.label_Coordinate.AutoSize = true;
            this.label_Coordinate.Location = new System.Drawing.Point(256, 157);
            this.label_Coordinate.Name = "label_Coordinate";
            this.label_Coordinate.Size = new System.Drawing.Size(44, 13);
            this.label_Coordinate.TabIndex = 3;
            this.label_Coordinate.Text = "Ready?";
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
            this.label_Answer.Location = new System.Drawing.Point(244, 333);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(68, 13);
            this.label_Answer.TabIndex = 5;
            this.label_Answer.Text = "Light or Dark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.label_Answer);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Coordinate);
            this.Controls.Add(this.radioButton_Dark);
            this.Controls.Add(this.radioButton_Light);
            this.Controls.Add(this.label_Square);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Square;
        private System.Windows.Forms.RadioButton radioButton_Light;
        private System.Windows.Forms.RadioButton radioButton_Dark;
        private System.Windows.Forms.Label label_Coordinate;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label_Answer;
    }
}

