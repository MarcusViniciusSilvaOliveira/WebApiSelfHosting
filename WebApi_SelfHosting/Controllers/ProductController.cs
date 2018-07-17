using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi_SelfHosting.Entidades;

namespace WebApi_SelfHosting.Controllers
{
    public class ProductController : ApiController
    {
        //Controlador receptora de requisições HTTP.
        [HttpGet]
        public List<Product> GetProducts()
        {
            //Ao acesso o método pela WebApi, irá retornar uma lista de alguma entidade.
            //No exemplo abaixo esta retornando um resultado estático.
            return ListaTemporaria();

            //Mas a idéia é fazer uma conexão com banco de dados e utilização de entidade/mapeamento.
            //Mas como o projeto é focado em realizar uma WebApi, utilizei um resultado estático como exemplo.
        }

        private List<Product> ListaTemporaria()
        {
            List<Product> result = new List<Product>();

            result.Add(new Product() {
                Id = 1,
                Code = "001",
                Name = "Arroz",
                IsActive = true
            });
            result.Add(new Product()
            {
                Id = 2,
                Code = "002",
                Name = "Feijão",
                IsActive = true
            });
            result.Add(new Product()
            {
                Id = 3,
                Code = "003",
                Name = "Queijo",
                IsActive = false
            });
            result.Add(new Product()
            {
                Id = 4,
                Code = "004",
                Name = "Farinha",
                IsActive = true
            });

            return result;
        }
    }
}
