namespace SQLApp.View.Forms
{
    partial class MainForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.CommandTabPage = new System.Windows.Forms.TabPage();
            this.CommandControl = new SQLApp.View.Controls.CommandControl();
            this.TablesTabPage = new System.Windows.Forms.TabPage();
            this.EditorValueOfTableControl = new SQLApp.View.Controls.EditorValueOfTableControl();
            this.TransactionsTabPage = new System.Windows.Forms.TabPage();
            this.TransactionsControl = new SQLApp.View.Controls.TransactionsControl();
            this.RightsTabPage = new System.Windows.Forms.TabPage();
            this.EditorRightsControl = new SQLApp.View.Controls.EditorRightsControl();
            this.ConnectionListControl = new SQLApp.View.Controls.ConnectionListControl();
            this.TabControl.SuspendLayout();
            this.CommandTabPage.SuspendLayout();
            this.TablesTabPage.SuspendLayout();
            this.TransactionsTabPage.SuspendLayout();
            this.RightsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.CommandTabPage);
            this.TabControl.Controls.Add(this.TablesTabPage);
            this.TabControl.Controls.Add(this.TransactionsTabPage);
            this.TabControl.Controls.Add(this.RightsTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 42);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(555, 390);
            this.TabControl.TabIndex = 1;
            // 
            // CommandTabPage
            // 
            this.CommandTabPage.Controls.Add(this.CommandControl);
            this.CommandTabPage.Location = new System.Drawing.Point(4, 22);
            this.CommandTabPage.Name = "CommandTabPage";
            this.CommandTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommandTabPage.Size = new System.Drawing.Size(547, 364);
            this.CommandTabPage.TabIndex = 0;
            this.CommandTabPage.Text = "Command";
            this.CommandTabPage.UseVisualStyleBackColor = true;
            // 
            // CommandControl
            // 
            this.CommandControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandControl.Location = new System.Drawing.Point(3, 3);
            this.CommandControl.Name = "CommandControl";
            this.CommandControl.Size = new System.Drawing.Size(541, 358);
            this.CommandControl.TabIndex = 0;
            // 
            // TablesTabPage
            // 
            this.TablesTabPage.Controls.Add(this.EditorValueOfTableControl);
            this.TablesTabPage.Location = new System.Drawing.Point(4, 22);
            this.TablesTabPage.Name = "TablesTabPage";
            this.TablesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TablesTabPage.Size = new System.Drawing.Size(547, 364);
            this.TablesTabPage.TabIndex = 1;
            this.TablesTabPage.Text = "Tables";
            this.TablesTabPage.UseVisualStyleBackColor = true;
            // 
            // EditorValueOfTableControl
            // 
            this.EditorValueOfTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorValueOfTableControl.Location = new System.Drawing.Point(3, 3);
            this.EditorValueOfTableControl.Name = "EditorValueOfTableControl";
            this.EditorValueOfTableControl.Size = new System.Drawing.Size(541, 358);
            this.EditorValueOfTableControl.TabIndex = 1;
            // 
            // TransactionsTabPage
            // 
            this.TransactionsTabPage.Controls.Add(this.TransactionsControl);
            this.TransactionsTabPage.Location = new System.Drawing.Point(4, 22);
            this.TransactionsTabPage.Name = "TransactionsTabPage";
            this.TransactionsTabPage.Size = new System.Drawing.Size(547, 364);
            this.TransactionsTabPage.TabIndex = 3;
            this.TransactionsTabPage.Text = "Transactions";
            this.TransactionsTabPage.UseVisualStyleBackColor = true;
            // 
            // TransactionsControl
            // 
            this.TransactionsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TransactionsControl.Location = new System.Drawing.Point(0, 0);
            this.TransactionsControl.Name = "TransactionsControl";
            this.TransactionsControl.Size = new System.Drawing.Size(547, 364);
            this.TransactionsControl.TabIndex = 0;
            // 
            // RightsTabPage
            // 
            this.RightsTabPage.Controls.Add(this.EditorRightsControl);
            this.RightsTabPage.Location = new System.Drawing.Point(4, 22);
            this.RightsTabPage.Name = "RightsTabPage";
            this.RightsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RightsTabPage.Size = new System.Drawing.Size(547, 364);
            this.RightsTabPage.TabIndex = 2;
            this.RightsTabPage.Text = "Rights";
            this.RightsTabPage.UseVisualStyleBackColor = true;
            // 
            // EditorRightsControl
            // 
            this.EditorRightsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorRightsControl.Location = new System.Drawing.Point(3, 3);
            this.EditorRightsControl.Name = "EditorRightsControl";
            this.EditorRightsControl.Size = new System.Drawing.Size(541, 358);
            this.EditorRightsControl.TabIndex = 0;
            // 
            // ConnectionListControl
            // 
            this.ConnectionListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionListControl.Location = new System.Drawing.Point(12, 12);
            this.ConnectionListControl.Name = "ConnectionListControl";
            this.ConnectionListControl.SelectedIndex = -1;
            this.ConnectionListControl.Size = new System.Drawing.Size(555, 24);
            this.ConnectionListControl.TabIndex = 0;
            this.ConnectionListControl.ConnectionChanged += new System.EventHandler(this.ConnectionListControl_ConnectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 444);
            this.Controls.Add(this.ConnectionListControl);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "SQLApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.CommandTabPage.ResumeLayout(false);
            this.TablesTabPage.ResumeLayout(false);
            this.TransactionsTabPage.ResumeLayout(false);
            this.RightsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CommandTabPage;
        private System.Windows.Forms.TabPage TablesTabPage;
        private SQLApp.View.Controls.CommandControl CommandControl;
        private SQLApp.View.Controls.ConnectionListControl ConnectionListControl;
        private Controls.EditorValueOfTableControl EditorValueOfTableControl;
        private System.Windows.Forms.TabPage TransactionsTabPage;
        private System.Windows.Forms.TabPage RightsTabPage;
        private Controls.EditorRightsControl EditorRightsControl;
        private Controls.TransactionsControl TransactionsControl;
    }
}