using DAL_FruitList_exercise;
using Microsoft.EntityFrameworkCore;

namespace Fruitlist_Exercise
{
    public static class Connect
    {
        public static void ConnectDB(this IServiceCollection services)
        {
            var config = services.BuildServiceProvider().GetService<IConfiguration>();
            var connection = config.GetConnectionString("DbConnect");
            services.AddDbContext<DbClass>(content => content.UseSqlServer(connection));
        }
    }
}
