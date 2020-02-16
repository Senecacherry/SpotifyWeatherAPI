using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAPIPractice.Data
{
    public interface IDAL
    {
        Task<List<T>> GetList<T>(Dictionary<string, string> Parameters);
        Task<T> Get<T>(Dictionary<string, string> Parameters);
    }
}
