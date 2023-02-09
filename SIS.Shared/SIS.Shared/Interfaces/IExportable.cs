using SIS.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Interfaces
{
    public interface IExportable
    {
        public ExportResult ExportResult { get; set; }
        public string ExportMessage { get; set; }
    }
}
