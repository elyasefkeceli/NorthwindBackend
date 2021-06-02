using NorthwindBackend.Core.DataAccess;
using NorthwindBackend.Core.Utilities.Results;
using NorthwindBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
