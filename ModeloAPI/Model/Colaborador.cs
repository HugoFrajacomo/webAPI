using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModeloAPI.Model
{
    [Table("Colaborador")]
    public class Colaborador
    {
        [Key]
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string foto { get; set; }

        public Colaborador(string nome, int idade, string foto)
        {
            this.nome = nome;
            this.idade = idade;
            this.foto = foto;
        }
    }
}
