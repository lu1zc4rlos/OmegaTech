using client_desktop.Login_Cadastro_Senhas;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace client_desktop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TesteMestre());
            //Application.Run(new Home.Home());




        }
    }
}