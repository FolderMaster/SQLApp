namespace SQLApp.View.Controls
{
    partial class DropTableControl
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
            this.SelectTableContol = new SQLApp.View.Controls.SelectTableContol();
            this.Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectTableContol
            // 
            this.SelectTableContol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectTableContol.ConnectionBuilder = null;
            this.SelectTableContol.Location = new System.Drawing.Point(0, 0);
            this.SelectTableContol.Name = "SelectTableContol";
            this.SelectTableContol.Size = new System.Drawing.Size(243, 22);
            this.SelectTableContol.TabIndex = 0;
            // 
            // Button
            // 
            this.Button.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Button.Location = new System.Drawing.Point(0, 28);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(243, 23);
            this.Button.TabIndex = 1;
            this.Button.Text = "Drop";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // DropTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button);
            this.Controls.Add(this.SelectTableContol);
            this.Name = "DropTableControl";
            this.Size = new System.Drawing.Size(242, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private SelectTableContol SelectTableContol;
        private System.Windows.Forms.Button Button;
    }
}
