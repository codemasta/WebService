using System.ServiceModel;
using System.ServiceModel.Channels;
using WebService.Console.CountryWebService;

namespace WebService.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryInfoServiceSoapTypeClient client = 
                new CountryInfoServiceSoapTypeClient("CountryInfoServiceSoap");

            var response = client.ListOfCountryNamesByName();
            foreach (var data in response)
            {
               System.Console.WriteLine(data.sName);   
            }

            System.Console.ReadLine();
        }
    }
}
