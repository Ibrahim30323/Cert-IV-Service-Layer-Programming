using System;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    
    
    [ApiController]
    [Route("[controller]")]

    public class HelloController: ControllerBase
    {
          int count = 0;
        
          [HttpGet]

          public string Get() {
              this.count++;
              return this.count.ToString();
          }

    }
    


}