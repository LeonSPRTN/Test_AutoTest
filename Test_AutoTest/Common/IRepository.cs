using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_AutoTest.Models;

namespace Test_AutoTest.Common
{
    public interface IRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Create(User user);
    }
}
