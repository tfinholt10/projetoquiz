using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Incluir connector MySQL
using MySql.Data.MySqlClient;
using System.Data;

namespace quiz1guerra
{
    public class THO
    {
        #region Atributos
        private MySqlConnection _conexao;
        private MySqlCommand _comandoDB;
        private MySqlDataAdapter _adaptador;
        private DataSet _dados;
        #endregion

        #region Getters e Setters 
        public string Host { get; set; } = "localhost";
        public string DBName { get; set; } = "";
        public string Usuario { get; set; } = "root";
        public string Senha { get; set; } = "";
        #endregion

        #region Construtor
        public THO() { }
        #endregion

        #region Métodos
        public void Conectar()
        {
            // dados da conexão
            //servidor, nome do banco, usario e senha
            // Server=<host>;Database=<banco>;Uid=<usuario>;Pwd=<senha>

            string strConexao = "Server=" + Host;
            strConexao += ";Database=" + DBName;
            strConexao += ";Uid=" + Usuario;
            strConexao += ";Pwd=" + Senha;
            strConexao += ";SSL Mode=None";
            // Server=localhost;Database=;Uid=root;Senha=

            try
            {// Bloco de comandos sujeito a erros       
                _conexao = new MySqlConnection(strConexao);
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

            }
            catch (MySqlException erro)
            {// Captura o erro, caso ocorra
                throw new Exception(erro.Message);
            }
            finally
            {// Libera o recurso, caso necessário, mesmo no erro
                _conexao.Dispose();
            }



        }

        public void Inserir(string strSQL)
        {

            try
            {
                if (_conexao.State.Equals(ConnectionState.Closed))
                {
                    _conexao.Open();
                }

                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao inserir");
                }
            }
            catch (MySqlException erro)
            {
                throw new Exception("Erro ao inserir: " + erro.Message);
            }
        }
        public DataSet Buscar(string strSQL)
        {
            _dados = new DataSet();
            _adaptador = new MySqlDataAdapter(strSQL, _conexao);
            _adaptador.Fill(_dados, "tbl_resultado");
            return _dados;
        }
        public void Atualizar(string strSQL, List<MySqlParameter> valores)
        {
            if(_conexao.State.Equals(ConnectionState.Closed))
            {
                _conexao.Open();
            }
            try
            {
                _comandoDB = _conexao.CreateCommand();
                _comandoDB.CommandText = strSQL;

                foreach (MySqlParameter valor in valores)
                {
                    _comandoDB.Parameters.Add(valor);
                }
                if (_comandoDB.ExecuteNonQuery() != 1)
                {
                    throw new Exception("Falha ao atualizar os dados!");
                }


            }

            catch(MySqlException erro)
            {
                throw new Exception(erro.Message);
            }
        }

        public void Excluir() { }
        #endregion
    }
}
