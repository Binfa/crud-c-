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
    class VeiculoDAO
    {
        public String GravarVeiculo(Veiculo veiculo)
        {
            string sql;
            int retorno;
            string resp;
            try
            {
                sql = "INSERT INTO veiculo( ID, modelo, ano, preco, ID_fabricante) ";
                sql += "VALUES (@id, @modelo, @ano, @preco, @id_fabricante)";
                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd = conexao.CreateCommand();

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", veiculo.id);
                cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
                cmd.Parameters.AddWithValue("@ano", veiculo.ano);
                cmd.Parameters.AddWithValue("@preco", veiculo.preco);
                cmd.Parameters.AddWithValue("@id_fabricante", veiculo.ID_fabricante);

                retorno = cmd.ExecuteNonQuery();
                if (retorno > 0)
                {
                    resp = "Cadastro de veículo efetuado";
                }
                else
                {
                    resp = "Cadastro não realizado";
                }
                cmd.Dispose();
                conexao.Dispose();
            }
            catch (SqlException ex)
            {
                resp = "ERRO: " + ex.ToString();
            }
            return resp;
        }



        public Veiculo ConsultaVeiculo(string id)
        {
            Veiculo veiculo = new Veiculo();
            string sql;
            try
            {
                sql = "SELECT * FROM veiculo WHERE ID = @id";
                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd        = conexao.CreateCommand();
                cmd.CommandText       = sql;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr      = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    veiculo.id            = Int32.Parse(dr["id"].ToString());
                    veiculo.modelo        = dr["modelo"].ToString();
                    veiculo.ano           = Int32.Parse(dr["ano"].ToString());
                    veiculo.preco         = float.Parse(dr["preco"].ToString());
                    veiculo.ID_fabricante = dr["id_fabricante"].ToString();
                }
                else
                {
                    veiculo = null;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Falha na consulta\n" + ex.ToString(), "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                veiculo = null;
            }
            return veiculo;
        }


        public string ExcluirVeiculo(string id)
        {
            string sql;
            string resp;
            int retorno;

            try
            {
                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd = conexao.CreateCommand();

                sql = "DELETE from veiculo WHERE ID ='" + id + "'";
                cmd = new SqlCommand(sql, conexao);
                retorno = cmd.ExecuteNonQuery();

                if (retorno > 0)
                {
                    resp = "Registro excluido";
                }
                else
                {
                    resp = "Não foi possível excluir o Registro!";
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



        public string AlteraVeiculo(Veiculo veiculo)
        {
            string resp;
            string sql;
            int retorno;

            try
            {

                sql = "UPDATE veiculo SET ID = @id, modelo = @modelo, ano = @ano, preco = @preço"
                    + " WHERE ID ='" + veiculo.id + "'";

                SqlConnection conexao = Conecta.GetConexao();
                SqlCommand cmd        = conexao.CreateCommand();
                cmd.CommandText       = sql;

                cmd.Parameters.AddWithValue("@id", veiculo.id);
                cmd.Parameters.AddWithValue("@modelo", veiculo.modelo);
                cmd.Parameters.AddWithValue("@ano", veiculo.ano);
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
