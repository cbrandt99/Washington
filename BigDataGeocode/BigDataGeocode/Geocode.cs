using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigDataGeocode
{
    public class Geocode
    {
        public Response Response { get; set; }
    }

    public class Response
    {
        public MetaInfo MetaInfo { get; set; }
        public View[] View { get; set; }
    }

    public class MetaInfo
    {
        public string Timestamp { get; set; }
    }

    public class View
    {
        public string Type { get; set; }
        public long ViewId { get; set; }
        public Result[] Result { get; set; }
    }

    public class Result
    {
        public long Relevance { get; set; }
        public string MatchLevel { get; set; }
        public MatchQuality MatchQuality { get; set; }
        public string MatchType { get; set; }
        public Location Location { get; set; }
    }

    public class Location
    {
        public string LocationId { get; set; }
        public string LocationType { get; set; }
        public DisplayPosition DisplayPosition { get; set; }
        public DisplayPosition[] NavigationPosition { get; set; }
        public MapView MapView { get; set; }
        public Address Address { get; set; }
    }

    public class Address
    {
        public string Label { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
        public AdditionalDatum[] AdditionalData { get; set; }
    }

    public class AdditionalDatum
    {
        public string Value { get; set; }
        public string Key { get; set; }
    }

    public class DisplayPosition
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class MapView
    {
        public DisplayPosition TopLeft { get; set; }
        public DisplayPosition BottomRight { get; set; }
    }

    public class MatchQuality
    {
        public long State { get; set; }
        public long City { get; set; }
        public double[] Street { get; set; }
        public long HouseNumber { get; set; }
    }

}