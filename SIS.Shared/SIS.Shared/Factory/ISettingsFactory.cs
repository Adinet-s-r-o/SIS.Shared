using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Factory
{
    public interface ISettingsFactory
    {
        string GetServerUrl();
        string GetWebUrl();
        string GetEnvironment();
        string GetConnectionString(string connectionName);
    }
}
