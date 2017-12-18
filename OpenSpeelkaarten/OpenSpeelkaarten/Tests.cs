using System;
using OpenSpeelkaarten.Comparator;
using OpenSpeelkaarten.ProgramElements.Cards;
using OpenSpeelkaarten.Structures.SLL;
using OpenSpeelkaarten.Structures.Stack;
using OpenSpeelkaarten.Structures.Queue;
using OpenSpeelkaarten.Structures.Tree;
using OpenSpeelkaarten.Sorters;
using OpenSpeelkaarten.Searchers;

namespace OpenSpeelkaarten
{
    class Tests
    {
        /// <summary>-
        /// Performs a test for the single linked list data structure.
        /// </summary>
        public void TestSLL()
        {
            //Example
            Deck deck = new Deck();
            ISingleLinkedList<Card> sll = new SingleLinkedList<Card>();
            ISort<int, int[]> a = new ArraySort<int>(new IntComparator());
            for (int i = 0; i < 25; i++)
            {
                sll.Insert(DrawCard(deck));
            }
            sll.Display();
            Console.WriteLine();
            sll.DeleteHead();
            sll.Display();
            Console.WriteLine();
            sll.DeleteEnd();
            sll.Display();
            Console.WriteLine();
        }

        /// <summary>
        /// Performs tests for the search algorithms.
        /// </summary>
        public void TestSearch()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Performs tests for the sort algorithms.
        /// </summary>
        public void TestSort()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Performs tests for the tree data structure.
        /// </summary>
        public void TestTree()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Performs tests for the stack data structure.
        /// </summary>
        public void TestStack()
        {
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// Performs tests for the queue data structure.
        /// </summary>
        public void TestQueue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Draws a card from a given deck.
        /// </summary>
        /// <param name="deck">Deck from which a card will be drawn.</param>
        private Card DrawCard(Deck deck)
        {
            return deck.Pop();
        }
    }
}
