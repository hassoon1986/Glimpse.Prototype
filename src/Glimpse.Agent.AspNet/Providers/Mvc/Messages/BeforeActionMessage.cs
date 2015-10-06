﻿
using System.Collections.Generic;

namespace Glimpse.Agent.AspNet.Mvc.Messages
{
    public class BeforeActionMessage : IActionRouteMessage
    {
        public string ActionId { get; set; }

        public string DisplayName { get; set; }

        public string ActionName { get; set; }

        public string ControllerName { get; set; }

        public string RouteName { get; set; }

        public string RoutePattern { get; set; }

        public IList<KeyValuePair<string, string>> RouteData { get; set; }

        public IList<KeyValuePair<string, RouteConfigurationData>> RouteConfiguration { get; set; }
    }
}