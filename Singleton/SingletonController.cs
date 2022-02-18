using System;
using Localiza.Frotas.Infra.Singleton.Singleton;

namespace Singleton
{
    [Route("api/v1/controller")]
    [ApiController]
    public sealed class SingletonController:ControllerBase
    {
        public Guid Id { get; } = Guid.NewGuid();

        private static Singleton instance = null;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }


        
    }
}
