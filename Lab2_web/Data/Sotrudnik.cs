using System.ComponentModel.DataAnnotations;

namespace Lab2_web.Data
{
    public class Sotrudnik
    {
        [Key]
        public int KodSotrudnika { get; set; }

        public string? Familiya { get; set; }

        public string? Imya { get; set; }

        public string? Otchestvo { get; set; }

        public DateTime? DataPriemaNaRabotu { get; set; }

        public DateTime? DataRozhdeniya { get; set; }

        public string? Pol { get; set; }
    }
}
