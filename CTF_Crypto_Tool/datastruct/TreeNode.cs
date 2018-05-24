using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTF_Crypto_Tool.datastruct
{
    public class TreeNode<T>
    {
        private T data;
        private TreeNode<T> lChild;
        private TreeNode<T> rChild;

        public TreeNode(T data,TreeNode<T> lChild,TreeNode<T> rChild)
        {
            this.data = data;
            this.lChild = lChild;
            this.rChild = rChild;
        }

        public TreeNode(T data)
        {
            this.data = data;
            lChild = null;
            rChild = null;
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public TreeNode<T> LChild
        {
            get { return lChild; }
            set { lChild = value; }
        }

        public TreeNode<T> RChild
        {
            get { return rChild; }
            set { rChild = value; }
        }

        public bool DelectLChild()
        {
            if (lChild == null)
                return false;
            try
            {
                lChild = null;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DelectRChild()
        {
            if (rChild == null)
                return false;
            try
            {
                rChild = null;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    public class BinaryTree<T>
    {
        private TreeNode<T> root;
        private string findString;

        public BinaryTree(TreeNode<T> root)
        {
            this.root = root;
        }

        public BinaryTree(T data)
        {
            TreeNode<T> head = new TreeNode<T>(data);
            root = head;
        }

        public BinaryTree(T data,TreeNode<T> lChild, TreeNode<T> rChild)
        {
            TreeNode<T> head = new TreeNode<T>(data, lChild, rChild);
            root = head;
        }

        public BinaryTree()
        {
            root = null;
        }

        public TreeNode<T> Root
        {
            get { return root; }
            set { root = value; }
        }

        public string FindString
        {
            get { return findString; }
        }

        public TreeNode<T> LChild
        {
            get { return root.LChild; }
            set { root.LChild = value; }
        }

        public TreeNode<T> RChild
        {
            get { return root.RChild; }
            set { root.RChild = value; }
        }

        public bool IsEmpty()
        {
            return root == null ? true : false;
        }

        public bool AddL(TreeNode<T> parent,T data)
        {
            if (parent.LChild != null)
                return false;
            try
            {
                TreeNode<T> tmp = new TreeNode<T>(data);
                parent.LChild = tmp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool AddR(TreeNode<T> parent, T data)
        {
            if (parent.RChild != null)
                return false;
            try
            {
                TreeNode<T> tmp = new TreeNode<T>(data);
                parent.RChild = tmp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertL(T data, TreeNode<T> parent)
        {
            try
            {
                TreeNode<T> tmp = new TreeNode<T>(data);
                tmp.LChild = parent.LChild;
                parent.LChild = tmp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertR(T data, TreeNode<T> parent)
        {
            try
            {
                TreeNode<T> tmp = new TreeNode<T>(data);
                tmp.RChild = parent.RChild;
                parent.RChild = tmp;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void PreOrder(TreeNode<T> ptr)
        {
            if (IsEmpty())
                return;
            if(ptr != null)
            {
                Console.Write(ptr.Data);
                PreOrder(ptr.LChild);
                PreOrder(ptr.RChild);
            }
        }

        public void FindData(TreeNode<char> tn, char data, string result)
        {
            if (tn.Data == '!')
                return;
            if (tn.Data == data)
            {
                findString = result;
                return;
            }
            else
            {
                string re1 = result + '-';
                string re2 = result + '.';
                if (tn.LChild != null)
                    FindData(tn.LChild, data, re1);
                if (tn.RChild != null)
                    FindData(tn.RChild, data, re2);
            }
        }
    }
}
