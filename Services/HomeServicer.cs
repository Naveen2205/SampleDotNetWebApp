using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NugetTestLib;
using NugetLocalLib;
using Newtonsoft.Json;

namespace RestApi.Services
{
    public interface IHomeServicer
    {
        public string DisplayText();
    }
    public class HomeServicer : IHomeServicer
    {
        public string DisplayText()
        {
            return Class1.NugetPrinter("nuget printer test");
        }
    }
}
