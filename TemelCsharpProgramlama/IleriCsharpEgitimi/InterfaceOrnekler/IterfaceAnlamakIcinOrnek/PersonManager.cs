using System;
namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces.KendiOrnegim
{
     class PersonManager
    {
        private IPersonDal _personDal;

        public PersonManager(IPersonDal personDal)
        {
            this._personDal = personDal;
        }

        public void Add() => _personDal.Add();
        public void Update() => _personDal.Update();
        public void Delete() => _personDal.Delete();
    }
}