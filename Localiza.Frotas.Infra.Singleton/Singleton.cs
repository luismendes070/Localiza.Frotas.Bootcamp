
using System;

namespace Localiza.Frotas.Infra.Singleton
{
    public class Singleton
    {
        [HttpGet()]
        public IActionResult Get()
        {
            var singleton = new Singleton();
            return Ok(singleton);
        }
    }
}
