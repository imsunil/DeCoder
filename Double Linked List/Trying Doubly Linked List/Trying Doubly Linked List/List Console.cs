using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Trying_Doubly_Linked_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LinkedList MyLinkedList = new LinkedList();
        Node CurrentPointer = null;


        private void button3_Click(object sender, EventArgs e)
        {
           CurrentPointer =  MyLinkedList.Add(newWord.Text);
            updateConsole(CurrentPointer);

        }

        private void updateConsole(Node CurrentPointer)
        {
            textBox1.Text = CurrentPointer.Word; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyLinkedList.Current = MyLinkedList.Current.previous;
            //textBox1.Text = MyLinkedList.PreviousValue();
            if (CurrentPointer.previous != null)
            {
                CurrentPointer = CurrentPointer.previous;
            }
            updateConsole(CurrentPointer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentPointer.next != null)
            {
                CurrentPointer = CurrentPointer.next; 
            }
            
            updateConsole(CurrentPointer);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CurrentPointer= MyLinkedList.DeleteNode(CurrentPointer);
            updateConsole(CurrentPointer);
        }

        
    }
}
