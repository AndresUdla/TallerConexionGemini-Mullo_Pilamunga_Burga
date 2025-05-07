using TallerConexionGemini_Mullo_Pilamunga_Burga.Interfaces;

namespace TallerConexionGemini_Mullo_Pilamunga_Burga.Repositories
{
    public class GeminiRepository : IChatBotService
    {
        HttpClient _httpClient;
        public string apiKey = AIzaSyAWRxEriVFjv74UGbnDrCXDTx25XRRSuTM;



        public GeminiRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<string> GetChatBotResponse(string prompt)
        {
            throw new NotImplementedException();
        }


    }
}
