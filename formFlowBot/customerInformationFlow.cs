using Microsoft.Bot.Builder.FormFlow;
using System;
using System.Collections.Generic;

namespace formFlowBot
{

    public enum profileOptions
    {
        OperatingSystems, Databases, Administration, CloudComputing, Developer
    }
    public enum experienceOptions
    {
        Junior, Senior, Expert
    }

    public enum gender
        {
            male, female, other
        }

    public enum nationality
    {
        British, German, Russian, Indian, Canadian, American
    }

    [Serializable]
    public class customerInformationFlow
    {
        public profileOptions? Profile;
        public experienceOptions Experience;
        public gender? Gender;
        public nationality? Nationality;


        public static IForm<customerInformationFlow> BuildForm()
        {

            return new FormBuilder<customerInformationFlow>()
                   .Message("Tell me about you!")
                   .Build();


        }
    }
}