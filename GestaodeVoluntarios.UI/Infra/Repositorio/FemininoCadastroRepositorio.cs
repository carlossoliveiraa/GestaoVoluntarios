using GestaodeVoluntarios.UI.Infra.Contexto;
using GestaodeVoluntarios.UI.Infra.Interfaces;
using GestaodeVoluntarios.UI.Models.Feminino;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaodeVoluntarios.UI.Infra.Repositorio
{
    public class FemininoCadastroRepositorio : RepositorioBasico<FemininoCadastro>, IFemininoCadastroRepositorio
    {
        public IConfiguration _configuration { get; }

        public static SqlCommand cmd = new SqlCommand();

        public FemininoCadastroRepositorio(ContextoVoluntarios contexto, IConfiguration configuration) : base(contexto)
        {
            _configuration = configuration;
        }

        public FemininoCadastro ObterCadastroFemininosPorId(int id)
        {
            try
            {
                return contexto.FemininoCadastros.AsNoTracking().FirstOrDefault(p => p.Id == id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<FemininoCadastro> ObterCadastroFemininosTodos()
        {
            try
            {
                return contexto.FemininoCadastros.AsNoTracking().ToArray();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public List<FemininoCadastro> FiltrarnoBackEnd(bool ativo, int masculinoId, string classesocial, int idadeDe, int idadeAte, string nome)
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
                              " ,FemininoCadastroId " +
                              " ,CadastroNome " +
                              " ,CadastroRG " +
                              " ,CadastroIdade " +
                              " ,CadastroClasseSocial " +
                              " ,CadastroIdade " +
                        " From FemininoCadastros ");
                    sb.Append($" Where Ativo = {Convert.ToUInt32(ativo)} ");
                    if (masculinoId != 0)
                        sb.Append($" And FemininoCadastroId = {masculinoId} ");
                    if (classesocial != "0")
                        sb.Append($" And CadastroClasseSocial = '{classesocial}' ");
                    if (idadeDe != 0 || idadeAte != 0)
                        sb.Append($" And CadastroIdade Between {idadeDe} And {idadeAte} ");
                    if (!string.IsNullOrEmpty(nome))
                        sb.Append($" And CadastroNome Like '%{nome}%' ");
                    sb.Append(" Order By FemininoCadastroId ");

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
      
        public List<FemininoCadastro> ObterCadastroFemininoTodosSql(bool ativo, int pagina, int tamPagina)
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
                            FROM FemininoCadastros
                            WHERE Ativo = {0}    
                            order by Id desc
                            OFFSET {1} ROWS
                            FETCH NEXT {2} ROWS ONLY",
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

        private List<FemininoCadastro> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            try
            {
                var femininoCadastro = new List<FemininoCadastro>();
                while (reader.Read())
                {
                    int valorSaida;
                    var obj = new FemininoCadastro()
                    {
                        Id = int.TryParse(reader["Id"].ToString(), out valorSaida) ? valorSaida : 0,
                        FemininoCadastroId = int.TryParse(reader["FemininoCadastroId"].ToString(), out valorSaida) ? valorSaida : 0,
                        CadastroIdade = int.TryParse(reader["CadastroIdade"].ToString(), out valorSaida) ? valorSaida : 0,
                        CadastroNome = reader["CadastroNome"].ToString(),
                        CadastroRG = reader["CadastroRG"].ToString(),
                        CadastroClasseSocial = reader["CadastroClasseSocial"].ToString(),
                        Ativo = bool.Parse(reader["Ativo"].ToString())
                    };
                    femininoCadastro.Add(obj);
                }
                reader.Close();
                return femininoCadastro;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<FemininoCadastro> ObterCadastroFemininoPorParametros(string parametros)
        {
            try
            {
                var listafeminino = new List<FemininoCadastro>();

                var result = contexto.FemininoCadastros.Where(p => p.Ativo.Equals(true)).Select(p => new FemininoCadastro
                {
                    Id = p.Id,
                    FemininoCadastroId = p.FemininoCadastroId,
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
