using System;

namespace OpenSpeelkaarten.ProgramElements.Cards
{
    class AbsCard :ICard
    {
        protected string value, type;

        public string GetCardType()
        {
            return type;
        }

        public string GetCardValue()
        {
            return value;
        }

        public string Stringify()
        {
            return string.Format("{0} {1}", type, value);
        }
    }
}
