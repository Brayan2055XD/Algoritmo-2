using System;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        // Crear el documento XML
        XmlWriterSettings settings = new XmlWriterSettings();
        settings.Indent = true;

        XmlWriter writer = XmlWriter.Create("SciFiMovies.xml", settings);
        writer.WriteStartDocument();
        writer.WriteStartElement("Movies");

        writer.WriteStartElement("Movie");
        writer.WriteElementString("Title", "Star Wars");
        writer.WriteElementString("Director", "George Lucas");
        writer.WriteElementString("ReleaseYear", "1977");
        writer.WriteEndElement();

        writer.WriteStartElement("Movie");
        writer.WriteElementString("Title", "The Matrix");
        writer.WriteElementString("Director", "The Wachowskis");
        writer.WriteElementString("ReleaseYear", "1999");
        writer.WriteEndElement();

        writer.WriteEndElement();
        writer.WriteEndDocument();

        writer.Flush();
        writer.Close();

        // Cargar el documento XML
        XDocument xmlDoc = XDocument.Load("SciFiMovies.xml");

        // Consulta LINQ para obtener los títulos de todas las películas
        var movieTitles = from movie in xmlDoc.Descendants("Movie")
                          select movie.Element("Title").Value;

        // Imprimir los títulos
        Console.WriteLine("Títulos de las películas:");
        foreach (var title in movieTitles)
        {
            Console.WriteLine(title);
        }
    }
}
