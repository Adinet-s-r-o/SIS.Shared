using SIS.Shared.Factory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;

namespace SIS.Shared.Common
{
    public static class Constants
    {
        static ISettingsFactory settingsFactory = Assembly.GetExecutingAssembly().CreateInstance("SIS.Core.Factory.SettingsLoaderFactory") as ISettingsFactory;
        public static readonly string Environment = settingsFactory == null ? String.Empty : settingsFactory.GetEnvironment();
        public static readonly string WebUrl = settingsFactory == null ? String.Empty : settingsFactory.GetWebUrl();
        public static readonly string ServerUrl = settingsFactory == null ? String.Empty : settingsFactory.GetServerUrl();

        public static class API
        {

            public const string ApiVersion1 = "v1";
            public const string ApiVersion2 = "v2";

            public static readonly string ApiUrl = ServerUrl + "api/"; // + ApiVersion1 + "/";
            public const int DefaultTimeout = 30;

            public const int DefaultPageIndex = 0;
            public const int DefaultPageSize = 20;

            public static class Urls
            {
                //Opatreni		
                public static readonly string OpatreniList = ApiUrl + "opatreni/list/";
                public static readonly string OpatreniGetItemById = ApiUrl + "opatreni/get/";
                public static readonly string OpatreniAdd = ApiUrl + "opatreni/add/";
                public static readonly string OpatreniDelete = ApiUrl + "opatreni/delete/";
                public static readonly string OpatreniUpdate = ApiUrl + "opatreni/update/";
                public static readonly string IsNameUsed = ApiUrl + "opatreni/IsNameUsed";
                public static readonly string IsPriorityUsed = ApiUrl + "opatreni/IsPriorityUsed";

                //Pumping
                public static readonly string PumpingList = ApiUrl + "pumpingtest/list/";

                //Plovak
                public static readonly string PlovakyList = ApiUrl + "plovaky/list/";
                public static readonly string PlovakyGetItemById = ApiUrl + "plovaky/get/";
                public static readonly string PlovakyAdd = ApiUrl + "plovaky/add/";
                public static readonly string PlovakyDelete = ApiUrl + "plovaky/delete/";
                public static readonly string PlovakyUpdate = ApiUrl + "plovaky/update/";

                public static readonly string PlovakyAddMonitoringRelativeUrl = "api/plovaky/addMonitoring/";

                //Provozni Parametry
                public static readonly string ProvozniParametryList = ApiUrl + "provozniParametry/list/";
                public static readonly string ProvozniParametryGetItemById = ApiUrl + "provozniParametry/get/";
                public static readonly string ProvozniParametryAdd = ApiUrl + "provozniParametry/add/";
                public static readonly string ProvozniParametryDelete = ApiUrl + "provozniParametry/delete/";
                public static readonly string ProvozniParametryUpdate = ApiUrl + "provozniParametry/update/";

                public static readonly string ProvozniParametryAddMonitoringRelativeUrl = "api/provozniParametry/addMonitoring/";

                //Redox
                public static readonly string RedoxList = ApiUrl + "redox/list/";
                public static readonly string RedoxGetItemById = ApiUrl + "redox/get/";
                public static readonly string RedoxAdd = ApiUrl + "redox/add/";
                public static readonly string RedoxDelete = ApiUrl + "redox/delete/";
                public static readonly string RedoxUpdate = ApiUrl + "redox/update/";
                
                public static readonly string RedoxAddMonitoringRelativeUrl = "api/redox/addMonitoring/";

                //HpvFaze
                public static readonly string HpvFazeList = ApiUrl + "hpvFaze/list/";
                public static readonly string HpvFazeGetItemById = ApiUrl + "hpvFaze/get/";
                public static readonly string HpvFazeAdd = ApiUrl + "hpvFaze/add/";
                public static readonly string HpvFazeDelete = ApiUrl + "hpvFaze/delete/";
                public static readonly string HpvFazeUpdate = ApiUrl + "hpvFaze/update/";

                public static readonly string HpvFazeAddMonitoringRelativeUrl = "api/hpvFaze/addMonitoring/";
                
                //HpvFaze
                public static readonly string BiosensoryList = ApiUrl + "biosensory/list/";
                //public static readonly string BiosensoryGetItemById = ApiUrl + "biosensory/get/";
                //public static readonly string BiosensoryGetByObjectId = ApiUrl + "biosensory/getByObjectId/";
                //public static readonly string BiosensoryGetByObjectIdAndRecordCnt = ApiUrl + "biosensory/getByObjectIdAndRecordCnt/";
                //public static readonly string BiosensoryGet1000ByObjectIdAndFromToDate = ApiUrl + "biosensory/get1000ByObjectIdAndFromToDate/";
                //public static readonly string BiosensoryGetByMultipleObjectIdAndFromToDate = ApiUrl + "biosensory/getByMultipleObjectIdAndFromToDate/";
                public static readonly string BiosensoryGetByObjectIds = ApiUrl + "biosensory/getByObjektIds/";
                public static readonly string BiosensoryAdd = ApiUrl + "biosensory/add/";
                public static readonly string BiosensoryDelete = ApiUrl + "biosensory/delete/";
                public static readonly string BiosensoryUpdate = ApiUrl + "biosensory/update/";
                public static readonly string BiosensoryExistsForObjects = ApiUrl + "biosensory/existsForObjects/";
                public static readonly string BiosensoryAddMonitoringRelativeUrl = "api/biosensory/addMonitoring/";

            }

        }
    }
}
