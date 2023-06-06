namespace Calculadora_Cientifica
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
            this.textResultado = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PORCIENTO = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.ELEVADO = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.btnMultiplcar = new System.Windows.Forms.Button();
            this.NUEVE = new System.Windows.Forms.Button();
            this.OCHO = new System.Windows.Forms.Button();
            this.SIETE = new System.Windows.Forms.Button();
            this.btnRestar = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.CINCO = new System.Windows.Forms.Button();
            this.CUATRO = new System.Windows.Forms.Button();
            this.btnSumar = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.DOS = new System.Windows.Forms.Button();
            this.UNO = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.CERO = new System.Windows.Forms.Button();
            this.PUNTO = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.MASyMenos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textResultado
            // 
            this.textResultado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultado.Location = new System.Drawing.Point(43, 76);
            this.textResultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textResultado.MaxLength = 12;
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.Size = new System.Drawing.Size(366, 56);
            this.textResultado.TabIndex = 0;
            this.textResultado.Text = "0";
            this.textResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textResultado.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(472, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // PORCIENTO
            // 
            this.PORCIENTO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PORCIENTO.Location = new System.Drawing.Point(34, 152);
            this.PORCIENTO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PORCIENTO.Name = "PORCIENTO";
            this.PORCIENTO.Size = new System.Drawing.Size(86, 51);
            this.PORCIENTO.TabIndex = 2;
            this.PORCIENTO.Text = "%";
            this.PORCIENTO.UseVisualStyleBackColor = true;
            this.PORCIENTO.Click += new System.EventHandler(this.ClickOperador);
            // 
            // C
            // 
            this.C.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.Location = new System.Drawing.Point(126, 152);
            this.C.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(86, 51);
            this.C.TabIndex = 3;
            this.C.Text = "C";
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.button2_Click);
            // 
            // ELEVADO
            // 
            this.ELEVADO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ELEVADO.Location = new System.Drawing.Point(218, 152);
            this.ELEVADO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ELEVADO.Name = "ELEVADO";
            this.ELEVADO.Size = new System.Drawing.Size(86, 51);
            this.ELEVADO.TabIndex = 4;
            this.ELEVADO.Tag = "²";
            this.ELEVADO.Text = "x²";
            this.ELEVADO.UseVisualStyleBackColor = true;
            this.ELEVADO.Click += new System.EventHandler(this.ClickOperador);
            // 
            // DELETE
            // 
            this.DELETE.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DELETE.Location = new System.Drawing.Point(323, 152);
            this.DELETE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(86, 51);
            this.DELETE.TabIndex = 5;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = true;
            this.DELETE.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMultiplcar
            // 
            this.btnMultiplcar.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplcar.Location = new System.Drawing.Point(320, 270);
            this.btnMultiplcar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultiplcar.Name = "btnMultiplcar";
            this.btnMultiplcar.Size = new System.Drawing.Size(86, 51);
            this.btnMultiplcar.TabIndex = 9;
            this.btnMultiplcar.Tag = "*";
            this.btnMultiplcar.Text = "*";
            this.btnMultiplcar.UseVisualStyleBackColor = true;
            this.btnMultiplcar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // NUEVE
            // 
            this.NUEVE.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUEVE.Location = new System.Drawing.Point(218, 270);
            this.NUEVE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUEVE.Name = "NUEVE";
            this.NUEVE.Size = new System.Drawing.Size(86, 51);
            this.NUEVE.TabIndex = 9;
            this.NUEVE.Text = "9";
            this.NUEVE.UseVisualStyleBackColor = true;
            this.NUEVE.Click += new System.EventHandler(this.ponerCero);
            // 
            // OCHO
            // 
            this.OCHO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OCHO.Location = new System.Drawing.Point(126, 269);
            this.OCHO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OCHO.Name = "OCHO";
            this.OCHO.Size = new System.Drawing.Size(86, 51);
            this.OCHO.TabIndex = 8;
            this.OCHO.Text = "8";
            this.OCHO.UseVisualStyleBackColor = true;
            this.OCHO.Click += new System.EventHandler(this.ponerCero);
            // 
            // SIETE
            // 
            this.SIETE.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SIETE.Location = new System.Drawing.Point(34, 270);
            this.SIETE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SIETE.Name = "SIETE";
            this.SIETE.Size = new System.Drawing.Size(86, 51);
            this.SIETE.TabIndex = 7;
            this.SIETE.Text = "7";
            this.SIETE.UseVisualStyleBackColor = true;
            this.SIETE.Click += new System.EventHandler(this.ponerCero);
            // 
            // btnRestar
            // 
            this.btnRestar.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestar.Location = new System.Drawing.Point(323, 338);
            this.btnRestar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRestar.Name = "btnRestar";
            this.btnRestar.Size = new System.Drawing.Size(86, 51);
            this.btnRestar.TabIndex = 13;
            this.btnRestar.Tag = "-";
            this.btnRestar.Text = "-";
            this.btnRestar.UseVisualStyleBackColor = true;
            this.btnRestar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(218, 338);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(86, 51);
            this.button10.TabIndex = 6;
            this.button10.Text = "6";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.ponerCero);
            // 
            // CINCO
            // 
            this.CINCO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CINCO.Location = new System.Drawing.Point(126, 338);
            this.CINCO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CINCO.Name = "CINCO";
            this.CINCO.Size = new System.Drawing.Size(86, 51);
            this.CINCO.TabIndex = 5;
            this.CINCO.Text = "5";
            this.CINCO.UseVisualStyleBackColor = true;
            this.CINCO.Click += new System.EventHandler(this.ponerCero);
            // 
            // CUATRO
            // 
            this.CUATRO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CUATRO.Location = new System.Drawing.Point(34, 338);
            this.CUATRO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CUATRO.Name = "CUATRO";
            this.CUATRO.Size = new System.Drawing.Size(86, 51);
            this.CUATRO.TabIndex = 4;
            this.CUATRO.Text = "4";
            this.CUATRO.UseVisualStyleBackColor = true;
            this.CUATRO.Click += new System.EventHandler(this.ponerCero);
            // 
            // btnSumar
            // 
            this.btnSumar.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumar.Location = new System.Drawing.Point(320, 412);
            this.btnSumar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(86, 51);
            this.btnSumar.TabIndex = 17;
            this.btnSumar.Tag = "+";
            this.btnSumar.Text = "+";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.ClickOperador);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(218, 412);
            this.button14.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(86, 51);
            this.button14.TabIndex = 3;
            this.button14.Text = "3";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.ponerCero);
            // 
            // DOS
            // 
            this.DOS.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOS.Location = new System.Drawing.Point(126, 412);
            this.DOS.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DOS.Name = "DOS";
            this.DOS.Size = new System.Drawing.Size(86, 51);
            this.DOS.TabIndex = 2;
            this.DOS.Text = "2";
            this.DOS.UseVisualStyleBackColor = true;
            this.DOS.Click += new System.EventHandler(this.ponerCero);
            // 
            // UNO
            // 
            this.UNO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNO.Location = new System.Drawing.Point(34, 412);
            this.UNO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UNO.Name = "UNO";
            this.UNO.Size = new System.Drawing.Size(86, 51);
            this.UNO.TabIndex = 1;
            this.UNO.Text = "1";
            this.UNO.UseVisualStyleBackColor = true;
            this.UNO.Click += new System.EventHandler(this.ponerCero);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(218, 481);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(188, 51);
            this.btnCalcular.TabIndex = 21;
            this.btnCalcular.Text = "=";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.button17_Click);
            // 
            // CERO
            // 
            this.CERO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CERO.Location = new System.Drawing.Point(126, 481);
            this.CERO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CERO.Name = "CERO";
            this.CERO.Size = new System.Drawing.Size(86, 51);
            this.CERO.TabIndex = 0;
            this.CERO.Text = "0";
            this.CERO.UseVisualStyleBackColor = true;
            this.CERO.Click += new System.EventHandler(this.ponerCero);
            // 
            // PUNTO
            // 
            this.PUNTO.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PUNTO.Location = new System.Drawing.Point(34, 481);
            this.PUNTO.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PUNTO.Name = "PUNTO";
            this.PUNTO.Size = new System.Drawing.Size(86, 51);
            this.PUNTO.TabIndex = 18;
            this.PUNTO.Text = ".";
            this.PUNTO.UseVisualStyleBackColor = true;
            this.PUNTO.Click += new System.EventHandler(this.button20_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(320, 211);
            this.btnRaiz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(86, 51);
            this.btnRaiz.TabIndex = 25;
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = true;
            this.btnRaiz.Click += new System.EventHandler(this.ClickOperador);
            // 
            // btndividir
            // 
            this.btndividir.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndividir.Location = new System.Drawing.Point(218, 211);
            this.btndividir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(86, 51);
            this.btndividir.TabIndex = 24;
            this.btndividir.Tag = "/";
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = true;
            this.btndividir.Click += new System.EventHandler(this.ClickOperador);
            // 
            // CE
            // 
            this.CE.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(126, 211);
            this.CE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(86, 51);
            this.CE.TabIndex = 23;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = true;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // MASyMenos
            // 
            this.MASyMenos.Font = new System.Drawing.Font("Lucida Sans Unicode", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASyMenos.Location = new System.Drawing.Point(34, 211);
            this.MASyMenos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MASyMenos.Name = "MASyMenos";
            this.MASyMenos.Size = new System.Drawing.Size(86, 51);
            this.MASyMenos.TabIndex = 22;
            this.MASyMenos.Text = "+/-";
            this.MASyMenos.UseVisualStyleBackColor = true;
            this.MASyMenos.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(472, 574);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.MASyMenos);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.CERO);
            this.Controls.Add(this.PUNTO);
            this.Controls.Add(this.btnSumar);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.DOS);
            this.Controls.Add(this.UNO);
            this.Controls.Add(this.btnRestar);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.CINCO);
            this.Controls.Add(this.CUATRO);
            this.Controls.Add(this.btnMultiplcar);
            this.Controls.Add(this.NUEVE);
            this.Controls.Add(this.OCHO);
            this.Controls.Add(this.SIETE);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.ELEVADO);
            this.Controls.Add(this.C);
            this.Controls.Add(this.PORCIENTO);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Calculadora ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button PORCIENTO;
        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button ELEVADO;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button btnMultiplcar;
        private System.Windows.Forms.Button NUEVE;
        private System.Windows.Forms.Button OCHO;
        private System.Windows.Forms.Button SIETE;
        private System.Windows.Forms.Button btnRestar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button CINCO;
        private System.Windows.Forms.Button CUATRO;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button DOS;
        private System.Windows.Forms.Button UNO;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button CERO;
        private System.Windows.Forms.Button PUNTO;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button MASyMenos;
    }
}

