using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Entity
    {
        public int Id { get; set; }
    }

    public class Cliente : Entity
    {
        public string Nome { get; set; }
        public string TelefoneResidencial { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string TelefoneCelular { get; set; }
    }
}
