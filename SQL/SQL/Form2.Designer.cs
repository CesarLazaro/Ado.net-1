namespace SQL
{
    partial class Form2
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
            this.BD = new System.Windows.Forms.ListBox();
            this.Tables = new System.Windows.Forms.ListBox();
            this.Views = new System.Windows.Forms.ListBox();
            this.SPs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BD
            // 
            this.BD.FormattingEnabled = true;
            this.BD.Location = new System.Drawing.Point(12, 64);
            this.BD.Name = "BD";
            this.BD.Size = new System.Drawing.Size(126, 186);
            this.BD.TabIndex = 0;
            this.BD.SelectedIndexChanged += new System.EventHandler(this.BD_SelectedIndexChanged);
            // 
            // Tables
            // 
            this.Tables.FormattingEnabled = true;
            this.Tables.Location = new System.Drawing.Point(178, 64);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(126, 186);
            this.Tables.TabIndex = 1;
            // 
            // Views
            // 
            this.Views.FormattingEnabled = true;
            this.Views.Location = new System.Drawing.Point(352, 64);
            this.Views.Name = "Views";
            this.Views.Size = new System.Drawing.Size(126, 186);
            this.Views.TabIndex = 2;
            // 
            // SPs
            // 
            this.SPs.FormattingEnabled = true;
            this.SPs.Location = new System.Drawing.Point(563, 64);
            this.SPs.Name = "SPs";
            this.SPs.Size = new System.Drawing.Size(126, 186);
            this.SPs.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "BD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "TABLES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "VIEWS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "SPs";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SPs);
            this.Controls.Add(this.Views);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.BD);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox BD;
        private System.Windows.Forms.ListBox Tables;
        private System.Windows.Forms.ListBox Views;
        private System.Windows.Forms.ListBox SPs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}