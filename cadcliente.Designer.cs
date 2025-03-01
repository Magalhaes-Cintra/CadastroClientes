namespace captaçãocliente
{
    partial class cadcliente
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
            this.nome = new System.Windows.Forms.TextBox();
            this.cidade = new System.Windows.Forms.TextBox();
            this.uf = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.endereco = new System.Windows.Forms.TextBox();
            this.numero = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.rg = new System.Windows.Forms.MaskedTextBox();
            this.cep = new System.Windows.Forms.MaskedTextBox();
            this.Cadastrar = new System.Windows.Forms.Button();
            this.atualizar = new System.Windows.Forms.Button();
            this.excluir = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numero)).BeginInit();
            this.SuspendLayout();
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(177, 97);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(100, 20);
            this.nome.TabIndex = 0;
            // 
            // cidade
            // 
            this.cidade.Location = new System.Drawing.Point(471, 344);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(100, 20);
            this.cidade.TabIndex = 1;
            // 
            // uf
            // 
            this.uf.Location = new System.Drawing.Point(611, 344);
            this.uf.Name = "uf";
            this.uf.Size = new System.Drawing.Size(100, 20);
            this.uf.TabIndex = 2;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(378, 97);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 3;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(151, 344);
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(100, 20);
            this.endereco.TabIndex = 4;
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(308, 345);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(120, 20);
            this.numero.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(608, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CPF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(408, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "RG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "CEP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(184, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Endereço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Número";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(503, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(656, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "UF";
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(577, 97);
            this.telefone.Mask = "(00) 00000-0000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 20;
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(210, 216);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(84, 20);
            this.cpf.TabIndex = 21;
            // 
            // rg
            // 
            this.rg.Location = new System.Drawing.Point(378, 216);
            this.rg.Mask = "00.000.000-00";
            this.rg.Name = "rg";
            this.rg.Size = new System.Drawing.Size(81, 20);
            this.rg.TabIndex = 22;
            // 
            // cep
            // 
            this.cep.Location = new System.Drawing.Point(577, 216);
            this.cep.Mask = "00000-000";
            this.cep.Name = "cep";
            this.cep.Size = new System.Drawing.Size(69, 20);
            this.cep.TabIndex = 23;
            // 
            // Cadastrar
            // 
            this.Cadastrar.Location = new System.Drawing.Point(681, 415);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 24;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.UseVisualStyleBackColor = true;
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // atualizar
            // 
            this.atualizar.Location = new System.Drawing.Point(582, 415);
            this.atualizar.Name = "atualizar";
            this.atualizar.Size = new System.Drawing.Size(75, 23);
            this.atualizar.TabIndex = 25;
            this.atualizar.Text = "Atualizar";
            this.atualizar.UseVisualStyleBackColor = true;
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // excluir
            // 
            this.excluir.Location = new System.Drawing.Point(496, 415);
            this.excluir.Name = "excluir";
            this.excluir.Size = new System.Drawing.Size(75, 23);
            this.excluir.TabIndex = 26;
            this.excluir.Text = "Excluir";
            this.excluir.UseVisualStyleBackColor = true;
            this.excluir.Click += new System.EventHandler(this.excluir_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(403, 415);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 27;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // cadcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.excluir);
            this.Controls.Add(this.atualizar);
            this.Controls.Add(this.Cadastrar);
            this.Controls.Add(this.cep);
            this.Controls.Add(this.rg);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.email);
            this.Controls.Add(this.uf);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.nome);
            this.Name = "cadcliente";
            this.Text = "cadcliente";
            ((System.ComponentModel.ISupportInitialize)(this.numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox cidade;
        private System.Windows.Forms.TextBox uf;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.NumericUpDown numero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.MaskedTextBox rg;
        private System.Windows.Forms.MaskedTextBox cep;
        private System.Windows.Forms.Button Cadastrar;
        private System.Windows.Forms.Button atualizar;
        private System.Windows.Forms.Button excluir;
        private System.Windows.Forms.Button Buscar;
    }
}