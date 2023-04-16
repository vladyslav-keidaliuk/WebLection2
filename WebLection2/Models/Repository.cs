namespace WebLection2.Models
{
    public static class Repository
    {
        
        private static List<PersonReview>responses = new List<PersonReview>();
        public static IEnumerable<PersonReview> Responses
        {
            get { return responses; }
        }
        public static void AddResponse(PersonReview response)
        {
            responses.Add(response);
        }
    }
}
