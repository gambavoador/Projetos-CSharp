using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Ficha_Aluno_POO_WF_03_11_2021
{
    
    public partial class Cadastro_Aluno : Form
    {
        Lista_Aluno listaAluno = new Lista_Aluno();
        Aluno aluno = new Aluno();
        public Cadastro_Aluno()
        {
            InitializeComponent();
        }
    

        public void BotaoLimpar()
        {
            tb_nome.Text = "";
            tb_ra.Text = "";
            tb_telefone.Text = "";
            tb_email.Text = "";
            tb_cpf.Text = "";
            tb_logradouro.Text = "";
            tb_numeroLogradouro.Text = "";
            tb_bairro.Text = "";
            numDia.Value = 1;
            numMes.Value = 1;
            numAno.Value = 1900;
            aluno.ra = 0;



        }



        private void bt_salvar_Click(object sender, EventArgs e)
        {
            

            aluno.nome = tb_nome.Text;
            aluno.telefone = tb_telefone.Text;
            aluno.email = tb_email.Text;
            aluno.cpf = tb_email.Text;
            aluno.logradouro = tb_logradouro.Text;
            aluno.numeroLogradouro = Convert.ToInt32(tb_numeroLogradouro.Text);
            aluno.bairro = tb_bairro.Text;
            aluno.datanascimento = new DateTime(Convert.ToInt32(numAno.Value), Convert.ToInt32(numMes.Value), Convert.ToInt32(numDia.Value));




            listaAluno.AdicionarAluno(aluno);


            ListViewItem item = new ListViewItem(new[] { Convert.ToString(aluno.nome), Convert.ToString(aluno.ra), Convert.ToString(aluno.datanascimento.ToShortDateString()), Convert.ToString(aluno.email), Convert.ToString(aluno.cpf), Convert.ToString(aluno.telefone), Convert.ToString(aluno.bairro), Convert.ToString(aluno.logradouro), Convert.ToString(aluno.numeroLogradouro) });
            lv_alunos.Items.Add(item);
            BotaoLimpar();
          }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            BotaoLimpar();
        }

        private void tb_cpf_Leave(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tb_cpf.Text)) && aluno.ra == 0)
            {
                aluno.ra = Convert.ToInt32(tb_cpf.Text.Substring(0, 5).Insert(5, Convert.ToString(numAno.Value)));
                tb_ra.Text = Convert.ToString(aluno.ra);
            }
        }

        private void Cadastro_Aluno_Load(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            banco.conexao();
        }
    }
}
