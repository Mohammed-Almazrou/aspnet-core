using ToDoAPP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ToDoAPP.Permissions;

public class ToDoAPPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ToDoAPPPermissions.MyPermission1, L("Permission:MyPermission1"));
    var bookStoreGroup = context.AddGroup(ToDoAPPPermissions.GroupName, L("Permission:BookStore"));

        var booksPermission = bookStoreGroup.AddPermission(ToDoAPPPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(ToDoAPPPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(ToDoAPPPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(ToDoAPPPermissions.Books.Delete, L("Permission:Books.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ToDoAPPResource>(name);
    }
}
