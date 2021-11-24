using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.CODE.DTO
{
    class facebookdto
    {
        //Properiedades privadas
        private int _id;
        private string _legenda;
        private string _local_postagem;

        //Métodos de encapsulamento (CTRL+R,E)
        public int Id { get => _id; set => _id = value; }
        public string Legenda { get => _legenda; set => _legenda = value; }
        public string Local_postagem { get => _local_postagem; set => _local_postagem = value; }
    }
}
