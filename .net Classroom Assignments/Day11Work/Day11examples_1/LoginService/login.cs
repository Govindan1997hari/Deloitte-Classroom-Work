using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginService
{
    public class login : ilogin
    {
        public bool authenticate(int id, string password)
        {
            TrainingDBEntities db = new TrainingDBEntities();
            if (id <= 0)
                throw new ArgumentException("ID cannot be negative or 0");
            else if (string.IsNullOrEmpty(password))
                throw new ArgumentException("Passowrd Cannot be null");
            else
            {
                var data = (from t in db.RegisterShoppings
                            where (t.Id == id && t.passw == password)
                            select t).SingleOrDefault();
                if (data == null)
                    throw new ArgumentException("Invalid UserName/Password");
                else
                    return true;
            }
        }
    }
}
