using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trying_Doubly_Linked_List
{
    class LinkedList
    {
        Node First = null;
        Node Last = null;
        Node Current = null;


        public string Add(string word)
        {
            Node newNode =new Node();
            newNode.Word = word;

            if (First == null)
            {
                First = newNode;
                Last = First;
                Current = First;
                Current.next = null;
                Current.previous = null;
                
            }
            else
            {
                Current = newNode;
                Last.next = Current;
                Current.previous = Last;
                Current.next = null;
                Last = Current;

            }
            return Current.Word;
        }

       public string PreviousValue()
       {
          if (Current.previous != null)
          {
              Current = Current.previous;
          }
           return Current.Word;
       }

       public string NextValue()
       {
           if(Current.next != null)
           {
               Current = Current.next;
           }
           return Current.Word;
       }

       public string DeleteNode()
       {
           if( (Current.next != null) && (Current.next != null) )
            {
               Current.previous.next = Current.next;
                Current.next.previous = Current.previous.previous;
                Current = Current.next;
             }
           else if ( Current.next == null )
           {
               Last = Current.previous;
               Last.next = null;
               Current.previous = null;
               Current.next = null;
               Current = Last;
               
             }
            else if( (Current.previous == null) )
           {
               First = Current.next;
               First.previous = null;
               Current.previous = null;
               Current.next = null;
               Current = First;
               
             }
           return Current.Word;
       }
    }
}
