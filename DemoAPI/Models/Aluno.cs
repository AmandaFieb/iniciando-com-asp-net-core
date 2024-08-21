using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Models
{
    public class Aluno
    {
        public class Aluno
        {
            public int Id { get; set; }

            public string? None { get; set; }

            public string? Email { get; set; }

            [DataType(DataType.Date)]

            public DateTime? DataCadastro { get; set; }

            public bool Ativo { get; set; }
        }
    }
}
