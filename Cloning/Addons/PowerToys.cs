namespace Cloning.Addons
{
    public class PowerToys : Addon
    {
        public PowerToys()
        {
            Title = "PowerToys";
            Version = "";
            Info = "Backup PowerToys settings";

            // Get the Documents folder - C:\Users\gutor\Documents\PowerToys\Backup
            Folders.Add(Utilities.Documents + @"\PowerToys\Backup");
        }
    }
}