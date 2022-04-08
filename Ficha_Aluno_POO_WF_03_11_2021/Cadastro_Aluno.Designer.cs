
namespace Ficha_Aluno_POO_WF_03_11_2021
{
    partial class Cadastro_Aluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_nome = new System.Windows.Forms.Label();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_salvar = new System.Windows.Forms.Button();
            this.lb_ra = new System.Windows.Forms.Label();
            this.tb_ra = new System.Windows.Forms.TextBox();
            this.lb_telefone = new System.Windows.Forms.Label();
            this.tb_telefone = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.tb_cpf = new System.Windows.Forms.TextBox();
            this.lb_logradouro = new System.Windows.Forms.Label();
            this.tb_logradouro = new System.Windows.Forms.TextBox();
            this.lb_numeroLogradouro = new System.Windows.Forms.Label();
            this.tb_numeroLogradouro = new System.Windows.Forms.TextBox();
            this.lb_bairro = new System.Windows.Forms.Label();
            this.tb_bairro = new System.Windows.Forms.TextBox();
            this.lv_alunos = new System.Windows.Forms.ListView();
            this.clNome = new System.Windows.Forms.ColumnHeader();
            this.clRA = new System.Windows.Forms.ColumnHeader();
            this.clDataNasc = new System.Windows.Forms.ColumnHeader();
            this.clEmail = new System.Windows.Forms.ColumnHeader();
            this.clCPF = new System.Windows.Forms.ColumnHeader();
            this.clTelefone = new System.Windows.Forms.ColumnHeader();
            this.clBairro = new System.Windows.Forms.ColumnHeader();
            this.clLogradouro = new System.Windows.Forms.ColumnHeader();
            this.clNumero = new System.Windows.Forms.ColumnHeader();
            this.lb_datanascimento = new System.Windows.Forms.Label();
            this.bt_limpar = new System.Windows.Forms.Button();
            this.numDia = new System.Windows.Forms.NumericUpDown();
            this.numMes = new System.Windows.Forms.NumericUpDown();
            this.lbDia = new System.Windows.Forms.Label();
            this.lbMes = new System.Windows.Forms.Label();
            this.lbAno = new System.Windows.Forms.Label();
            this.numAno = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Location = new System.Drawing.Point(12, 18);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(43, 15);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "Nome:";
            // 
            // tb_nome
            // 
            this.tb_nome.Location = new System.Drawing.Point(106, 10);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(279, 23);
            this.tb_nome.TabIndex = 1;
            // 
            // bt_salvar
            // 
            this.bt_salvar.Image = global::Ficha_Aluno_POO_WF_03_11_2021.Properties.Resources.transferir;
            this.bt_salvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salvar.Location = new System.Drawing.Point(189, 456);
            this.bt_salvar.Name = "bt_salvar";
            this.bt_salvar.Size = new System.Drawing.Size(133, 122);
            this.bt_salvar.TabIndex = 2;
            this.bt_salvar.Text = "Salvar";
            this.bt_salvar.UseVisualStyleBackColor = true;
            this.bt_salvar.Click += new System.EventHandler(this.bt_salvar_Click);
            // 
            // lb_ra
            // 
            this.lb_ra.AutoSize = true;
            this.lb_ra.Location = new System.Drawing.Point(12, 278);
            this.lb_ra.Name = "lb_ra";
            this.lb_ra.Size = new System.Drawing.Size(25, 15);
            this.lb_ra.TabIndex = 3;
            this.lb_ra.Text = "RA:";
            // 
            // tb_ra
            // 
            this.tb_ra.Location = new System.Drawing.Point(106, 275);
            this.tb_ra.Name = "tb_ra";
            this.tb_ra.ReadOnly = true;
            this.tb_ra.Size = new System.Drawing.Size(279, 23);
            this.tb_ra.TabIndex = 4;
            // 
            // lb_telefone
            // 
            this.lb_telefone.AutoSize = true;
            this.lb_telefone.Location = new System.Drawing.Point(11, 58);
            this.lb_telefone.Name = "lb_telefone";
            this.lb_telefone.Size = new System.Drawing.Size(54, 15);
            this.lb_telefone.TabIndex = 5;
            this.lb_telefone.Text = "Telefone:";
            // 
            // tb_telefone
            // 
            this.tb_telefone.Location = new System.Drawing.Point(106, 50);
            this.tb_telefone.Name = "tb_telefone";
            this.tb_telefone.Size = new System.Drawing.Size(279, 23);
            this.tb_telefone.TabIndex = 6;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(12, 106);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(44, 15);
            this.lb_email.TabIndex = 7;
            this.lb_email.Text = "E-mail:";
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(106, 98);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(279, 23);
            this.tb_email.TabIndex = 8;
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Location = new System.Drawing.Point(11, 235);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(31, 15);
            this.lb_cpf.TabIndex = 9;
            this.lb_cpf.Text = "CPF:";
            // 
            // tb_cpf
            // 
            this.tb_cpf.Location = new System.Drawing.Point(106, 232);
            this.tb_cpf.Name = "tb_cpf";
            this.tb_cpf.Size = new System.Drawing.Size(279, 23);
            this.tb_cpf.TabIndex = 10;
            this.tb_cpf.Leave += new System.EventHandler(this.tb_cpf_Leave);
            // 
            // lb_logradouro
            // 
            this.lb_logradouro.AutoSize = true;
            this.lb_logradouro.Location = new System.Drawing.Point(12, 316);
            this.lb_logradouro.Name = "lb_logradouro";
            this.lb_logradouro.Size = new System.Drawing.Size(72, 15);
            this.lb_logradouro.TabIndex = 11;
            this.lb_logradouro.Text = "Logradouro:";
            // 
            // tb_logradouro
            // 
            this.tb_logradouro.Location = new System.Drawing.Point(106, 313);
            this.tb_logradouro.Name = "tb_logradouro";
            this.tb_logradouro.Size = new System.Drawing.Size(279, 23);
            this.tb_logradouro.TabIndex = 12;
            // 
            // lb_numeroLogradouro
            // 
            this.lb_numeroLogradouro.AutoSize = true;
            this.lb_numeroLogradouro.Location = new System.Drawing.Point(8, 403);
            this.lb_numeroLogradouro.Name = "lb_numeroLogradouro";
            this.lb_numeroLogradouro.Size = new System.Drawing.Size(116, 15);
            this.lb_numeroLogradouro.TabIndex = 13;
            this.lb_numeroLogradouro.Text = "Número Logradouro";
            // 
            // tb_numeroLogradouro
            // 
            this.tb_numeroLogradouro.Location = new System.Drawing.Point(144, 400);
            this.tb_numeroLogradouro.Name = "tb_numeroLogradouro";
            this.tb_numeroLogradouro.Size = new System.Drawing.Size(59, 23);
            this.tb_numeroLogradouro.TabIndex = 14;
            // 
            // lb_bairro
            // 
            this.lb_bairro.AutoSize = true;
            this.lb_bairro.Location = new System.Drawing.Point(11, 356);
            this.lb_bairro.Name = "lb_bairro";
            this.lb_bairro.Size = new System.Drawing.Size(41, 15);
            this.lb_bairro.TabIndex = 15;
            this.lb_bairro.Text = "Bairro:";
            // 
            // tb_bairro
            // 
            this.tb_bairro.Location = new System.Drawing.Point(106, 353);
            this.tb_bairro.Name = "tb_bairro";
            this.tb_bairro.Size = new System.Drawing.Size(158, 23);
            this.tb_bairro.TabIndex = 16;
            // 
            // lv_alunos
            // 
            this.lv_alunos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clNome,
            this.clRA,
            this.clDataNasc,
            this.clEmail,
            this.clCPF,
            this.clTelefone,
            this.clBairro,
            this.clLogradouro,
            this.clNumero});
            this.lv_alunos.HideSelection = false;
            this.lv_alunos.Location = new System.Drawing.Point(558, 18);
            this.lv_alunos.Name = "lv_alunos";
            this.lv_alunos.Size = new System.Drawing.Size(311, 198);
            this.lv_alunos.TabIndex = 17;
            this.lv_alunos.UseCompatibleStateImageBehavior = false;
            this.lv_alunos.View = System.Windows.Forms.View.Details;
            // 
            // clNome
            // 
            this.clNome.Text = "Nome";
            this.clNome.Width = 100;
            // 
            // clRA
            // 
            this.clRA.Text = "RA";
            this.clRA.Width = 85;
            // 
            // clDataNasc
            // 
            this.clDataNasc.Text = "DataNasc";
            this.clDataNasc.Width = 120;
            // 
            // clEmail
            // 
            this.clEmail.Text = "E-mail";
            this.clEmail.Width = 120;
            // 
            // clCPF
            // 
            this.clCPF.Text = "CPF";
            this.clCPF.Width = 80;
            // 
            // clTelefone
            // 
            this.clTelefone.Text = "Telefone";
            this.clTelefone.Width = 80;
            // 
            // clBairro
            // 
            this.clBairro.Text = "Bairro";
            this.clBairro.Width = 100;
            // 
            // clLogradouro
            // 
            this.clLogradouro.Text = "Logradouro";
            this.clLogradouro.Width = 300;
            // 
            // clNumero
            // 
            this.clNumero.Text = "Numero";
            // 
            // lb_datanascimento
            // 
            this.lb_datanascimento.AutoSize = true;
            this.lb_datanascimento.Location = new System.Drawing.Point(8, 145);
            this.lb_datanascimento.Name = "lb_datanascimento";
            this.lb_datanascimento.Size = new System.Drawing.Size(117, 15);
            this.lb_datanascimento.TabIndex = 18;
            this.lb_datanascimento.Text = "Data de Nascimento:";
            // 
            // bt_limpar
            // 
            this.bt_limpar.Image = global::Ficha_Aluno_POO_WF_03_11_2021.Properties.Resources.RaFfaMoreIra;
            this.bt_limpar.Location = new System.Drawing.Point(24, 456);
            this.bt_limpar.Name = "bt_limpar";
            this.bt_limpar.Size = new System.Drawing.Size(127, 122);
            this.bt_limpar.TabIndex = 20;
            this.bt_limpar.Text = "Limpar";
            this.bt_limpar.UseVisualStyleBackColor = true;
            this.bt_limpar.Click += new System.EventHandler(this.bt_limpar_Click);
            // 
            // numDia
            // 
            this.numDia.Location = new System.Drawing.Point(71, 177);
            this.numDia.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.numDia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDia.Name = "numDia";
            this.numDia.Size = new System.Drawing.Size(54, 23);
            this.numDia.TabIndex = 21;
            this.numDia.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMes
            // 
            this.numMes.Location = new System.Drawing.Point(189, 177);
            this.numMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMes.Name = "numMes";
            this.numMes.Size = new System.Drawing.Size(54, 23);
            this.numMes.TabIndex = 23;
            this.numMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbDia
            // 
            this.lbDia.AutoSize = true;
            this.lbDia.Location = new System.Drawing.Point(41, 179);
            this.lbDia.Name = "lbDia";
            this.lbDia.Size = new System.Drawing.Size(24, 15);
            this.lbDia.TabIndex = 22;
            this.lbDia.Text = "Dia";
            // 
            // lbMes
            // 
            this.lbMes.AutoSize = true;
            this.lbMes.Location = new System.Drawing.Point(144, 179);
            this.lbMes.Name = "lbMes";
            this.lbMes.Size = new System.Drawing.Size(29, 15);
            this.lbMes.TabIndex = 24;
            this.lbMes.Text = "Mês";
            // 
            // lbAno
            // 
            this.lbAno.AutoSize = true;
            this.lbAno.Location = new System.Drawing.Point(267, 179);
            this.lbAno.Name = "lbAno";
            this.lbAno.Size = new System.Drawing.Size(29, 15);
            this.lbAno.TabIndex = 25;
            this.lbAno.Text = "Ano";
            // 
            // numAno
            // 
            this.numAno.Location = new System.Drawing.Point(302, 177);
            this.numAno.Maximum = new decimal(new int[] {
            2021,
            0,
            0,
            0});
            this.numAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numAno.Name = "numAno";
            this.numAno.Size = new System.Drawing.Size(60, 23);
            this.numAno.TabIndex = 26;
            this.numAno.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(558, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(311, 188);
            this.dataGridView1.TabIndex = 27;
            // 
            // Cadastro_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 590);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numAno);
            this.Controls.Add(this.lbAno);
            this.Controls.Add(this.lbMes);
            this.Controls.Add(this.numMes);
            this.Controls.Add(this.lbDia);
            this.Controls.Add(this.numDia);
            this.Controls.Add(this.bt_limpar);
            this.Controls.Add(this.lb_datanascimento);
            this.Controls.Add(this.lv_alunos);
            this.Controls.Add(this.tb_bairro);
            this.Controls.Add(this.lb_bairro);
            this.Controls.Add(this.tb_numeroLogradouro);
            this.Controls.Add(this.lb_numeroLogradouro);
            this.Controls.Add(this.tb_logradouro);
            this.Controls.Add(this.lb_logradouro);
            this.Controls.Add(this.tb_cpf);
            this.Controls.Add(this.lb_cpf);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.tb_telefone);
            this.Controls.Add(this.lb_telefone);
            this.Controls.Add(this.tb_ra);
            this.Controls.Add(this.lb_ra);
            this.Controls.Add(this.bt_salvar);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.lb_nome);
            this.Name = "Cadastro_Aluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.Cadastro_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_salvar;
        private System.Windows.Forms.Label lb_ra;
        private System.Windows.Forms.TextBox tb_ra;
        private System.Windows.Forms.Label lb_telefone;
        private System.Windows.Forms.TextBox tb_telefone;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.TextBox tb_cpf;
        private System.Windows.Forms.Label lb_logradouro;
        private System.Windows.Forms.TextBox tb_logradouro;
        private System.Windows.Forms.Label lb_numeroLogradouro;
        private System.Windows.Forms.TextBox tb_numeroLogradouro;
        private System.Windows.Forms.Label lb_bairro;
        private System.Windows.Forms.TextBox tb_bairro;
        private System.Windows.Forms.ListView lv_alunos;
        private System.Windows.Forms.ColumnHeader clNome;
        private System.Windows.Forms.Label lb_datanascimento;
        private System.Windows.Forms.Button bt_limpar;
        private System.Windows.Forms.ColumnHeader clRA;
        private System.Windows.Forms.ColumnHeader clDataNasc;
        private System.Windows.Forms.ColumnHeader clEmail;
        private System.Windows.Forms.ColumnHeader clCPF;
        private System.Windows.Forms.ColumnHeader clTelefone;
        private System.Windows.Forms.ColumnHeader clBairro;
        private System.Windows.Forms.ColumnHeader clLogradouro;
        private System.Windows.Forms.ColumnHeader clNumero;
        private System.Windows.Forms.NumericUpDown numDia;
        private System.Windows.Forms.NumericUpDown numMes;
        private System.Windows.Forms.Label lbDia;
        private System.Windows.Forms.Label lbMes;
        private System.Windows.Forms.Label lbAno;
        private System.Windows.Forms.NumericUpDown numAno;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

