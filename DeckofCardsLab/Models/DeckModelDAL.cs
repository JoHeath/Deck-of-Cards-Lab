using Newtonsoft.Json;
using System.Net;

namespace DeckofCardsLab.Models
{
    public class DeckModelDAL
    {
        public static DeckModel GetDeck()//adjust here return type and name
        {
            //adjust url
            //setup section
            string url = "https://deckofcardsapi.com/api/deck/vvqrg5jwmw1l/draw/?count=5";

            //request for data
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            //converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //adjust model type
            //convert to c#
            //install Newtonsoft.json
            DeckModel result = JsonConvert.DeserializeObject<DeckModel>(json);
            return result;
        }
        public static Shuffle ShuffleDeck()//adjust here return type and name
        {
            //adjust url
            //setup section
            string url = "https://deckofcardsapi.com/api/deck/vvqrg5jwmw1l/shuffle/";

            //request for data
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            //converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string json = reader.ReadToEnd();

            //adjust model type
            //convert to c#
            //install Newtonsoft.json
            Shuffle result = JsonConvert.DeserializeObject<Shuffle>(json);
            return result;
        }


    }
}
