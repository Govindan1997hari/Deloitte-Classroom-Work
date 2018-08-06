using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using entity;
namespace bal
{
    public class loginbal
    {
        logindal dal = new logindal();
         public bool Authenticate(loginentity le)
        {
            if (le.password.Length < 2)
                throw new Exception("Password format incorrect");
            else
                return dal.Authenticate(le);
        }
    }
}
