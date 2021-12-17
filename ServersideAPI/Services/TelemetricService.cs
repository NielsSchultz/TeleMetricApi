using ServersideAPI.Data;
using ServersideAPI.Data.Entities;

namespace ServersideAPI.Services
{
    public class TelemetricService : ITelemetricService
    {
        private readonly EntityContext _context;
        private readonly IConfiguration _config;

        public TelemetricService(EntityContext context, IConfiguration configuration)
        {
            _context = context;
            _config = configuration;
        }
        public List<Telemetrics> GetTelemetrics()
        {
            return _context.Telemtrics.ToList();
        }

    }
}
