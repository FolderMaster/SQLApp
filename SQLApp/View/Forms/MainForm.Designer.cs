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
            this.TableTabPage = new System.Windows.Forms.TabPage();
            this.ConnectionListControl = new SQLApp.View.Controls.ConnectionListControl();
            this.CommandControl = new SQLApp.View.Controls.CommandControl();
            this.TableListControl = new SQLApp.View.Controls.TableListControl();
            this.TabControl.SuspendLayout();
            this.CommandTabPage.SuspendLayout();
            this.TableTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.CommandTabPage);
            this.TabControl.Controls.Add(this.TableTabPage);
            this.TabControl.Location = new System.Drawing.Point(12, 42);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(427, 396);
            this.TabControl.TabIndex = 1;
            // 
            // CommandTabPage
            // 
            this.CommandTabPage.Controls.Add(this.CommandControl);
            this.CommandTabPage.Location = new System.Drawing.Point(4, 22);
            this.CommandTabPage.Name = "CommandTabPage";
            this.CommandTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommandTabPage.Size = new System.Drawing.Size(419, 370);
            this.CommandTabPage.TabIndex = 0;
            this.CommandTabPage.Text = "Command";
            this.CommandTabPage.UseVisualStyleBackColor = true;
            // 
            // TableTabPage
            // 
            this.TableTabPage.Controls.Add(this.TableListControl);
            this.TableTabPage.Location = new System.Drawing.Point(4, 22);
            this.TableTabPage.Name = "TableTabPage";
            this.TableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TableTabPage.Size = new System.Drawing.Size(419, 370);
            this.TableTabPage.TabIndex = 1;
            this.TableTabPage.Text = "Table";
            this.TableTabPage.UseVisualStyleBackColor = true;
            // 
            // ConnectionListControl
            // 
            this.ConnectionListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectionListControl.Location = new System.Drawing.Point(12, 12);
            this.ConnectionListControl.Name = "ConnectionListControl";
            this.ConnectionListControl.SelectedIndex = -1;
            this.ConnectionListControl.Size = new System.Drawing.Size(427, 24);
            this.ConnectionListControl.TabIndex = 0;
            this.ConnectionListControl.ConnectionBuilderChanged += new System.EventHandler(this.ConnectionListControl_ConnectionBuilderChanged);
            // 
            // CommandControl
            // 
            this.CommandControl.ConnectionBuilder = null;
            this.CommandControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandControl.Location = new System.Drawing.Point(3, 3);
            this.CommandControl.Name = "CommandControl";
            this.CommandControl.Size = new System.Drawing.Size(413, 364);
            this.CommandControl.TabIndex = 0;
            // 
            // TableListControl
            // 
            this.TableListControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableListControl.Location = new System.Drawing.Point(6, 6);
            this.TableListControl.Name = "TableListControl";
            this.TableListControl.Size = new System.Drawing.Size(407, 23);
            this.TableListControl.TabIndex = 0;
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
            this.TableTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage CommandTabPage;
        private System.Windows.Forms.TabPage TableTabPage;
        private SQLApp.View.Controls.CommandControl CommandControl;
        private SQLApp.View.Controls.ConnectionListControl ConnectionListControl;
        private Controls.TableListControl TableListControl;
    }
}