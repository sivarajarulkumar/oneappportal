using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneAppPlatform.DataAccess.Entity
{
    public class Application:BaseEntity<int>
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
