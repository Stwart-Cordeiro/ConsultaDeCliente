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
                SqlDataAdapter da = new SqlDataAdapter("SELECT con_numero, con_CpfCnpj FROM Consulta order by con_id desc", conexao.StringConexao);
                //order by  con_cnpjcpf

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
            cmd.CommandText = "SELECT con_numero, con_CpfCnpj FROM Consulta order by  con_CpfCnpj";
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.ConCod = Convert.ToInt32(registro["con_id"]);
                modelo.ConCnpjCpf = Convert.ToString(registro["con_cnpjcpf"]);
                modelo.ConTel = Convert.ToString(registro["con_tel"]);
            }
            conexao.Desconecta();
            return modelo;

        }
    }
}
