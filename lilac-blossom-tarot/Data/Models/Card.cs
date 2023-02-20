namespace lilac_blossom_tarot.Data.Models
{
    public class Card
    {
        public string? type { get; set; }
        public string? name_short { get; set; }
        public string? name { get; set; }
        public string? value { get; set; }
        public int? value_int { get; set; }
        public string? meaning_up { get; set; }
        public string? meaning_rev { get; set; }
        public string? desc_up { get; set; }
    }
}
