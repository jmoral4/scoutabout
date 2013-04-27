using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespaceWeb.Models
{
publicclassComboBoxItems
{
staticprivateList<string>cities=newList<string>(){"NewYork","LosAngeles","Chicago"," Houston"," Phoenix"," Philadelphia"," SanAntonio"," SanDiego"," Dallas"," SanJose"," Detroit"," Jacksonville"," Indianapolis","SanFrancisco"," Columbus"," Austin"," Memphis"," FortWorth"," Baltimore"," Charlotte"," ElPaso"," Boston"," Seattle"," Washington"," Milwaukee"," Denver"," Louisville/JeffersonCounty"," LasVegas","Nashville-Davidson"," OklahomaCity"," Portland"," Tucson"," Albuquerque"," Atlanta"," LongBeach"," Fresno"," Sacramento"," Mesa"," KansasCity"," Cleveland"," VirginiaBeach"," Omaha"," Miami"," Oakland"," Tulsa"," Honolulu"," Minneapolis"," ColoradoSprings"," Arlington"," Wichita"," Raleigh"," St.Louis"," SantaAna"," Anaheim"," Tampa"," Cincinnati"," Pittsburgh"," Bakersfield"," Aurora"," Toledo"," Riverside"," Stockton"," CorpusChristi"," Newark"," Anchorage","Buffalo"," St.Paul"," Lexington-Fayette","Plano"," FortWayne"," St.Petersburg"," Glendale"," JerseyCity"," Lincoln"," Henderson"," Chandler"," Greensboro"," Scottsdale"," BatonRouge"," Birmingham"," Norfolk"," Madison"," NewOrleans"," Chesapeake"," Orlando","Garland","Hialeah","Laredo"," ChulaVista"," Lubbock"," Reno"," Akron"," Durham"," Rochester"," Modesto"," Montgomery"," Fremont"," Shreveport"," Arlington","Glendale"};
staticpublicList<string>Cities{get{
cities.Sort();
returncities;}}
}
}