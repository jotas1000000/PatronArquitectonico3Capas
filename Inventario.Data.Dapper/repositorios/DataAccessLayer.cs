using Inventario.Data.Dapper.repositorios;
using Inventario.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data.repositorios
{
    public class DataAccessLayer : IDataAccessLayer
    {

        private IProductoRepository repository;
        private string ConnectionString;
        public DataAccessLayer(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
            //this.repository = new ProductoRepositoryDapper(ConnectionString);
        }

        public void SetStrategyORM(string orm)
        {
            switch(orm)
            {
                case "dapper":
                    this.repository = new ProductoRepositoryDapper(this.ConnectionString);
                    break;
                case "entity framework":
                    this.repository = new ProductoRepositoryEntityFramework(this.ConnectionString);
                    break;
                default:
                    break;
            }
        }

        public Task<bool> DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Producto>> GetAllProducts()
        {
            SetStrategyORM("entity framework");
            return this.repository.GetAllProducts();
        }

        public Task<Producto> GetProductoDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProduct(Producto producto)
        {
            SetStrategyORM("dapper");
            return this.repository.InsertProduct(producto);
        }

        public Task<bool> UpdateProduct(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
