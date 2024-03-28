namespace BackendNet.Models
{
    public class Campus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Campus(int id, string name)
        {

            this.Id = id;
            this.Name = name;

        }

        public Campus() { }

    }
}
