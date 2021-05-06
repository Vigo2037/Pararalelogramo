using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Paralelogramo.Controllers
{
    // [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    { 
           [HttpGet]
           [Route("Multiplicacao/{b:int}/{a:int}")]

            public int Multiplicacao(int b, int a)
            {
                Operacao Operacao = new Operacao();
                return Operacao.Multiplicacao(b, a);
            }
        
    }

}

