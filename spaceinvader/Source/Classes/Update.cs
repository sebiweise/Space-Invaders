using System.IO;
using System.Net;

namespace Space_Invaders.Classes
{
    class UpdateScript
    {
        public bool GetVersion(string VersionInformation)
        {
                string Directorie = "C:\\Users\\Public\\Documents\\";
                string Link = "https://www.dropbox.com/s/hj9c8g69q3o1af0/version.txt?dl=1";
                string Download = "https://www.dropbox.com/s/v8ct28apzl87dbz/Space_Invaders.exe?dl=1";
                string VersionsFile = Directorie + "version.txt", mystringwebresource = null;
                string DownloadFile = Directorie + "Space_Invaders.exe";

                    //Alte version.txt löschen
                    System.IO.File.Delete(Directorie + "version.txt");

                    // create a new webclient instance.
                    WebClient versioncheck = new WebClient();

                    // concatenate the domain with the web resource filename.
                    mystringwebresource = Link;
            try
            {
                    //Default Proxy setzen
                    versioncheck.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;

                    //Download der Datei und Speicherung in den definierten Pfad
                    versioncheck.DownloadFile(mystringwebresource, VersionsFile);

                    //Durchlesen der version.txt
                    using (StreamReader reader = new StreamReader(@VersionsFile))
                    {

                        //Vergleich von der version.txt mit der Programmversion
                        if (reader.ReadLine() == VersionInformation)
                        {
                            return true;
                        }
                        else
                        {
                            //Alte Space_Invaders.exe löschen
                            System.IO.File.Delete(Directorie + "Space_Invaders.exe");

                            // concatenate the domain with the web resource filename.
                            mystringwebresource = Download;

                            //Download der Datei und Speicherung in den definierten Pfad
                            versioncheck.DownloadFile(mystringwebresource, DownloadFile);
                            return false;
                        }
                    }
                }
            catch (WebException)
            {
                return false;
            }
        }
    }
}