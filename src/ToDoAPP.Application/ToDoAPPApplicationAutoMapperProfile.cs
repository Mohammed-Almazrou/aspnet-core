using AutoMapper;
using ToDoAPP.Books;
namespace ToDoAPP;

public class ToDoAPPApplicationAutoMapperProfile : Profile
{
    public ToDoAPPApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

         CreateMap<Book,BookDto>();
         CreateMap<CreateUpdateBookDto, Book>();
    }
}
