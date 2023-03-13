using System;
using System.Collections.Generic;
using System.Text;

namespace SIS.Shared.Enum
{
    public enum ErrorType
    {
        NotSet,
        Unauthorized,
        IncorrectVerificationCode,
        InternalServerError,
        SignUpEmailExists,
        IncorrectEmailOrPassword,
        CannotDeleteRemainingExternalAccount,
        OldPasswordsDoNotMatch,
        ChainbAccountNotFound,
        EmailAlreadyUsed,
        EmailDoesNotMatch,
        PermissionError,
        TermsAndConditionsMustBeAccepted,
        FormatNotSupported,
        CannotAddGroupAsGroupMember,
        CannotAddAnotherAdmin, // not used - can be replaced
        IdentityAlreadyExistsAsUser,
        IdentityAlreadyMemberOfDifferentCompany,
        IdentityAlreadyExists,
        ResetLinkExpired,
        WrongApplicationLogin,
        AlreadyVerified,
        MemberAlreadyExists,
        IncorrectInputData,
        EntityNotFound,
        ValidationFailed,
        FileCouldNotBeSaved,
        OnboardingRequestAlreadyExists,
        CompanyAlreadyClaimed,
        InvalidEntityState,
        EntityAlreadyExists,
        ExceptionThrown,
        DuplicateValue,
        GeneralSisError
    }
}
