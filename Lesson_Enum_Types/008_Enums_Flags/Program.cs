namespace _008_Enums_Flags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assigning multiple permissions using bitwise OR
            FileAccessPermissions permissions = FileAccessPermissions.Read | FileAccessPermissions.Write;

            // Checking if specific permissions are set
            bool canRead = permissions.HasFlag(FileAccessPermissions.Read);
            bool canWrite = permissions.HasFlag(FileAccessPermissions.Write);
            bool canExecute = permissions.HasFlag(FileAccessPermissions.Execute);

            Console.WriteLine($"Can Read: {canRead}, Can Write: {canWrite}, Can Execute: {canExecute}");
            // Output: Can Read: True, Can Write: True, Can Execute: False

            // Adding execute permission
            permissions |= FileAccessPermissions.Execute;

            // Removing write permission
            permissions &= ~FileAccessPermissions.Write;

            Console.WriteLine(permissions); // Output: Read, Execute

        }
    }
    [Flags]
    enum FileAccessPermissions
    {
        Read = 1,    // 0001
        Write = 2,   // 0010
        Execute = 4, // 0100
        FullControl = Read | Write | Execute // 0111
    }
}
