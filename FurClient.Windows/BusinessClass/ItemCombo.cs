namespace FurClient.BusinessClass
{
    public class ItemCombo
    {
        public string Text { get; set; }
        public string Value { get; set; }

        public ItemCombo(string valore, string testo)
        {
            Value = valore;
            Text = testo;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}