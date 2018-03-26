using Es.Riam.Cargas.Utils;
using Gnoss.ApiWrapper;
using Gnoss.ApiWrapper.ApiModel;
using Gnoss.ApiWrapper.Exceptions;
using Gnoss.ApiWrapper.Model;
using GnossLRTRoutesExample.Model;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GnossLRTRoutesExample.Carga
{
    class cargaRutas
    {
        List<winery> mlistWinery = new List<winery>();
        ResourceApi mRACarga = new ResourceApi(System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "Config\\config.xml");
        #region Diccionarios

        Dictionary<string, winery> mdicWinery = new Dictionary<string, winery>();

        #endregion

        public cargaRutas()
        {
        }

        public void llamadaMetodos()
        {
            leerRutas();
            cargaDatos();

        }
        public void leerRutas()
        {
            UtilsFicheros.LeerExcelDeRutaADataSet("");
            string routesCsvFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data", "bodegas.csv");

            using (CsvReader csvReader = new CsvReader(new StreamReader(routesCsvFile), true))
            {
                while (csvReader.ReadNextRecord())
                {
                    //Guardar datos del CSV en variables
                    string name = csvReader[0];
                    string descriptionEs = csvReader[1];
                    string descriptionEn = csvReader[2];
                    string cityName = csvReader[3];
                    string streetAddressEs = csvReader[4];
                    string streetAddressEn = csvReader[5];
                    string image1 = csvReader[6];
                    string image2 = csvReader[7];
                    string price = csvReader[8];
                    string region = csvReader[9];
                    string telephone = csvReader[10];
                    string url = csvReader[11];
                    string locationNameEs = csvReader[12];
                    string locationNameEn = csvReader[13];
                    string latitude = csvReader[14];
                    string longitude = csvReader[15];

                    //Objeto Location con sus propiedades
                    Location l = new Location();
                    l.LocationNameEs = locationNameEs;
                    l.LocationNameEn = locationNameEn;
                    l.Latitude = latitude;
                    l.Longitude = longitude;

                    //Objeto Wimery con sus propiedades
                    winery w = new winery();
                    w.Name = name;
                    w.DescriptionEs = descriptionEs;
                    w.DescriptionEn = descriptionEn;
                    w.CityName = cityName;
                    w.StreetAddressEs = streetAddressEs;
                    w.StreetAddressEn = streetAddressEn;
                    w.Images.Add(image1);
                    w.Price = price;
                    w.Region = region;
                    w.Telephone = telephone;
                    w.Url = url;
                    w.Location = l;

                    //Añadimos a la lista cada bodega
                    mlistWinery.Add(w);
                }
            }
        }
        public void cargaDatos()
        {
            winery winery = new winery();
            List<ComplexOntologyResource> listaRecursosCarga = winery.toRecursos(mRACarga, mlistWinery);
            mRACarga.LoadComplexSemanticResourceList(listaRecursosCarga, false, 1);
        }

        private Dictionary<string, string> ejemploLeerExcel()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var mDs = UtilsFicheros.LeerExcelDeRutaADataSet(@"ruta");

            for (int i = 0; i < mDs.Tables.Count; i++)
            {
                if (mDs.Tables[i] != null)
                {
                    foreach (DataRow dr in mDs.Tables[i].Rows)
                    {
                        string dni = dr["DNI"].ToString();
                        string ruta = dr["Nombre Trabajo"].ToString();

                        if (!dic.ContainsKey(dni))
                        {
                            dic.Add(dni, @"ruta" + ruta + ".pdf");
                        }

                    }
                }
            }
            return dic;
        }
    }
}