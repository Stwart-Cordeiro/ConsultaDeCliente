using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {
        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            conexao = cx;
        }

        public DataTable Localizar()
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar();
        }

        public ModeloCliente CarregaModeloCliente()
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente();

        }
    }
}
