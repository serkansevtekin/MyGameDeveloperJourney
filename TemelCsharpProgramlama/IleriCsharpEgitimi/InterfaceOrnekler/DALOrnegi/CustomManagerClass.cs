using System;

namespace CSharpProgramlama.IleriCSharpEgitimi.Interfaces
{
    class CustomManager
    {

        // Constructor ile (dependency injection)
        private ICustomerDAL _custemerDAL;

        public CustomManager(ICustomerDAL customerDAL)
        {
            this._custemerDAL = customerDAL;
        }

        public void Add() => _custemerDAL.Add();
        public void Update() => _custemerDAL.Update();
        public void Delete() => _custemerDAL.Delete();




        /*  public void Add(ICustomerDAL customerDAL)
         {
             customerDAL.Add();
         }
  */

    }
}