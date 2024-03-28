namespace BackendNet.Models
{
    public class EventoCampus
    {
        public int EventoId { get; set; }
        public Evento Evento { get; set; }

        public int CampusId { get; set; }
        public Campus Campus { get; set; }
    }
}
