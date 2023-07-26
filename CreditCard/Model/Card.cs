namespace CreditCard.Model
{
    public class Card
    {
        public int Id { get; set; }
        public string CardNumber { get; set; } = string.Empty;
        public string CardHolder { get; set; } = string.Empty;
        public int CardMonth { get; set; }
        public int CardYear { get; set; }
        public string CardCvv { get; set; } = string.Empty;

    }
}
