using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;

namespace FluentValidationL
{
    public static class AppServicesExt
    {
        public static IMvcBuilder ExtensionServices(this IMvcBuilder services) 
        {
          return services.AddFluentValidation(fvc => 
            fvc.RegisterValidatorsFromAssemblyContaining<Startup>());
        }
     }
}