using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entity;
namespace DAL
{
    public class logindal   
    {
        public bool Authenticate(loginentity le)
        {
            try
            {
                TrainingDBEntities db = new TrainingDBEntities();
                var data = (from t in db.RegisterShoppings
                            where t.Id == le.userid && t.passw == le.password
                            select t).SingleOrDefault();
                if (data == null)
                    throw new Exception("Invalid credentials");
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
