using System.Text.Json;
using GovtPincodeApp.Model;

namespace GovtPincodeApp.Domain.response
{
    public class SearchResponse
    {
        public List<ContactDetails> Data { get; }
        public string? Error { get; set; }
        public string? Warning { get; }
        public int? StatusCode { get; set; }

        public SearchResponse(List<ContactDetails> data = null, string? error = null, string? warning = null, int? statusCode = null)
        {
            Data = data;
            Error = error;
            Warning = warning;
            StatusCode = statusCode;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
