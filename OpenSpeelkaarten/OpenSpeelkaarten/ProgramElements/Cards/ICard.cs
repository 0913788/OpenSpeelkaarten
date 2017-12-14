namespace OpenSpeelkaarten.ProgramElements.Cards
{
    interface ICard
    {
        /// <summary>
        /// Retruns the type of a card.
        /// </summary>
        /// <returns>String</returns>
        string TheType();
        
        /// <summary>
        /// Returns the value of a card.
        /// </summary>
        /// <returns>String</returns>
        string TheValue();

        /// <summary>
        /// Returns the following card representation: "[Type] [Value]"
        /// </summary>
        /// <returns>String</returns>
        string Stringify();
    }
}
