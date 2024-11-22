namespace RealEstateDapper8.Dtos.MessageDto
{
    public class UpdateMessageDto
    {
        public int MessageID { get; set; }
        public int Sender { get; set; }
        public int Receiver { get; set; }
        public string Detail { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
