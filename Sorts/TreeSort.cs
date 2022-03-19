using System;

using DataStructures;

namespace Sorts
{
    public class TreeSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public TreeSort(T[] array) : base(array) { }


        public override void Sort()
        {
            // BinaryTreeSearch is my version of popular data structer.
            BinarySearchTree<T> binarySearchTree = new(_array);
            _array = binarySearchTree.Inorder().ToArray();
        }
    }
}
