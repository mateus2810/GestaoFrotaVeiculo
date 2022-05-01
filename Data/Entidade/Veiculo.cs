namespace Data.Entidade
{
    public  class Veiculo
    {
        public long? id_veiculo { get; set; }
        public long? id_cliente { get; set; }
        public long? id_fabricante { get; set; }
        public long? id_modelo { get; set; }
        public string? numero_placa { get; set; }
        public string? chassi { get; set; }
    }
}
