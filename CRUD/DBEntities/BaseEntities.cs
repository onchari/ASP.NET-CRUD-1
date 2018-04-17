using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.DBEntities
{
    public class BaseEntities
    {
        public Int64 Id { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime dateTime { get; set; }
        public string IPAddress { get; set; }
    }
}
