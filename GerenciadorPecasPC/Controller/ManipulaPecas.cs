using GerenciadorPecasPC.Model;
using GerenciadorPecasPC.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPecasPC.Controller
{
    internal class ManipulaPecas
    {
        public void CadPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pcadastrarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("capacidades", Pecas.Capacidade);

                SqlParameter nv = cmd.Parameters.Add("idPecas", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça Cadastrada com Sucesso, Deseja cadastrar outra Peça?",
                    "Novo registro", MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    TelaCadastrarPecas telaCadastro = new TelaCadastrarPecas();
                    telaCadastro.AbrirCadastro();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void BuscaPecasCod()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pBuscaPecasCodigo", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();

                var registros = cmd.ExecuteReader();

                if (registros.Read())
                {
                    Pecas.Codigo = Convert.ToInt32(registros["idPecas"]);
                    Pecas.Peca = (string)registros["pecas"];
                    Pecas.Marca = (string)registros["marcas"];
                    Pecas.Capacidade = (string)registros["capacidades"];
                }
                else
                {
                    Pecas.Codigo = 0;
                    Pecas.Peca = "";
                    Pecas.Marca = "";
                    Pecas.Capacidade = "";
                    MessageBox.Show("Peça não encontrada", "Pesquisa Código");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pDeletarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas", Pecas.Codigo);
                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Peça deletada com sucesso, Deseja deletar outra Peça?",
                    "Deletar registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

               
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void AlterarPecas()
        {
            SqlConnection cn = new SqlConnection(Conexao.Conectar());
            SqlCommand cmd = new SqlCommand("pAlterarPecas", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idPecas",Pecas.Codigo);
                cmd.Parameters.AddWithValue("pecas", Pecas.Peca);
                cmd.Parameters.AddWithValue("marcas", Pecas.Marca);
                cmd.Parameters.AddWithValue("capacidades", Pecas.Capacidade);

                cn.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Peça alterada com sucesso");

                Pecas.Codigo = 0;
                Pecas.Peca = "";
                Pecas.Marca = "";
                Pecas.Capacidade = "";

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
