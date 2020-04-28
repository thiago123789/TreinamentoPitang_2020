using System;
using System.Threading.Tasks;

namespace Pitang.Treinamento.ONS.Services
{
    public interface IUserService //: SinletonLifeCycle
    {
        Task<object> GetAsync(int id);
    }
}
