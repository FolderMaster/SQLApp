namespace SQLApp.View.Controls
{
    partial class EditorValueOfTableControl
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.CreateConditionButton = new System.Windows.Forms.Button();
            this.TableListControl = new SQLApp.View.Controls.TableListControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(0, 29);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(512, 297);
            this.DataGridView.TabIndex = 3;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Location = new System.Drawing.Point(437, 332);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SortButton.Location = new System.Drawing.Point(0, 332);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 7;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // CreateConditionButton
            // 
            this.CreateConditionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateConditionButton.Location = new System.Drawing.Point(81, 332);
            this.CreateConditionButton.Name = "CreateConditionButton";
            this.CreateConditionButton.Size = new System.Drawing.Size(95, 23);
            this.CreateConditionButton.TabIndex = 8;
            this.CreateConditionButton.Text = "Create Condition";
            this.CreateConditionButton.UseVisualStyleBackColor = true;
            this.CreateConditionButton.Click += new System.EventHandler(this.CreateConditionButton_Click);
            // 
            // TableListControl
            // 
            this.TableListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableListControl.Location = new System.Drawing.Point(0, 0);
            this.TableListControl.Name = "TableListControl";
            this.TableListControl.SelectedIndex = -1;
            this.TableListControl.Size = new System.Drawing.Size(512, 23);
            this.TableListControl.TabIndex = 6;
            this.TableListControl.SelectedNameTableChanged += new System.EventHandler(this.TableListControl_SelectedNameTableChanged);
            // 
            // EditorValueOfTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateConditionButton);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.TableListControl);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DataGridView);
            this.Name = "EditorValueOfTableControl";
            this.Size = new System.Drawing.Size(512, 355);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button SaveButton;
        private TableListControl TableListControl;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button CreateConditionButton;
    }
}
