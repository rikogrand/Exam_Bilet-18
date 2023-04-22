using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_Korondenko
{
    public class JewerlyDB

    {
        public List<Jewerly> jewerlyList { get;set; }
        public void Initialize() => jewerlyList = new List<Jewerly>
         {
         new Jewerly()
        {
            Name = "Толстая цепочка из золота",
            Carates = 47,
            Price = 100000,
            Type = "Цепь"
        },
        new Jewerly()
        {
            Name = "Кольцо с красивым камнем",
            Carates = 23,
            Price = 150000,
            Type = "Кольцо"
        },
         };
     
        
    }
}

    