// <auto-generated>
// Code generated by LUISGen whois.json -cs Luis.WhoLuis -o C:\Users\shzhen\Desktop\
// Tool github: https://github.com/microsoft/botbuilder-tools
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>
using Newtonsoft.Json;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
namespace Luis
{
    public partial class WhoLuis: IRecognizerConvert
    {
        public string Text;
        public string AlteredText;
        public enum Intent {
            Department, 
            DirectReports, 
            EmailAbout, 
            EmailAddress, 
            JobTitle, 
            Location, 
            Manager, 
            MeetAbout, 
            None, 
            Peers, 
            PhoneNumber, 
            ShowDetail, 
            ShowNextPage, 
            ShowPreviousPage, 
            WhoIs
        };
        public Dictionary<Intent, IntentScore> Intents;

        public class _Entities
        {
            // Simple entities
            public string[] keyword;

            // Built-in entities
            public double[] ordinal;

            // Instance
            public class _Instance
            {
                public InstanceData[] keyword;
                public InstanceData[] ordinal;
            }
            [JsonProperty("$instance")]
            public _Instance _instance;
        }
        public _Entities Entities;

        [JsonExtensionData(ReadData = true, WriteData = true)]
        public IDictionary<string, object> Properties {get; set; }

        public void Convert(dynamic result)
        {
            var app = JsonConvert.DeserializeObject<WhoLuis>(JsonConvert.SerializeObject(result, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            Text = app.Text;
            AlteredText = app.AlteredText;
            Intents = app.Intents;
            Entities = app.Entities;
            Properties = app.Properties;
        }

        public (Intent intent, double score) TopIntent()
        {
            Intent maxIntent = Intent.None;
            var max = 0.0;
            foreach (var entry in Intents)
            {
                if (entry.Value.Score > max)
                {
                    maxIntent = entry.Key;
                    max = entry.Value.Score.Value;
                }
            }
            return (maxIntent, max);
        }
    }
}
