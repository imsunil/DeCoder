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

        private void button3_Click(object sender, EventArgs e)
        {
           textBox1.Text =  MyLinkedList.Add(newWord.Text);
            //updateConsole();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MyLinkedList.Current = MyLinkedList.Current.previous;
            textBox1.Text = MyLinkedList.PreviousValue();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = MyLinkedList.NextValue();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyLinkedList.DeleteNode();
        }

        
    }
}
