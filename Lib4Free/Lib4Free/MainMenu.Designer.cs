namespace Lib4Free
{
    partial class MainMenu
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
            this.btnBookManager = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnEventManager = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBookManager
            // 
            this.btnBookManager.Location = new System.Drawing.Point(102, 192);
            this.btnBookManager.Name = "btnBookManager";
            this.btnBookManager.Size = new System.Drawing.Size(159, 56);
            this.btnBookManager.TabIndex = 0;
            this.btnBookManager.Text = "Book Manager";
            this.btnBookManager.UseVisualStyleBackColor = true;
            this.btnBookManager.Click += new System.EventHandler(this.btnBookManager_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(317, 192);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(159, 56);
            this.btn.TabIndex = 1;
            this.btn.Text = "Donate Books";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEventManager
            // 
            this.btnEventManager.Location = new System.Drawing.Point(547, 192);
            this.btnEventManager.Name = "btnEventManager";
            this.btnEventManager.Size = new System.Drawing.Size(159, 56);
            this.btnEventManager.TabIndex = 2;
            this.btnEventManager.Text = "Event Manager";
            this.btnEventManager.UseVisualStyleBackColor = true;
            this.btnEventManager.Click += new System.EventHandler(this.btnEventManager_Click);
            // 
            // btnReports
            // 
            this.btnReports.Location = new System.Drawing.Point(317, 326);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(159, 56);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Location = new System.Drawing.Point(365, 66);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(72, 16);
            this.lblMainMenu.TabIndex = 4;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.btnEventManager);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnBookManager);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookManager;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnEventManager;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Label lblMainMenu;
    }
}

