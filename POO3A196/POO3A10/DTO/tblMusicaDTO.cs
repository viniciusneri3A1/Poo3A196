using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3A10.DTO
{
    class tblMusicaDTO
    {

        private int idMusica, idGravadora, idCD;
        private string nome, nomeAutor;

        public int Id_Musica { get => idMusica; set => idMusica = value; }
        public int Id_Gravadora { get => idGravadora; set => idGravadora = value; }
        public int Id_CD { get => idCD; set => idCD = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo nome é obrigatório.");
                }

            }
            get { return this.nome; }
        }

        public string Nome_Autor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("O campo nome do autor é obrigatório.");
                }

            }
            get { return this.nomeAutor; }
        }

    }
}
