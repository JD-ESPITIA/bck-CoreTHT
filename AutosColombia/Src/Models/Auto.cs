using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutosColombia.Src.Models
{
    public class Auto
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string CarBrand { get; set; }
        public int Seating { get; set; }
        public string FabricationDate { get; set; }
        public string UrlPicture { get; set; }
    }
}
