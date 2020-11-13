using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AutoTest.Common;
using Test_AutoTest.Models;

namespace Test_AutoTest.Services
{
    public class RepositoryService
    {
        IRepository _sender;

        public RepositoryService(IRepository sender)
        {
            _sender = sender;
        }

        public IEnumerable<User> GetAll()
        {
            return _sender.GetAll();
        }

        public User Get(int id)
        {
            return _sender.Get(id);
        }

        public void Create(User user)
        {
            _sender.Create(user);
        }
    }
}
