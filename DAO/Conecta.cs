using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Exercicio_veiculo.DAO
{
    class Conecta
    {
        public static SqlConnection GetConexao()
        {
            SqlConnection conexao;

            try
            {
                conexao = new SqlConnection(@"Data Source=notefabio;Initial Catalog=producao;Integrated Security=True");
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao abrir banco de dados\n" + ex.ToString(), "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
