using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hotel.Common.EntityModel.PostgreSql;

public static class HotelContextExtensions
{
    public static IServiceCollection AddHotelContext(this IServiceCollection services, string connection)
    {
        services.AddDbContext<HotelContext>(options =>
        {
            options.UseNpgsql(connection);
        });
        return services;
    }
}