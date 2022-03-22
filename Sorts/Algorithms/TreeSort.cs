using System;
using System.Collections.Generic;

using DataStructures;

namespace Sorts.Algorithms
{
    public class TreeSort<T> : SortBase<T>
        where T : IComparable<T>
    {
        public override void Sort(List<T> collection)
        {
            Collection = new BinarySearchTree<T>(collection).Inorder();
        }
    }
}
