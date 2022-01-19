using KPSService;
using MyWebsite.Business.Abstract;
using MyWebsite.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWebsite.Business.ServiceAdapters
{
    public class MernisServiceAdapter : IUserCheckService
    {
        public async Task<bool> ValidatePerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var state = await client.TCKimlikNoDogrulaAsync(Convert.ToInt64(person.IdentityNumber), person.FirstName.ToUpper(), person.LastName.ToUpper(), person.BirthOfDay.Year);
            return state.Body.TCKimlikNoDogrulaResult;
        }

        public bool CheckIfUserRealPerson(Person person)
        {
            return ValidatePerson(person).Result;
        }
    }
}
