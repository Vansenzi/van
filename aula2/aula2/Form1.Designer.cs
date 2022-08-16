namespace aula2
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
            this.btcalcular = new System.Windows.Forms.Button();
            this.btlimpar = new System.Windows.Forms.Button();
            this.lblbase = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btcalcular
            // 
            this.btcalcular.BackColor = System.Drawing.SystemColors.MenuText;
            this.btcalcular.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btcalcular.Location = new System.Drawing.Point(228, 285);
            this.btcalcular.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btcalcular.Name = "btcalcular";
            this.btcalcular.Size = new System.Drawing.Size(185, 70);
            this.btcalcular.TabIndex = 0;
            this.btcalcular.Text = "Calcular";
            this.btcalcular.UseVisualStyleBackColor = false;
            this.btcalcular.Click += new System.EventHandler(this.Btcalcular_Click);
            // 
            // btlimpar
            // 
            this.btlimpar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btlimpar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btlimpar.Location = new System.Drawing.Point(530, 285);
            this.btlimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(196, 70);
            this.btlimpar.TabIndex = 1;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = false;
            this.btlimpar.Click += new System.EventHandler(this.Btlimpar_Click);
            // 
            // lblbase
            // 
            this.lblbase.AutoSize = true;
            this.lblbase.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblbase.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbase.Location = new System.Drawing.Point(27, 85);
            this.lblbase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbase.Name = "lblbase";
            this.lblbase.Size = new System.Drawing.Size(147, 22);
            this.lblbase.TabIndex = 2;
            this.lblbase.Text = "Informe a base";
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblaltura.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaltura.Location = new System.Drawing.Point(27, 149);
            this.lblaltura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(155, 22);
            this.lblaltura.TabIndex = 3;
            this.lblaltura.Text = "Informe a altura";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblarea.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(27, 205);
            this.lblarea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(170, 22);
            this.lblarea.TabIndex = 4;
            this.lblarea.Text = "Área do triângulo";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(228, 201);
            this.txtarea.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(498, 29);
            this.txtarea.TabIndex = 5;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(228, 145);
            this.txtaltura.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(498, 29);
            this.txtaltura.TabIndex = 6;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(228, 81);
            this.txtbase.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(498, 29);
            this.txtbase.TabIndex = 7;
            this.txtbase.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(807, 439);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblbase);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.btcalcular);
            this.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcalcular;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Label lblbase;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.TextBox txtbase;
    }
}

