
namespace PowerBi
{
    partial class MenuForm
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
            this.Performance = new System.Windows.Forms.Button();
            this.SLA = new System.Windows.Forms.Button();
            this.Outstanding = new System.Windows.Forms.Button();
            this.Outstanding2 = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Button();
            this.CreatedClosed = new System.Windows.Forms.Button();
            this.CreatedClosed2 = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Performance
            // 
            this.Performance.Location = new System.Drawing.Point(38, 28);
            this.Performance.Name = "Performance";
            this.Performance.Size = new System.Drawing.Size(116, 56);
            this.Performance.TabIndex = 0;
            this.Performance.Text = "Performance";
            this.Performance.UseVisualStyleBackColor = true;
            this.Performance.Click += new System.EventHandler(this.Performance_Click);
            // 
            // SLA
            // 
            this.SLA.Location = new System.Drawing.Point(179, 28);
            this.SLA.Name = "SLA";
            this.SLA.Size = new System.Drawing.Size(116, 56);
            this.SLA.TabIndex = 1;
            this.SLA.Text = "SLA";
            this.SLA.UseVisualStyleBackColor = true;
            this.SLA.Click += new System.EventHandler(this.SLA_Click);
            // 
            // Outstanding
            // 
            this.Outstanding.Location = new System.Drawing.Point(38, 100);
            this.Outstanding.Name = "Outstanding";
            this.Outstanding.Size = new System.Drawing.Size(116, 56);
            this.Outstanding.TabIndex = 2;
            this.Outstanding.Text = "Outstanding";
            this.Outstanding.UseVisualStyleBackColor = true;
            this.Outstanding.Click += new System.EventHandler(this.Outstanding_Click);
            // 
            // Outstanding2
            // 
            this.Outstanding2.Location = new System.Drawing.Point(179, 100);
            this.Outstanding2.Name = "Outstanding2";
            this.Outstanding2.Size = new System.Drawing.Size(116, 56);
            this.Outstanding2.TabIndex = 3;
            this.Outstanding2.Text = "Outstanding2";
            this.Outstanding2.UseVisualStyleBackColor = true;
            this.Outstanding2.Click += new System.EventHandler(this.Outstanding2_Click);
            // 
            // Top
            // 
            this.Top.Location = new System.Drawing.Point(38, 174);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(116, 56);
            this.Top.TabIndex = 4;
            this.Top.Text = "Top";
            this.Top.UseVisualStyleBackColor = true;
            this.Top.Click += new System.EventHandler(this.Top_Click);
            // 
            // CreatedClosed
            // 
            this.CreatedClosed.Location = new System.Drawing.Point(179, 174);
            this.CreatedClosed.Name = "CreatedClosed";
            this.CreatedClosed.Size = new System.Drawing.Size(116, 56);
            this.CreatedClosed.TabIndex = 5;
            this.CreatedClosed.Text = "Created/Closed";
            this.CreatedClosed.UseVisualStyleBackColor = true;
            this.CreatedClosed.Click += new System.EventHandler(this.CreatedClosed_Click);
            // 
            // CreatedClosed2
            // 
            this.CreatedClosed2.Location = new System.Drawing.Point(38, 248);
            this.CreatedClosed2.Name = "CreatedClosed2";
            this.CreatedClosed2.Size = new System.Drawing.Size(116, 56);
            this.CreatedClosed2.TabIndex = 6;
            this.CreatedClosed2.Text = "Created/Closed2";
            this.CreatedClosed2.UseVisualStyleBackColor = true;
            this.CreatedClosed2.Click += new System.EventHandler(this.CreatedClosed2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(179, 248);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 56);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 342);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CreatedClosed2);
            this.Controls.Add(this.CreatedClosed);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Outstanding2);
            this.Controls.Add(this.Outstanding);
            this.Controls.Add(this.SLA);
            this.Controls.Add(this.Performance);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Performance;
        private System.Windows.Forms.Button SLA;
        private System.Windows.Forms.Button Outstanding;
        private System.Windows.Forms.Button Outstanding2;
        private System.Windows.Forms.Button Top;
        private System.Windows.Forms.Button CreatedClosed;
        private System.Windows.Forms.Button CreatedClosed2;
        private System.Windows.Forms.Button Exit;
    }
}