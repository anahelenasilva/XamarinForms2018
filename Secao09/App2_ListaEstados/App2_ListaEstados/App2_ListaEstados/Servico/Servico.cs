using App2_ListaEstados.Modelo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace App2_ListaEstados.Servico
{
    public static class Servico
    {
        private static string URL_ESTADO = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string URL_CIDADE = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> GetEstados()
        {
            List<Estado> listaEstados;

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(URL_ESTADO);
            wc.Dispose();

            listaEstados = JsonConvert.DeserializeObject<List<Estado>>(conteudo);
            return listaEstados;
        }

        public static List<Cidade> GetCidades(int idEstado)
        {
            List<Cidade> listaCidades;

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(string.Format(URL_CIDADE, idEstado));
            wc.Dispose();

            listaCidades = JsonConvert.DeserializeObject<List<Cidade>>(conteudo);
            return listaCidades;
        }
    }
}
