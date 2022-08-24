using System.Xml;

namespace KindergartenComplex
{
    internal static class AppParameters
    {
        public static string ConnectionString;
        public static string KindergartenName;

        public static void GetParameters()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("parameters.xml");
            
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlNode node in xRoot)
            {
                switch (node.Name)
                {
                    case "connectionString":
                        ConnectionString = node.InnerText;
                        break;
                    case "kindergartenName":
                        KindergartenName = node.InnerText;
                        break;
                }
            }
        }
    }
}
