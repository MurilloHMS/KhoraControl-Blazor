using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace KhoraControl.Infrastructure.Services;

public class LicencaService
{
    private readonly HttpClient _httpClient;

    public LicencaService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<bool> VerificarLicencaAsync()
    {
        try
        {
            var url = "https://gist.githubusercontent.com/MurilloHMS/4d344d46d057e79125924b86665b4883/raw/licenca.json";
            var licenca = await _httpClient.GetFromJsonAsync<Licenca>(url);
            if (licenca == null || !licenca.Ativo || licenca.ExpiraEm < DateTime.Today)
            {
                return false;
            }

            return true;
        }
        catch
        {
            return false;
        }
    }

}

public class Licenca
{
    [JsonPropertyName("ativo")]
    public bool Ativo { get; set; }

    [JsonPropertyName("mensagem")]
    public string Mensagem { get; set; }

    [JsonPropertyName("expiraEm")]
    public DateTime ExpiraEm { get; set; }
}