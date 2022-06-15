using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Data

{
	internal sealed class Song
	{
        [Key]
        public int SongId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(100000)]
        public string Description { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string VideoUrl { get; set; } = string.Empty;
    }
}

