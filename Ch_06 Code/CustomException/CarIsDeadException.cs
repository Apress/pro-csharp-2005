#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace CustomException
{

    #region CarIsDeadException, take one.
    // This custom exception represents a car-is-dead condition.
//    public class CarIsDeadException : System.ApplicationException
//    {
//        private string messageDetails;
//        public CarIsDeadException() { }
//        public CarIsDeadException(string message)
//        {
//            messageDetails = message;
//        }
//
//        // Override the Exception.Message property.
//        public override string Message
//        {
//            get
//            {
//                return string.Format("Car Error Message: {0}", messageDetails);
//            }
//        }
//    } 
    #endregion


    #region CarIsDeadException, take two.
//    public class CarIsDeadException : System.ApplicationException
//    {
//        public CarIsDeadException() { }
//        public CarIsDeadException(string message)
//          : base(message) { }
//    } 
    #endregion


    #region CarIsDeadException, take three.
    [System.Serializable]
    public class CarIsDeadException : System.ApplicationException
    {
        public CarIsDeadException() { }
        public CarIsDeadException(string message) : base( message ) { }
        public CarIsDeadException(string message, System.Exception inner) : base( message, inner ) { }
        protected CarIsDeadException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base( info, context ) { }
    } 
    #endregion
}