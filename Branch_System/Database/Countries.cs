using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace MPBS.Database
{
    public class Country
    {
        public string code { get; set; }
        public string name { get; set; }
        public string isoCode { get; set; }
    }

    public static class CountryInfo
    {

        public static List<Country> getCountriesWithISOCode(string countryCode)
        {
            List<Country> countries = new List<Country>();
            foreach (ISO3166.Country country in ISO3166.Country.List)
            {
                Country cntry = new Country();

                cntry.name = country.Name;
                cntry.isoCode = country.NumericCode;

                countries.Add(cntry);

            }

            return countries;
        }


        public static string getCountryWithISOCode(string countryName)
        {
            foreach (ISO3166.Country country in ISO3166.Country.List)
            {
                Console.WriteLine(country.Name);
                if (country.Name == countryName)
                {
                    return country.NumericCode;
                }
            }

            return "434";
        }

        public static List<Country> getCountriesWithPhoneCode()
        {
            List<Country> countries = new List<Country>();
            XDocument doc = XDocument.Parse(MPBS.Resources.Countries.countries);
            IEnumerable<Countries> result = from rec in doc.Descendants("countries")
                                         
                                          select new Countries()
                                          {
                                              Code = (string)rec.Element("code"),
                                             
                                              Name = (string)rec.Element("name")
                                          };

            foreach (Countries c in result)
            {
                //Console.WriteLine("ID:" + p.Code + ", Name: " + p.Name);
                Country country = new Country();
                country.code = c.Code;
                country.name = c.Name;

                countries.Add(country);
            }



            return countries;


        }

        public static List<Country> getCountriesWithISOCode()
        {
            List<Country> countries = new List<Country>();
            foreach (ISO3166.Country c in ISO3166.Country.List)
            {
                Country country = new Country();
                country.isoCode = c.NumericCode;
                country.name = c.Name;

                countries.Add(country);

            }

            return countries;


        }

    }

    [XmlRoot(ElementName = "countries")]
    public class Countries
    {
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "root")]
    public class Root
    {
        [XmlElement(ElementName = "countries")]
        public List<Countries> Countries { get; set; }
       // public string Countries { get; set; }
    }
}
