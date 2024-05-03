using FluentValidation;
using FluentValidationBase_.Requests;
using FluentValidationBase_.Translations.Pipelines;
using Microsoft.Extensions.Localization;
using FluentValidationBase_.Validators.Extensions;

namespace FluentValidationBase_.Validators;

public class MyRequestValidator : AbstractValidator<MyRequest>
{
    //public MyRequestValidator(LanguageTranslations stringLocalizer)
    //{
    //    RuleFor(p => p.Guid).NotEmpty().WithErrorCode("100").WithMessage("Id Errorrrr");
    //    RuleFor(p => p.Name).NotEmpty().WithErrorCode("101").WithMessage("Name Errorrrr");
    //    RuleFor(p => p.Guid).GuidValidation(stringLocalizer);
    //    RuleFor(p => p.Phone).PhoneValidator(stringLocalizer);

    //}
    public MyRequestValidator()
    {
        //RuleFor(p => p.Guid).NotEmpty().WithErrorCode("100").WithMessage("Id Errorrrr");
        RuleFor(p => p.Name).NotEmpty().WithErrorCode("101").WithMessage("Name Errorrrr");
        RuleFor(p => p.Guid).GuidValidation();

        //When(x => x.NotificationMessage.Recipients.IsNullOrEmpty(), () =>
        //{
        //    RuleFor(x => x.NotificationMessage.AccountId).GuidValidation(stringLocalizer);
        //}).Otherwise(() =>
        //{
        //    RuleForEach(x => x.NotificationMessage.Recipients).EmailValidation(stringLocalizer);
        //});

        //When(x => !x.NotificationMessage.AccountId.Equals(Guid.Empty), () =>
        //{
        //    RuleFor(x => x.NotificationMessage.AccountId).GuidValidation(stringLocalizer);
        //});

        //When(x => !x.NotificationMessage.CCs.IsNullOrEmpty(), () =>
        //{
        //    RuleForEach(x => x.NotificationMessage.CCs).EmailValidation(stringLocalizer);

        //});

        //RuleFor(x => x.NotificationMessage.Id).GuidValidation(stringLocalizer);
        //RuleFor(x => x.NotificationMessage.Subject).StringValidator(stringLocalizer);
        //RuleFor(x => x.NotificationMessage.Content).StringValidator(stringLocalizer);
        //RuleFor(x => x.NotificationMessage.Context).StringValidator(stringLocalizer);

    }

}
