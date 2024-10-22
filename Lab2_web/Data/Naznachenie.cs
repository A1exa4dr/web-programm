using System.ComponentModel.DataAnnotations;

namespace Lab2_web.Data
{
    public class Naznachenie
    {
        [Key]
        public int KodDokumenta { get; set; }

        public string? NomerDokumenta { get; set; }

        public DateTime? DataRegistratsii { get; set; }

        public DateTime? DataNaznachenia { get; set; }

        public int KodSotrudnika { get; set; }

        public int KodDolzhnosti { get; set; }

        public Sotrudnik? Sotrudnik { get; set; }

        public Dolzhnost? Dolzhnost { get; set; }
    }
}
