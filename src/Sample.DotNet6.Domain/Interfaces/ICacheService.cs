using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.DotNet6.Domain.Interfaces
{
    public interface ICacheService
    {
        T GetValue<T>(string key, Func<T> getValue) where T : class;
    }
}
