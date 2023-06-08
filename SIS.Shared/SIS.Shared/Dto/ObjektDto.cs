using System;

namespace SIS.Shared.Dto
{
    public class ObjektDto
    {
        public int ObjektId { get; set; }
        public string? Nazev { get; set; }
        public string? Typ { get; set; }
        public string? AlternativniNazev { get; set; }
    }
}