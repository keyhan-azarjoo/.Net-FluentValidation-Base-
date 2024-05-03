namespace FluentValidationBase_.Translations.Pipelines;

public sealed record LanguageTranslations
{
    public static class Validation
    {
        public static class Codes
        {
            public const string BadInput = "400-error-badinput";
            public const string DateTime = "400-error-datetime";
            public const string Email = "400-error-email";
            public const string Maximum = "400-error-maximum";
            public const string Minimum = "400-error-minimum";
            public const string PatternMismatch = "400-error-patternmismatch ";
            public const string Range = "400-error-range";
            public const string Required = "400-error-required";
        }

        public static class Messages
        {
            public const string BadInput = "Validation.BadInput";
            public const string Email = "Validation.Email";
            public const string Required = "Validation.Required";
            public const string StartDateTime = "Validation.StartDateTime";
            public const string EndDateTime = "Validation.EndDateTime";
            public const string DateTime = "Validation.DateTime";
            public const string Length = "Validation.Length";

            public const string RegexPattern = "Validation.RegexPattern";

            public const string Prompt = "use the information in the descriptionc to solve they problem or contact support";
            public const string PasswordMismatch = "Validation.PasswordMismatch";
            public const string PasswordRange = "Validation.PasswordRange";
            public const string PasswordUppercase = "Validation.PasswordUppercase";
            public const string PasswordLowercase = "Validation.PasswordLowercase";
            public const string PasswordNumber = "Validation.PasswordNumber";
            public const string PasswordSpecialCharacters = "Validation.PasswordSpecialCharacters";
        }
    }


    internal static class Names
    {
        /// <summary>
        ///     language resource not found
        /// </summary>
        public const string LanguageNotFound = "Names.LanguageNotFound"; // todo - en


        /// <summary>
        ///     time zone resource not found
        /// </summary>
        public const string TimezoneNotFound = "Names.TimezoneNotFound"; // todo - en


        /// <summary>
        ///     resource not found
        /// </summary>
        public const string NotFound = "Names.NotFound";

        /// <summary>
        ///     request denied
        /// </summary>
        public const string BadRequest = "Names.BadRequest";

        /// <summary>
        ///     invalid access token
        /// </summary>
        public const string Token = "Names.Token";

        /// <summary>
        ///     internal server error
        /// </summary>
        public const string Internal = "Names.Internal";

        /// <summary>
        ///     identity errors
        /// </summary>
        public const string Identity = "Names.Identity";

        /// <summary>
        ///     not authorised
        /// </summary>
        public const string Unauthorised = "Names.Unauthorised";

        /// <summary>
        ///     forbidden access
        /// </summary>
        public const string Forbidden = "Names.Forbiddeln";

        /// <summary>
        ///     record already exists
        /// </summary>
        public const string Exists = "Names.Exists";

        public const string Password = "Names.Passwords";

        public const string VerificationFailed = "Names.VerificationFailed";

        public const string Translations = "Names.Translations";

        public const string AccountUsers = "Names.AccountUsers";
    }

    internal static class Descriptions
    {
        internal const string BadRequest = "Descriptions.BadRequest";
        internal const string Failed = "Descriptions.Failed";
        internal const string Forbidden = "Descriptions.Forbidden";
        internal const string Exists = "Descriptions.Exists";
        public const string AccountExists = "Descriptions.AccountExists";
        public const string EmailExists = "Descriptions.EmailExists";
        public const string EmailUnconfirmed = "Descriptions.EmailUnconfirmed";
        public const string Exceptions = "Descriptions.Excptions";
        public const string InactiveUser = "Descriptions.InactiveUser";
        public const string Internal = "Descriptions.Internal";
        public const string InvalidCredentials = "Descriptions.InvalidCredentials";
        public const string InvalidToken = "Descriptions.InvalidAccessToken";
        public const string LanguageNotFound = "Descriptions.LanguageNotFound";
        public const string LocationRequired = "Descriptions.LocationRequired";
        public const string Locked = "Descriptions.Locked";
        public const string NativeIdentityErrors = "Descriptions.NativeIdentityErrors";
        public const string NotFound = "Descriptions.NotFound";
        public const string Payload = "Descriptions.Payload";
        public const string PhonenumberExists = "Descriptions.PhonenumberExists";
        public const string PreferencesExists = "Descriptions.PreferencesExists";
        public const string RecordExists = "Descriptions.RecordExists";
        public const string RequestDenied = "Descriptions.RequestDenied";
        public const string TimezoneNotFound = "Descriptions.TimezoneNotFound";
        public const string TokenExpired = "Descriptions.TokenExpired";
        public const string TokenForbidden = "Descriptions.TokenForbidden";
        public const string TokenTempered = "Description.TokenTempered";
        public const string TokenUnprocessed = "Descriptions.TokenUnprocessed";
        public const string Translations = "Descriptions.Translations";
        public const string Unauthorised = "Descriptions.Unauthorised";
        public const string UserAccountExists = "Descriptions.UserAccountExists";
        public const string UsernameExists = "Descriptions.UsernameExists";
        public const string UserprofileExists = "Descriptions.UserprofileExists";
        public const string VerificationFailed = "Descriptions.VerificationFailed";
    }

    internal static class Prompts
    {
        internal const string Exists = "Descriptions.Exists";
        public const string Id = "Prompts.Id";

        public const string Translations = "Prompts.Translations";

        public const string NotFound = "Prompts.NotFound";

        /// <summary>
        ///     request refresh / new access token
        /// </summary>
        public const string Reauthenticate = "Prompts.Reauthenticate";


        /// <summary>
        ///     confirm user email address to proceed
        /// </summary>
        public const string Email = "Prompts.Email";

        /// <summary>
        ///     check that the provided credentials are correct
        /// </summary>
        public const string Credentials = "Prompts.Credentials";

        /// <summary>
        ///     have you tried the update mechanism
        /// </summary>
        public const string Update = "Prompts.Update";

        /// <summary>
        ///     only role and permission elevated users have access to perform this action
        /// </summary>
        public const string Elevated = "Prompts.Elevated";

        /// <summary>
        ///     check that the provided information was correct
        /// </summary>
        public const string Information = "Prompts.Information";

        /// <summary>
        ///     use the exception to solve the problem
        /// </summary>
        public const string Exception = "Prompts.Exception";

        /// <summary>
        ///     update to select an active location prior deselecting the address
        /// </summary>
        public const string Location = "Prompts.Location";

        /// <summary>
        ///     user not active. please contact the administrator
        /// </summary>
        public const string InactiveUser = "Prompts.InactiveUser";

        /// <summary>
        ///     profile can be updated after it has been created
        /// </summary>
        public const string Profile = "Prompts.Profile";

        /// <summary>
        ///     check identity error to resolve the problem
        /// </summary>
        public const string Identity = "Prompts.Identity";

        public const string PreferencesExists = "Prompts.PreferencesExists";

        /// <summary>
        ///     there is already an account with similar information
        /// </summary>
        public const string AccountExists = "Prompts.AccountExists";

        public const string EmailUnconfirmed = "Prompts.EmailUnconfirmed";

        public const string Locked = "Prompts.Locked";

        public const string VerificationFailed = "Prompts.VerificationFailed";
    }
}