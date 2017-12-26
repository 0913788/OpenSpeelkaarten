using OpenSpeelkaarten.Comparators;
using OpenSpeelkaarten.Structures.Cards;
using OpenSpeelkaarten.Tests;

namespace OpenSpeelkaarten
{
    class Program
    {
        /// <summary>
        /// Perform tests to see if your implementation of datastructures and algorithms work.
        /// </summary>
        static void Main(string[] args)
        {
            ITests<Card> CardTest = new CardTests();
            CardTest.TestSLL();
        }
    }
}
