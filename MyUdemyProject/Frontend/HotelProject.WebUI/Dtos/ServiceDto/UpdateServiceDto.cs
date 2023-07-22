﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet İkon Linki Giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet Başlığı Giriniz")]
        [MaxLength(100, ErrorMessage = "Hizmet Başlığı En Fazla 100 Karakter Olabilir ")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet Açıklaması Giriniz")]
        [MaxLength(500, ErrorMessage = "Hizmet Açıklaması En Fazla 500 Karakter Olabilir ")]
        public string Description { get; set; }
    }
}
