using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace CustomSerialization
{
    #region Custom Serialization using ISerializable
    [Serializable]
    class MyStringData : ISerializable
    {
        public string dataItemOne, dataItemTwo;

        public MyStringData() { }

        private MyStringData(SerializationInfo si, StreamingContext ctx)
        {
            dataItemOne = si.GetString("First_Item").ToLower();
            dataItemTwo = si.GetString("dataItemTwo").ToLower();
        }

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
        {
            // Fill up the SerializationInfo object with the formatted data.
            info.AddValue("First_Item", dataItemOne.ToUpper());
            info.AddValue("dataItemTwo", dataItemTwo.ToUpper());
        }
    } 
    #endregion

    #region Custom Serialization using attributes
    [Serializable]
    class MoreData
    {
        public string dataItemOne, dataItemTwo;

        [OnSerializing]
        internal void OnSerializing(StreamingContext context)
        {
            // Called during the serialization process. 
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }

        [OnDeserialized]
        internal void OnDeserialized(StreamingContext context)
        {
            // Called once the deserialization process is complete.
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }
    } 
    #endregion
}
