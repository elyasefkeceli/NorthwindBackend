using NorthwindBackend.Core.DataAccess;
using NorthwindBackend.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.DataAccess.Abstract
{
    public interface IUserDal :IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
