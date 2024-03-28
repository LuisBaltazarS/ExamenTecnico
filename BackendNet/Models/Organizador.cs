namespace BackendNet.Models
{
    public class Organizador
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Organizador(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public Organizador() { }
    }
}
