using GovtPincodeApp.Domain.requests;
using GovtPincodeApp.Model;

namespace GovtPincodeApp.Service;

public interface ISearchService
{
    List<ContactDetails> Search(QueryParameters queryParameters);
}