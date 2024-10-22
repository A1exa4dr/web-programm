using System.ComponentModel.DataAnnotations;

namespace Lab2_web.Data
{
    public class Dolzhnost
    {
        [Key]
        public int KodDolzhnosti { get; set; }

        public string? NazvanieDolzhnosti { get; set; }

        public string? Lgoty { get; set; }

        public string? TrebovaniyaKvalifikatsii { get; set; }
    }
}
