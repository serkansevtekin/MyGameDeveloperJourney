using System;
using Entity.Abstract;

namespace Entity.Concrete
{
    public class Product: IEntity
    {
        public string? Name { get; set; }
    }
}