namespace Lab7CSharp
{
    partial class Task2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fullColorRadioButton = new System.Windows.Forms.RadioButton();
            this.colorRadioButton = new System.Windows.Forms.RadioButton();
            this.InvertButton = new System.Windows.Forms.Button();
            this.InvertedPictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvertedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fullColorRadioButton);
            this.groupBox1.Controls.Add(this.colorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(58, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 53);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // fullColorRadioButton
            // 
            this.fullColorRadioButton.AutoSize = true;
            this.fullColorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullColorRadioButton.Location = new System.Drawing.Point(248, 18);
            this.fullColorRadioButton.Name = "fullColorRadioButton";
            this.fullColorRadioButton.Size = new System.Drawing.Size(91, 21);
            this.fullColorRadioButton.TabIndex = 1;
            this.fullColorRadioButton.TabStop = true;
            this.fullColorRadioButton.Text = "full Color";
            this.fullColorRadioButton.UseVisualStyleBackColor = true;
            // 
            // colorRadioButton
            // 
            this.colorRadioButton.AutoSize = true;
            this.colorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorRadioButton.Location = new System.Drawing.Point(13, 18);
            this.colorRadioButton.Name = "colorRadioButton";
            this.colorRadioButton.Size = new System.Drawing.Size(64, 21);
            this.colorRadioButton.TabIndex = 0;
            this.colorRadioButton.TabStop = true;
            this.colorRadioButton.Text = "Color";
            this.colorRadioButton.UseVisualStyleBackColor = true;
            // 
            // InvertButton
            // 
            this.InvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvertButton.Location = new System.Drawing.Point(179, 275);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.Size = new System.Drawing.Size(75, 23);
            this.InvertButton.TabIndex = 13;
            this.InvertButton.Text = "Invert";
            this.InvertButton.UseVisualStyleBackColor = true;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
            // 
            // InvertedPictureBox
            // 
            this.InvertedPictureBox.Location = new System.Drawing.Point(222, 103);
            this.InvertedPictureBox.Name = "InvertedPictureBox";
            this.InvertedPictureBox.Size = new System.Drawing.Size(221, 166);
            this.InvertedPictureBox.TabIndex = 12;
            this.InvertedPictureBox.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(306, 275);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save file";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OriginalPictureBox
            // 
            this.OriginalPictureBox.Location = new System.Drawing.Point(12, 103);
            this.OriginalPictureBox.Name = "OriginalPictureBox";
            this.OriginalPictureBox.Size = new System.Drawing.Size(204, 166);
            this.OriginalPictureBox.TabIndex = 10;
            this.OriginalPictureBox.TabStop = false;
            // 
            // OpenButton
            // 
            this.OpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenButton.Location = new System.Drawing.Point(58, 275);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "Open file";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Invert type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Original image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Inverted image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PaleGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(155, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Lab 7.   C#. Task2";
            // 
            // Task2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(455, 310);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvertButton);
            this.Controls.Add(this.InvertedPictureBox);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OriginalPictureBox);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Task2";
            this.Text = "Task2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvertedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fullColorRadioButton;
        private System.Windows.Forms.RadioButton colorRadioButton;
        private System.Windows.Forms.Button InvertButton;
        private System.Windows.Forms.PictureBox InvertedPictureBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.PictureBox OriginalPictureBox;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}