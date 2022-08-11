namespace SQLApp.View.Controls
{
    partial class RightsControl
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
            this.GrantButton = new System.Windows.Forms.Button();
            this.RevokeButton = new System.Windows.Forms.Button();
            this.TablesLabel = new System.Windows.Forms.Label();
            this.UsersLabel = new System.Windows.Forms.Label();
            this.UserListBox = new SQLApp.View.Controls.UserListBox();
            this.TableListBox = new SQLApp.View.Controls.TableListBox();
            this.SuspendLayout();
            // 
            // GrantButton
            // 
            this.GrantButton.Location = new System.Drawing.Point(312, 16);
            this.GrantButton.Name = "GrantButton";
            this.GrantButton.Size = new System.Drawing.Size(75, 23);
            this.GrantButton.TabIndex = 4;
            this.GrantButton.Text = "Grant";
            this.GrantButton.UseVisualStyleBackColor = true;
            this.GrantButton.Click += new System.EventHandler(this.GrantButton_Click);
            // 
            // RevokeButton
            // 
            this.RevokeButton.Location = new System.Drawing.Point(312, 45);
            this.RevokeButton.Name = "RevokeButton";
            this.RevokeButton.Size = new System.Drawing.Size(75, 23);
            this.RevokeButton.TabIndex = 5;
            this.RevokeButton.Text = "Revoke";
            this.RevokeButton.UseVisualStyleBackColor = true;
            this.RevokeButton.Click += new System.EventHandler(this.RevokeButton_Click);
            // 
            // TablesLabel
            // 
            this.TablesLabel.AutoSize = true;
            this.TablesLabel.Location = new System.Drawing.Point(-3, 0);
            this.TablesLabel.Name = "TablesLabel";
            this.TablesLabel.Size = new System.Drawing.Size(42, 13);
            this.TablesLabel.TabIndex = 0;
            this.TablesLabel.Text = "Tables:";
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Location = new System.Drawing.Point(153, 0);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(37, 13);
            this.UsersLabel.TabIndex = 1;
            this.UsersLabel.Text = "Users:";
            // 
            // UserListBox
            // 
            this.UserListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.UserListBox.Location = new System.Drawing.Point(156, 16);
            this.UserListBox.Name = "UserListBox";
            this.UserListBox.Size = new System.Drawing.Size(150, 171);
            this.UserListBox.TabIndex = 3;
            // 
            // TableListBox
            // 
            this.TableListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TableListBox.Location = new System.Drawing.Point(0, 16);
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Size = new System.Drawing.Size(150, 171);
            this.TableListBox.TabIndex = 2;
            // 
            // EditorRightsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UsersLabel);
            this.Controls.Add(this.TablesLabel);
            this.Controls.Add(this.UserListBox);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.RevokeButton);
            this.Controls.Add(this.GrantButton);
            this.Name = "EditorRightsControl";
            this.Size = new System.Drawing.Size(387, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GrantButton;
        private System.Windows.Forms.Button RevokeButton;
        private TableListBox TableListBox;
        private UserListBox UserListBox;
        private System.Windows.Forms.Label TablesLabel;
        private System.Windows.Forms.Label UsersLabel;
    }
}
