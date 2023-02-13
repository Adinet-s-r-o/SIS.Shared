using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class ProvozniParametryRequest
    {
        public int ProvozniParametryId{ get; set; }
        public string DeleteU { get; set; } = String.Empty;
        public string? ObjektName { get; set; }
        public ProvozniParametryDto ProvozniParametry { get; set; }
        public string ConnectionString { get; set; } = String.Empty;
        public ProvozniParametryRequest()
        {
            ProvozniParametry = new ProvozniParametryDto();
        }      
    }
}
