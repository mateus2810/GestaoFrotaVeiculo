
using System;

namespace Data.Entidade
{
    public  class Cliente
    {
        public int id_cliente { get; set; }
        public string? nome { get; set; }
        public long cpf { get; set; }
        public DateTime nascimento { get; set; }
        public int numero_cnh { get; set; }
        public string? endereco { get; set; }
    }
}
