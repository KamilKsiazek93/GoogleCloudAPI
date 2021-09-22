namespace GoogleCloudServiceAPI.Data
{
    public class SpeechParamModel
    {
        public Input Input { get; set; }
        public Voice Voice { get; set; }
        public AudioConfig AudioConfig { get; set; }

        public SpeechParamModel(Input input, Voice voice, AudioConfig audioConfig)
        {
            Input = input;
            Voice = voice;
            AudioConfig = audioConfig;
        }
    }
}