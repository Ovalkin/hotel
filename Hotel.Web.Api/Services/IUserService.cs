using Hotel.Common.EntityModel.PostgreSql.Entities;

namespace Hotel.Web.Api.Services;

public interface IUserService
{
    Task<bool> Register(User user);
}