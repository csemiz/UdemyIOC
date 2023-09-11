namespace UdemyIOC.Web.Models
{
    public class DateService : ISingletonDateService, IScopedDateService, ITransientDateService
    {
        private readonly ILogger<DateService> _logger;


        public DateService(ILogger<DateService> logger) //ctor'a dependency Injection
        {
            _logger = logger;

            _logger.LogWarning("DateService constructor'ına girdi.");
        }

        public DateTime GetDateTime { get; } = DateTime.Now;
    }
}
