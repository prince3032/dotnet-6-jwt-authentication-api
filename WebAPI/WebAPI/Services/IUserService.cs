using WebAPI.Entities;
using WebAPI.Models;

namespace WebAPI.Services
{
    public interface IUserService
    {
        AuthenticationResponse Authenticate(AuthenticationRequest model);
        IEnumerable<User> GetAll();
        User GetById(int id);
    }
}
