namespace Sample.DotNet6.Api.Services
{
    public interface IHelloService
    {
        string Hello(bool isHappy);
    }

    public class HelloService : IHelloService
    {
        public string Hello(bool isHappy)
        {
            var hello = $"Hello";

            if (isHappy)
                return $"{hello}, you seem to be happy today";
            return hello;
        }
    }
}