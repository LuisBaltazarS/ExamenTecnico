using System.Numerics;

namespace BackendNet.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        //Relations
        
        //TipoEvento
        public int TipoEventoId { get; set; }
        public TipoEvento TipoEvento { get; set; }

        //SubtipoEvento
        public int SubtipoEventoId {  get; set; }
        public SubtipoEvento SubtipoEvento { get; set; }

        //Organizador
        public int OrganizadorId {  get; set; }
        public Organizador Organizador { get; set; }

        //Docente
        public long DocenteId { get; set; }
        public Docente Docente { get; set; }

        //CampusEvento
        public ICollection<EventoCampus> EventoCampus { get; set; }

        //Ubicación
        public int UbicacionId { get; set; }
        public Ubicacion Ubicacion { get; set;}

    }
}
