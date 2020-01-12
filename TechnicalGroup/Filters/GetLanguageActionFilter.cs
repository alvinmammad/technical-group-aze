using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace TechnicalGroup.Filters
{
    public class GetLanguageActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string lang = context.HttpContext.Features.Get<IRequestCultureFeature>()
                .RequestCulture.Culture.TwoLetterISOLanguageName;


            var locOptions = context.HttpContext.RequestServices.GetService<IOptions<RequestLocalizationOptions>>();

            if (!locOptions.Value.SupportedCultures.Any(c => c.TwoLetterISOLanguageName == lang))
            {
                lang = "az";
            }

            context.ActionArguments["lang"] = lang;
        }
    }
}
