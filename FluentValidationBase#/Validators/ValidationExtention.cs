using FluentValidation;
using FluentValidation.Validators;
using FluentValidationBase_.Translations.Pipelines;

namespace FluentValidationBase_.Validators.Extensions;

internal static class ValidatorExtensions // You can use it for handling your validation rules
{
    //    internal static IRuleBuilderOptions<T, string> MustBeJson<T>(this IRuleBuilder<T, string> ruleBuilder, IPropertyValidator<T, string> validator) where T : class
    //    {
    //        return ruleBuilder.SetValidator(validator);
    //    }

    //    internal static IRuleBuilderOptions<T, string> Base64Validation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Matches(@"^[a-zA-Z0-9\+/]*={0,3}$")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(LanguageTranslations.Validation.Messages.BadInput);
    //    }


    //    internal static IRuleBuilderOptions<T, string> EmailValidation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .EmailAddress()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Email)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Email);
    //    }


    //    internal static IRuleBuilderOptions<T, string> StringValidator<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required);
    //    }

    //    internal static IRuleBuilderOptions<T, string> PhoneValidator<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .MaximumLength(20)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput)
    //            .MinimumLength(6)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput)
    //            .Matches(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput);
    //    }


    //    internal static IRuleBuilderOptions<T, string> PassWordValidator<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(LanguageTranslations.Validation.Messages.Required)
    //            .Length(8, 16)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Range)
    //            .WithMessage(LanguageTranslations.Validation.Messages.PasswordMismatch)
    //            .Matches(@"[A-Z]+")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(LanguageTranslations.Validation.Messages.PasswordUppercase)
    //            .Matches(@"[a-z]+")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(LanguageTranslations.Validation.Messages.PasswordLowercase)
    //            .Matches(@"[0-9]+")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(LanguageTranslations.Validation.Messages.PasswordNumber)
    //            .Matches(@"[\!\@\#\-\?\*\.]+")
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(LanguageTranslations.Validation.Messages.PasswordSpecialCharacters);
    //    }


    //    internal static IRuleBuilderOptions<T, string> ShortTextValidation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Length(3, 100)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Range)
    //            .WithMessage(LanguageTranslations.Validation.Messages.Length);
    //    }

    //    internal static IRuleBuilderOptions<T, string> LongTextValidation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Length(3, 300)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Range)
    //            .WithMessage(LanguageTranslations.Validation.Messages.Length);
    //    }

    //    internal static IRuleBuilderOptions<T, string> TokenValidation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required);
    //    }


    //    internal static IRuleBuilderOptions<T, int> NumberValidation<T>(this IRuleBuilder<T, int> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .GreaterThanOrEqualTo(0)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Range)
    //            .WithMessage(LanguageTranslations.Validation.Messages.Length);
    //    }


    //    internal static IRuleBuilderOptions<T, DateTime> StartDateTimeValidation<T>(this IRuleBuilder<T, DateTime> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .GreaterThan(DateTime.UtcNow)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.DateTime)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.StartDateTime);
    //    }


    //    internal static IRuleBuilderOptions<T, byte> EnumValidation<T>(this IRuleBuilder<T, byte> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Must(p => p > 0)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput);
    //    }

    //    internal static IRuleBuilderOptions<T, byte> PngAndJpgOnlyMimeEnumValidation<T>(this IRuleBuilder<T, byte> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Must(p => p == 1 || p == 2)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput);
    //    }

    //    internal static IRuleBuilderOptions<T, byte> PngAndJpgOnlyUnitEnumValidation<T>(this IRuleBuilder<T, byte> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .Must(p => p == 1)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.BadInput);
    //    }

    //    internal static IRuleBuilderOptions<T, List<T>> CollectionValidation<T>(this IRuleBuilder<T, List<T>> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required);
    //    }

    //    internal static IRuleBuilderOptions<T, object> ObjectValidation<T>(this IRuleBuilder<T, object> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required);
    //    }

    //    internal static IRuleBuilderOptions<T, DateTime> EndDateTimeValidation<T>(this IRuleBuilder<T, DateTime> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .GreaterThan(DateTime.UtcNow)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.DateTime)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.EndDateTime);
    //    }

    //    internal static IRuleBuilderOptions<T, Guid> GuidValidation<T>(this IRuleBuilder<T, Guid> rule, LanguageTranslations stringLocalizer)
    //    {
    //        return rule
    //            .NotNull()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEmpty()
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
    //            .NotEqual(Guid.Empty)
    //            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
    //            .WithMessage(LanguageTranslations.Validation.Messages.Required);
    //    }

    internal static IRuleBuilderOptions<T, Guid> GuidValidation<T>(this IRuleBuilder<T, Guid> rule)
    {
        return rule
            .NotNull()
            .WithErrorCode("1000 Error Code")
            .WithMessage("Should not br null")
            .NotEmpty()
            .WithErrorCode("1001 Error Code")
            .WithMessage("Not Empty")
            .NotEqual(Guid.Empty)
            .WithErrorCode("1002 Error Code")
            .WithMessage("Not Guild Empty");
    }

//    internal static IRuleBuilderOptions<T, string> UrlValidation<T>(this IRuleBuilder<T, string> rule, LanguageTranslations stringLocalizer)
//    {
//        return rule
//            .NotEmpty()
//            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
//            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
//            .NotNull()
//            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
//            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
//            .Must(url => Uri.TryCreate(url, UriKind.Absolute, out var outUri) && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps))
//            .WithErrorCode(LanguageTranslations.Validation.Codes.BadInput)
//            .WithMessage(LanguageTranslations.Validation.Messages.BadInput);
//    }


//    internal static IRuleBuilderOptions<T, bool> BooleanValidation<T>(this IRuleBuilder<T, bool> rule, LanguageTranslations stringLocalizer)
//    {
//        return rule
//            .NotEmpty()
//            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
//            .WithMessage(x => LanguageTranslations.Validation.Messages.Required)
//            .NotNull()
//            .WithErrorCode(LanguageTranslations.Validation.Codes.Required)
//            .WithMessage(x => LanguageTranslations.Validation.Messages.Required);
//    }
}