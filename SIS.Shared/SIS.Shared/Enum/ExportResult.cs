using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIS.Shared.Enum
{
    public enum ExportResult
    {
        Inserted,
        ParameterNameError,
        ParameterDataTypeError,
        RequiredParameterMissing,
        InvalidTimestamp,
        PartlyInserted,
        DuplicateRecord,
        ConfigurationNotFound,
        InactiveConfiguration,
        GeneralSISError
    }
}
