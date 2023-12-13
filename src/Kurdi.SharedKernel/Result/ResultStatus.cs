namespace Kurdi.SharedKernel.Result;

    public enum ResultStatus
    {
        Ok,
        Error,
        Forbidden,
        Unauthorized,
        Invalid,
        NotFound,
        Conflict,
        CriticalError,
        Unavailable
    }
