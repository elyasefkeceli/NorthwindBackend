using NorthwindBackend.Business.Abstract;
using NorthwindBackend.Core.Entities.Concrete;
using NorthwindBackend.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
            
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(p=>p.Email==email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }
    }
}
