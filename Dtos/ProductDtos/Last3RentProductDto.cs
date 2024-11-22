namespace RealEstateDapper8.Dtos.ProductDtos
{
    public class Last3RentProductDto
    {
        public string ProductID { get; set; }
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductCoverImage { get; set; }
        public string ProductCity { get; set; }
        public string ProductDistrict { get; set; }
        public string ProductAdress { get; set; }
        public string ProductDescription { get; set; }
        public string CategoryName { get; set; }
        public int AppUserID { get; set; }
        public string Tipi { get; set; }
        public string SlugUrl { get; set; }
        public bool DealOfTheDay { get; set; }
        public string AdvertDate { get; set; }
        public bool ProductStatus { get; set; }
    }
}
