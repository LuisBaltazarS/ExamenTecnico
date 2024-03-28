namespace BackendNet.Models
{
    public class TipoEvento
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public TipoEvento(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public TipoEvento() { }
    }
}
