namespace Cloning.Addons
{
    public class Plex : Addon
    {
        public Plex()
        {
            Title = "Plex";
            Version = "Compatible ONLY with CS5";
            Info = "Backup Plex settings";

            Folders.Add(Utilities.LocalAppData + @"\Plex Media Server");
            Keys.Add(@"HKEY_CURRENT_USER\Software\Plex, Inc.\Plex Media Server");
        }
    }
}