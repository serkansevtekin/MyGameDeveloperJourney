using System;
using Entity.Concrete;

namespace Business.Abstract
{
      public interface IPersonService
    {
        bool CheckPerson(Persons person);
    }

}