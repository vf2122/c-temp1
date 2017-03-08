namespace Apresentacao
{
    partial class FrmCadastrarCliente
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
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.labelIdCliente = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelLimiteCompra = new System.Windows.Forms.Label();
            this.textBoxLimiteCompra = new System.Windows.Forms.TextBox();
            this.dateDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFeminino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(11, 24);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.ReadOnly = true;
            this.textBoxIdCliente.Size = new System.Drawing.Size(61, 20);
            this.textBoxIdCliente.TabIndex = 1;
            this.textBoxIdCliente.TabStop = false;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(11, 68);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(158, 20);
            this.textBoxNome.TabIndex = 3;
            // 
            // labelIdCliente
            // 
            this.labelIdCliente.AutoSize = true;
            this.labelIdCliente.Location = new System.Drawing.Point(9, 9);
            this.labelIdCliente.Name = "labelIdCliente";
            this.labelIdCliente.Size = new System.Drawing.Size(53, 13);
            this.labelIdCliente.TabIndex = 0;
            this.labelIdCliente.Text = "ID Cliente";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(11, 53);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome";
            // 
            // labelLimiteCompra
            // 
            this.labelLimiteCompra.AutoSize = true;
            this.labelLimiteCompra.Location = new System.Drawing.Point(9, 200);
            this.labelLimiteCompra.Name = "labelLimiteCompra";
            this.labelLimiteCompra.Size = new System.Drawing.Size(73, 13);
            this.labelLimiteCompra.TabIndex = 9;
            this.labelLimiteCompra.Text = "Limite Compra";
            // 
            // textBoxLimiteCompra
            // 
            this.textBoxLimiteCompra.Location = new System.Drawing.Point(11, 215);
            this.textBoxLimiteCompra.Name = "textBoxLimiteCompra";
            this.textBoxLimiteCompra.Size = new System.Drawing.Size(100, 20);
            this.textBoxLimiteCompra.TabIndex = 10;
            // 
            // dateDataNascimento
            // 
            this.dateDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataNascimento.Location = new System.Drawing.Point(11, 114);
            this.dateDataNascimento.Name = "dateDataNascimento";
            this.dateDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.dateDataNascimento.TabIndex = 5;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Location = new System.Drawing.Point(9, 99);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(63, 13);
            this.labelDataNascimento.TabIndex = 4;
            this.labelDataNascimento.Text = "Nascimento";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Location = new System.Drawing.Point(9, 149);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(31, 13);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(11, 289);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 11;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(92, 289);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 12;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(11, 164);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioMasculino.TabIndex = 7;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFeminino
            // 
            this.radioFeminino.AutoSize = true;
            this.radioFeminino.Location = new System.Drawing.Point(102, 164);
            this.radioFeminino.Name = "radioFeminino";
            this.radioFeminino.Size = new System.Drawing.Size(67, 17);
            this.radioFeminino.TabIndex = 8;
            this.radioFeminino.TabStop = true;
            this.radioFeminino.Text = "Feminino";
            this.radioFeminino.UseVisualStyleBackColor = true;
            // 
            // FrmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 328);
            this.Controls.Add(this.radioFeminino);
            this.Controls.Add(this.radioMasculino);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateDataNascimento);
            this.Controls.Add(this.labelLimiteCompra);
            this.Controls.Add(this.textBoxLimiteCompra);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelIdCliente);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxIdCliente);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label labelIdCliente;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelLimiteCompra;
        private System.Windows.Forms.TextBox textBoxLimiteCompra;
        private System.Windows.Forms.DateTimePicker dateDataNascimento;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFeminino;
    }
}