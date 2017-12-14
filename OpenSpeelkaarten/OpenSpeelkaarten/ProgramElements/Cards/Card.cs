namespace OpenSpeelkaarten.ProgramElements.Cards
{
    class Card: AbsCard
    {
        public Card(string value, string type)
        {
            this.value = value;
            this.type = type;
        }

        public string Print()
        {
            return string.Format("{0} {1}", type, value);
        }
    }
}
