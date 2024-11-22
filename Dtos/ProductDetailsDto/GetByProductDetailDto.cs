namespace RealEstateDapper8.Dtos.ProductDetailsDto
{
    public class GetByProductDetailDto
    {
        public int ProductDetailID { get; set; }
        public int ProductSize { get; set; }
        public int RoomCount { get; set; }
        public int BedRoomCount { get; set; }
        public int BathCount { get; set; }
        public int GarageSize { get; set; }
        public int Garage { get; set; }
        public string BuildYear { get; set; }
        public string AvaiableFrom { get; set; }
        public string ExteriorMeterial { get; set; }
        public string StructureType { get; set; }
        public decimal ProductDetailPrice { get; set; }
        public string ProductDetailLocation { get; set; }
        public string ProductDetailVideoUrl { get; set; }
        public int ProductID { get; set; }
       
    }
}
