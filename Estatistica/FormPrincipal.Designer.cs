namespace Estatistica
{
    partial class FormPrincipal
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
            this.lbNumeroInteiro = new System.Windows.Forms.Label();
            this.tbNumero = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lvNumeros = new System.Windows.Forms.ListView();
            this.gbNumerosDigitados = new System.Windows.Forms.GroupBox();
            this.btnGerarRol = new System.Windows.Forms.Button();
            this.gbRol = new System.Windows.Forms.GroupBox();
            this.lvNumerosRol = new System.Windows.Forms.ListView();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbMedia = new System.Windows.Forms.Label();
            this.lbModa = new System.Windows.Forms.Label();
            this.lbMediana = new System.Windows.Forms.Label();
            this.lbMaiorNumero = new System.Windows.Forms.Label();
            this.lbMenorNumero = new System.Windows.Forms.Label();
            this.lbVariancia = new System.Windows.Forms.Label();
            this.lbDesvioPadrao = new System.Windows.Forms.Label();
            this.lbModaDePearson = new System.Windows.Forms.Label();
            this.lbMediaResult = new System.Windows.Forms.Label();
            this.lbModaResult = new System.Windows.Forms.Label();
            this.lbModaPearsonResult = new System.Windows.Forms.Label();
            this.lbMedianaResult = new System.Windows.Forms.Label();
            this.lbMaiorNumeroResult = new System.Windows.Forms.Label();
            this.lbMenorNumeroResult = new System.Windows.Forms.Label();
            this.lbVarianciaResult = new System.Windows.Forms.Label();
            this.lbDesvioPadraoResult = new System.Windows.Forms.Label();
            this.gbNumerosDigitados.SuspendLayout();
            this.gbRol.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNumeroInteiro
            // 
            this.lbNumeroInteiro.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbNumeroInteiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroInteiro.Location = new System.Drawing.Point(20, 17);
            this.lbNumeroInteiro.Name = "lbNumeroInteiro";
            this.lbNumeroInteiro.Size = new System.Drawing.Size(77, 20);
            this.lbNumeroInteiro.TabIndex = 0;
            this.lbNumeroInteiro.Text = "Número inteiro";
            // 
            // tbNumero
            // 
            this.tbNumero.AcceptsReturn = true;
            this.tbNumero.AllowDrop = true;
            this.tbNumero.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbNumero.Location = new System.Drawing.Point(103, 15);
            this.tbNumero.Name = "tbNumero";
            this.tbNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNumero.Size = new System.Drawing.Size(70, 20);
            this.tbNumero.TabIndex = 1;
            this.tbNumero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNumero_KeyDown);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdicionar.Location = new System.Drawing.Point(290, 15);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(159, 23);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lvNumeros
            // 
            this.lvNumeros.HideSelection = false;
            this.lvNumeros.Location = new System.Drawing.Point(28, 19);
            this.lvNumeros.Name = "lvNumeros";
            this.lvNumeros.Size = new System.Drawing.Size(270, 65);
            this.lvNumeros.TabIndex = 0;
            this.lvNumeros.TabStop = false;
            this.lvNumeros.UseCompatibleStateImageBehavior = false;
            // 
            // gbNumerosDigitados
            // 
            this.gbNumerosDigitados.BackColor = System.Drawing.SystemColors.Control;
            this.gbNumerosDigitados.Controls.Add(this.btnGerarRol);
            this.gbNumerosDigitados.Controls.Add(this.lvNumeros);
            this.gbNumerosDigitados.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbNumerosDigitados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbNumerosDigitados.Location = new System.Drawing.Point(23, 50);
            this.gbNumerosDigitados.Name = "gbNumerosDigitados";
            this.gbNumerosDigitados.Padding = new System.Windows.Forms.Padding(4);
            this.gbNumerosDigitados.Size = new System.Drawing.Size(428, 99);
            this.gbNumerosDigitados.TabIndex = 3;
            this.gbNumerosDigitados.TabStop = false;
            this.gbNumerosDigitados.Text = "Números digitados";
            this.gbNumerosDigitados.UseCompatibleTextRendering = true;
            // 
            // btnGerarRol
            // 
            this.btnGerarRol.Location = new System.Drawing.Point(323, 61);
            this.btnGerarRol.Name = "btnGerarRol";
            this.btnGerarRol.Size = new System.Drawing.Size(75, 23);
            this.btnGerarRol.TabIndex = 1;
            this.btnGerarRol.Text = "Gerar Rol";
            this.btnGerarRol.UseVisualStyleBackColor = true;
            this.btnGerarRol.Click += new System.EventHandler(this.btnGerarRol_Click);
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.lvNumerosRol);
            this.gbRol.Location = new System.Drawing.Point(23, 155);
            this.gbRol.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbRol.Name = "gbRol";
            this.gbRol.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gbRol.Size = new System.Drawing.Size(428, 100);
            this.gbRol.TabIndex = 4;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol dos números";
            // 
            // lvNumerosRol
            // 
            this.lvNumerosRol.HideSelection = false;
            this.lvNumerosRol.Location = new System.Drawing.Point(28, 19);
            this.lvNumerosRol.Name = "lvNumerosRol";
            this.lvNumerosRol.Size = new System.Drawing.Size(270, 65);
            this.lvNumerosRol.TabIndex = 0;
            this.lvNumerosRol.TabStop = false;
            this.lvNumerosRol.UseCompatibleStateImageBehavior = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(266, 261);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(185, 30);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbMedia
            // 
            this.lbMedia.Location = new System.Drawing.Point(26, 317);
            this.lbMedia.Name = "lbMedia";
            this.lbMedia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMedia.Size = new System.Drawing.Size(87, 13);
            this.lbMedia.TabIndex = 6;
            this.lbMedia.Text = "Média: ";
            this.lbMedia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModa
            // 
            this.lbModa.Location = new System.Drawing.Point(26, 343);
            this.lbModa.Name = "lbModa";
            this.lbModa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModa.Size = new System.Drawing.Size(87, 13);
            this.lbModa.TabIndex = 8;
            this.lbModa.Text = "Moda: ";
            this.lbModa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMediana
            // 
            this.lbMediana.Location = new System.Drawing.Point(20, 397);
            this.lbMediana.Name = "lbMediana";
            this.lbMediana.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMediana.Size = new System.Drawing.Size(87, 13);
            this.lbMediana.TabIndex = 12;
            this.lbMediana.Text = "Mediana: ";
            this.lbMediana.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMaiorNumero
            // 
            this.lbMaiorNumero.Location = new System.Drawing.Point(243, 317);
            this.lbMaiorNumero.Name = "lbMaiorNumero";
            this.lbMaiorNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMaiorNumero.Size = new System.Drawing.Size(87, 13);
            this.lbMaiorNumero.TabIndex = 14;
            this.lbMaiorNumero.Text = "Maior número:";
            this.lbMaiorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMenorNumero
            // 
            this.lbMenorNumero.Location = new System.Drawing.Point(243, 347);
            this.lbMenorNumero.Name = "lbMenorNumero";
            this.lbMenorNumero.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMenorNumero.Size = new System.Drawing.Size(87, 13);
            this.lbMenorNumero.TabIndex = 16;
            this.lbMenorNumero.Text = "Menor número: ";
            this.lbMenorNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbVariancia
            // 
            this.lbVariancia.Location = new System.Drawing.Point(243, 375);
            this.lbVariancia.Name = "lbVariancia";
            this.lbVariancia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbVariancia.Size = new System.Drawing.Size(87, 13);
            this.lbVariancia.TabIndex = 18;
            this.lbVariancia.Text = "Variância: ";
            this.lbVariancia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDesvioPadrao
            // 
            this.lbDesvioPadrao.Location = new System.Drawing.Point(243, 397);
            this.lbDesvioPadrao.Name = "lbDesvioPadrao";
            this.lbDesvioPadrao.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbDesvioPadrao.Size = new System.Drawing.Size(87, 13);
            this.lbDesvioPadrao.TabIndex = 20;
            this.lbDesvioPadrao.Text = "Desvio Padrão:";
            this.lbDesvioPadrao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModaDePearson
            // 
            this.lbModaDePearson.Location = new System.Drawing.Point(16, 371);
            this.lbModaDePearson.Name = "lbModaDePearson";
            this.lbModaDePearson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModaDePearson.Size = new System.Drawing.Size(97, 13);
            this.lbModaDePearson.TabIndex = 10;
            this.lbModaDePearson.Text = "Moda de Pearson: ";
            this.lbModaDePearson.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMediaResult
            // 
            this.lbMediaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMediaResult.Location = new System.Drawing.Point(119, 313);
            this.lbMediaResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbMediaResult.Name = "lbMediaResult";
            this.lbMediaResult.Size = new System.Drawing.Size(114, 21);
            this.lbMediaResult.TabIndex = 7;
            this.lbMediaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMediaResult.UseCompatibleTextRendering = true;
            // 
            // lbModaResult
            // 
            this.lbModaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbModaResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModaResult.Location = new System.Drawing.Point(119, 339);
            this.lbModaResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbModaResult.Name = "lbModaResult";
            this.lbModaResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbModaResult.Size = new System.Drawing.Size(114, 21);
            this.lbModaResult.TabIndex = 9;
            this.lbModaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbModaResult.UseMnemonic = false;
            // 
            // lbModaPearsonResult
            // 
            this.lbModaPearsonResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbModaPearsonResult.Location = new System.Drawing.Point(119, 366);
            this.lbModaPearsonResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbModaPearsonResult.Name = "lbModaPearsonResult";
            this.lbModaPearsonResult.Size = new System.Drawing.Size(114, 21);
            this.lbModaPearsonResult.TabIndex = 11;
            this.lbModaPearsonResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMedianaResult
            // 
            this.lbMedianaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMedianaResult.Location = new System.Drawing.Point(119, 393);
            this.lbMedianaResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbMedianaResult.Name = "lbMedianaResult";
            this.lbMedianaResult.Size = new System.Drawing.Size(114, 21);
            this.lbMedianaResult.TabIndex = 13;
            this.lbMedianaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMedianaResult.UseCompatibleTextRendering = true;
            // 
            // lbMaiorNumeroResult
            // 
            this.lbMaiorNumeroResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMaiorNumeroResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMaiorNumeroResult.Location = new System.Drawing.Point(336, 313);
            this.lbMaiorNumeroResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbMaiorNumeroResult.Name = "lbMaiorNumeroResult";
            this.lbMaiorNumeroResult.Size = new System.Drawing.Size(113, 21);
            this.lbMaiorNumeroResult.TabIndex = 15;
            this.lbMaiorNumeroResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbMenorNumeroResult
            // 
            this.lbMenorNumeroResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMenorNumeroResult.Location = new System.Drawing.Point(336, 339);
            this.lbMenorNumeroResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbMenorNumeroResult.Name = "lbMenorNumeroResult";
            this.lbMenorNumeroResult.Size = new System.Drawing.Size(113, 21);
            this.lbMenorNumeroResult.TabIndex = 17;
            this.lbMenorNumeroResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbMenorNumeroResult.UseCompatibleTextRendering = true;
            // 
            // lbVarianciaResult
            // 
            this.lbVarianciaResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbVarianciaResult.Location = new System.Drawing.Point(336, 367);
            this.lbVarianciaResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbVarianciaResult.Name = "lbVarianciaResult";
            this.lbVarianciaResult.Size = new System.Drawing.Size(113, 21);
            this.lbVarianciaResult.TabIndex = 19;
            this.lbVarianciaResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbVarianciaResult.UseCompatibleTextRendering = true;
            // 
            // lbDesvioPadraoResult
            // 
            this.lbDesvioPadraoResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDesvioPadraoResult.Location = new System.Drawing.Point(336, 393);
            this.lbDesvioPadraoResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbDesvioPadraoResult.Name = "lbDesvioPadraoResult";
            this.lbDesvioPadraoResult.Size = new System.Drawing.Size(113, 21);
            this.lbDesvioPadraoResult.TabIndex = 21;
            this.lbDesvioPadraoResult.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbDesvioPadraoResult.UseCompatibleTextRendering = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 447);
            this.Controls.Add(this.lbDesvioPadraoResult);
            this.Controls.Add(this.lbVarianciaResult);
            this.Controls.Add(this.lbMenorNumeroResult);
            this.Controls.Add(this.lbMaiorNumeroResult);
            this.Controls.Add(this.lbMedianaResult);
            this.Controls.Add(this.lbModaPearsonResult);
            this.Controls.Add(this.lbModaResult);
            this.Controls.Add(this.lbMediaResult);
            this.Controls.Add(this.lbModaDePearson);
            this.Controls.Add(this.lbDesvioPadrao);
            this.Controls.Add(this.lbVariancia);
            this.Controls.Add(this.lbMenorNumero);
            this.Controls.Add(this.lbMaiorNumero);
            this.Controls.Add(this.lbMediana);
            this.Controls.Add(this.lbModa);
            this.Controls.Add(this.lbMedia);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gbRol);
            this.Controls.Add(this.gbNumerosDigitados);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.tbNumero);
            this.Controls.Add(this.lbNumeroInteiro);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(489, 486);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(489, 486);
            this.Name = "FormPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estatística";
            this.gbNumerosDigitados.ResumeLayout(false);
            this.gbRol.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumeroInteiro;
        private System.Windows.Forms.TextBox tbNumero;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView lvNumeros;
        private System.Windows.Forms.GroupBox gbNumerosDigitados;
        private System.Windows.Forms.Button btnGerarRol;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.ListView lvNumerosRol;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lbMedia;
        private System.Windows.Forms.Label lbModa;
        private System.Windows.Forms.Label lbMediana;
        private System.Windows.Forms.Label lbMaiorNumero;
        private System.Windows.Forms.Label lbMenorNumero;
        private System.Windows.Forms.Label lbVariancia;
        private System.Windows.Forms.Label lbDesvioPadrao;
        private System.Windows.Forms.Label lbModaDePearson;
        private System.Windows.Forms.Label lbMediaResult;
        private System.Windows.Forms.Label lbModaResult;
        private System.Windows.Forms.Label lbModaPearsonResult;
        private System.Windows.Forms.Label lbMedianaResult;
        private System.Windows.Forms.Label lbMaiorNumeroResult;
        private System.Windows.Forms.Label lbMenorNumeroResult;
        private System.Windows.Forms.Label lbVarianciaResult;
        private System.Windows.Forms.Label lbDesvioPadraoResult;
    }
}

