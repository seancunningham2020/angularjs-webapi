﻿using System.Collections.Generic;
using angularjs_webapi.api.Models;

namespace angularjs_webapi.api.Repositories
{
    public interface IProductRepository
    {
        Product Get(int productId);

        List<Product> GetAll();

        Product Add(Product product);

        void Remove(int id);

        bool Update(Product product);
    }
}