using System;

namespace Data.Entidade
{
    public class ReservaCliente
    {
        public string nome_cliente { get; set; }
        public int cpf { get; set; }
        public string nome_fabricante { get; set; }
        public string nome_modelo { get; set; }
        public string numero_placa { get; set; }
        public DateTime data_retirada { get; set; }
        public DateTime data_prev_devolucao { get; set; }
        public DateTime? data_devolucao { get; set; }
    }
}
