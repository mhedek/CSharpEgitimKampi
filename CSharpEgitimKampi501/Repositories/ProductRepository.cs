using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreatProductAsyc(CreatProductDto creatProductDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProductAsyc(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultProductDto>> GetAllProductAsyc()
        {
            throw new NotImplementedException();
        }

        public Task GetByProductIdAsyc(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsyc(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
