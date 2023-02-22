using ToDoAPP.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ToDoAPP.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ToDoAPPController : AbpControllerBase
{
    protected ToDoAPPController()
    {
        LocalizationResource = typeof(ToDoAPPResource);
    }
}
