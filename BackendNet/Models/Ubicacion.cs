namespace BackendNet.Models
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public string Modality { get; set; }
        public string Name { get; set; }

        public Ubicacion(int id, string name, string modality)
        {
            this.Id = id;
            this.Name = name;
            this.Modality = modality;
        }
    }
}
