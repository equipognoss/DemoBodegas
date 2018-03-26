using Gnoss.ApiWrapper;
using Gnoss.ApiWrapper.ApiModel;
using Gnoss.ApiWrapper.Exceptions;
using Gnoss.ApiWrapper.Model;
using GnossLRTRoutesExample.Carga;
using GnossLRTRoutesExample.Model;
using LumenWorks.Framework.IO.Csv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace GnossLRTRoutesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            cargaRutas carga = new cargaRutas();
            carga.llamadaMetodos();
        }
    }
}