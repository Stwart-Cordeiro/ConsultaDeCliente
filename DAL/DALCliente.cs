using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace DAL
{
    public class DALCliente
    {
        private DALConexao conexao;

        public DALCliente(DALConexao cx)
        {
            conexao = cx;
        }

        public DataTable Localizar()
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT TOP(12) con_numero, con_CpfCnpj, con_fila FROM Consulta order by con_id desc";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                
                da.Fill(tabela);
                return tabela;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public DataTable LocalizarPorData(DateTime inicio,DateTime final)
        {
            try
            {
                DataTable tabela = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT con_numero,con_CpfCnpj,con_data FROM Consulta WHERE con_data BETWEEN @dtInicial + 00:00:00 AND @dtFinal + 23:59:59";
                cmd.Parameters.Add("@dtInicial", SqlDbType.DateTime);
                cmd.Parameters["@dtInicial"].Value = inicio;
                cmd.Parameters.Add("@dtFinal", SqlDbType.DateTime);
                cmd.Parameters["@dtFinal"].Value = final;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(tabela);
                return tabela;
            }
            catch (SqlException erro)
            {
                throw erro;
            }
        }

        public ModeloCliente CarregaModeloCliente()
        {
            ModeloCliente modelo = new ModeloCliente();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT TOP(12) con_numero, con_CpfCnpj, con_fila FROM Consulta order by  con_CpfCnpj";
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ConCod = Convert.ToInt32(registro["con_id"]);
                modelo.ConCnpjCpf = Convert.ToString(registro["con_cnpjcpf"]);
                modelo.ConTel = Convert.ToString(registro["con_tel"]);
                modelo.ConFila = Convert.ToString(registro["con_fila"]);
            }
            conexao.Desconecta();
            return modelo;

        }
    }
}
