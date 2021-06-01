namespace AgileCoding.Extentions.Directories
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class DirectoryExtentions
    {
        public static DriveInfo GetDriveInfo(this DirectoryInfo directory)
        {
            try
            {
                return new DriveInfo(directory.Root.FullName);
            }
            catch (Exception ex)
            {
                throw new DirectoryNotFoundException($"Unable to get drive info from directory {directory.Root.FullName}.{Environment.NewLine}Exception details : {ex.ToString()}");
            }
        }

        public static FileInfo[] GetFilesByFilterPattern(this DirectoryInfo directory, string filter)
        {
            List<FileInfo> result = new List<FileInfo>();
            foreach (var file in directory.GetFiles())
            {
                if (filter.Contains(file.Extension))
                {
                    result.Add(file);
                }
            }

            return result.ToArray();
        }
    }
}
