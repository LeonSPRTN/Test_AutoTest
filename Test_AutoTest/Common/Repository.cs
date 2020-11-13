using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AutoTest.Models;

namespace Test_AutoTest.Common
{
    public class Repository : IRepository
    {
        public void Create(User user)
        {
            var users = new List<User>();
            users.Add(user);
        }

        public User Get(int id)
        {
            var user = new List<User>
            {
                new User { Id=1, FirstName="Трус", LastName = "Трусович", Age=35},
                new User { Id=2, FirstName="Болбес", LastName = "Болбесович", Age=29},
                new User { Id=3, FirstName="Бывалый", LastName = "Бывалов", Age=32},
            }.Where(x => x.Id == id).FirstOrDefault();

            return user;
        }

        public IEnumerable<User> GetAll()
        {
            var users = new List<User>
            {
                new User { Id=1, FirstName="Трус", LastName = "Трусович", Age=35},
                new User { Id=2, FirstName="Болбес", LastName = "Болбесович", Age=29},
                new User { Id=3, FirstName="Бывалый", LastName = "Бывалов", Age=32},
            };
            return users;
        }
    }
}
