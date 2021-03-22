using Microsoft.EntityFrameworkCore;

namespace RicardoMarino.Data.Context
{
    /// <summary>
    /// Contexto da aplicação sem o Identity
    /// </summary>
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions options) : base (options)
        {

        }
    }
}
