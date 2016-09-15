using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brand7.Models
{
    class GameHelper
    {
        public BrandHelper BrandHelper { get; set; }
        public ThemeModel ThemeModel { get; set; }

        public GameHelper()
        {
            BrandHelper = new Models.BrandHelper();
            ThemeModel = new Models.ThemeModel();
        }
    }
}
