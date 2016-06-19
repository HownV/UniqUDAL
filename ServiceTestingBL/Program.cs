using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceTestingBL.AuthenticationService;

namespace ServiceTestingBL
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new AuthenticationServiceClient("BasicHttpBinding_IAuthenticationService");
            bool isValid = client.AuthenticateWebSiteUser("qwe@qwe.qwe", "tbp3rx972nNYlOdGoZmssdLINkJNovxGvrtVQj3Mv/hxh3ow+rd6MeR7CinqAVSILlMumimyIKjylYdzMTu7Kg==");

            bool isAdded = client.RegisterNewUser("123@123.qwe", "tbp3rx972nNYlOdGoZmssdLINkJNovxGvrtVQj3Mv/hxh3ow+rd6MeR7CinqAVSILlMumimyIKjylYdzMTu7Kg==");
            Console.WriteLine("The end");
        }
    }
}
