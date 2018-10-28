using System.Net.Http;
using System.Threading.Tasks;

namespace FireboardImportAuftrag
{
    public class FireboardConnector
    {
        private static readonly HttpClient Client = new HttpClient();

        private string UrlOperationData { get; }

        public FireboardConnector(string authKey)
        {
            UrlOperationData = $"https://login.fireboard.net/api?authkey={authKey}&call=operation_data";
        }

        public async Task<string> PostFireboardOperation(string payload)
        {
            var response = await Client.PostAsync(UrlOperationData, new StringContent(payload));

            var responseString = await response.Content.ReadAsStringAsync();

            return responseString;
        }
    }
}