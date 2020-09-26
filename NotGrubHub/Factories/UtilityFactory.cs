using NotGrubHub.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotGrubHub.Factories
{
    public static class UtilityFactory
    {
        public static IApp GetApp() => new App(GetLogger());
        public static ILogger GetLogger() => new Logger();
    }
}
