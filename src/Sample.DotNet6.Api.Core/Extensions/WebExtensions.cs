using System;
using System.Threading.Tasks;

namespace Sample.DotNet6.Api.Core.Extensions
{
    public static class WebExtensions
    {
        public static async Task<T> ExecuteAsync<T>(Func<Task<T>> executeAsync)
        {
            return await executeAsync();
        }
    }
}
