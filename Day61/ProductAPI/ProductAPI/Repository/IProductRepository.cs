﻿using ProductAPI.Models;

namespace ProductAPI.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductByID(int ProductId);
        void InsertProduct(Product Product);
        void DeleteProduct(int ProductId);
        void UpdateProduct(Product Product);
        void Save();
    }
}
