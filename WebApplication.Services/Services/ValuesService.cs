namespace WebApplication.Services.Services
{
    public interface IValuesService
    {
        string GetValue();
    }

    public class ValuesService : IValuesService
    {
        public string GetValue()
        {
            return "Hello";
        }

    }
}