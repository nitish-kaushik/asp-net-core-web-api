using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWebAPI.Controllers
{
   
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/api/get-all")]
        [Route("~/getall")]
        [Route("~/get-all")]
      
        public string GetAll()
        {
            return "hello from get all";
        }

       // [Route("api/get-all-authors")]
       
        //[Route("getall")]  //this is not possible
        public string GetAllAuthors()
        {
            return "hello from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetById(int id)
        {
            return "hello "+id;
        }

       // [Route("books/{id}/author/{authorId}")]
        public string GetAuthorAddressById(int id, int authorId)
        {
            return "hello author address " + id +" " + authorId;
        }

        //[Route("search")]
        public string SeacrhBooks(int id, int authorId, string name, int rating, int price)
        {
            return "hello from search";
        }
    }
}
