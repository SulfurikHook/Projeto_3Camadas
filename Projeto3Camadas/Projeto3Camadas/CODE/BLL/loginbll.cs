using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.CODE.DAL; //nomeProjeto.nomeDaPasta.nomeDaPasta
using System.Data;

namespace Projeto3Camadas.CODE.BLL
{
    class loginbll
    {
        //Objeto para acesso ao banco de dados
        conexaobd conexao = new conexaobd();
        string tabela = "usuario";

        public bool RealizarLogin(logindto login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
        }
}
