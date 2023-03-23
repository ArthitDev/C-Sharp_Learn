using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructure
{
    public partial class BinarySearchTreeDemo : Form
    {
        public BinarySearchTreeDemo()
        {
            InitializeComponent();
            binarySearchTreeTest();
            
        }
        public void binarySearchTreeTest()
        {
            BinarySearchTree bsTree = new BinarySearchTree();

            bsTree.Insert(40);
            bsTree.Insert(70);
            bsTree.Insert(20);
            bsTree.Insert(35);
            bsTree.Insert(60);
            bsTree.Insert(80);

            Console.WriteLine("PreOrder Traversal");
            bsTree.TraversePreOrder(bsTree.root);
            Console.WriteLine();

            Console.WriteLine("InOrder Traversal");
            bsTree.TraverseInOrder(bsTree.root);
            Console.WriteLine();

            Console.WriteLine("PostOrder Traversal");        
            bsTree.TraversePostOrder(bsTree.root);
            Console.WriteLine();

            Console.WriteLine(bsTree.FindNode(bsTree.root,55));
            Console.WriteLine(bsTree.sumData(bsTree.root));
            Console.WriteLine(bsTree.countNode(bsTree.root));
        }
        
    }
}

class Node
{
    public Node leftNode;
    public Node rigthNode;
    public int data;
}

class BinarySearchTree
{
    public Node root;
    public void Insert(int value)
    {
        Node newNode = new Node();
        newNode.data = value;
        if (root == null)
            root = newNode;
        else
        {
            Node target = null, p = root;
            while (p != null)
            {

                target = p;
                if (value <= p.data)
                {
                    p = p.leftNode;
                }
                else if (value > p.data)
                {
                    p = p.rigthNode;
                }
            }
            if (value <= target.data)
                target.leftNode = newNode;
            else
                target.rigthNode = newNode;
        }
    }

    public void TraversePreOrder(Node parent)
    {
        if (parent != null)
        {
            Console.Write(parent.data + " ");
            TraversePreOrder(parent.leftNode);
            TraversePreOrder(parent.rigthNode);
        }
    }

    public void TraverseInOrder(Node parent)
    {
        if (parent != null)
        {
            TraverseInOrder(parent.leftNode);
            Console.Write(parent.data + " ");
            TraverseInOrder(parent.rigthNode);
        }
    }

    public void TraversePostOrder(Node parent)
    {
        if (parent != null)
        {
            TraversePostOrder(parent.leftNode);
            TraversePostOrder(parent.rigthNode);
            Console.Write(parent.data + " ");
        }
    }

    bool dataFound = false;
    public bool FindNode(Node parent, int dataReserve)
    {
        if (parent != null)
        {
            if (parent.data == dataReserve)
            {
                dataFound = true;
            }
            else if (parent.data < dataReserve)
            {
                FindNode(parent.rigthNode, dataReserve);
            }
            else if (parent.data > dataReserve)
            {
                FindNode(parent.leftNode, dataReserve);
            }
            else
                dataFound = false;
        }
        return dataFound;
    }

    public int sumData (Node parent)
    {
        if(parent == null)
            return 0;
        return parent.data + sumData(parent.leftNode) + sumData(parent.rigthNode);
        
    }

    public int countNode(Node parent)
    {
        if (parent == null)
            return 0;
        return 1 + countNode(parent.leftNode) + countNode(parent.rigthNode);
    }
}
