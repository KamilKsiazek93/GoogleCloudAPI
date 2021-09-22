namespace GoogleCloudServiceAPI.Data
{
    public class AudioConfig
    {
        public string AudioEncoding { get; set; }

        public AudioConfig(string audioEncoding)
        {
            AudioEncoding = audioEncoding;
        }
    }
}