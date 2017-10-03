using DependencyInjectionUnity.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionUnity.Providers
{
    public class MyProvider : IMyProvider
    {
        public string GetMessage()
        {
            return $"Message from: {this.GetType()}";
        }
    }
}