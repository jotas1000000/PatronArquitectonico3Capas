using Dapper;
using Inventario.Data.Dapper.repositorios;
using Inventario.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data.repositorios
{
    class ProductoRepositoryEntityFramework : IProductoRepository
    {
        private string ConnectionString;

        public ProductoRepositoryEntityFramework(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> DeleteProducto(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Producto>> GetAllProducts()
        {
            var db = dbConnection();
            var sql = @"
                        SELECT id, nombre, cantidad, precio
                        FROM [dbo].[Productos]
                        ";

            return await db.QueryAsync<Producto>(sql.ToString(), new { });
        }

        public Task<Producto> GetProductoDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertProduct(Producto producto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
