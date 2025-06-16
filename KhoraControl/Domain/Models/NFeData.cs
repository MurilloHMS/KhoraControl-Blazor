using System.Xml.Linq;

namespace KhoraControl.Domain.Models
{
    public class NFeData
    {
        public int ID { get; set; }
        public string Referência { get; set; }
        public string Descrição { get; set; }
        public int Quantidade { get; set; }
        public string Fornecedor { get; set; }
        public string ChaveNFe { get; set; }
        public string CNPJ { get; set; }
        public string NumeroNFe { get; set; }
        public string Serie { get; set; }

        public DateTime DataEmissao { get; set; }

        public List<NFeData> ReturnDados(string path)
        {
            // Ler o XML da NFe
            XDocument doc = XDocument.Load(path);

            // Namespace do XML
            XNamespace ns = "http://www.portalfiscal.inf.br/nfe";

            // Dados do fornecedor (emissor)
            var emitente = doc.Descendants(ns + "emit").FirstOrDefault();
            CNPJ = emitente.Element(ns + "CNPJ").Value;
            Fornecedor = emitente.Element(ns + "xNome").Value;

            var dados = doc.Descendants(ns + "ide").FirstOrDefault();
            NumeroNFe = dados.Element(ns + "nNF").Value;
            Serie = dados.Element(ns + "serie").Value;
            string dataEmissaoStr = dados.Element(ns + "dhEmi").Value;

            var chave = doc.Descendants(ns + "infProt").FirstOrDefault();
            ChaveNFe = chave.Element(ns + "chNFe").Value;

            if (DateTime.TryParseExact(dataEmissaoStr, "yyyy-MM-ddTHH:mm:sszzz", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime dataEmissao))
            {
                DataEmissao = dataEmissao; // Atribuir a data de emissão convertida à propriedade DataEmissao
            }
            else
            {
                // Tratar o caso em que a conversão falha
                throw new Exception("Erro ao converter a data de emissão.");
            }

            // Lista para armazenar os dados dos produtos
            List<NFeData> products = new List<NFeData>();


            // Loop através das tags <det> no XML
            foreach (XElement det in doc.Descendants(ns + "det"))
            {
                // Extrair os dados do produto
                NFeData product = new NFeData
                {
                    //ID = int.Parse(det.Element(ns + "nItem").Value),
                    Referência = det.Element(ns + "prod").Element(ns + "cProd").Value,
                    Descrição = det.Element(ns + "prod").Element(ns + "xProd").Value,
                    Quantidade = int.Parse(det.Element(ns + "prod").Element(ns + "qCom").Value.Split('.')[0]),
                    Fornecedor = emitente.Element(ns + "xNome").Value
                };
                // Adicionar o produto à lista
                products.Add(product);
            }

            // Preencher o DataGridView com os dados dos produtos
            return products;
        }


    }


}
