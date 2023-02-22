namespace ToDoAPP.Permissions;

public static class ToDoAPPPermissions
{
    public const string GroupName = "ToDoAPP";

     public static class Books
    {
        public const string Default = GroupName + ".Books";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
