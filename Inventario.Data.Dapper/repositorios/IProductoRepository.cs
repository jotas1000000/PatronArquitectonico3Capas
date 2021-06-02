using Inventario.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data.Dapper.repositorios
{
    interface IProductoRepository
    {
        Task<IEnumerable<Producto>> GetAllProducts();
        Task<Producto> GetProductoDetails(int id);
        Task<bool> InsertProduct(Producto producto);
        Task<bool> UpdateProduct(Producto producto);
        Task<bool> DeleteProducto(int id);
    }
}
