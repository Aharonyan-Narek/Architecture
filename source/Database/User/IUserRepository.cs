using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Repositories;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IUserRepository : IRepository<UserEntity>
    {
        Task<UserModel> GetByIdAsync(long id);

        Task<SignedInModel> SignInAsync(SignInModel signInModel);

        Task UpdateStatusAsync(UserEntity userEntity);
    }
}
