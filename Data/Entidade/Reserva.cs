using System;

namespace Data.Entidade
{
    public class Reserva
    {
        public long id_reserva { get; set; }
        public long id_cliente { get; set; }
        public long id_veiculo { get; set; }
        public DateTime data_retirada { get; set; }
        public DateTime data_prev_devolucao { get; set; }
        public DateTime data_devolucao { get; set; }
    }
}
