/*
 * Reflex - Software de auto ajuda.
 * Copyright (C) 2020  Quantum Comp IT Solutions
 
 * Este arquivo é parte do programa Reflex
 * Reflex é um software livre; você pode redistribuí-lo e/ou
 * modificá-lo dentro dos termos da Licença Pública Geral GNU como
 * publicada pela Free Software Foundation (FSF); na versão 3 da
 * Licença, ou qualquer versão posterior.

 * Este programa é distribuído na esperança de que possa ser útil,
 * mas SEM NENHUMA GARANTIA; sem uma garantia implícita de ADEQUAÇÃO
 * a qualquer MERCADO ou APLICAÇÃO EM PARTICULAR. Veja a
 * Licença Pública Geral GNU para maiores detalhes.

 * Você deve ter recebido uma cópia da Licença Pública Geral GNU junto
 * com este programa, Se não, veja <https://www.gnu.org/licenses/gpl-3.0.txt>.
 */

/*
 * Classe responsável por implementar o métodos da tabela alegria
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SQLite;
using DAL;
using System.Windows.Forms;
using Cypher;

/*
 * Reflex / Controller / Alegria
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public sealed class Controller_Alegria : IController_Alegria
    {
        public void AddAlegria(Cypher.Alegria a)
        {
            //Usuario padrão não pode conter nenhum registro
            if (a.IdUsuario == "1")
            {
                Window.abrirOperacaoInvalida();
            }
            else
            {
                try
                {
                    using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO tbl_alegria(descricao_alegria, id) VALUES (@descricao_alegria, @id)";
                        cmd.Parameters.AddWithValue("@descricao_alegria", a.DescricaoAlegria);
                        cmd.Parameters.AddWithValue("@id", a.IdUsuario);

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        Window.abrirOperacaoOK();
                    }

                }
                catch (Exception e)
                {
                    Misc.AbrirFormExcecao(Misc.PrintStackTrace(e));
                }
                finally
                {
                    ConnectionFactory.DisposeConnection();
                }
            }
        }


        public DataTable GetAlegriaTodosRegistros(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_alegria, descricao_alegria FROM tbl_alegria WHERE id ='" + id + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
                return null;
            }
        }

        public DataTable GetAlegriaporData(string id, string dataRegistro, string dataAmanha)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_alegria, descricao_alegria FROM tbl_alegria WHERE id ='" + id + "' AND data_registro_alegria BETWEEN '" + dataRegistro + "' AND '" + dataAmanha + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
                return null;
            }
        }


        public void DeletarAlegria(string id, string dataRegistro)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_alegria where id = @id AND data_registro_alegria = @data_registro_alegria";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data_registro_alegria", dataRegistro);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }

        public void DeletarAlegriaTodosRegistros(string id)
        {
            //Excluir todos registros de humor de um usuário para poder deletá-lo da base de dados
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_alegria where id = @id";
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
            }
            finally
            {
                ConnectionFactory.DisposeConnection();
            }
        }
    }
}
