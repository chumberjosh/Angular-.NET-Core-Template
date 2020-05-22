using System.Collections.Generic;
using DatingApp.API.Models.xTransportMap;

namespace DatingApp.API.Data
{
    public interface IExternalApiRepository
    {
        // IEnumerable<ExternalApi> FetchData(string apiUrl, string apiKey);

        IEnumerable<ExternalApi> FetchData(string apiUrl, string apiKey);

    }
}