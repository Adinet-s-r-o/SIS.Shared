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
                //Objekt
                public static readonly string ObjektyListSimple = ApiUrl + "objekty/listSimple/";


                //Opatreni		
                public static readonly string OpatreniList = ApiUrl + "opatreni/list/";
                public static readonly string OpatreniGetItemById = ApiUrl + "opatreni/get/";
                public static readonly string OpatreniAdd = ApiUrl + "opatreni/add/";
                public static readonly string OpatreniDelete = ApiUrl + "opatreni/delete/";
                public static readonly string OpatreniUpdate = ApiUrl + "opatreni/update/";
                public static readonly string IsNameUsed = ApiUrl + "opatreni/IsNameUsed";
                public static readonly string IsPriorityUsed = ApiUrl + "opatreni/IsPriorityUsed";
                
                //Kampane
                public static readonly string KampaneList = ApiUrl + "kampane/list/";
                public static readonly string KampaneGetItemById = ApiUrl + "kampane/get/";
                public static readonly string KampaneAdd = ApiUrl + "kampane/add/";
                public static readonly string KampaneDelete = ApiUrl + "kampane/delete/";
                public static readonly string KampaneUpdate = ApiUrl + "kampane/update/";
                public static readonly string KampaneIsNameUsed = ApiUrl + "kampane/IsNameUsed";
                public static readonly string KampaneGetKampanId = ApiUrl + "kampane/getKampanId";

                //Pumping
                public static readonly string PumpingList = ApiUrl + "pumpingtest/list/";
                public static readonly string PumpingListByKampane = ApiUrl + "pumpingtest/listByKampane/";

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
                public static readonly string ProvozniParametryExistsForObjects = ApiUrl + "provozniParametry/existsForObjects/";
                public static readonly string ProvozniParametryGetByObjectIds = ApiUrl + "provozniParametry/getByObjektIds/";
                public static readonly string ProvozniParametryGetXYoungestByObjectId = ApiUrl + "provozniParametry/getXYougestByObjektIds/";

                public static readonly string ProvozniParametryAddMonitoringRelativeUrl = "api/provozniParametry/addMonitoring/";

                //Redox
                public static readonly string RedoxList = ApiUrl + "redox/list/";
                public static readonly string RedoxGetItemById = ApiUrl + "redox/get/";
                public static readonly string RedoxAdd = ApiUrl + "redox/add/";
                public static readonly string RedoxAddMonitoringRelativeUrl = "api/redox/addMonitoring/";
                public static readonly string RedoxDelete = ApiUrl + "redox/delete/";
                public static readonly string RedoxUpdate = ApiUrl + "redox/update/";
                public static readonly string RedoxExistsForObjects = ApiUrl + "redox/existsForObjects/";
                public static readonly string RedoxGetByObjectId = ApiUrl + "redox/getByObjectId/";
                public static readonly string RedoxGetByObjectIdYoungest = ApiUrl + "redox/getByObjectIdYoungest/";
                public static readonly string RedoxGetByObjectIdDateDistributed = ApiUrl + "redox/getByObjectIdDateDistributed/";
                public static readonly string RedoxGetByMultipleObjectIds = ApiUrl + "redox/getByMultipleObjectIds/";
                public static readonly string RedoxGetElectricPotential = ApiUrl + "redox/getElectricPotential/";
                public static readonly string RedoxGetDistinctRedoxMeasuredDateByObjectIdsForElPotencial = ApiUrl + "redox/getDistinctRedoxMeasuredDateByObjectIdsForElPotencial/";


                //HpvFaze
                public static readonly string HpvFazeList = ApiUrl + "hpvFaze/list/";
                public static readonly string HpvFazeGetItemById = ApiUrl + "hpvFaze/get/";
                public static readonly string HpvFazeAdd = ApiUrl + "hpvFaze/add/";
                public static readonly string HpvFazeDelete = ApiUrl + "hpvFaze/delete/";
                public static readonly string HpvFazeUpdate = ApiUrl + "hpvFaze/update/";
                public static readonly string HpvFazeGetByObjektIdAndMereno = ApiUrl + "hpvFaze/getByObjektIdAndMereno/"; 
                public static readonly string HpvFazeListByObjektId = ApiUrl + "hpvFaze/getListByObjektId/";
                public static readonly string HpvFazeGetByMultipleObjektIdsAndDates = ApiUrl + "hpvFaze/getByMultipleObjektIdsAndDates/";
                public static readonly string HpvFazeExistsForObjects = ApiUrl + "hpvFaze/existsForObjects/";
                public static readonly string HpvFazeGetYoungestRecordByKampan  = ApiUrl + "hpvFaze/getYoungestRecordByKampan/";

                public static readonly string HpvFazeAddMonitoringRelativeUrl = "api/hpvFaze/addMonitoring/";
                
                //HpvFaze
                public static readonly string BiosensoryList = ApiUrl + "biosensory/list/";
                public static readonly string BiosensoryGetItemById = ApiUrl + "biosensory/get/";
                //public static readonly string BiosensoryGetByObjectId = ApiUrl + "biosensory/getByObjectId/";
                //public static readonly string BiosensoryGetByObjectIdAndRecordCnt = ApiUrl + "biosensory/getByObjectIdAndRecordCnt/";
                //public static readonly string BiosensoryGet1000ByObjectIdAndFromToDate = ApiUrl + "biosensory/get1000ByObjectIdAndFromToDate/";
                //public static readonly string BiosensoryGetByMultipleObjectIdAndFromToDate = ApiUrl + "biosensory/getByMultipleObjectIdAndFromToDate/";
                public static readonly string BiosensoryGetByObjectIds = ApiUrl + "biosensory/getByObjektIds/";
                public static readonly string BiosensoryGetXYoungestByObjectId = ApiUrl + "biosensory/getXYougestByObjektIds/";
                public static readonly string BiosensoryAdd = ApiUrl + "biosensory/add/";
                public static readonly string BiosensoryDelete = ApiUrl + "biosensory/delete/";
                public static readonly string BiosensoryUpdate = ApiUrl + "biosensory/update/";
                public static readonly string BiosensoryExistsForObjects = ApiUrl + "biosensory/existsForObjects/";
                public static readonly string BiosensoryAddMonitoringRelativeUrl = "api/biosensory/addMonitoring/";

                // Cerpani
                public static readonly string CerpaniList = ApiUrl + "cerpani/list/";
                public static readonly string CerpaniGetItemById = ApiUrl + "cerpani/get/";
                public static readonly string CerpaniAdd = ApiUrl + "cerpani/add/";
                public static readonly string CerpaniDelete = ApiUrl + "cerpani/delete/";
                public static readonly string CerpaniUpdate = ApiUrl + "cerpani/update/";
                public static readonly string CerpaniGetByObjectId = ApiUrl + "cerpani/getByObjektId/";
                public static readonly string CerpaniGetByObjektIdWithCalculatedValues = ApiUrl + "cerpani/getByObjektIdWithCalculatedValues/";
                public static readonly string CerpaniGetByObjectIdAndMereno = ApiUrl + "cerpani/getByObjektIdAndMereno/";
                public static readonly string CerpaniGetByMultipleObjektIdsAndDates = ApiUrl + "cerpani/getByMultipleObjektIdsAndDates/";
                public static readonly string CerpaniExistsForObjects = ApiUrl + "cerpani/existsForObjects/";
                public static readonly string CerpaniExistsForObjectsBetweenDates = ApiUrl + "cerpani/existsForObjectsBetweenDates/";
                public static readonly string CerpaniExistsForObjectsAndKampan = ApiUrl + "cerpani/existsForObjectsAndKampan/";
                public static readonly string CerpaniGetByMultipleObjektIdsAndCampaign = ApiUrl + "cerpani/getByMultipleObjektIdsAndCampaign/";


                // kriteria

                public static readonly string KriteriaGetByVelicinaAndObjektId = ApiUrl + "kriteria/getByVelicinaAndObjektId/";


                // objekt valuation

                public static readonly string ObjektValuationGetYoungestHpvFazeByMerenoAndPocetDniZpet = ApiUrl + "objektValuation/getYoungestHpvFazeByMerenoAndPocetDniZpet/";
                public static readonly string ObjektValuationGetYoungestHpvFazeByKampan = ApiUrl + "objektValuation/getYoungestHpvFazeByKampan/";
                public static readonly string ObjektValuationGetYoungestCerpaniEndByObjekt = ApiUrl + "objektValuation/getYoungestCerpaniEndByObjekt/";
                public static readonly string ObjektValuationGetYoungestCerpaniEndByObjektAndKampan = ApiUrl + "objektValuation/getYoungestCerpaniEndByObjektAndKampan/";
                public static readonly string ObjektValuationGetCerpaniLastRecord = ApiUrl + "objektValuation/getCerpaniLastRecord/";
                public static readonly string ObjektValuationGetRelevantCerpaniStart = ApiUrl + "objektValuation/getRelevantCerpaniStart/";
                public static readonly string ObjektValuationGetStaticWaterLevelFromYoungestHpvFaze = ApiUrl + "objektValuation/getStaticWaterLevelFromYoungestHpvFaze/";
                public static readonly string ObjektValuationGetStaticWaterLevelFromYoungestHpvFazeByKampan = ApiUrl + "objektValuation/getStaticWaterLevelFromYoungestHpvFazeByKampan/";



                // FyzChemMega
                public static readonly string FyzChemMegaList = ApiUrl + "fyzChemMega/list/";
                public static readonly string FyzChemMegaGetItemById = ApiUrl + "fyzChemMega/get/";
                public static readonly string FyzChemMegaAdd = ApiUrl + "fyzChemMega/add/";
                public static readonly string FyzChemMegaDelete = ApiUrl + "fyzChemMega/delete/";
                public static readonly string FyzChemMegaUpdate = ApiUrl + "fyzChemMega/update/";
                public static readonly string FyzChemMegaGetByObjectId = ApiUrl + "fyzChemMega/getByObjektId/";
            }

        }
    }
}
