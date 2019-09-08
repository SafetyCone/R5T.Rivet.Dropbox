using System;

using R5T.NetStandard.IO.Paths;
using R5T.NetStandard.IO.Paths.Extensions;
using R5T.Rivet.Organizational;

using DropboxUtilities = R5T.Dropbox.Base.Utilities;
using OrganizationalUtilities = R5T.NetStandard.Organizational.Utilities;


namespace R5T.Rivet.Dropbox
{
    public static class Utilities
    {
        public static string RivetDirectoryPathValue
        {
            get
            {
                var dropboxDirectoryPathValue = DropboxUtilities.DropboxDirectoryPathValue;

                var output = OrganizationalUtilities.AppendOrganizationsAndDefaultOrganizationDirectories(dropboxDirectoryPathValue, RivetOrganization.Instance);
                return output;
            }
        }

        public static DirectoryPath RivetDirectoryPath
        {
            get
            {
                var output = Utilities.RivetDirectoryPathValue.AsDirectoryPath();
                return output;
            }
        }

        public static string DataDirectoryPathValue
        {
            get
            {
                var output = OrganizationalUtilities.AppendDataDirectory(Utilities.RivetDirectoryPathValue);
                return output;
            }
        }

        public static DirectoryPath DataDirectoryPath
        {
            get
            {
                var output = Utilities.DataDirectoryPathValue.AsDirectoryPath();
                return output;
            }
        }
    }
}
