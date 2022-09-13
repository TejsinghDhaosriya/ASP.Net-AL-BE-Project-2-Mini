using System.Globalization;
using CsvHelper;
using GovtPincodeApp.Domain.requests;
using GovtPincodeApp.Model;

namespace GovtPincodeApp.Service;

public class SearchService : ISearchService
{
    public List<ContactDetails> Search(QueryParameters qp)
    {
        var contactsData = getContactDataList();

        if (!string.IsNullOrEmpty(qp.telephone) && !string.IsNullOrEmpty(qp.pincode))
        {
            return contactsData
                .Where(t =>
                    t.pincode.Equals(qp.pincode) &&
                    t.Telephone.Equals(qp.telephone))
                .ToList();
        }

        if (!string.IsNullOrEmpty(qp.pincode))
        {
            return contactsData
                .Where(t =>
                    t.pincode.Equals(qp.pincode))
                .ToList();
        }

        return contactsData
            .Where(t =>
                t.Telephone.Equals(qp.telephone))
            .ToList();
    }

    private List<ContactDetails> getContactDataList()
    {
        using var reader = new StreamReader("govt-data.csv");
        using var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture);
        var contactDetails = csvReader.GetRecords<ContactDetails>();
        return contactDetails.ToList();
    }
}