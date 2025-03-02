using Hotel.Common.EntityModel.PostgreSql;
using Hotel.Common.EntityModel.PostgreSql.Entities;

namespace Hotel.Web.Api.Services;

public class UserService : IUserService
{
    private readonly HotelContext _db;
    public UserService(HotelContext db)
    {
        _db = db;
    }
    public async Task<bool> Register(User user)
    {
        await _db.Users.AddAsync(user);
        int result = await _db.SaveChangesAsync();

        if (result == 1)
            return true;
        return false;
    }
}