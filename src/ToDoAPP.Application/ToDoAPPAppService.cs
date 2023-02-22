using System;
using System.Collections.Generic;
using System.Text;
using ToDoAPP.Localization;
using Volo.Abp.Application.Services;

namespace ToDoAPP;

/* Inherit your application services from this class.
 */
public abstract class ToDoAPPAppService : ApplicationService
{
    protected ToDoAPPAppService()
    {
        LocalizationResource = typeof(ToDoAPPResource);
    }
}
