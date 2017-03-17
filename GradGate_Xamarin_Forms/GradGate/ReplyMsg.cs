using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradGate
{
   public class ReplyMsg
    {
        string idR,idQ;
        string replyPost;
        bool done;

        [JsonProperty(PropertyName = "id")]
        public string IdR
        {
            get { return idR; }
            set { idR = value; }
        }

        [JsonProperty(PropertyName = "questionId")]
        public string IdQ
        {
            get { return idQ; }
            set { idQ = value; }
        }

        [JsonProperty(PropertyName = "reply")]
        public string ReplyPost
        {
            get { return replyPost; }
            set { replyPost = value; }
        }


        [JsonProperty(PropertyName = "complete")]
        public bool Done
        {
            get { return done; }
            set { done = value; }
        }

        [Version]
        public string Version { get; set; }
    }
}
