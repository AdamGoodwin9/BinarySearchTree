namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private TreeNode head;

        public int Size { get; private set; }

        public BinarySearchTree()
        {
            head = null;
            Size = 0;
        }

        public TreeNode Search(int key)
        {
            TreeNode temp = head;
            while (temp != null && temp.Key != key)
            {
                if (key < temp.Key)
                {
                    temp = temp.Left;
                }
                else
                {
                    temp = temp.Right;
                }
            }
            return temp;
        }

        public void Insert(int key)
        {
            if (IsEmpty())
            {
                head = new TreeNode(key);
                Size++;
                return;
            }

            TreeNode temp = head;
            while (temp != null)
            {
                if (key < temp.Key)
                {
                    if (temp.Left == null)
                    {
                        temp.Left = new TreeNode(key, temp);
                        Size++;
                        return;
                    }
                    temp = temp.Left;
                }
                else
                {
                    if (temp.Right == null)
                    {
                        temp.Right = new TreeNode(key, temp);
                        Size++;
                        return;
                    }
                    temp = temp.Right;
                }
            }
        }

        public bool Delete(int key)
        {
            return Delete(Search(key));
        }

        public bool Delete(TreeNode nodeD)
        {
            if (IsEmpty() || nodeD == null)
            {
                return false;
            }

            int nodeDChildCount = nodeD.ChildCount();

            if (nodeDChildCount == 2)
            {
                TreeNode temp = nodeD.Left;
                while (temp.Right != null)
                {
                    temp = temp.Right;
                }
                nodeD.Key = temp.Key;
                Delete(temp);
            }
            else
            {
                bool nodeDIsHead = nodeD == head;
                if (nodeDChildCount == 1)
                {
                    if (nodeD.Left != null)
                    {
                        if (nodeDIsHead)
                        {
                            head = head.Left;
                            head.Parent = null;
                        }
                        else
                        {
                            nodeD.MakeLeft();
                        }
                    }
                    else
                    {
                        if (nodeDIsHead)
                        {
                            head = head.Right;
                            head.Parent = null;
                        }
                        else
                        {
                            nodeD.MakeRight();
                        }
                    }
                }
                else
                {
                    if (nodeDIsHead)
                    {
                        head = null;
                    }
                    else
                    {
                        nodeD.Nullify();
                    }
                }
                Size--;
            }
            return true;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public TreeNode Minimum()
        {
            TreeNode temp = head;
            while (temp != null)
            {
                temp = temp.Left;
            }
            return temp;
        }

        public TreeNode Maximum()
        {
            TreeNode temp = head;
            while (temp != null)
            {
                temp = temp.Right;
            }
            return temp;
        }

        public bool IsLeftChild(int key)
        {
            if (IsEmpty() || key == head.Key)
            {
                return false;
            }

            TreeNode temp = head;
            while (temp != null)
            {
                if (key < temp.Key)
                {
                    temp = temp.Left;
                    if (temp != null && temp.Key == key)
                    {
                        return true;
                    }
                }
                else
                {
                    temp = temp.Right;
                    if (temp != null && temp.Key == key)
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public bool IsRightChild(int key)
        {
            if (IsEmpty() || key == head.Key)
            {
                return false;
            }

            TreeNode temp = head;
            while (temp != null)
            {
                if (key < temp.Key)
                {
                    temp = temp.Left;
                    if (temp != null && temp.Key == key)
                    {
                        return false;
                    }
                }
                else
                {
                    temp = temp.Right;
                    if (temp != null && temp.Key == key)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override string ToString()
        {

            return base.ToString();
        }
    }
}