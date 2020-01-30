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
 * Classe responsável por implementar o métodos da tabela meta
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
 * Reflex / Controller / Metas
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public sealed class Controller_Metas : IController_Metas
    {

        private SQLiteCommand cmd = new SQLiteCommand();

        public void AddNovaMeta(Meta m)
        {
            //Usuario padrão não pode conter nenhum registro
            if (m.IdUsuario == "1")
            {
                Window.abrirOperacaoInvalida();
            }
            else 
            {
                try
                {
                    using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO tbl_metas(descricao_meta, motivo_meta, id) VALUES (@descricao_meta, @motivo_meta, @id)";
                        cmd.Parameters.AddWithValue("@descricao_meta", m.MetaDescricao);
                        cmd.Parameters.AddWithValue("@motivo_meta", m.Motivo);
                        cmd.Parameters.AddWithValue("@id", m.IdUsuario);

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


        public DataTable GetTodasMetas(string id)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_meta, descricao_meta, motivo_meta, status_meta FROM tbl_metas WHERE id ='" + id + "'";
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


        public DataTable GetMetasporStatus(string id, string status)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    //Não será necessario innerjoin pois cada usuario verá apenas seus registros
                    cmd.CommandText = "SELECT data_registro_meta, descricao_meta, motivo_meta, status_meta FROM tbl_metas WHERE id ='" + id + "' AND status_meta = '" + status + "'";
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

        public void AtualizarStatusMeta(string id, string dataRegistro) 
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE tbl_metas SET status_meta = 'Realizada' WHERE id = @id AND data_registro_meta = @data_registro_meta";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data_registro_meta", dataRegistro);
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    Window.abrirMetaRealizada();
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


        public void DeletarMeta(string id, string dataRegistro)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_metas where id = @id AND data_registro_meta = @data_registro_meta";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@data_registro_meta", dataRegistro);
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

        public void DeletarTodasMetas(string id) 
        {
            //Excluir todas as metas de um usuário para poder deletá-lo da base de dados
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM tbl_metas where id = @id";
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
