namespace GoogleCloudServiceAPI.Data
{
    public class Voice
    {
        public string LanguageCode { get; set; }
        public string Name { get; set; }
        public string SsmlGender { get; set; }

        public Voice(string languageCode, string name, string ssmlGender)
        {
            LanguageCode = languageCode;
            Name = name;
            SsmlGender = ssmlGender;
        }
    }
}