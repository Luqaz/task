using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_task.Models
{
    public class Shop
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string WorkTime { get; set; }
        public ICollection<Goods> Goods { get; set; }
    }
}