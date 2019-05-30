using MongoDB.Driver.GeoJsonObjectModel;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GutenBergProjectApp.Models
{
   public class City
    {
        public string CityName { get; set; }

        public GeoJsonPoint<GeoJson2DGeographicCoordinates> Location { get; set; }

        public string Long { get; set; }

        public string Lat { get; set; }


        public City( string cityName, string lng, string lat)
        {
            CityName = cityName;
            Long = lng; 
            Lat = lat;
            Location = new GeoJsonPoint<GeoJson2DGeographicCoordinates>(
        new GeoJson2DGeographicCoordinates(double.Parse(Lat.Replace(",", "."), CultureInfo.InvariantCulture), double.Parse(Long.Replace(",", "."), CultureInfo.InvariantCulture)));

        }


    }
}
