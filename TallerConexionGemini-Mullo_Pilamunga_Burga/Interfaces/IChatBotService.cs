namespace TallerConexionGemini_Mullo_Pilamunga_Burga.Interfaces
{
    public interface IChatBotService
    {
        public Task<string> GetChatBotResponse(string prompt);
    }
}
