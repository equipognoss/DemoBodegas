using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GnossLRTRoutesExample.Model
{
    public static class Constants
    {
        public static class Prefixes
        {
            public const string Dc = "xmlns:dc=\"http://purl.org/dc/elements/1.1/\"";
            public const string Dcterm = "xmlns:dcterm=\"http://purl.org/dc/terms/\"";
            public const string Dcterms = "xmlns:dcterms=\"http://purl.org/dc/terms/\"";
            public const string Eharmonise = "xmlns:eharmonise=\"http://www.eharmonise/2014-03-12#\"";
            public const string Eroute = "xmlns:eroute=\"http://www.eroute/2014-04-28#\"";
            public const string Foaf = "xmlns:foaf=\"http://xmlns.com/foaf/0.1/\"";
            public const string Geo = "xmlns:geo=\"http://www.w3.org/2003/01/geo/wgs84_pos#\"";
            public const string Gn = "xmlns:gn=\"http://www.geonames.org/ontology#\"";
            public const string Gnoss = "xmlns:gnoss=\"http://gnoss/\"";
            public const string Harmonise = "xmlns:harmonise=\"http://protege.stanford.edu/rdf/HTOv4002#\"";
            public const string Mlo = "xmlns:mlo=\"http://purl.org/net/mlo/\"";
            public const string OnTour = "xmlns:onTour=\"http://e-tourism.deri.at/ont/e-tourism#\"";
            public const string Org = "xmlns:org=\"http://www.w3.org/ns/org#\"";
            public const string Owl = "xmlns:owl=\"http://www.w3.org/2002/07/owl#\"";
            public const string Qm = "xmlns:qm=\"http://qallme.itc.it/ontology/qallme-tourism.owl#\"";
            public const string Rdf = "xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"";
            public const string Rdfs = "xmlns:rdfs=\"http://www.w3.org/2000/01/rdf-schema#\"";
            public const string Route = "xmlns:route=\"http://www.obertadecatalunya/route#\"";
            public const string Sioc = "xmlns:sioc=\"http://rdfs.org/sioc/ns#\"";
            public const string Skos = "xmlns:skos=\"http://www.w3.org/2004/02/skos/core#\"";
            public const string Vcard = "xmlns:vcard=\"http://www.w3.org/2006/vcard/ns#\"";
            public const string Wgs84_pos = "xmlns:wgs84_pos=\"http://www.w3.org/2003/01/geo/wgs84_pos#\"";
            public const string Xsd = "xmlns:xsd=\"http://www.w3.org/2001/XMLSchema#\"";
            public const string Daw = "xmlns:daw=\"http://www.try.gnoss.com/daw#\"";
        }

        public static class Ontologies
        {
            public const string Route = "http://www.obertadecatalunya/route#";
            public const string Eharmonise = "http://www.eharmonise/2014-03-12#";
            public const string Harmonise = "http://protege.stanford.edu/rdf/HTOv4002#";
            public const string Rdf = "http://www.w3.org/1999/02/22-rdf-syntax-ns#";
            public const string Daw = "http://www.try.gnoss.com/daw#";
        }

        public static class RouteProperties
        {
            public const string Name = "http://www.eroute/2014-04-28#routeName";
            public const string NameWithNamespace = "eroute:routeName";
            public const string Description = "http://www.eroute/2014-04-28#description";
            public const string DescriptionWithNamespace = "eroute:description";
            public const string Location = "http://www.eharmonise/2014-03-12#location";
            public const string LocationWithNamespace = "eharmonise:location";
            public const string Lat = "http://www.w3.org/2003/01/geo/wgs84_pos#lat";
            public const string LatWithNamespace = "wgs84_pos:lat";
            public const string Long = "http://www.w3.org/2003/01/geo/wgs84_pos#long";
            public const string LongWithNamespace = "wgs84_pos:long";
            public const string Ads = "http://www.eroute/2014-04-28#ads";
            public const string AdsWithNamespace = "eroute:ads";
            public const string Color = "http://www.eroute/2014-04-28#color";
            public const string ColorWithNamespace = "eroute:color";
            public const string Date = "http://www.eroute/2014-04-28#date";
            public const string DateWithNamespace = "eroute:date";
            public const string GpsRoute = "http://www.eroute/2014-04-28#gpsRoute";
            public const string GpsRouteWithNamespace = "eroute:gpsRoute";
            public const string HasLandmark = "http://www.eroute/2014-04-28#hasLandmark";
            public const string HasLandmarkWithNamespace = "eroute:hasLandmark";
            public const string HeadOf = "http://www.eroute/2014-04-28#headOf";
            public const string HeadOfWithNamespace = "eroute:headOf";
            public const string Hunts = "http://www.eroute/2014-04-28#hunts";
            public const string HuntsWithNamespace = "eroute:hunts";
            public const string Pdf = "http://www.eroute/2014-04-28#pdf";
            public const string PdfWithNamespace = "eroute:pdf";
            public const string Points = "http://www.eroute/2014-04-28#points";
            public const string PointsWithNamespace = "eroute:points";
            public const string Publication = "http://www.eroute/2014-04-28#publication";
            public const string PublicationWithNamespace = "eroute:publication";
            public const string RouteFeature = "http://www.eroute/2014-04-28#routeFeature";
            public const string RouteFeatureWithNamespace = "eroute:routeFeature";
            public const string RouteId = "http://www.eroute/2014-04-28#routeId";
            public const string RouteIdWithNamespace = "eroute:routeId";
            public const string RouteNaturalValue = "http://www.eroute/2014-04-28#routeNaturalValue";
            public const string RouteNaturalValueWithNamespace = "eroute:routeNaturalValue";
            public const string RouteNumber = "http://www.eroute/2014-04-28#routeNumber";
            public const string RouteNumberWithNamespace = "eroute:routeNumber";
            public const string Source = "http://www.eroute/2014-04-28#source";
            public const string SourceWithNamespace = "eroute:source";
            public const string TouristInformation = "http://www.eroute/2014-04-28#touristInformation";
            public const string TouristInformationWithNamespace = "eroute:touristInformation";
            public const string Trail = "http://www.eroute/2014-04-28#trail";
            public const string TrailWithNamespace = "eroute:trail";
            public const string TrailPoint = "http://www.eroute/2014-04-28#trailPoint";
            public const string TrailPointWithNamespace = "eroute:trailPoint";
            public const string City = "http://www.eharmonise/2014-03-12#city";
            public const string CityWithNamespace = "eharmonise:city";
            public const string Image = "http://www.eharmonise/2014-03-12#image";
            //public const string ImageWithNamespace = "eharmonise:image";
            public const string ImageWithNamespace = "daw:image";
            public const string Images = "http://www.eharmonise/2014-03-12#images";
            public const string ImagesWithNamespace = "eharmonise:images";
            public const string Title = "http://www.eharmonise/2014-03-12#title";
            public const string TitleWithNamespace = "eharmonise:title";
            public const string Region = "http://www.eharmonise/2014-03-12#region";
            public const string RegionWithNamespace = "eharmonise:region";
            public const string Duration = "http://www.obertadecatalunya/route#duration";
            public const string DurationWithNamespace = "route:duration";
            public const string IsPartOfRoute = "http://www.obertadecatalunya/route#isPartOfRoute";
            public const string IsPartOfRouteWithNamespace = "route:isPartOfRoute";
            public const string Length = "http://www.obertadecatalunya/route#length";
            public const string LengthWithNamespace = "route:length";
            public const string Signaling = "http://www.obertadecatalunya/route#signaling";
            public const string SignalingWithNamespace = "route:signaling";
            public const string Url = "http://www.obertadecatalunya/route#url";
            public const string UrlWithNamespace = "route:url";
        }

    }
}
