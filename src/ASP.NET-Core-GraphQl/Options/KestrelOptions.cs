namespace ASP.NET_Core_GraphQl.Options
{
    using System.Collections.Generic;

    public class KestrelOptions
    {
        public Dictionary<string, EndpointOptions> Endpoints { get; set; }
    }
}
