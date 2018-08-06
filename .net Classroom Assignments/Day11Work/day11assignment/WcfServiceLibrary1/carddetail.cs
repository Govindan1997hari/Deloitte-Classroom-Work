using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceLibrary1
{
    class carddetail:icarddetail
    {
        AssignmentDBEntities db = new AssignmentDBEntities();
        public bool DateValidate(int cardno)
        {
            if(cardno<=0)
            {
                throw new Exception("Invalid Card Number");
            }
            else
            {
                var data = (from t in db.cardinfoes
                            where t.cardno == cardno
                            select t).SingleOrDefault();
                if(data==null)
                {
                    throw new Exception("Account Dosent Exist With the id " + cardno);
                }
                else
                {
                    DateTime expire = DateTime.Parse(data.expdate.ToString());
                    var data2 = (from t in db.cardinfoes
                                 where (t.cardno == cardno && expire>DateTime.Now)
                                 select t).SingleOrDefault();
                    if (data2 == null)
                        throw new Exception("Card Expired On " + expire);
                    else
                        return true;

                }
                
            }
        }
        public bool CvvValidate(int cardno, int cvv)
        {
            if (cvv < 0)
                throw new Exception("Invalid CVV Number (Enter The 3 Digit Number From Credit Card)");
            else
            {
                var data = (from t in db.cardinfoes
                            where (t.cardno == cardno && t.cvvno == cvv)
                            select t).SingleOrDefault();
                if (data == null)
                    throw new Exception("The CVV Number Does Not Match !");
                else
                    return true;
            }            
        }
        public bool BalValidation(int cardno,int amt)
        {
            if (amt < 0)
                throw new Exception("Enter The Amount To Be Withdrawn !");
            else
            {
                var data = (from t in db.cardinfoes
                            where (t.cardno == cardno && t.balance>amt)
                            select t).SingleOrDefault();
                if (data == null)
                    throw new Exception("Insufficient Balance");
                else
                {
                    data.balance = data.balance - amt;
                    db.SaveChanges();
                    return true;
                }
            }
        }
    }
}
