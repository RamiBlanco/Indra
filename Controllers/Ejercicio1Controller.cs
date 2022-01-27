using Microsoft.AspNetCore.Mvc;
using WebApplicationIndra.App;

namespace WebApplicationIndra.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Ejercicio1Controller : ControllerBase
    {
                
        public Casas_Output Ejercicio1 (Casas_Input consulta)
        {
            Ejercicio_Casas Ejercicio1 = new Ejercicio_Casas();
            Casas_Output result = Ejercicio1.Ejercicio1(consulta);
            return result;

        }
    }
}
