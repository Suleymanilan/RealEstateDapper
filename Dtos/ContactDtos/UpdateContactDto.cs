﻿namespace RealEstateDapper8.Dtos.ContactDtos
{
    public class UpdateContactDto
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public string EMail { get; set; }
        public string Message { get; set; }
        public string Contactİmage { get; set; }
        public DateTime SendDate { get; set; }
    }
}