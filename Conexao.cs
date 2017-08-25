using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ExtractServerPhotosWithProcedure
{
    class Conexao
    {
        //Referencia: http://splintersharp.blogspot.com.br/2010/08/criando-uma-classe-de-conexao-para-suas.html

        private static string connString = "Data Source=XXXX;Initial Catalog=XXXX; user id=XXXX; password=XXXX;";
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException sqle)
            {
                conn = null;
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }
}