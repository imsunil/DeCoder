using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trying_Doubly_Linked_List
{
    class LinkedList
    {
        Node First = null;
        Node Last = null;
        Node Current = null;


        public Node Add(string word)
        {
            Node newNode =new Node();
            newNode.Word = word;
            newNode.next = null;
            
            if (First == null)
            {
                newNode.previous = null;
                First = newNode;
                Last = First;
                //Current = First;
                //Current.next = null;
                
                
            }
            else
            {
                //Current = newNode;
                Last.next = newNode;
                newNode.previous = Last;
                //Current.next = null;
                Last = newNode;

            }
            return Last;
        }

       //public string PreviousValue()
       //{
       //   if (Current.previous != null)
       //   {
       //       Current = Current.previous;
       //   }
       //    return Current.Word;
       //}

       //public string NextValue()
       //{
       //    if(Current.next != null)
       //    {
       //        Current = Current.next;
       //    }
       //    return Current.Word;
       //}

       public Node DeleteNode(Node currentPointer)
       {
           String CurrentLocation = WhereIsCurrent(currentPointer);

           //MessageBox.Show(CurrentLocation);
           //return currentPointer;

           switch (CurrentLocation)
           {
               case "AtFirstNode":
                   MessageBox.Show("Deleting First node");
                   //First = currentPointer.next;
                   First = First.next;
                   First.previous = null;
                   currentPointer.next = null;
                   currentPointer = First;
                   //currentPointer = currentPointer.next;
                   //First = Current.next;
                   //First.previous = null;
                   //Current.previous = null;
                   //Current.next = null;
                   //Current = First;
                   break;
               case "AtLastNode":
                   MessageBox.Show("Deleting last node");
                   Last = Last.previous;
                   Last.next = null;
                   currentPointer.previous = null;
                   currentPointer = Last;
                   //Last = Current.previous;
                   //Last.next = null;
                   //Current.previous = null;
                   //Current.next = null;
                   //Current = Last;
                   break;
               case "InTheMiddle":
                   MessageBox.Show("Deleting Middle node");
                   currentPointer.previous.next = currentPointer.next;
                   currentPointer.next.previous = currentPointer.previous;
                   Current = currentPointer;
                   currentPointer = Current.next;
                   Current.next = Current.previous = null;
                   break;   
           }
           
           
           //if( (Current.next != null) && (Current.next != null) )
           // {
           //    Current.previous.next = Current.next;
           //     Current.next.previous = Current.previous.previous;
           //     Current = Current.next;
           //  }
           //else if ( Current.next == null )
           //{
           //    Last = Current.previous;
           //    Last.next = null;
           //    Current.previous = null;
           //    Current.next = null;
           //    Current = Last;
               
           //  }
           // else if( (Current.previous == null) )
           //{
           //    First = Current.next;
           //    First.previous = null;
           //    Current.previous = null;
           //    Current.next = null;
           //    Current = First;
               
           //  }
          return currentPointer;
       }

       private string WhereIsCurrent(Node currentPointer)
       {
           if (currentPointer == First && currentPointer == Last)
           {
               return "OnlyOneNode";
           }
           if(currentPointer.previous == null)
           {
               return "AtFirstNode";
           }
           if (currentPointer.next == null)
           {
               return "AtLastNode";
           }
           return "InTheMiddle";

       }
    }
}
