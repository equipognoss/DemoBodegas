using Gnoss.ApiWrapper;
using Gnoss.ApiWrapper.ApiModel;
using Gnoss.ApiWrapper.Model;
using GnossLRTRoutesExample.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GnossLRTRoutesExample.Carga
{
    class winery
    {
        #region miembros

        private string name;
        private string descriptionEs;
        private string descriptionEn;
        private string cityName;
        private string streetAddressEs;
        private string streetAddressEn;
        List<string> images = new List<string>();
        private string price;
        private string region;
        private string telephone;
        private string url;
        Location location;

        #endregion

        #region propiedades

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string CityName
        {
            get
            {
                return cityName;
            }

            set
            {
                cityName = value;
            }
        }

        public string Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

        public List<string> Images
        {
            get
            {
                return images;
            }

            set
            {
                images = value;
            }
        }

        public Location Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public string DescriptionEs
        {
            get
            {
                return descriptionEs;
            }

            set
            {
                descriptionEs = value;
            }
        }

        public string DescriptionEn
        {
            get
            {
                return descriptionEn;
            }

            set
            {
                descriptionEn = value;
            }
        }

        public string StreetAddressEs
        {
            get
            {
                return streetAddressEs;
            }

            set
            {
                streetAddressEs = value;
            }
        }

        public string StreetAddressEn
        {
            get
            {
                return streetAddressEn;
            }

            set
            {
                streetAddressEn = value;
            }
        }

        #endregion

        public List<ComplexOntologyResource> toRecursos(ResourceApi pRA, List<winery> pListWinery)
        {
            List<ComplexOntologyResource> listaRecursosCarga = new List<ComplexOntologyResource>();

            //Prefijos de ontología
            List<string> prefijosOntologia = new List<string>() {
                 Constants.Prefixes.Rdf,
                 Constants.Prefixes.Rdfs,
                 Constants.Prefixes.Owl,
                 Constants.Prefixes.Xsd,
                 Constants.Prefixes.OnTour,
                 Constants.Prefixes.Gn,
                 Constants.Prefixes.Wgs84_pos,
                 Constants.Prefixes.Eharmonise,
                 Constants.Prefixes.Harmonise,
                 Constants.Prefixes.Daw
        };

            foreach (winery bodega in pListWinery)
            {

                ComplexOntologyResource recurso = new ComplexOntologyResource();

                // Propiedades
                List<OntologyProperty> listPropiedades = new List<OntologyProperty>();
                listPropiedades.Add(new StringOntologyProperty("daw:address", bodega.StreetAddressEs, "es"));
                listPropiedades.Add(new StringOntologyProperty("daw:address", bodega.StreetAddressEn, "en"));
                listPropiedades.Add(new StringOntologyProperty("daw:city", bodega.cityName));
                listPropiedades.Add(new StringOntologyProperty("daw:price", bodega.price));
                listPropiedades.Add(new StringOntologyProperty("daw:region", bodega.region));
                listPropiedades.Add(new StringOntologyProperty("daw:telephone", bodega.Telephone));
                listPropiedades.Add(new StringOntologyProperty("daw:url", bodega.Url));
                listPropiedades.Add(new StringOntologyProperty("harmonise:longDescription", bodega.DescriptionEs, "es"));
                listPropiedades.Add(new StringOntologyProperty("harmonise:longDescription", bodega.DescriptionEn, "en"));
                listPropiedades.Add(new StringOntologyProperty("harmonise:name", bodega.name));

                //Entidades
                List<OntologyEntity> listEntidades = new List<OntologyEntity>();
                List<OntologyProperty> listPropiedadesEntidad = new List<OntologyProperty>();
                listPropiedadesEntidad.Add(new StringOntologyProperty("daw:name", bodega.location.LocationNameEs, "es"));
                listPropiedadesEntidad.Add(new StringOntologyProperty("daw:name", bodega.location.LocationNameEn, "en"));
                listPropiedadesEntidad.Add(new StringOntologyProperty("daw:long", bodega.location.Longitude));
                listPropiedadesEntidad.Add(new StringOntologyProperty("daw:lat", bodega.location.Latitude));

                OntologyEntity ent_Location = new OntologyEntity(Constants.Ontologies.Daw + "Location", Constants.Ontologies.Daw + "Location", "daw:location", listPropiedadesEntidad);

                listEntidades.Add(ent_Location);

                Ontology ont = new Ontology(pRA.GraphsUrl, pRA.OntologyUrl, Constants.Ontologies.Daw + "Winery", Constants.Ontologies.Daw + "Winery", prefijosOntologia, listPropiedades, listEntidades);

                recurso.Ontology = ont;
                recurso.CreationDate = DateTime.Now;
                recurso.Title = bodega.Name;
                recurso.Visibility = ResourceVisibility.open;

                //Imágenes
                List<ImageAction> listAcciones = new List<ImageAction>();
                listAcciones.Add(new ImageAction(234, Gnoss.ApiWrapper.Helpers.ImageTransformationType.Crop, 100));
                listAcciones.Add(new ImageAction(300, Gnoss.ApiWrapper.Helpers.ImageTransformationType.ResizeToHeight, 100));
                listAcciones.Add(new ImageAction(660, Gnoss.ApiWrapper.Helpers.ImageTransformationType.ResizeToHeight, 100));

                bool mainImage = true;

                foreach (string ruta_imagen in bodega.images)
                {

                    string relativeImageUrl = "https://content1.lariojaturismo.com/" + ruta_imagen;

                    //Descargar imagen en carpeta
                    //using (WebClient client = new WebClient())
                    //{
                    //    client.DownloadFile(new Uri(relativeImageUrl), Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", ruta_imagen.Substring(ruta_imagen.LastIndexOf("/") + 1, ruta_imagen.IndexOf("?") - ruta_imagen.LastIndexOf("/") - 1).ToString()));
                    //}

                    recurso.AttachImage(relativeImageUrl, listAcciones, Constants.RouteProperties.ImageWithNamespace, mainImage, "jpg");
                    mainImage = false;
                }

                listaRecursosCarga.Add(recurso);
            }

            return listaRecursosCarga;
        }
    }
    public class Location
    {

        private string locationNameEs;
        private string locationNameEn;
        private string latitude;
        private string longitude;

        public string Latitude
        {
            get
            {
                return latitude;
            }

            set
            {
                latitude = value;
            }
        }

        public string Longitude
        {
            get
            {
                return longitude;
            }

            set
            {
                longitude = value;
            }
        }

        public string LocationNameEs
        {
            get
            {
                return locationNameEs;
            }

            set
            {
                locationNameEs = value;
            }
        }

        public string LocationNameEn
        {
            get
            {
                return locationNameEn;
            }

            set
            {
                locationNameEn = value;
            }
        }
    }
}