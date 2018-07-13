using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi_SelfHosting
{
    public class WebApiConfiguration
    {
        //Necessita ter o nome "Configuration", póis a biblioteca
        //irá procurar um método com este nome
        public void Configuration(IAppBuilder app)
        {
            //Instância o objeto para configuração Self-Host
            var config = new HttpConfiguration();

            //{controller} + {action} para permitir em um mesmo controlador conter
            //2 ou mais métodos do mesmo tipo: GET, POST...ect.
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            app.UseWebApi(config);
        }
    }
}
