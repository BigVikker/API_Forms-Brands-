namespace APIBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;

    public partial class PRODUCT
    {
        
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal? PromotionPrice { get; set; }

        public int? Rating { get; set; }

        public string ProductImage { get; set; }

        public int? ProductStock { get; set; }

        public string ProductURL { get; set; }

        public int? Viewcount { get; set; }

        public bool? ProductStatus { get; set; }

        public DateTime? CreatedDate { get; set; }


        
    }
}
