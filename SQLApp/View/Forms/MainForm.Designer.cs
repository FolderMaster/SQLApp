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
            this.CreateTableTabPage = new System.Windows.Forms.TabPage();
            this.ConnectionListControl = new SQLApp.View.Controls.ConnectionListControl();
            this.CommandControl = new SQLApp.View.Controls.CommandControl();
            this.CreateTableControl = new SQLApp.View.Controls.CreateTableControl();
            this.TabControl.SuspendLayout();
            this.CommandTabPage.SuspendLayout();
            this.CreateTableTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.CommandTabPage);
            this.TabControl.Controls.Add(this.CreateTableTabPage);
            this.TabControl.Location = new System.Drawing.Point(3, 50);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(439, 388);
            this.TabControl.TabIndex = 1;
            // 
            // CommandTabPage
            // 
            this.CommandTabPage.Controls.Add(this.CommandControl);
            this.CommandTabPage.Location = new System.Drawing.Point(4, 22);
            this.CommandTabPage.Name = "CommandTabPage";
            this.CommandTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommandTabPage.Size = new System.Drawing.Size(431, 362);
            this.CommandTabPage.TabIndex = 0;
            this.CommandTabPage.Text = "Command";
            this.CommandTabPage.UseVisualStyleBackColor = true;
            // 
            // CreateTableTabPage
            // 
            this.CreateTableTabPage.Controls.Add(this.CreateTableControl);
            this.CreateTableTabPage.Location = new System.Drawing.Point(4, 22);
            this.CreateTableTabPage.Name = "CreateTableTabPage";
            this.CreateTableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateTableTabPage.Size = new System.Drawing.Size(431, 362);
            this.CreateTableTabPage.TabIndex = 1;
            this.CreateTableTabPage.Text = "Create Table";
            this.CreateTableTabPage.UseVisualStyleBackColor = true;
            // 
            // ConnectionListControl
            // 
            this.ConnectionListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionListControl.Location = new System.Drawing.Point(12, 12);
            this.ConnectionListControl.Name = "ConnectionListControl";
            this.ConnectionListControl.Size = new System.Drawing.Size(430, 24);
            this.ConnectionListControl.TabIndex = 2;
            this.ConnectionListControl.ConnectionBuilderChanged += new System.EventHandler(this.ConnectionListControl_ConnectionBuilderChanged);
            // 
            // CommandControl
            // 
            this.CommandControl.ConnectionBuilder = null;
            this.CommandControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandControl.Location = new System.Drawing.Point(3, 3);
            this.CommandControl.Name = "CommandControl";
            this.CommandControl.Size = new System.Drawing.Size(425, 356);
            this.CommandControl.TabIndex = 0;
            // 
            // CreateTableControl
            // 
            this.CreateTableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateTableControl.Location = new System.Drawing.Point(3, 3);
            this.CreateTableControl.Name = "CreateTableControl";
            this.CreateTableControl.Size = new System.Drawing.Size(425, 356);
            this.CreateTableControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.ConnectionListControl);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.Text = "SQLApp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.CommandTabPage.ResumeLayout(false);
            this.CreateTableTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CommandTabPage;
        private System.Windows.Forms.TabPage CreateTableTabPage;
        private SQLApp.View.Controls.CommandControl CommandControl;
        private SQLApp.View.Controls.ConnectionListControl ConnectionListControl;
        private Controls.CreateTableControl CreateTableControl;
    }
}