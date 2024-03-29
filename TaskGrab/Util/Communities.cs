﻿using Google.Maps.Geocoding;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskGrab.Data;

namespace TaskGrab.Util
{

    public class Location
    {
        public double latitude { get; set; }
        public double longitude { get; set; }
    }
    class Communities
    {
        TaskGrabContext _context;
        public Communities()
        {
            _context =  new TaskGrabContext();
        }
        
        public Location GetLocation(string community)
        {
            try
            {
                CommunityLocation location = _context.CommunityLocations.Single(c => c.Community == community);
                return new Location() {
                    latitude = location.latitude,
                    longitude = location.longitude
                };
            } catch (InvalidOperationException e)
            {
                var request = new GeocodingRequest();
                request.Address = community;
                var response = new GeocodingService().GetResponse(request);

                if (response.Results.Length > 0)
                {
                    Result result = response.Results.First();
                    CommunityLocation location = new CommunityLocation() {
                        Community = community,
                        longitude = result.Geometry.Location.Longitude,
                        latitude = result.Geometry.Location.Latitude
                    };
                    _context.CommunityLocations.Add(location);
                    _context.SaveChanges();

                    return new Location() { 
                        latitude = location.latitude,
                        longitude = location.longitude
                    };
                }

                return null; 

            }
            
        }
    }
}
