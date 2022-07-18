namespace SQLApp.View.Controls
{
    partial class TransactionsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CommitButton = new System.Windows.Forms.Button();
            this.RollbackButton = new System.Windows.Forms.Button();
            this.SavePointButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CommitButton
            // 
            this.CommitButton.Location = new System.Drawing.Point(0, 0);
            this.CommitButton.Name = "CommitButton";
            this.CommitButton.Size = new System.Drawing.Size(75, 23);
            this.CommitButton.TabIndex = 0;
            this.CommitButton.Text = "Commit";
            this.CommitButton.UseVisualStyleBackColor = true;
            this.CommitButton.Click += new System.EventHandler(this.CommitButton_Click);
            // 
            // RollbackButton
            // 
            this.RollbackButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RollbackButton.Location = new System.Drawing.Point(81, 0);
            this.RollbackButton.Name = "RollbackButton";
            this.RollbackButton.Size = new System.Drawing.Size(75, 23);
            this.RollbackButton.TabIndex = 1;
            this.RollbackButton.Text = "Rollback";
            this.RollbackButton.UseVisualStyleBackColor = true;
            this.RollbackButton.Click += new System.EventHandler(this.RollbackButton_Click);
            // 
            // SavePointButton
            // 
            this.SavePointButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePointButton.Location = new System.Drawing.Point(162, 0);
            this.SavePointButton.Name = "SavePointButton";
            this.SavePointButton.Size = new System.Drawing.Size(75, 23);
            this.SavePointButton.TabIndex = 2;
            this.SavePointButton.Text = "Save point";
            this.SavePointButton.UseVisualStyleBackColor = true;
            this.SavePointButton.Click += new System.EventHandler(this.SavePointButton_Click);
            // 
            // TransactionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SavePointButton);
            this.Controls.Add(this.RollbackButton);
            this.Controls.Add(this.CommitButton);
            this.Name = "TransactionsControl";
            this.Size = new System.Drawing.Size(237, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CommitButton;
        private System.Windows.Forms.Button RollbackButton;
        private System.Windows.Forms.Button SavePointButton;
    }
}
