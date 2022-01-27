using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationIndra.App;
using WebApplicationIndra.Models;

namespace WebApplicationIndra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Ejercicio2Controller : ControllerBase
    {
        public List<int> Ejercicio2(Camion_Input consulta)
        {
            Ejercicio_Camion Ejercicio2 = new Ejercicio_Camion();
            return Ejercicio2.Ejercicio2(consulta);  
        }
    }
}
