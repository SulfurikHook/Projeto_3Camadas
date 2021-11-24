using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importação da camada de negócio e da camada de acesso a dados
using Projeto3Camadas.CODE.DTO; //nomeProjeto.nomeDaPasta.nomeDaPasta
using Projeto3Camadas.CODE.DAL;
using System.Data;

namespace Projeto3Camadas.CODE.BLL
{
    class facebookbll
    {
        //Objeto para acesso ao banco de dados
        conexaobd conexao = new conexaobd();
        string tabela = "postagens";

        //O método de inserir recebe os dados via DTO 
        //e envia para o banco de dados através da classe AcessoBancoDados
        public void Inserir(facebookdto medDto)
        {
            //Antes de criar o comando aqui, teste no PhpMyAdmin ou Worckbench
            string inserir = $"insert into {tabela} values(null,'{medDto.Legenda}','{medDto.Local_postagem}')";
            conexao.ExecutarComando(inserir);
        }

        public DataTable Listar()      //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(facebookdto meddDto)
        {
            string alterar = $"update {tabela} set legenda = '{meddDto.Legenda}', local_postagem = '{meddDto.Local_postagem}' where id = '{meddDto.Id}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(facebookdto medDto)
        {
            string excluir = $"delete from {tabela} where id = '{medDto.Id}';";
            conexao.ExecutarComando(excluir);
        }
        }
}
