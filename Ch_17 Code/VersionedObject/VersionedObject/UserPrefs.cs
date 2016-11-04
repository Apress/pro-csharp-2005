using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace VersionedObject
{
    [Serializable]
    class UserPrefs
    {
        public ConsoleColor BackgroundColor;
        public ConsoleColor ForegroundColor;

        // New!
        [OptionalField]
        public int BeepFreq;
        [OptionalField]
        public string ConsoleTitle;

        public UserPrefs()
        {
            BeepFreq = 1000;
            ConsoleTitle = "My Console";
            BackgroundColor = ConsoleColor.Black;
            ForegroundColor = ConsoleColor.Red;
        }
    }
}
