/*
 * Classe responsável pelo acesso ao banco de dados
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

/*
 * Reflex / DAL / ConnectionFactory
 * @author MRX
 * Version : 1.0.0
 */

namespace DAL
{
    public sealed class ConnectionFactory
    {

        //Objeto para conexão
        private static SQLiteConnection conn;

        // Método de conexão
        public static SQLiteConnection RequestConnection()
        {
            conn = new SQLiteConnection("Data Source=" + Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Reflex - Documentos\\database\\db_reflex.sqlite;Version=3;");
            conn.Open();
            return conn;
        }

        //Desconectar
        public static void DisposeConnection() 
        {
            if (conn.State == System.Data.ConnectionState.Open) 
            {
                conn.Close();
            }
        }
    }
}
