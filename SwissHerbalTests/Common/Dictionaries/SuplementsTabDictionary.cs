using SwissHerbalTests.Common.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SwissHerbalTests.Common.Dictionaries
{
    public static class SuplementsTabDictionary
    {
        public static Dictionary<SuplementsTabs, string> suplementsTabsUrls = new Dictionary<SuplementsTabs, string>()
        {
            { SuplementsTabs.ENERGIA, "https://pl.swissherbal.eu/kategoria-produktu/energia/" },
            { SuplementsTabs.KONCENTRACJA, "https://pl.swissherbal.eu/kategoria-produktu/nauka/"},
            { SuplementsTabs.PAMIĘĆ, "https://pl.swissherbal.eu/kategoria-produktu/pamiec/" },
            { SuplementsTabs.NASTRÓJ, "https://pl.swissherbal.eu/kategoria-produktu/nastroj/" },
            { SuplementsTabs.RELAKS, "https://pl.swissherbal.eu/kategoria-produktu/relaks/" },
            { SuplementsTabs.SEN , "https://pl.swissherbal.eu/kategoria-produktu/sen/" },
            { SuplementsTabs.SIŁA, "https://pl.swissherbal.eu/kategoria-produktu/sila/" },
            { SuplementsTabs.LIBIDO, "https://pl.swissherbal.eu/kategoria-produktu/libido/" },
            { SuplementsTabs.DIETA, "https://pl.swissherbal.eu/kategoria-produktu/dieta/" },
            { SuplementsTabs.DETOKS, "https://pl.swissherbal.eu/kategoria-produktu/suplementy/detoks/" },
            { SuplementsTabs.ODPORNOŚĆ, "https://pl.swissherbal.eu/kategoria-produktu/suplementy/odpornosc/" },
            { SuplementsTabs.WITALNOŚĆ, "https://pl.swissherbal.eu/kategoria-produktu/zdrowie/" }
        };
    }
}
