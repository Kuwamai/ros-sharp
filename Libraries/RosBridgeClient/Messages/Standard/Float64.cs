using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Standard
{
    public class Float64 : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "std_msgs/Float64";
        public long data;

        public Float64()
        {
            data = 0;
        }
    }
}