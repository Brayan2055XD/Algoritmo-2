namespace LoteriaApp
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
            this.monto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajap3 = new System.Windows.Forms.TextBox();
            this.cajap2 = new System.Windows.Forms.TextBox();
            this.cajap1 = new System.Windows.Forms.TextBox();
            this.radioButtonSolo = new System.Windows.Forms.RadioButton();
            this.radioButtonPale = new System.Windows.Forms.RadioButton();
            this.loteria = new System.Windows.Forms.Button();
            this.resultado1 = new System.Windows.Forms.Button();
            this.resultado2 = new System.Windows.Forms.Button();
            this.resultado3 = new System.Windows.Forms.Button();
            this.final = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monto
            // 
            this.monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monto.Location = new System.Drawing.Point(594, 90);
            this.monto.Multiline = true;
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(213, 46);
            this.monto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Monto introduccido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(735, 69);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loteria Nacional Pichardo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cajap3);
            this.groupBox1.Controls.Add(this.cajap2);
            this.groupBox1.Controls.Add(this.cajap1);
            this.groupBox1.Controls.Add(this.radioButtonSolo);
            this.groupBox1.Controls.Add(this.radioButtonPale);
            this.groupBox1.Location = new System.Drawing.Point(41, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 203);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Modo de juego";
            // 
            // cajap3
            // 
            this.cajap3.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajap3.Location = new System.Drawing.Point(205, 69);
            this.cajap3.Multiline = true;
            this.cajap3.Name = "cajap3";
            this.cajap3.Size = new System.Drawing.Size(80, 61);
            this.cajap3.TabIndex = 7;
            // 
            // cajap2
            // 
            this.cajap2.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajap2.Location = new System.Drawing.Point(101, 69);
            this.cajap2.Multiline = true;
            this.cajap2.Name = "cajap2";
            this.cajap2.Size = new System.Drawing.Size(80, 61);
            this.cajap2.TabIndex = 6;
            // 
            // cajap1
            // 
            this.cajap1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajap1.Location = new System.Drawing.Point(6, 69);
            this.cajap1.Multiline = true;
            this.cajap1.Name = "cajap1";
            this.cajap1.Size = new System.Drawing.Size(80, 61);
            this.cajap1.TabIndex = 4;
            // 
            // radioButtonSolo
            // 
            this.radioButtonSolo.AutoSize = true;
            this.radioButtonSolo.Location = new System.Drawing.Point(205, 21);
            this.radioButtonSolo.Name = "radioButtonSolo";
            this.radioButtonSolo.Size = new System.Drawing.Size(56, 20);
            this.radioButtonSolo.TabIndex = 5;
            this.radioButtonSolo.TabStop = true;
            this.radioButtonSolo.Text = "Solo";
            this.radioButtonSolo.UseVisualStyleBackColor = true;
            // 
            // radioButtonPale
            // 
            this.radioButtonPale.AutoSize = true;
            this.radioButtonPale.Location = new System.Drawing.Point(6, 21);
            this.radioButtonPale.Name = "radioButtonPale";
            this.radioButtonPale.Size = new System.Drawing.Size(56, 20);
            this.radioButtonPale.TabIndex = 4;
            this.radioButtonPale.TabStop = true;
            this.radioButtonPale.Text = "Pale";
            this.radioButtonPale.UseVisualStyleBackColor = true;
            // 
            // loteria
            // 
            this.loteria.Font = new System.Drawing.Font("MS PGothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loteria.Location = new System.Drawing.Point(523, 176);
            this.loteria.Name = "loteria";
            this.loteria.Size = new System.Drawing.Size(249, 71);
            this.loteria.TabIndex = 4;
            this.loteria.Text = "Loteria";
            this.loteria.UseVisualStyleBackColor = true;
            this.loteria.Click += new System.EventHandler(this.loteria_Click);
            // 
            // resultado1
            // 
            this.resultado1.Location = new System.Drawing.Point(496, 276);
            this.resultado1.Name = "resultado1";
            this.resultado1.Size = new System.Drawing.Size(98, 81);
            this.resultado1.TabIndex = 5;
            this.resultado1.UseVisualStyleBackColor = true;
            // 
            // resultado2
            // 
            this.resultado2.Location = new System.Drawing.Point(617, 276);
            this.resultado2.Name = "resultado2";
            this.resultado2.Size = new System.Drawing.Size(98, 81);
            this.resultado2.TabIndex = 6;
            this.resultado2.UseVisualStyleBackColor = true;
            // 
            // resultado3
            // 
            this.resultado3.Location = new System.Drawing.Point(733, 276);
            this.resultado3.Name = "resultado3";
            this.resultado3.Size = new System.Drawing.Size(98, 81);
            this.resultado3.TabIndex = 7;
            this.resultado3.UseVisualStyleBackColor = true;
            // 
            // final
            // 
            this.final.Location = new System.Drawing.Point(581, 372);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(191, 46);
            this.final.TabIndex = 8;
            this.final.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ganancias";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(547, 431);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(225, 64);
            this.total.TabIndex = 10;
            this.total.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 507);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.final);
            this.Controls.Add(this.resultado3);
            this.Controls.Add(this.resultado2);
            this.Controls.Add(this.resultado1);
            this.Controls.Add(this.loteria);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cajap1;
        private System.Windows.Forms.RadioButton radioButtonSolo;
        private System.Windows.Forms.RadioButton radioButtonPale;
        private System.Windows.Forms.TextBox cajap3;
        private System.Windows.Forms.TextBox cajap2;
        private System.Windows.Forms.Button loteria;
        private System.Windows.Forms.Button resultado1;
        private System.Windows.Forms.Button resultado2;
        private System.Windows.Forms.Button resultado3;
        private System.Windows.Forms.Button final;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button total;
    }
}

