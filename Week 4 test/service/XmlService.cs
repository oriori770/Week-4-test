using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_4_test.service
{
    internal class XmlService
    {
        string filePath = "Data/XmlData.xml";
        public XmlService() 
        {
        }


        public XElement CreateXML(string Day, string DayMonth, string Month, string Year, string Result)
        {
            // Create XElement
            XElement Query = new XElement("Query",
                new XElement("Day", Day),
                new XElement("DayMonth", DayMonth),
                new XElement("Month", Month),
                new XElement("Year", Year),
                new XElement("Result", Result)
            );
            return Query;
        }
        public void SaveQueryToFile(XElement Query)
        {
            //CreateFile(filePath);
            Query.Save(filePath);

        }

        private void CreateFile(string filePath)
        {
            // Check if the file exists
            if (!File.Exists(filePath))
            {
                // Create the file
                using (FileStream fs = File.Create(filePath))
                {

                }
            }
        }
    }

}
