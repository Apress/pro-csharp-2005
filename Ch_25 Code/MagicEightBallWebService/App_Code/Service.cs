using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public Service () {

    }

    [WebMethod]
    public string TellFortune(string userQuestion)
    {
        string[] answers =  { "Future Uncertain", "Yes", "No", 
        "Hazy", "Ask again later", "Definitely" };

        // Return a response out of answers using random number.
        Random r = new Random();
        return string.Format("{0}? {1}",
            userQuestion, answers[r.Next(6)]);
    }    
}
