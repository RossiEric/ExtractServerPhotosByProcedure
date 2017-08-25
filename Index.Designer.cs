namespace ExtractServerPhotosWithProcedure
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.show_contador = new System.Windows.Forms.Label();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_proc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_caminho_local = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkTeste = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Teste Conexao";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Executar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(946, 262);
            this.textBox1.TabIndex = 2;
            // 
            // show_contador
            // 
            this.show_contador.AutoSize = true;
            this.show_contador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_contador.Location = new System.Drawing.Point(293, 147);
            this.show_contador.Name = "show_contador";
            this.show_contador.Size = new System.Drawing.Size(18, 20);
            this.show_contador.TabIndex = 3;
            this.show_contador.Text = "_";
            // 
            // tb_url
            // 
            this.tb_url.AccessibleName = "";
            this.tb_url.Location = new System.Drawing.Point(111, 16);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(461, 20);
            this.tb_url.TabIndex = 5;
            this.tb_url.Text = "http://seudominio.com.br/";
            // 
            // tb_proc
            // 
            this.tb_proc.AccessibleName = "";
            this.tb_proc.Location = new System.Drawing.Point(111, 52);
            this.tb_proc.Name = "tb_proc";
            this.tb_proc.Size = new System.Drawing.Size(461, 20);
            this.tb_proc.TabIndex = 6;
            this.tb_proc.Text = "sp_procedure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "URL:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "PROC:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Salvar em:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_caminho_local
            // 
            this.tb_caminho_local.AccessibleName = "";
            this.tb_caminho_local.Location = new System.Drawing.Point(111, 88);
            this.tb_caminho_local.Name = "tb_caminho_local";
            this.tb_caminho_local.Size = new System.Drawing.Size(461, 20);
            this.tb_caminho_local.TabIndex = 10;
            this.tb_caminho_local.Text = "c:\\BKPautomatico\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(575, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ex. \"http://dominio.com\" - sem barra no final";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "ex. \"sp_procedure_\"";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(248, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "ex. \"c:\\pasta\\pasta\\\" SEMPRE teminar com barra.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(882, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkTeste
            // 
            this.checkTeste.AutoSize = true;
            this.checkTeste.Location = new System.Drawing.Point(12, 121);
            this.checkTeste.Name = "checkTeste";
            this.checkTeste.Size = new System.Drawing.Size(187, 17);
            this.checkTeste.TabIndex = 15;
            this.checkTeste.Text = "Testar primeiras 10 linhas e parar?";
            this.checkTeste.UseVisualStyleBackColor = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 447);
            this.Controls.Add(this.checkTeste);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_caminho_local);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_proc);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.show_contador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Index";
            this.Text = "ProcAnt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label show_contador;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_proc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_caminho_local;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkTeste;
    }
}

