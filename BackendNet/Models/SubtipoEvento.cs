﻿namespace BackendNet.Models
{
    public class SubtipoEvento
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SubtipoEvento(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public SubtipoEvento() { }
    }
}
