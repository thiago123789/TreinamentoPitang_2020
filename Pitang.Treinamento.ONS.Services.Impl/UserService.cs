using System;
using Pitang.Treinamento.ONS.Repository.Contracts;

namespace Pitang.Treinamento.ONS.Services.Impl
{
    public class UserService : IUserService
    {

        public UserService(IUnitOfWork unitOfWork)
        {
        }

        public object Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
