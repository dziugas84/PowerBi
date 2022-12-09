
namespace PowerBi
{
    partial class CreatedClosedForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.Export = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "To:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "From:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_to
            // 
            this.txt_to.Location = new System.Drawing.Point(12, 76);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(193, 20);
            this.txt_to.TabIndex = 9;
            this.txt_to.TextChanged += new System.EventHandler(this.txt_to_TextChanged);
            // 
            // txt_from
            // 
            this.txt_from.Location = new System.Drawing.Point(12, 28);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(193, 20);
            this.txt_from.TabIndex = 8;
            this.txt_from.TextChanged += new System.EventHandler(this.txt_from_TextChanged);
            // 
            // Export
            // 
            this.Export.Location = new System.Drawing.Point(130, 125);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(75, 23);
            this.Export.TabIndex = 7;
            this.Export.Text = "Export";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(12, 125);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 6;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // CreatedClosedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 160);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Back);
            this.Name = "CreatedClosedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreatedClosedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_to;
        private System.Windows.Forms.TextBox txt_from;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button Back;
    }
}