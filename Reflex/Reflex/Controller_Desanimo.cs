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
 * Classe responsável por implementar o métodos da tabela desanimo
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
 * Reflex / Controller / Desanimo
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public sealed class Controller_Desanimo : IController_Desanimo
    {
        public void AddDesanimo(Desanimo d)
        {
            //Usuario padrão não pode conter nenhum registro
            if (d.IdUsuario == "1")
            {
                Window.abrirOperacaoInvalida();
            }
            else
            {
                try
                {
                    using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO tbl_desanimo(motivo_desanimo, pensamento, acao, id) VALUES (@motivo_desanimo, @pensamento, @acao, @id)";
                        cmd.Parameters.AddWithValue("@motivo_desanimo", d.Motivo);
                        cmd.Parameters.AddWithValue("@pensamento", d.Pensamento);
                        cmd.Parameters.AddWithValue("@acao", d.Acao);
                        cmd.Parameters.AddWithValue("@id", d.IdUsuario);

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


        public DataTable GetDesanimoTodosRegistros(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_desanimo, motivo_desanimo, pensamento, acao FROM tbl_desanimo WHERE id ='" + id + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
                return null;
                // throw ex;
            }
        }

        public DataTable GetDesanimoporData(string id, string dataRegistro, string dataAmanha)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_desanimo, motivo_desanimo, pensamento, acao FROM tbl_desanimo WHERE id ='" + id + "' AND data_registro_desanimo BETWEEN'" + dataRegistro + "' AND '" + dataAmanha + "'";
                    da = new SQLiteDataAdapter(cmd.CommandText, ConnectionFactory.RequestConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
                return null;
                // throw ex;
            }
        }

        //Dados já vem formatados
        public void AtualizarAcaoDesanimo(string id, string dataRegistro, string acao)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tbl_desanimo SET acao = @acao WHERE id = @id AND data_registro_desanimo = @data_registro_desanimo";
                    cmd.Parameters.AddWithValue("@acao", acao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data_registro_desanimo", dataRegistro);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    Window.abrirAtualizacaoDesanimo();
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


        public void DeletarDesanimo(string id, string dataRegistro)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_desanimo where id = @id AND data_registro_desanimo = @data_registro_desanimo";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data_registro_desanimo", dataRegistro);
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

        public void DeletarDesanimoTodosRegistros(string id)
        {
            //Excluir todos registros de humor de um usuário para poder deletá-lo da base de dados
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_desanimo where id = @id";
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
