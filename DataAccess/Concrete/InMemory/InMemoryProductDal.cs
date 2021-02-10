﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; //naming convention

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                //Oracle, Sql Server, Postgres, MongoDb
                new Product{ProductId =1, CategoryId = 1, ProductName = "Bardak", UnitPrice = 15, UnitsInStock = 15},
                new Product{ProductId =1, CategoryId = 2, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3},
                new Product{ProductId =1, CategoryId = 3, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2},
                new Product{ProductId =1, CategoryId = 4, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65},
                new Product{ProductId =1, CategoryId = 1, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1},
            };
        }
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //Product productToDelete= null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId==p.ProductId)
            //    {
            //        productToDelete = p;
            //    }
                
            //}
            //lambda
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
            
            _products.Remove(productToDelete); 

        }


        public List<Product> GetAll()
        {
            return _products;
        }

        public void Update(Product product)
        {
            //Gönderdiği ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return  _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }
    }
}
