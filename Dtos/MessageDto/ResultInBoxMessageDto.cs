namespace RealEstateDapper8.Dtos.MessageDto
{
    public class ResultInBoxMessageDto
    {
        public int MessageID { get; set; }
        public string Name { get; set; }
        public string UserİmageUrl { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
