using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            hMalServesContainer db = new hMalServesContainer();
            MFUsers user = new MFUsers();
            user.DOB = DateTime.Now;
            user.MFUserName = "hMailUser25";
            db.MFUsersSet.Add(user);
            db.SaveChanges();

            foreach (MFUsers item in db.MFUsersSet)
            {
                Console.WriteLine(item.Id + " " + item.MFUserName);
            }
        }
    }
}
