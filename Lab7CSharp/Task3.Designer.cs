namespace Lab7CSharp
{
    partial class Task3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CountOfElemntsPictureTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.circleRadioButton = new System.Windows.Forms.RadioButton();
            this.squareRadioButton = new System.Windows.Forms.RadioButton();
            this.equilateralTriangleRadioButton = new System.Windows.Forms.RadioButton();
            this.rectangleRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textOfElementTextBox = new System.Windows.Forms.TextBox();
            this.openColorDialog1Button = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.side1textBox = new System.Windows.Forms.TextBox();
            this.side2textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sideTriangleTextBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sideSquareTextBox = new System.Windows.Forms.TextBox();
            this.inputNewElemIntoMassiveButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.exitProgramButton = new System.Windows.Forms.Button();
            this.drawPictureButton = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.PaleGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lab 7.   C#. Task3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Кількість елементів малюнка";
            // 
            // CountOfElemntsPictureTextBox
            // 
            this.CountOfElemntsPictureTextBox.Location = new System.Drawing.Point(243, 50);
            this.CountOfElemntsPictureTextBox.Name = "CountOfElemntsPictureTextBox";
            this.CountOfElemntsPictureTextBox.Size = new System.Drawing.Size(100, 20);
            this.CountOfElemntsPictureTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.circleRadioButton);
            this.groupBox1.Controls.Add(this.squareRadioButton);
            this.groupBox1.Controls.Add(this.equilateralTriangleRadioButton);
            this.groupBox1.Controls.Add(this.rectangleRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(15, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип елемента";
            // 
            // circleRadioButton
            // 
            this.circleRadioButton.AutoSize = true;
            this.circleRadioButton.Location = new System.Drawing.Point(6, 88);
            this.circleRadioButton.Name = "circleRadioButton";
            this.circleRadioButton.Size = new System.Drawing.Size(50, 17);
            this.circleRadioButton.TabIndex = 3;
            this.circleRadioButton.TabStop = true;
            this.circleRadioButton.Text = "Коло";
            this.circleRadioButton.UseVisualStyleBackColor = true;
            this.circleRadioButton.CheckedChanged += new System.EventHandler(this.circleRadioButton_CheckedChanged);
            // 
            // squareRadioButton
            // 
            this.squareRadioButton.AutoSize = true;
            this.squareRadioButton.Location = new System.Drawing.Point(6, 65);
            this.squareRadioButton.Name = "squareRadioButton";
            this.squareRadioButton.Size = new System.Drawing.Size(67, 17);
            this.squareRadioButton.TabIndex = 2;
            this.squareRadioButton.TabStop = true;
            this.squareRadioButton.Text = "Квадрат";
            this.squareRadioButton.UseVisualStyleBackColor = true;
            this.squareRadioButton.CheckedChanged += new System.EventHandler(this.squareRadioButton_CheckedChanged);
            // 
            // equilateralTriangleRadioButton
            // 
            this.equilateralTriangleRadioButton.AutoSize = true;
            this.equilateralTriangleRadioButton.Location = new System.Drawing.Point(6, 42);
            this.equilateralTriangleRadioButton.Name = "equilateralTriangleRadioButton";
            this.equilateralTriangleRadioButton.Size = new System.Drawing.Size(130, 17);
            this.equilateralTriangleRadioButton.TabIndex = 1;
            this.equilateralTriangleRadioButton.TabStop = true;
            this.equilateralTriangleRadioButton.Text = "Рівносторонній трик.";
            this.equilateralTriangleRadioButton.UseVisualStyleBackColor = true;
            this.equilateralTriangleRadioButton.CheckedChanged += new System.EventHandler(this.equilateralTriangleRadioButton_CheckedChanged);
            // 
            // rectangleRadioButton
            // 
            this.rectangleRadioButton.AutoSize = true;
            this.rectangleRadioButton.Location = new System.Drawing.Point(6, 19);
            this.rectangleRadioButton.Name = "rectangleRadioButton";
            this.rectangleRadioButton.Size = new System.Drawing.Size(93, 17);
            this.rectangleRadioButton.TabIndex = 0;
            this.rectangleRadioButton.TabStop = true;
            this.rectangleRadioButton.Text = "Прямокутник";
            this.rectangleRadioButton.UseVisualStyleBackColor = true;
            this.rectangleRadioButton.CheckedChanged += new System.EventHandler(this.rectangleRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textOfElementTextBox);
            this.groupBox2.Controls.Add(this.openColorDialog1Button);
            this.groupBox2.Location = new System.Drawing.Point(21, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(178, 100);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Загальні параметри";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Текст елемента";
            // 
            // textOfElementTextBox
            // 
            this.textOfElementTextBox.Location = new System.Drawing.Point(6, 68);
            this.textOfElementTextBox.Name = "textOfElementTextBox";
            this.textOfElementTextBox.Size = new System.Drawing.Size(116, 20);
            this.textOfElementTextBox.TabIndex = 9;
            // 
            // openColorDialog1Button
            // 
            this.openColorDialog1Button.Location = new System.Drawing.Point(6, 26);
            this.openColorDialog1Button.Name = "openColorDialog1Button";
            this.openColorDialog1Button.Size = new System.Drawing.Size(116, 23);
            this.openColorDialog1Button.TabIndex = 0;
            this.openColorDialog1Button.Text = "Вибрати колір";
            this.openColorDialog1Button.UseVisualStyleBackColor = true;
            this.openColorDialog1Button.Click += new System.EventHandler(this.openColorDialog1Button_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.side1textBox);
            this.groupBox3.Controls.Add(this.side2textBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(243, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметри прямокутника";
            // 
            // side1textBox
            // 
            this.side1textBox.Location = new System.Drawing.Point(95, 19);
            this.side1textBox.Name = "side1textBox";
            this.side1textBox.Size = new System.Drawing.Size(52, 20);
            this.side1textBox.TabIndex = 8;
            // 
            // side2textBox
            // 
            this.side2textBox.Location = new System.Drawing.Point(95, 48);
            this.side2textBox.Name = "side2textBox";
            this.side2textBox.Size = new System.Drawing.Size(52, 20);
            this.side2textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Сторона 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Сторона 1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.sideTriangleTextBox);
            this.groupBox4.Location = new System.Drawing.Point(243, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 61);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметри рівн. трикутника";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Сторона";
            // 
            // sideTriangleTextBox
            // 
            this.sideTriangleTextBox.Location = new System.Drawing.Point(95, 25);
            this.sideTriangleTextBox.Name = "sideTriangleTextBox";
            this.sideTriangleTextBox.Size = new System.Drawing.Size(52, 20);
            this.sideTriangleTextBox.TabIndex = 10;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.sideSquareTextBox);
            this.groupBox5.Location = new System.Drawing.Point(243, 226);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 61);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметри квадрата";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Сторона";
            // 
            // sideSquareTextBox
            // 
            this.sideSquareTextBox.Location = new System.Drawing.Point(95, 29);
            this.sideSquareTextBox.Name = "sideSquareTextBox";
            this.sideSquareTextBox.Size = new System.Drawing.Size(52, 20);
            this.sideSquareTextBox.TabIndex = 9;
            // 
            // inputNewElemIntoMassiveButton
            // 
            this.inputNewElemIntoMassiveButton.Location = new System.Drawing.Point(68, 358);
            this.inputNewElemIntoMassiveButton.Name = "inputNewElemIntoMassiveButton";
            this.inputNewElemIntoMassiveButton.Size = new System.Drawing.Size(322, 23);
            this.inputNewElemIntoMassiveButton.TabIndex = 8;
            this.inputNewElemIntoMassiveButton.Text = "Ввести новий елемент у масив";
            this.inputNewElemIntoMassiveButton.UseVisualStyleBackColor = true;
            this.inputNewElemIntoMassiveButton.Click += new System.EventHandler(this.inputNewElemIntoMassiveButton_Click);
            // 
            // exitProgramButton
            // 
            this.exitProgramButton.Location = new System.Drawing.Point(68, 387);
            this.exitProgramButton.Name = "exitProgramButton";
            this.exitProgramButton.Size = new System.Drawing.Size(148, 23);
            this.exitProgramButton.TabIndex = 9;
            this.exitProgramButton.Text = "Вихід з програми";
            this.exitProgramButton.UseVisualStyleBackColor = true;
            this.exitProgramButton.Click += new System.EventHandler(this.exitProgramButton_Click);
            // 
            // drawPictureButton
            // 
            this.drawPictureButton.Location = new System.Drawing.Point(230, 387);
            this.drawPictureButton.Name = "drawPictureButton";
            this.drawPictureButton.Size = new System.Drawing.Size(160, 23);
            this.drawPictureButton.TabIndex = 10;
            this.drawPictureButton.Text = "Побудувати малюнок";
            this.drawPictureButton.UseVisualStyleBackColor = true;
            this.drawPictureButton.Click += new System.EventHandler(this.drawPictureButton_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.radiusTextBox);
            this.groupBox6.Location = new System.Drawing.Point(243, 293);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 47);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Параметри круга";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Радіус";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.Location = new System.Drawing.Point(95, 19);
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(52, 20);
            this.radiusTextBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(427, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 360);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Task3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(778, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.drawPictureButton);
            this.Controls.Add(this.exitProgramButton);
            this.Controls.Add(this.inputNewElemIntoMassiveButton);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CountOfElemntsPictureTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Task3";
            this.Text = "Task3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CountOfElemntsPictureTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox side1textBox;
        private System.Windows.Forms.TextBox side2textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox sideTriangleTextBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sideSquareTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button inputNewElemIntoMassiveButton;
        private System.Windows.Forms.RadioButton rectangleRadioButton;
        private System.Windows.Forms.RadioButton squareRadioButton;
        private System.Windows.Forms.RadioButton equilateralTriangleRadioButton;
        private System.Windows.Forms.Button openColorDialog1Button;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox textOfElementTextBox;
        private System.Windows.Forms.Button exitProgramButton;
        private System.Windows.Forms.Button drawPictureButton;
        private System.Windows.Forms.RadioButton circleRadioButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}