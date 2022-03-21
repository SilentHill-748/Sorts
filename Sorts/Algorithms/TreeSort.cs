using System;
using System.Collections.Generic;

using DataStructures;

namespace Sorts.Algorithms
{
    public class TreeSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public TreeSort(List<T> list) : base(list) { }


        public override void Sort()
        {
            // BinaryTreeSearch is my version of popular data structer.
            SortedCollection = new BinarySearchTree<T>(_list).Inorder();
        }
    }
}
