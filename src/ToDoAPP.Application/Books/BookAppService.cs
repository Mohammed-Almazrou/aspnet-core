using System;
using ToDoAPP.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace ToDoAPP.Books;

public class BookAppService :
    CrudAppService<
        Book, //The Book entity
        BookDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateBookDto>, //Used to create/update a book
    IBookAppService //implement the IBookAppService
{public BookAppService(IRepository<Book, Guid> repository)
        : base(repository)
    {
 GetPolicyName = ToDoAPPPermissions.Books.Default;
        GetListPolicyName = ToDoAPPPermissions.Books.Default;
        CreatePolicyName = ToDoAPPPermissions.Books.Create;
        UpdatePolicyName = ToDoAPPPermissions.Books.Edit;
        DeletePolicyName = ToDoAPPPermissions.Books.Delete;
    }
}