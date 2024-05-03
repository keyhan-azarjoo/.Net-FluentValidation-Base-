using FluentValidationBase_.Requests;
//using FluentValidationBase_.Translations.Pipelines;
using FluentValidationBase_.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace FluentValidationBase_.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class SimpleFluentValidationController : Controller
    {
        //public readonly LanguageTranslations languageTranslator;

        [HttpPost("register")]
        //[AllowAnonymous] 
        public async Task<ActionResult> register(MyRequest request, CancellationToken cancellationToken) // any request will go to validator befor hiting the controller.
        {

            // You can have your exception handler here 
            // for better implimentation search for mediator fluent validation

            //var validator = new MyRequestValidator(languageTranslator);
            //var validatorresult = validator.Validate(request);
            //var errors = validatorresult.Errors;
            //var message = validatorresult.ToString();

            //if (!validatorresult.IsValid)
            //{
            //    throw new Exception();// you can throw as exeption as you need base on result.
            //}

            await Task.CompletedTask;
            string result = "rigestered";
            return Ok(result);
        }
    }
}
