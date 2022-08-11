namespace SQLApp.View.Controls
{
    partial class ConditionControl
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
            this.NotColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OperationColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConjunctionColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotColumn,
            this.ColumnColumn,
            this.OperationColumn,
            this.ValueColumn,
            this.ConjunctionColumn});
            this.DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView.Location = new System.Drawing.Point(0, 0);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(545, 180);
            this.DataGridView.TabIndex = 0;
            // 
            // NotColumn
            // 
            this.NotColumn.HeaderText = "Not";
            this.NotColumn.Name = "NotColumn";
            // 
            // ColumnColumn
            // 
            this.ColumnColumn.HeaderText = "Column";
            this.ColumnColumn.Name = "ColumnColumn";
            // 
            // OperationColumn
            // 
            this.OperationColumn.HeaderText = "Operation";
            this.OperationColumn.Name = "OperationColumn";
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            // 
            // ConjunctionColumn
            // 
            this.ConjunctionColumn.HeaderText = "Conjunction";
            this.ConjunctionColumn.Name = "ConjunctionColumn";
            // 
            // ConditionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DataGridView);
            this.Name = "ConditionControl";
            this.Size = new System.Drawing.Size(545, 180);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OperationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn ConjunctionColumn;
    }
}
