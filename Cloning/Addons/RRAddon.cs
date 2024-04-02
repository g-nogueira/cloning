using System;

namespace Cloning.Addons
{
    public enum RrName
    {
        Radarr,
        Sonarr,
        Prowlarr,
        Bazarr
    }

    public class RRAddon : Addon
    {
        protected RRAddon(RrName name)
        {
            switch (name)
            {
                case RrName.Radarr:
                    Title = "Radarr";
                    Folders.Add(Utilities.ProgramData + @"\Radarr\Backups");
                    break;
                case RrName.Sonarr:
                    Title = "Sonarr";
                    Folders.Add(Utilities.ProgramData + @"\Sonarr\Backups");
                    break;
                case RrName.Prowlarr:
                    Title = "Prowlarr";
                    Folders.Add(Utilities.ProgramData + @"\Prowlarr\Backups");
                    break;
                case RrName.Bazarr:
                    Title = "Bazarr";
                    Folders.Add(Utilities.ProgramData + @"\Bazarr\backup");
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(name), name, null);
            }

            Version = "";
            Info = $"Backup {Title} settings";
        }
    }
}