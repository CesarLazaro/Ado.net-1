namespace SQL
{
    partial class Form1
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAll = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tablas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.Enabled = false;
            this.btnAll.Location = new System.Drawing.Point(705, 197);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(106, 47);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "MOSTRAR TABLA COMPLETA";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 222);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(583, 197);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 47);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "MOSTRAR TABLA POR ID";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(642, 160);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(116, 20);
            this.txt.TabIndex = 3;
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "INSERTE ID A BUSCAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tablas
            // 
            this.Tablas.FormattingEnabled = true;
            this.Tablas.Location = new System.Drawing.Point(690, 57);
            this.Tablas.Name = "Tablas";
            this.Tablas.Size = new System.Drawing.Size(121, 21);
            this.Tablas.TabIndex = 5;
            this.Tablas.SelectedIndexChanged += new System.EventHandler(this.Tablas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SELECIONE TABLA";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(705, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Soy un boton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAll);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Tablas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

