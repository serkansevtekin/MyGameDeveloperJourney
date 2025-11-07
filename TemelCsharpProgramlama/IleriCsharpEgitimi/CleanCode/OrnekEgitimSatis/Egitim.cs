using System;

namespace EgitimSatis
{
    public class Egitim : IEntity
    {
        public int Id { get; set; }
        public string? Ad { get; set; }
        public decimal Fiyat { get; set; }
    }
}