using System.IO;
using System.Xml.Serialization;

namespace Ex03.Services
{
    public class AppSettings
    {
        public string LastAccessToken { get; set; }

        public bool RememberMe { get; set; }
        
        private const string k_FilePath = @".\AppSettings.xml";

        private AppSettings()
        {
            LastAccessToken = null;
            RememberMe = false;         
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            if (File.Exists(k_FilePath))
            {
                using (Stream stream = new FileStream(k_FilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            if (!RememberMe)
            {
                LastAccessToken = null;
            }

            using (Stream stream = new FileStream(k_FilePath, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
