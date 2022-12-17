using System.Xml.Serialization;

namespace Alura_DesignPatterns_2.Atividade08
{
    public class GeradorDeXml
    {
        public string GeraXml(object o)
        {
            var serializer = new XmlSerializer(o.GetType());

            var writer = new StringWriter();
            serializer.Serialize(writer, o);
            return writer.ToString();
        }
    }
}
