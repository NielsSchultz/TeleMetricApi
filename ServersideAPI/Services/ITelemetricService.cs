using ServersideAPI.Data.Entities;

namespace ServersideAPI.Services
{
    public interface ITelemetricService
    {
        List<Telemetrics> GetTelemetrics();
    }
}
