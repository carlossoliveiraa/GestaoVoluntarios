using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models.Masculino;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace GestaodeVoluntarios.UI.Infra.Repositorio
{
    public sealed class MasculinoCadastroRepositorio : RepositorioBasico<MasculinoCadastro>, IMasculinoCadastroRepositorio
    {
        public IConfiguration _configuration { get; }

        public static SqlCommand cmd = new SqlCommand();

        public MasculinoCadastroRepositorio(ContextoVoluntarios contexto, IConfiguration configuration) : base(contexto)
        {
            _configuration = configuration;
        }

        public MasculinoCadastro ObterCadastroMasculinosPorId(int id)
        {
            try
            {
                return contexto.MasculinoCadastros.AsNoTracking().FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<MasculinoCadastro> ObterCadastroMasculinosTodos()
        {
            try
            {
                return contexto.MasculinoCadastros.AsNoTracking().ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MasculinoCadastro> FiltrarnoBackEnd(bool ativo, int masculinoId, string classesocial, int idadeDe, int idadeAte, string nome)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    conn.Open();
                    cmd.Connection = conn;

                    StringBuilder sb = new StringBuilder();

                    sb.Append("Select " +
                              " Id " +
                              " ,Ativo " +
                              " ,MasculinoCadastroId " +
                              " ,CadastroNome " +
                              " ,CadastroRG " +
                              " ,CadastroIdade " +
                              " ,CadastroClasseSocial " +
                              " ,CadastroIdade " +
                        " From MasculinoCadastros ");
                    sb.Append($" Where Ativo = {Convert.ToUInt32(ativo)} ");
                    if (masculinoId != 0)
                        sb.Append($" And MasculinoCadastroId = {masculinoId} ");
                    if (classesocial != "0")
                        sb.Append($" And CadastroClasseSocial = '{classesocial}' ");
                    if (idadeDe != 0 || idadeAte != 0)
                        sb.Append($" And CadastroIdade Between {idadeDe} And {idadeAte} ");
                    if (!string.IsNullOrEmpty(nome))
                        sb.Append($" And CadastroNome Like '%{nome}%' ");
                    sb.Append(" Order By MasculinoCadastroId ");

                    cmd.CommandText = sb.ToString();
                    var retornoDataReader = cmd.ExecuteReader();
                    return TransformaReaderEmListaDeObjeto(retornoDataReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MasculinoCadastro> ObterCadastroMasculinosTodosSql(bool ativo, int pagina, int tamPagina)
        {
            try
            {
                using (var conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    var pos = (pagina - 1) * tamPagina;

                    var strQuery = string.Format(
                        @"  SELECT * 
                            FROM MasculinoCadastros
                            WHERE Ativo = {0}    
                            order by Id desc
                            OFFSET {1} ROWS
                            FETCH NEXT {2} ROWS ONLY ",
                            Convert.ToInt32(ativo), pos > 0 ? pos : 0, tamPagina);

                    cmd.CommandText = strQuery;
                    var retornoDataReader = cmd.ExecuteReader();
                    return TransformaReaderEmListaDeObjeto(retornoDataReader);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private List<MasculinoCadastro> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            try
            {
                var masculinoCadastro = new List<MasculinoCadastro>();
                while (reader.Read())
                {
                    int valorSaida;
                    var obj = new MasculinoCadastro()
                    {
                        Id = int.TryParse(reader["Id"].ToString(), out valorSaida) ? valorSaida : 0,
                        MasculinoCadastroId = int.TryParse(reader["MasculinoCadastroId"].ToString(), out valorSaida) ? valorSaida : 0,
                        CadastroIdade = int.TryParse(reader["CadastroIdade"].ToString(), out valorSaida) ? valorSaida : 0,
                        CadastroNome = reader["CadastroNome"].ToString(),
                        CadastroRG = reader["CadastroRG"].ToString(),
                        CadastroClasseSocial = reader["CadastroClasseSocial"].ToString(),
                        Ativo = bool.Parse(reader["Ativo"].ToString())
                    };
                    masculinoCadastro.Add(obj);
                }
                reader.Close();
                return masculinoCadastro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<MasculinoCadastro> ObterCadastroMasculinoPorParametros(string parametros)
        {
            try
            {
                var listamasculino = new List<MasculinoCadastro>();

                var result = contexto.MasculinoCadastros.Where(p => p.Ativo.Equals(true)).Select(p => new MasculinoCadastro
                {
                    Id = p.Id,
                    MasculinoCadastroId = p.MasculinoCadastroId,
                    CadastroNome = p.CadastroNome,
                    CadastroRG = p.CadastroRG,
                    CadastroClasseSocial = p.CadastroClasseSocial
                }
                  ).Where(m => m.CadastroNome.Contains(parametros)

                  ).ToList();


                //).Where(m => m.CadastroNome.Contains(parametros)
                //                                || m.CadastroRG.Contains(parametros)
                //                                || m.CPF.Contains(parametros)
                //                                || m.CadastroClasseSocial.Contains(parametros)).ToList(); 

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
