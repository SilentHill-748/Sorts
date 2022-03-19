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
            
            // This code slower, but I'm test quality of completion.
            var result = binarySearchTree.Inorder().ToArray();

            for (int i = 0; i < result.Length; i++)
                _array[i] = result[i];
        }
    }
}
