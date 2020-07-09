using Model;
using System.Collections.Generic;

namespace Repository
{
    public interface IUserRepository
    {
        List<User> getall();
        /*
         * string user-name of the user
         * string password - password of user
         * 
         * find a user based on user and password, returns null if not found
         */


        User findOne(string user, string password);

        /*
        * int user-id of the user, from database
        * 
        * find a user based on id, returns null if not found
        */
        User find(int id);


        /*
       * string user-username
       * string password-password 
       * 
       * deletes a user from database based on username and password
       * returns the deleted user or null of the operation was not sucessfull
       */

        User delete(string user, string password);

        /*string username
         * string password
         * Status st
         * int section
         * 
         * Add user to database, if there is already a user
        *with the given username and password returns null
        *else returns the added user
        */


        User add(string username, string password, Status st, int section);

        /*int id
         * string username
         * string password
         * Status st
         * Update a user based on id, if the operation is
        *sucessful returns the new user else returns null
        */
        User update(int id, string username, string password, Status st);
    }
}
