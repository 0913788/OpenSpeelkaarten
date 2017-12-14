using System;

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

        public string Stringify()
        {
            return string.Format("{0} {1}", type, value);
        }
    }
}
