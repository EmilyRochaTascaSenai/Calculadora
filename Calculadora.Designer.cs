namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            BtnMais = new Button();
            BtnMenos = new Button();
            BtnVezes = new Button();
            BtnDividido = new Button();
            Btnigual = new Button();
            CE = new Button();
            Porcentagem = new Button();
            Num1 = new Button();
            Num2 = new Button();
            Num3 = new Button();
            Num4 = new Button();
            Num5 = new Button();
            Num6 = new Button();
            Num7 = new Button();
            Num8 = new Button();
            Num9 = new Button();
            Num0 = new Button();
            TxtResultado = new TextBox();
            SuspendLayout();
            // 
            // BtnMais
            // 
            BtnMais.BackColor = Color.FromArgb(255, 128, 0);
            BtnMais.ForeColor = SystemColors.ControlText;
            BtnMais.Location = new Point(614, 54);
            BtnMais.Name = "BtnMais";
            BtnMais.Size = new Size(83, 38);
            BtnMais.TabIndex = 0;
            BtnMais.Text = "+";
            BtnMais.UseVisualStyleBackColor = false;
            BtnMais.Click += button1_Click;
            // 
            // BtnMenos
            // 
            BtnMenos.BackColor = Color.FromArgb(255, 128, 0);
            BtnMenos.ForeColor = SystemColors.ControlText;
            BtnMenos.Location = new Point(614, 122);
            BtnMenos.Name = "BtnMenos";
            BtnMenos.Size = new Size(83, 38);
            BtnMenos.TabIndex = 1;
            BtnMenos.Text = "-";
            BtnMenos.UseVisualStyleBackColor = false;
            // 
            // BtnVezes
            // 
            BtnVezes.BackColor = Color.FromArgb(255, 128, 0);
            BtnVezes.ForeColor = SystemColors.ControlText;
            BtnVezes.Location = new Point(614, 205);
            BtnVezes.Name = "BtnVezes";
            BtnVezes.Size = new Size(83, 38);
            BtnVezes.TabIndex = 2;
            BtnVezes.Text = "x";
            BtnVezes.UseVisualStyleBackColor = false;
            // 
            // BtnDividido
            // 
            BtnDividido.BackColor = Color.FromArgb(255, 128, 0);
            BtnDividido.ForeColor = SystemColors.ControlText;
            BtnDividido.Location = new Point(614, 281);
            BtnDividido.Name = "BtnDividido";
            BtnDividido.Size = new Size(83, 38);
            BtnDividido.TabIndex = 3;
            BtnDividido.Text = "÷";
            BtnDividido.UseVisualStyleBackColor = false;
            // 
            // Btnigual
            // 
            Btnigual.BackColor = Color.FromArgb(255, 128, 0);
            Btnigual.ForeColor = SystemColors.ControlText;
            Btnigual.Location = new Point(614, 357);
            Btnigual.Name = "Btnigual";
            Btnigual.Size = new Size(83, 38);
            Btnigual.TabIndex = 4;
            Btnigual.Text = "=";
            Btnigual.UseVisualStyleBackColor = false;
            Btnigual.Click += Btnigual_Click;
            // 
            // CE
            // 
            CE.BackColor = Color.FromArgb(255, 128, 0);
            CE.ForeColor = SystemColors.ControlText;
            CE.Image = (Image)resources.GetObject("CE.Image");
            CE.ImageAlign = ContentAlignment.TopLeft;
            CE.Location = new Point(65, 101);
            CE.Name = "CE";
            CE.Size = new Size(83, 38);
            CE.TabIndex = 5;
            CE.Text = "CE";
            CE.UseVisualStyleBackColor = false;
            // 
            // Porcentagem
            // 
            Porcentagem.BackColor = Color.FromArgb(255, 128, 0);
            Porcentagem.ForeColor = SystemColors.ControlText;
            Porcentagem.Location = new Point(251, 101);
            Porcentagem.Name = "Porcentagem";
            Porcentagem.Size = new Size(83, 38);
            Porcentagem.TabIndex = 6;
            Porcentagem.Text = "%";
            Porcentagem.UseVisualStyleBackColor = false;
            // 
            // Num1
            // 
            Num1.BackColor = Color.FromArgb(255, 128, 0);
            Num1.ForeColor = SystemColors.ControlText;
            Num1.Location = new Point(65, 178);
            Num1.Name = "Num1";
            Num1.Size = new Size(83, 38);
            Num1.TabIndex = 7;
            Num1.Text = "1";
            Num1.UseVisualStyleBackColor = false;
            Num1.Click += Num1_Click;
            // 
            // Num2
            // 
            Num2.BackColor = Color.FromArgb(255, 128, 0);
            Num2.ForeColor = SystemColors.ControlText;
            Num2.Location = new Point(251, 178);
            Num2.Name = "Num2";
            Num2.Size = new Size(83, 38);
            Num2.TabIndex = 8;
            Num2.Text = "2";
            Num2.UseVisualStyleBackColor = false;
            Num2.Click += Num2_Click;
            // 
            // Num3
            // 
            Num3.BackColor = Color.FromArgb(255, 128, 0);
            Num3.ForeColor = SystemColors.ControlText;
            Num3.Location = new Point(402, 178);
            Num3.Name = "Num3";
            Num3.Size = new Size(83, 38);
            Num3.TabIndex = 9;
            Num3.Text = "3";
            Num3.UseVisualStyleBackColor = false;
            Num3.Click += Num3_Click;
            // 
            // Num4
            // 
            Num4.BackColor = Color.FromArgb(255, 128, 0);
            Num4.ForeColor = SystemColors.ControlText;
            Num4.Location = new Point(65, 255);
            Num4.Name = "Num4";
            Num4.Size = new Size(83, 38);
            Num4.TabIndex = 10;
            Num4.Text = "4";
            Num4.UseVisualStyleBackColor = false;
            Num4.Click += Num4_Click;
            // 
            // Num5
            // 
            Num5.BackColor = Color.FromArgb(255, 128, 0);
            Num5.ForeColor = SystemColors.ControlText;
            Num5.Location = new Point(251, 255);
            Num5.Name = "Num5";
            Num5.Size = new Size(83, 38);
            Num5.TabIndex = 11;
            Num5.Text = "5";
            Num5.UseVisualStyleBackColor = false;
            Num5.Click += Num5_Click;
            // 
            // Num6
            // 
            Num6.BackColor = Color.FromArgb(255, 128, 0);
            Num6.ForeColor = SystemColors.ControlText;
            Num6.Location = new Point(402, 255);
            Num6.Name = "Num6";
            Num6.Size = new Size(83, 38);
            Num6.TabIndex = 12;
            Num6.Text = "6";
            Num6.UseVisualStyleBackColor = false;
            Num6.Click += Num6_Click;
            // 
            // Num7
            // 
            Num7.BackColor = Color.FromArgb(255, 128, 0);
            Num7.ForeColor = SystemColors.ControlText;
            Num7.Location = new Point(65, 357);
            Num7.Name = "Num7";
            Num7.Size = new Size(83, 38);
            Num7.TabIndex = 13;
            Num7.Text = "7";
            Num7.UseVisualStyleBackColor = false;
            Num7.Click += Num7_Click;
            // 
            // Num8
            // 
            Num8.BackColor = Color.FromArgb(255, 128, 0);
            Num8.ForeColor = SystemColors.ControlText;
            Num8.Location = new Point(251, 357);
            Num8.Name = "Num8";
            Num8.Size = new Size(83, 38);
            Num8.TabIndex = 14;
            Num8.Text = "8";
            Num8.UseVisualStyleBackColor = false;
            Num8.Click += Num8_Click;
            // 
            // Num9
            // 
            Num9.BackColor = Color.FromArgb(255, 128, 0);
            Num9.ForeColor = SystemColors.ControlText;
            Num9.Location = new Point(402, 357);
            Num9.Name = "Num9";
            Num9.Size = new Size(83, 38);
            Num9.TabIndex = 15;
            Num9.Text = "9";
            Num9.UseVisualStyleBackColor = false;
            Num9.Click += Num9_Click;
            // 
            // Num0
            // 
            Num0.BackColor = Color.FromArgb(255, 128, 0);
            Num0.ForeColor = SystemColors.ControlText;
            Num0.Location = new Point(402, 101);
            Num0.Name = "Num0";
            Num0.Size = new Size(83, 38);
            Num0.TabIndex = 16;
            Num0.Text = "0";
            Num0.UseVisualStyleBackColor = false;
            Num0.Click += Num0_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.White;
            TxtResultado.Location = new Point(289, -3);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(305, 46);
            TxtResultado.TabIndex = 17;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(TxtResultado);
            Controls.Add(Num0);
            Controls.Add(Num9);
            Controls.Add(Num8);
            Controls.Add(Num7);
            Controls.Add(Num6);
            Controls.Add(Num5);
            Controls.Add(Num4);
            Controls.Add(Num3);
            Controls.Add(Num2);
            Controls.Add(Num1);
            Controls.Add(Porcentagem);
            Controls.Add(CE);
            Controls.Add(Btnigual);
            Controls.Add(BtnDividido);
            Controls.Add(BtnVezes);
            Controls.Add(BtnMenos);
            Controls.Add(BtnMais);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMais;
        private Button BtnMenos;
        private Button BtnVezes;
        private Button BtnDividido;
        private Button Btnigual;
        private Button CE;
        private Button Porcentagem;
        private Button Num1;
        private Button Num2;
        private Button Num3;
        private Button Num4;
        private Button Num5;
        private Button Num6;
        private Button Num7;
        private Button Num8;
        private Button Num9;
        private Button Num0;
        private TextBox TxtResultado;
    }
}