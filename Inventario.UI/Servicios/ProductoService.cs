using Inventario.Data.Dapper.repositorios;
using Inventario.Data.repositorios;
using Inventario.Model;
using Inventario.UI.Data;
using Inventario.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.UI.Servicios
{
    public class ProductoService : IProductoService
    {
        private readonly SqlConfiguration _configuration;
        private DataAccessLayer _dataAccessLayer;
        public ProductoService(SqlConfiguration configuration )
        {
            this._configuration = configuration;
            this._dataAccessLayer = new DataAccessLayer(configuration.ConnectionString);
        }

        public Task<bool> DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> GetAllProducts()
        {
            return _dataAccessLayer.GetAllProducts();
        }

        public Task<Producto> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveProducto(Producto producto)
        {
            if (producto.id == 0)
            {
                return _dataAccessLayer.InsertProduct(producto);
            }else
            {
                return null;
            }
        }
    }
}
