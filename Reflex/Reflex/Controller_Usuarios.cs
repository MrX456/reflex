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
 * Classe responsável por implementar o métodos da tabela usuários
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
 * Reflex / Controller / Usuarios
 * @author MRX
 * Version : 1.0.0
 */

namespace Reflex
{
    public sealed class Controller_Usuarios : IController_Usuarios
    {
        private SQLiteCommand cmd = new SQLiteCommand();

        public static string nome;

        public void Login(string login, string senha, Form f)
        {
            cmd.CommandText = "SELECT * FROM tbl_usuarios WHERE login = '" + login + "' AND senha = '" + senha +"'";
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {

                cmd.Connection = ConnectionFactory.RequestConnection();

                // Ler os dados
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // Se retornou algum dado do banco de dados
                if (reader.HasRows)
                {
                    FrmHome h = new FrmHome();
                    h.Text = "Reflex - " + reader[1].ToString();
                    h.lblID.Text = reader[0].ToString();
                    h.lblNascimento.Text = reader[4].ToString();
                    h.Show();
                    f.Hide();
                   
                }
                else
                {
                    Window.abrirWarningLoginInvalido();
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


        public void CadastrarUsuario(Usuario u)
        {
            try
            {
                using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO tbl_usuarios(nome, login, senha, nascimento, sexo) VALUES (@nome, @login, @senha, @nascimento, @sexo)";
                    cmd.Parameters.AddWithValue("@nome", u.Nome);
                    cmd.Parameters.AddWithValue("@login", u.Login);
                    cmd.Parameters.AddWithValue("@senha", u.Senha);
                    cmd.Parameters.AddWithValue("@nascimento", u.Nascimento);
                    cmd.Parameters.AddWithValue("@sexo", u.Sexo);

                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();

                    Window.abrirCadastroOK();
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


        public SQLiteDataReader GetDadosUsuario(string id)
        {
            cmd.CommandText = "SELECT * FROM tbl_usuarios WHERE id = '" + id + "'";
            cmd.CommandType = System.Data.CommandType.Text;

            try
            {

                cmd.Connection = ConnectionFactory.RequestConnection();

                // Ler os dados
                SQLiteDataReader reader = cmd.ExecuteReader();
                reader.Read();

                // Se retornou algum dado do banco de dados
                if (reader.HasRows)
                {
                    return reader;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Misc.AbrirFormExcecao(Misc.PrintStackTrace(ex));
                return null;
            }
        }

        public void AtualizarDadosUsuario(Usuario u)
        {
            //Não permitir atualizaçao do user padrão
            if (u.IdUsuario == "1")
            {
                Window.abrirOperacaoInvalida();
            }
            else 
            {
                try
                {
                    using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE tbl_usuarios SET nome = @nome, login = @login, senha = @senha, nascimento = @nascimento, sexo = @sexo WHERE id = @id";
                        cmd.Parameters.AddWithValue("@nome", u.Nome);
                        cmd.Parameters.AddWithValue("@login", u.Login);
                        cmd.Parameters.AddWithValue("@senha", u.Senha);
                        cmd.Parameters.AddWithValue("@nascimento", u.Nascimento);
                        cmd.Parameters.AddWithValue("@sexo", u.Sexo);
                        cmd.Parameters.AddWithValue("@id", u.IdUsuario);

                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();

                        Window.abrirDadosAtualizados();
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

        public void DeletarUsuario(string id)
        {
            //Não permitir exclusão do user padrão
            if (id == "1")
            {
                Window.abrirOperacaoInvalida();
            }
            else 
            {
                try
                {
                    using (var cmd = ConnectionFactory.RequestConnection().CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM tbl_usuarios where id = @id";
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        Window.abrirDadosExcluidos();
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
}
