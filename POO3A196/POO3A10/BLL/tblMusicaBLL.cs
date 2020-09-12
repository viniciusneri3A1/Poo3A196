using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO3A10.DAL;
using POO3A10.DTO;

namespace POO3A10.BLL
{
    class tblMusicaBLL
    {

        private DALBD daoBanco = new DALBD();

        public DataTable PesquisarMusicas(string condicao)
        {
            string sql = string.Format($@"select * from TBL_Musica where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable PesquisarMusicas()
        {
            string sql = string.Format($@"select * from TBL_Musica");
            return daoBanco.ExecutarConsulta(sql);
        }

    }
}
