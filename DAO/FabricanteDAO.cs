using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Exercicio_veiculo.Classes;

namespace Exercicio_veiculo.DAO
{
    class FabricanteDAO
    {
        public string GravarFabricante(Fabricante fabricante)
        {
            string sql;
            int retorno;
            string resp;
            try
            {
                sql = "INSERT INTO fabricante( ID, descricao) ";
                sql += "VALUES (@id, @descricao)";
                SqlConnection conexao = Conecta.GetConexao();
                using (SqlCommand cmd = conexao.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.Parameters.AddWithValue("@id", fabricante.id);
                    cmd.Parameters.AddWithValue("@descricao", fabricante.descricao);

                    retorno = cmd.ExecuteNonQuery();
                    if (retorno > 0)
                    {
                        resp = "Cadastro efetuado";
                    }
                    else
                    {
                        resp = "Cadastro não realizado";
                    }
                    cmd.Dispose();
                }
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "ERRO: " + ex.ToString();
            }
            return resp;
        }

        public Fabricante ConsultaFabricante(string id)
        {
            Fabricante fabrica = new Fabricante();
            string sql;
            try
            {
                sql = "SELECT * FROM fabricante WHERE ID = @id";

                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd        = conexao.CreateCommand();
                cmd.CommandText       = sql;

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    fabrica.id        = dr["id"].ToString();
                    fabrica.descricao = dr["descricao"].ToString();
                }
                else
                {
                    fabrica = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha na consulta\n" + ex.ToString(), "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                fabrica = null;
            }
            return fabrica;
        }


        public string ExcluirFabricante(string id)
        {
            string sql;
            string resp;
            int    retorno;

            try
            {
                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd        = conexao.CreateCommand();
                sql                   = "DELETE from fabricante WHERE ID ='" + id + "'";
                cmd                   = new SqlCommand(sql, conexao);
                retorno               = cmd.ExecuteNonQuery();

                if (retorno > 0)
                {
                    resp = "Registro excluido";
                }
                else
                {
                    resp = "Não foi possível exluir o Registro!";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                resp = "";
            }
            return resp;
        }



        public string AlteraFabricante(Fabricante fabrica)
        {
            string resp;
            string sql;
            int    retorno;

            try
            {

                sql = "UPDATE fabricante SET ID = @id, descricao = @descricao"
                    + " WHERE ID ='" + fabrica.id + "'";
                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd        = conexao.CreateCommand();
                cmd.CommandText       = sql; 

                cmd.Parameters.AddWithValue("@id", fabrica.id);
                cmd.Parameters.AddWithValue("@descricao", fabrica.descricao);

                retorno = cmd.ExecuteNonQuery();

                if (retorno > 0)
                {
                    resp = "Alterado com sucesso!";
                }
                else
                {
                    resp = "Não foi possivel alerar!";
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
                resp = "erro";
            }
            return resp;

        }
    }
}
