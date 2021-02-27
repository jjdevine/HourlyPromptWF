
namespace HourlyPromptWF
{
    partial class HourlyLog
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.TextBoxLog = new System.Windows.Forms.TextBox();
            this.SaveContinueButton = new System.Windows.Forms.Button();
            this.SaveExitButton = new System.Windows.Forms.Button();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(86, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(636, 66);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tasks for Previous Hour:";
            // 
            // TextBoxLog
            // 
            this.TextBoxLog.BackColor = System.Drawing.Color.Black;
            this.TextBoxLog.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxLog.ForeColor = System.Drawing.Color.Red;
            this.TextBoxLog.Location = new System.Drawing.Point(30, 139);
            this.TextBoxLog.Multiline = true;
            this.TextBoxLog.Name = "TextBoxLog";
            this.TextBoxLog.Size = new System.Drawing.Size(748, 340);
            this.TextBoxLog.TabIndex = 1;
            this.TextBoxLog.Text = "Task text goes here";
            // 
            // SaveContinueButton
            // 
            this.SaveContinueButton.BackColor = System.Drawing.Color.Navy;
            this.SaveContinueButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveContinueButton.ForeColor = System.Drawing.Color.Yellow;
            this.SaveContinueButton.Location = new System.Drawing.Point(30, 486);
            this.SaveContinueButton.Name = "SaveContinueButton";
            this.SaveContinueButton.Size = new System.Drawing.Size(551, 48);
            this.SaveContinueButton.TabIndex = 2;
            this.SaveContinueButton.Text = "Save and Start Next Hour";
            this.SaveContinueButton.UseVisualStyleBackColor = false;
            this.SaveContinueButton.Click += new System.EventHandler(this.SaveContinueButton_Click);
            // 
            // SaveExitButton
            // 
            this.SaveExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.SaveExitButton.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveExitButton.ForeColor = System.Drawing.Color.Yellow;
            this.SaveExitButton.Location = new System.Drawing.Point(587, 486);
            this.SaveExitButton.Name = "SaveExitButton";
            this.SaveExitButton.Size = new System.Drawing.Size(191, 48);
            this.SaveExitButton.TabIndex = 3;
            this.SaveExitButton.Text = "Save and Exit";
            this.SaveExitButton.UseVisualStyleBackColor = false;
            this.SaveExitButton.Click += new System.EventHandler(this.SaveExitButton_Click);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelTime.Location = new System.Drawing.Point(342, 84);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(95, 37);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "00:00";
            // 
            // HourlyLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.SaveExitButton);
            this.Controls.Add(this.SaveContinueButton);
            this.Controls.Add(this.TextBoxLog);
            this.Controls.Add(this.labelTitle);
            this.Name = "HourlyLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HourlyLog";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox TextBoxLog;
        private System.Windows.Forms.Button SaveContinueButton;
        private System.Windows.Forms.Button SaveExitButton;
        private System.Windows.Forms.Label labelTime;
    }
}