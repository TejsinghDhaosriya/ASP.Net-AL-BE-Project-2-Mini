namespace GovtPincodeApp.Domain.requests
{
    public class QueryParameters
    {
        public QueryParameters()
        {
            pincode = "";
            telephone = "";
        }

        public string pincode { get; set; }

        public string telephone { get; set; }


        public bool IsValidParam()
        {
            return !string.IsNullOrEmpty(pincode) || !string.IsNullOrEmpty(telephone) ;
        }
    }
}