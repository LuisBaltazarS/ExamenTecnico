using System.Numerics;

namespace BackendNet.Models
{
    public class Docente
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }

        public Docente(long id, string name, string code)
        {

            this.Id = id;
            this.Name = name;
            this.Code = code;

        }

        public Docente() { }

    }
}
