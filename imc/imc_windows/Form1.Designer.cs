namespace imc_windows
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelnome = new System.Windows.Forms.Label();
            this.labelidade = new System.Windows.Forms.Label();
            this.labelpeso = new System.Windows.Forms.Label();
            this.labelaltura = new System.Windows.Forms.Label();
            this.textBoxNOME = new System.Windows.Forms.TextBox();
            this.textBoxPESO = new System.Windows.Forms.TextBox();
            this.textBoxIDADE = new System.Windows.Forms.TextBox();
            this.textBoxALTURA = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(13, 36);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(142, 18);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "qual o seu nome?";
            // 
            // labelidade
            // 
            this.labelidade.AutoSize = true;
            this.labelidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidade.Location = new System.Drawing.Point(14, 99);
            this.labelidade.Name = "labelidade";
            this.labelidade.Size = new System.Drawing.Size(139, 18);
            this.labelidade.TabIndex = 1;
            this.labelidade.Text = "qual a sua idade?";
            // 
            // labelpeso
            // 
            this.labelpeso.AutoSize = true;
            this.labelpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpeso.Location = new System.Drawing.Point(466, 36);
            this.labelpeso.Name = "labelpeso";
            this.labelpeso.Size = new System.Drawing.Size(137, 18);
            this.labelpeso.TabIndex = 2;
            this.labelpeso.Text = "qual o seu peso?";
            // 
            // labelaltura
            // 
            this.labelaltura.AutoSize = true;
            this.labelaltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelaltura.Location = new System.Drawing.Point(469, 103);
            this.labelaltura.Name = "labelaltura";
            this.labelaltura.Size = new System.Drawing.Size(141, 18);
            this.labelaltura.TabIndex = 3;
            this.labelaltura.Text = "qual a sua altura?";
            // 
            // textBoxNOME
            // 
            this.textBoxNOME.Location = new System.Drawing.Point(16, 67);
            this.textBoxNOME.Name = "textBoxNOME";
            this.textBoxNOME.Size = new System.Drawing.Size(246, 20);
            this.textBoxNOME.TabIndex = 4;
            // 
            // textBoxPESO
            // 
            this.textBoxPESO.Location = new System.Drawing.Point(469, 66);
            this.textBoxPESO.Name = "textBoxPESO";
            this.textBoxPESO.Size = new System.Drawing.Size(198, 20);
            this.textBoxPESO.TabIndex = 5;
            // 
            // textBoxIDADE
            // 
            this.textBoxIDADE.Location = new System.Drawing.Point(13, 138);
            this.textBoxIDADE.Name = "textBoxIDADE";
            this.textBoxIDADE.Size = new System.Drawing.Size(249, 20);
            this.textBoxIDADE.TabIndex = 6;
            // 
            // textBoxALTURA
            // 
            this.textBoxALTURA.Location = new System.Drawing.Point(472, 138);
            this.textBoxALTURA.Name = "textBoxALTURA";
            this.textBoxALTURA.Size = new System.Drawing.Size(195, 20);
            this.textBoxALTURA.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(17, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(525, 186);
            this.listBox1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(596, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 54);
            this.button1.TabIndex = 11;
            this.button1.Text = "resultado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(593, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "calculo do IMC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxALTURA);
            this.Controls.Add(this.textBoxIDADE);
            this.Controls.Add(this.textBoxPESO);
            this.Controls.Add(this.textBoxNOME);
            this.Controls.Add(this.labelaltura);
            this.Controls.Add(this.labelpeso);
            this.Controls.Add(this.labelidade);
            this.Controls.Add(this.labelnome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelidade;
        private System.Windows.Forms.Label labelpeso;
        private System.Windows.Forms.Label labelaltura;
        private System.Windows.Forms.TextBox textBoxNOME;
        private System.Windows.Forms.TextBox textBoxPESO;
        private System.Windows.Forms.TextBox textBoxIDADE;
        private System.Windows.Forms.TextBox textBoxALTURA;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

