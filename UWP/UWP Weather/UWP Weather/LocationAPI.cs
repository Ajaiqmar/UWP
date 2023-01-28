using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace UWP_Weather
{
    internal class LocationAPI
    {
        internal async static Task<Geoposition> GetCurrentLocation()
        {
            var access = await Geolocator.RequestAccessAsync();

            if(access == GeolocationAccessStatus.Allowed)
            {
                var geoLocator = new Geolocator { DesiredAccuracyInMeters = 0 };

                return await geoLocator.GetGeopositionAsync();
            }

            throw new Exception();
        }
    }
}
