using Volo.Abp;


namespace ToDoAPP.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(ToDoAPPDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}
