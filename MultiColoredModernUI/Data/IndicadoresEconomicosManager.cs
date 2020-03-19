using System;
using System.Collections.Generic;
using System.Text;
using System.Net;  
using System.Xml;  
using System.Xml.Serialization;
using System.Net.Http;


namespace MultiColoredModernUI.Data
{
    class Cat_indicadoreconomic
    {

    }

    class Indicador
    {
        /*
         * <Datos_de_INGC011_CAT_INDICADORECONOMIC>
         *      <INGC011_CAT_INDICADORECONOMIC> 
         *          <COD_INDICADORINTERNO>317</COD_INDICADORINTERNO>
         *          <DES_FECHA>2019-02-26T00:00:00-06:00</DES_FECHA>
         *          <NUM_VALOR>604.97000000</NUM_VALOR> 
         *      </INGC011_CAT_INDICADORECONOMIC> 
         *      <INGC011_CAT_INDICADORECONOMIC> 
         *          <COD_INDICADORINTERNO>317</COD_INDICADORINTERNO>
         *          <DES_FECHA>2019-02-27T00:00:00-06:00</DES_FECHA>
         *          <NUM_VALOR>605.35000000</NUM_VALOR>
         *      </INGC011_CAT_INDICADORECONOMIC>
         *  </Datos_de_INGC011_CAT_INDICADORECONOMIC>
         */
        public string Cod_indicadorinterno { get; set; }
        public string Des_fecha { get; set; }
        public string Num_valor { get; set; }
    }

    public class IndicadoresEconomicosManager
    {
        
        //private string url;
        private string url = "http://indicadoreseconomicos.bccr.fi.cr/indicadoreseconomicos/WebServices/wsIndicadoresEconomicos.asmx";

        private string getUrl = "http://indicadoreseconomicos.bccr.fi.cr/indicadoreseconomicos/WebServices/wsIndicadoresEconomicos.asmx/ObtenerIndicadoresEconomicosXML?tcIndicador=317&tcFechaInicio={0}&tcFechaFinal={1}&tcNombre=cviales&tnSubNiveles=n";

        private HttpClient client = new HttpClient();

        public async void ObtenerIndicadoresEconomicosXMLAsync( DateTime fechaInicio, DateTime fechaFin)
        {            
            HttpResponseMessage result = await client.GetAsync(string.Format(getUrl,fechaInicio.ToString("dd/mm/yy"),fechaFin.ToString("dd/mm/yy")));
            if (result.StatusCode == HttpStatusCode.OK)
            {
                string content = await result.Content.ReadAsStringAsync();
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(content);
                
            }
        }
    }
}
