﻿using NorthwindBackend.Core.Utilities.Results;
using NorthwindBackend.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindBackend.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
        IDataResult<Category> GetById(int categoryId);

        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);
    }
}
