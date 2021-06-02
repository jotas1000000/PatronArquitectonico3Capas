using Dapper;
using Inventario.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Data.Dapper.repositorios
{
    public class ProductoRepositoryDapper : IProductoRepository
    {
        private string ConnectionString;

        public ProductoRepositoryDapper(string ConnectionString)
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

            return await db.QueryAsync<Producto>(sql.ToString(), new {});
        }

        public Task<Producto> GetProductoDetails(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> InsertProduct(Producto producto)
        {
            var db = dbConnection();
            var sql = @"
                        INSERT INTO Productos (nombre, cantidad, precio)
                        VALUES (@nombre, @cantidad, @precio)
                       ";

            var result = await db.ExecuteAsync(sql.ToString(), new { producto.nombre, producto.cantidad, producto.precio });
            return result > 0;
        }

        public Task<bool> UpdateProduct(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
