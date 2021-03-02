using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    class CustomerManager
    {
        public void Ekle(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
