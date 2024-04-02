namespace Cloning.Addons
{
    public class Bazarr : Addon
    {
        public Bazarr()
        {
            Title = "Bazarr";
            Version = "";
            Info = "Backup Bazarr settings";

            Folders.Add(Utilities.ProgramData + @"\Bazarr\Backups");
        }
    }
}