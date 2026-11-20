
using System.ComponentModel.DataAnnotations;

namespace Vừ_A_Vả_Day6.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên thể loại")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập mô tả")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Vui lòng nhập đường dẫn hình ảnh")]
        public string ImageUrl { get; set; } = string.Empty;

        public Genre() { }
    }
}
