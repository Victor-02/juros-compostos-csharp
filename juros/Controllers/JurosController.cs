using Microsoft.AspNetCore.Mvc;
using juros.Model;
using juros.Util;

namespace juros.Controllers;

    
[ApiController]
[Route("api/[controller]")]
public class JurosController : ControllerBase
{
    Investimento invest = new Investimento(0.01, 500.0, 1000.0, 12);

    [HttpGet]
    public Dictionary<string, double> getTotal()
    {
        return Util.Utils.jurosCompostos(invest);
    }

    [HttpPost]
    public Dictionary<string, double> Post([FromBody]Investimento model)
    {
        return Util.Utils.jurosCompostos(model);
        
    }
}