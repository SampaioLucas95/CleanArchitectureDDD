using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionName.Service.Redis
{
    public interface ICacheService
    {
        T Get<T>(string key);

        void Set<T>(string key, T content);

        void Remove(string key);

    }
}
