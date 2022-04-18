namespace Mia_Calculadora
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
            this.textoperacao = new System.Windows.Forms.TextBox();
            this.bot_adi = new System.Windows.Forms.Button();
            this.bot_Pot = new System.Windows.Forms.Button();
            this.bot_Porc = new System.Windows.Forms.Button();
            this.bot_Raiz = new System.Windows.Forms.Button();
            this.bot_Arredondar = new System.Windows.Forms.Button();
            this.bot_Sub = new System.Windows.Forms.Button();
            this.bot_Result = new System.Windows.Forms.Button();
            this.bot_Caract = new System.Windows.Forms.Button();
            this.bot_0 = new System.Windows.Forms.Button();
            this.bot_Mult = new System.Windows.Forms.Button();
            this.bot_9 = new System.Windows.Forms.Button();
            this.bot_8 = new System.Windows.Forms.Button();
            this.bot_7 = new System.Windows.Forms.Button();
            this.bot_Div = new System.Windows.Forms.Button();
            this.bot_6 = new System.Windows.Forms.Button();
            this.bot_5 = new System.Windows.Forms.Button();
            this.bot_4 = new System.Windows.Forms.Button();
            this.bot_Del = new System.Windows.Forms.Button();
            this.bot_3 = new System.Windows.Forms.Button();
            this.bot_2 = new System.Windows.Forms.Button();
            this.bot_1 = new System.Windows.Forms.Button();
            this.textresultado = new System.Windows.Forms.TextBox();
            this.textcalculo = new System.Windows.Forms.TextBox();
            this.bot_ArreCima = new System.Windows.Forms.Button();
            this.bot_Apagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoperacao
            // 
            this.textoperacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textoperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textoperacao.ForeColor = System.Drawing.Color.White;
            this.textoperacao.Location = new System.Drawing.Point(177, -43);
            this.textoperacao.MaxLength = 31767;
            this.textoperacao.Name = "textoperacao";
            this.textoperacao.Size = new System.Drawing.Size(447, 26);
            this.textoperacao.TabIndex = 75;
            this.textoperacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bot_adi
            // 
            this.bot_adi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bot_adi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bot_adi.Location = new System.Drawing.Point(293, 437);
            this.bot_adi.Margin = new System.Windows.Forms.Padding(2);
            this.bot_adi.Name = "bot_adi";
            this.bot_adi.Size = new System.Drawing.Size(96, 80);
            this.bot_adi.TabIndex = 74;
            this.bot_adi.Text = "+";
            this.bot_adi.UseVisualStyleBackColor = false;
            this.bot_adi.Click += new System.EventHandler(this.bot_adi_Click);
            // 
            // bot_Pot
            // 
            this.bot_Pot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Pot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bot_Pot.ForeColor = System.Drawing.Color.White;
            this.bot_Pot.Location = new System.Drawing.Point(389, 355);
            this.bot_Pot.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Pot.Name = "bot_Pot";
            this.bot_Pot.Size = new System.Drawing.Size(95, 80);
            this.bot_Pot.TabIndex = 73;
            this.bot_Pot.Text = "xⁿ";
            this.bot_Pot.UseVisualStyleBackColor = false;
            this.bot_Pot.Click += new System.EventHandler(this.bot_Pot_Click);
            // 
            // bot_Porc
            // 
            this.bot_Porc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Porc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bot_Porc.ForeColor = System.Drawing.Color.White;
            this.bot_Porc.Location = new System.Drawing.Point(389, 275);
            this.bot_Porc.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Porc.Name = "bot_Porc";
            this.bot_Porc.Size = new System.Drawing.Size(95, 80);
            this.bot_Porc.TabIndex = 72;
            this.bot_Porc.Text = "%";
            this.bot_Porc.UseVisualStyleBackColor = false;
            this.bot_Porc.Click += new System.EventHandler(this.bot_Porc_Click);
            // 
            // bot_Raiz
            // 
            this.bot_Raiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Raiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.bot_Raiz.ForeColor = System.Drawing.Color.White;
            this.bot_Raiz.Location = new System.Drawing.Point(389, 194);
            this.bot_Raiz.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Raiz.Name = "bot_Raiz";
            this.bot_Raiz.Size = new System.Drawing.Size(95, 80);
            this.bot_Raiz.TabIndex = 70;
            this.bot_Raiz.Text = "√";
            this.bot_Raiz.UseVisualStyleBackColor = false;
            this.bot_Raiz.Click += new System.EventHandler(this.bot_Raiz_Click);
            // 
            // bot_Arredondar
            // 
            this.bot_Arredondar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Arredondar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bot_Arredondar.ForeColor = System.Drawing.Color.White;
            this.bot_Arredondar.Location = new System.Drawing.Point(292, 113);
            this.bot_Arredondar.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Arredondar.Name = "bot_Arredondar";
            this.bot_Arredondar.Size = new System.Drawing.Size(97, 80);
            this.bot_Arredondar.TabIndex = 69;
            this.bot_Arredondar.Text = "ARRE ";
            this.bot_Arredondar.UseVisualStyleBackColor = false;
            this.bot_Arredondar.Click += new System.EventHandler(this.bot_Arredondar_Click);
            // 
            // bot_Sub
            // 
            this.bot_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bot_Sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_Sub.Location = new System.Drawing.Point(293, 356);
            this.bot_Sub.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Sub.Name = "bot_Sub";
            this.bot_Sub.Size = new System.Drawing.Size(96, 80);
            this.bot_Sub.TabIndex = 67;
            this.bot_Sub.Text = "-";
            this.bot_Sub.UseVisualStyleBackColor = false;
            this.bot_Sub.Click += new System.EventHandler(this.bot_Sub_Click);
            // 
            // bot_Result
            // 
            this.bot_Result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bot_Result.ForeColor = System.Drawing.Color.White;
            this.bot_Result.Location = new System.Drawing.Point(389, 437);
            this.bot_Result.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Result.Name = "bot_Result";
            this.bot_Result.Size = new System.Drawing.Size(95, 80);
            this.bot_Result.TabIndex = 66;
            this.bot_Result.Text = "=";
            this.bot_Result.UseVisualStyleBackColor = false;
            this.bot_Result.Click += new System.EventHandler(this.bot_Result_Click);
            // 
            // bot_Caract
            // 
            this.bot_Caract.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_Caract.Location = new System.Drawing.Point(195, 437);
            this.bot_Caract.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Caract.Name = "bot_Caract";
            this.bot_Caract.Size = new System.Drawing.Size(97, 80);
            this.bot_Caract.TabIndex = 65;
            this.bot_Caract.Text = ",";
            this.bot_Caract.UseVisualStyleBackColor = true;
            this.bot_Caract.Click += new System.EventHandler(this.bot_Caract_Click);
            // 
            // bot_0
            // 
            this.bot_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_0.Location = new System.Drawing.Point(2, 437);
            this.bot_0.Margin = new System.Windows.Forms.Padding(2);
            this.bot_0.Name = "bot_0";
            this.bot_0.Size = new System.Drawing.Size(192, 80);
            this.bot_0.TabIndex = 64;
            this.bot_0.Text = "0";
            this.bot_0.UseVisualStyleBackColor = true;
            this.bot_0.Click += new System.EventHandler(this.bot_0_Click);
            // 
            // bot_Mult
            // 
            this.bot_Mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bot_Mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bot_Mult.Location = new System.Drawing.Point(293, 275);
            this.bot_Mult.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Mult.Name = "bot_Mult";
            this.bot_Mult.Size = new System.Drawing.Size(96, 80);
            this.bot_Mult.TabIndex = 63;
            this.bot_Mult.Text = "x";
            this.bot_Mult.UseVisualStyleBackColor = false;
            this.bot_Mult.Click += new System.EventHandler(this.bot_Mult_Click);
            // 
            // bot_9
            // 
            this.bot_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_9.Location = new System.Drawing.Point(195, 356);
            this.bot_9.Margin = new System.Windows.Forms.Padding(2);
            this.bot_9.Name = "bot_9";
            this.bot_9.Size = new System.Drawing.Size(97, 80);
            this.bot_9.TabIndex = 62;
            this.bot_9.Text = "9";
            this.bot_9.UseVisualStyleBackColor = true;
            this.bot_9.Click += new System.EventHandler(this.bot_9_Click);
            // 
            // bot_8
            // 
            this.bot_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_8.Location = new System.Drawing.Point(99, 356);
            this.bot_8.Margin = new System.Windows.Forms.Padding(2);
            this.bot_8.Name = "bot_8";
            this.bot_8.Size = new System.Drawing.Size(95, 80);
            this.bot_8.TabIndex = 61;
            this.bot_8.Text = "8";
            this.bot_8.UseVisualStyleBackColor = true;
            this.bot_8.Click += new System.EventHandler(this.bot_8_Click);
            // 
            // bot_7
            // 
            this.bot_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_7.Location = new System.Drawing.Point(2, 356);
            this.bot_7.Margin = new System.Windows.Forms.Padding(2);
            this.bot_7.Name = "bot_7";
            this.bot_7.Size = new System.Drawing.Size(95, 80);
            this.bot_7.TabIndex = 60;
            this.bot_7.Text = "7";
            this.bot_7.UseVisualStyleBackColor = true;
            this.bot_7.Click += new System.EventHandler(this.bot_7_Click);
            // 
            // bot_Div
            // 
            this.bot_Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bot_Div.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_Div.Location = new System.Drawing.Point(293, 194);
            this.bot_Div.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Div.Name = "bot_Div";
            this.bot_Div.Size = new System.Drawing.Size(95, 80);
            this.bot_Div.TabIndex = 59;
            this.bot_Div.Text = "÷";
            this.bot_Div.UseVisualStyleBackColor = false;
            this.bot_Div.Click += new System.EventHandler(this.bot_Div_Click);
            // 
            // bot_6
            // 
            this.bot_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_6.Location = new System.Drawing.Point(195, 275);
            this.bot_6.Margin = new System.Windows.Forms.Padding(2);
            this.bot_6.Name = "bot_6";
            this.bot_6.Size = new System.Drawing.Size(97, 80);
            this.bot_6.TabIndex = 58;
            this.bot_6.Text = "6";
            this.bot_6.UseVisualStyleBackColor = true;
            this.bot_6.Click += new System.EventHandler(this.bot_6_Click);
            // 
            // bot_5
            // 
            this.bot_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_5.Location = new System.Drawing.Point(99, 275);
            this.bot_5.Margin = new System.Windows.Forms.Padding(2);
            this.bot_5.Name = "bot_5";
            this.bot_5.Size = new System.Drawing.Size(95, 80);
            this.bot_5.TabIndex = 57;
            this.bot_5.Text = "5";
            this.bot_5.UseVisualStyleBackColor = true;
            this.bot_5.Click += new System.EventHandler(this.bot_5_Click);
            // 
            // bot_4
            // 
            this.bot_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_4.Location = new System.Drawing.Point(2, 275);
            this.bot_4.Margin = new System.Windows.Forms.Padding(2);
            this.bot_4.Name = "bot_4";
            this.bot_4.Size = new System.Drawing.Size(95, 80);
            this.bot_4.TabIndex = 56;
            this.bot_4.Text = "4";
            this.bot_4.UseVisualStyleBackColor = true;
            this.bot_4.Click += new System.EventHandler(this.bot_4_Click);
            // 
            // bot_Del
            // 
            this.bot_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Del.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bot_Del.ForeColor = System.Drawing.Color.White;
            this.bot_Del.Location = new System.Drawing.Point(3, 113);
            this.bot_Del.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Del.Name = "bot_Del";
            this.bot_Del.Size = new System.Drawing.Size(191, 80);
            this.bot_Del.TabIndex = 55;
            this.bot_Del.Text = "DEL";
            this.bot_Del.UseVisualStyleBackColor = false;
            this.bot_Del.Click += new System.EventHandler(this.bot_Del_Click);
            // 
            // bot_3
            // 
            this.bot_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_3.Location = new System.Drawing.Point(195, 194);
            this.bot_3.Margin = new System.Windows.Forms.Padding(2);
            this.bot_3.Name = "bot_3";
            this.bot_3.Size = new System.Drawing.Size(97, 80);
            this.bot_3.TabIndex = 54;
            this.bot_3.Text = "3";
            this.bot_3.UseVisualStyleBackColor = true;
            this.bot_3.Click += new System.EventHandler(this.bot_3_Click);
            // 
            // bot_2
            // 
            this.bot_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_2.Location = new System.Drawing.Point(99, 194);
            this.bot_2.Margin = new System.Windows.Forms.Padding(2);
            this.bot_2.Name = "bot_2";
            this.bot_2.Size = new System.Drawing.Size(95, 80);
            this.bot_2.TabIndex = 53;
            this.bot_2.Text = "2";
            this.bot_2.UseVisualStyleBackColor = true;
            this.bot_2.Click += new System.EventHandler(this.bot_2_Click);
            // 
            // bot_1
            // 
            this.bot_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_1.Location = new System.Drawing.Point(2, 194);
            this.bot_1.Margin = new System.Windows.Forms.Padding(2);
            this.bot_1.Name = "bot_1";
            this.bot_1.Size = new System.Drawing.Size(95, 80);
            this.bot_1.TabIndex = 52;
            this.bot_1.Text = "1";
            this.bot_1.UseVisualStyleBackColor = true;
            this.bot_1.Click += new System.EventHandler(this.bot_1_Click);
            // 
            // textresultado
            // 
            this.textresultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textresultado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.textresultado.ForeColor = System.Drawing.Color.White;
            this.textresultado.Location = new System.Drawing.Point(-2, 36);
            this.textresultado.MaxLength = 31767;
            this.textresultado.Name = "textresultado";
            this.textresultado.Size = new System.Drawing.Size(488, 76);
            this.textresultado.TabIndex = 51;
            this.textresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textresultado.TextChanged += new System.EventHandler(this.textresultado_TextChanged);
            // 
            // textcalculo
            // 
            this.textcalculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textcalculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcalculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.textcalculo.ForeColor = System.Drawing.Color.White;
            this.textcalculo.Location = new System.Drawing.Point(-2, 17);
            this.textcalculo.MaxLength = 31767;
            this.textcalculo.Name = "textcalculo";
            this.textcalculo.Size = new System.Drawing.Size(488, 19);
            this.textcalculo.TabIndex = 76;
            this.textcalculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bot_ArreCima
            // 
            this.bot_ArreCima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_ArreCima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.bot_ArreCima.ForeColor = System.Drawing.Color.White;
            this.bot_ArreCima.Location = new System.Drawing.Point(389, 113);
            this.bot_ArreCima.Margin = new System.Windows.Forms.Padding(2);
            this.bot_ArreCima.Name = "bot_ArreCima";
            this.bot_ArreCima.Size = new System.Drawing.Size(95, 80);
            this.bot_ArreCima.TabIndex = 77;
            this.bot_ArreCima.Text = "ARRE ↑";
            this.bot_ArreCima.UseVisualStyleBackColor = false;
            this.bot_ArreCima.Click += new System.EventHandler(this.bot_ArreCima_Click);
            // 
            // bot_Apagar
            // 
            this.bot_Apagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bot_Apagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bot_Apagar.ForeColor = System.Drawing.Color.White;
            this.bot_Apagar.Location = new System.Drawing.Point(195, 113);
            this.bot_Apagar.Margin = new System.Windows.Forms.Padding(2);
            this.bot_Apagar.Name = "bot_Apagar";
            this.bot_Apagar.Size = new System.Drawing.Size(96, 80);
            this.bot_Apagar.TabIndex = 78;
            this.bot_Apagar.Text = "CE";
            this.bot_Apagar.UseVisualStyleBackColor = false;
            this.bot_Apagar.Click += new System.EventHandler(this.bot_Apagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 520);
            this.Controls.Add(this.bot_Apagar);
            this.Controls.Add(this.bot_ArreCima);
            this.Controls.Add(this.textresultado);
            this.Controls.Add(this.textoperacao);
            this.Controls.Add(this.bot_adi);
            this.Controls.Add(this.bot_Pot);
            this.Controls.Add(this.bot_Porc);
            this.Controls.Add(this.bot_Raiz);
            this.Controls.Add(this.bot_Arredondar);
            this.Controls.Add(this.bot_Sub);
            this.Controls.Add(this.bot_Result);
            this.Controls.Add(this.bot_Caract);
            this.Controls.Add(this.bot_0);
            this.Controls.Add(this.bot_Mult);
            this.Controls.Add(this.bot_9);
            this.Controls.Add(this.bot_8);
            this.Controls.Add(this.bot_7);
            this.Controls.Add(this.bot_Div);
            this.Controls.Add(this.bot_6);
            this.Controls.Add(this.bot_5);
            this.Controls.Add(this.bot_4);
            this.Controls.Add(this.bot_Del);
            this.Controls.Add(this.bot_3);
            this.Controls.Add(this.bot_2);
            this.Controls.Add(this.bot_1);
            this.Controls.Add(this.textcalculo);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoperacao;
        private System.Windows.Forms.Button bot_adi;
        private System.Windows.Forms.Button bot_Pot;
        private System.Windows.Forms.Button bot_Porc;
        private System.Windows.Forms.Button bot_Raiz;
        private System.Windows.Forms.Button bot_Arredondar;
        private System.Windows.Forms.Button bot_Sub;
        private System.Windows.Forms.Button bot_Result;
        private System.Windows.Forms.Button bot_Caract;
        private System.Windows.Forms.Button bot_0;
        private System.Windows.Forms.Button bot_Mult;
        private System.Windows.Forms.Button bot_9;
        private System.Windows.Forms.Button bot_8;
        private System.Windows.Forms.Button bot_7;
        private System.Windows.Forms.Button bot_Div;
        private System.Windows.Forms.Button bot_6;
        private System.Windows.Forms.Button bot_5;
        private System.Windows.Forms.Button bot_4;
        private System.Windows.Forms.Button bot_Del;
        private System.Windows.Forms.Button bot_3;
        private System.Windows.Forms.Button bot_2;
        private System.Windows.Forms.Button bot_1;
        private System.Windows.Forms.TextBox textresultado;
        private System.Windows.Forms.TextBox textcalculo;
        private System.Windows.Forms.Button bot_ArreCima;
        private System.Windows.Forms.Button bot_Apagar;
    }
}

