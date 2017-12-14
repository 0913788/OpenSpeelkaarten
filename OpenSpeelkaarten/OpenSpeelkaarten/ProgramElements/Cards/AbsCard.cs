namespace OpenSpeelkaarten.ProgramElements.Cards
{
    class AbsCard :ICard
    {
        protected string value, type;
        public string TheType()
        {
            return type;
        }

        public string TheValue()
        {
            return value;
        }
    }
}
