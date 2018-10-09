namespace BinarySearchTree
{
    public class TreeNode
    {
        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }


        public TreeNode Parent { get; set; }
        
        public int Key { get; set; }

        public TreeNode(int key) : this(key, null) { }

        public TreeNode(int key, TreeNode parent)
        {
            Key = key;
            Left = null;
            Right = null;
            Parent = parent;
        }

        public bool IsRightChild()
        {
            return this == Parent?.Right;
        }

        public void Nullify()
        {
            if(Parent == null)
            {
                return;
            }

            if(IsRightChild())
            {
                Parent.Right = null;
            }
            else
            {
                Parent.Left = null;
            }
        }

        public void MakeLeft()
        {
            if(Parent == null)
            {
                return;
            }
            if (IsRightChild())
            {
                Parent.Right = Left;
            }
            else
            {
                Parent.Left = Left;
            }
        }

        public void MakeRight()
        {
            if(Parent == null)
            {
                return;
            }

            if (IsRightChild())
            {
                Parent.Right = Right;
            }
            else
            {
                Parent.Left = Right;
            }
        }

        public int ChildCount()
        {
            int num = 0;
            if (Left != null)
            {
                num += 1;
            }
            if(Right != null)
            {
                num += 1;
            }
            return num;
        }

        public override string ToString()
        {
            return $"TreeNode: Key: {Key} ChildCount: {ChildCount()}";
        }
    }
}
