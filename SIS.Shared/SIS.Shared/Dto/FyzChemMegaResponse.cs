﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Dto
{
    public class FyzChemMegaResponse
    {
        public List<FyzChemMegaDto> Data { get; set; }
        public int FyzChemMegaId { get; set; }
        public bool ExistsForObjects { get; set; }
        public bool DeleteFyzChemMega { get; set; }
        public FyzChemMegaResponse()
        {
            Data = new List<FyzChemMegaDto>();
        }
    }
}