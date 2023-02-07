using TODO.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TODO.Permissions;

public class TODOPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TODOPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TODOPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TODOResource>(name);
    }
}
