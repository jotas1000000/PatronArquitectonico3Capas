using Inventario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.UI.Interfaces
{
    public interface IProductoService
    {
        Task<IEnumerable<Producto>> GetAllProducts();
        Task<Producto> GetDetails(int id);
        Task<bool> DeleteProducto(int id);
        Task<bool> SaveProducto(Producto producto);
    }
}
