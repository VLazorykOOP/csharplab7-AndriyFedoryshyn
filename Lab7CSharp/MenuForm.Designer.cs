namespace Lab7CSharp
{
    partial class MenuForm
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
            this.task1button = new System.Windows.Forms.Button();
            this.Task2button = new System.Windows.Forms.Button();
            this.task3button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task1button
            // 
            this.task1button.Location = new System.Drawing.Point(125, 98);
            this.task1button.Name = "task1button";
            this.task1button.Size = new System.Drawing.Size(75, 23);
            this.task1button.TabIndex = 0;
            this.task1button.Text = "Task1";
            this.task1button.UseVisualStyleBackColor = true;
            this.task1button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Task2button
            // 
            this.Task2button.Location = new System.Drawing.Point(125, 157);
            this.Task2button.Name = "Task2button";
            this.Task2button.Size = new System.Drawing.Size(75, 23);
            this.Task2button.TabIndex = 1;
            this.Task2button.Text = "Task2";
            this.Task2button.UseVisualStyleBackColor = true;
            this.Task2button.Click += new System.EventHandler(this.Task2button_Click);
            // 
            // task3button
            // 
            this.task3button.Location = new System.Drawing.Point(125, 214);
            this.task3button.Name = "task3button";
            this.task3button.Size = new System.Drawing.Size(75, 23);
            this.task3button.TabIndex = 2;
            this.task3button.Text = "Task3";
            this.task3button.UseVisualStyleBackColor = true;
            this.task3button.Click += new System.EventHandler(this.task3button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select task:";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.task3button);
            this.Controls.Add(this.Task2button);
            this.Controls.Add(this.task1button);
            this.Name = "MenuForm";
            this.Text = "Task1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button task1button;
        private System.Windows.Forms.Button Task2button;
        private System.Windows.Forms.Button task3button;
        private System.Windows.Forms.Label label1;
    }
}