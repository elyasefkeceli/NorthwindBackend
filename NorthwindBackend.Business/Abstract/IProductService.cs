using NorthwindBackend.Core.Utilities.Results;
using NorthwindBackend.Entities.Concrete;
using System.Collections.Generic;

namespace NorthwindBackend.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
