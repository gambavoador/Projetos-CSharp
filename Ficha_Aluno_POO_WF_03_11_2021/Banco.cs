using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Windows.Forms;

namespace Ficha_Aluno_POO_WF_03_11_2021
{
    public class Banco
    {
        public void conexao()

        { 
        MySqlConnection sqlConexao;
        sqlConexao = new MySqlConnection("Persist Security Info=False;server = localhost; database = Cadastro_Aluno; uid = root; pwd = 1234");
        MySqlDataAdapter sqlAdapter;
        DataSet dataSet = new DataSet();

        try
        {
          sqlConexao.Open();
        }

        catch (System.Exception ex)
        {
          MessageBox.Show(ex.Message.ToString());
        }
        
        
        if (sqlConexao.State == System.Data.ConnectionState.Open)
        {
          string query = "select * from Aluno";
          sqlAdapter = new MySqlDataAdapter(query, sqlConexao);
          sqlAdapter.Fill(dataSet, "Aluno");
               
        }

        }
    }
}
