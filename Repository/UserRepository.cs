using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Repository.Utils;

namespace Repository
{
 public class UserRepository : IUserRepository
    {
        private string dbcon;
       public  UserRepository(string dbname) { dbcon = dbname; }

        public List<User> getall()
        {

            using (var v = new MyContext(dbcon))
            {
                List<User> dictionary = v.Users.OrderByDescending(o => o.Username).ToList();

                return dictionary;
            }

        }
        public User findOne(string user, string password)

        {
           
            
          using (var v=new MyContext(dbcon))
            {
                List<User> us = v.Users.Where(u => u.Username == user).ToList();
                foreach (var el in us)
                {
                    if (PasswordHash.ValidatePassword(password, el.Password))
                    { return el; }
                }
            }
            return null;
        }

        public User delete(string user, string password)
        {
           
            using (var v = new MyContext(dbcon))
            {
                User us = findOne(user, password);
                if (us != null)
                {
                    v.Users.Attach(us);
                    v.Users.Remove(us);
                    v.SaveChanges();
                    return us;
                }
            }
            return null;

        }

        public User add(string username,string password,Status st,int section)
        {

            using (var v = new MyContext(dbcon))
            {
                if (findOne(username, password) == null)
                {
                    User us = new User();
                    us.Username = username;
                    us.Password = PasswordHash.HashPassword(password);
                    us.Status = st;
                    us.SectieID = section;
                    v.Users.Add(us);
                    v.SaveChanges();
                    return us;
                }
            }
            return null;

        }

        public User update(int id,string username, string password, Status st)
        {

            using (var v = new MyContext(dbcon))
            {
                var result = v.Users.SingleOrDefault(b => b.UserID == id);
                if (result != null)
                {
                    result.Username = username;

                    result.Password = PasswordHash.HashPassword(password);
                    result.Status = st;
                    v.SaveChanges();
                }
            }
            return null;

        }

        public User find(int id)
        {
            using (var v = new MyContext(dbcon))
            {
                User o = v.Users.First(c => c.UserID == id);
                return o;
            }
            return null;
        }
    }
}
