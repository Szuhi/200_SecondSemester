using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinSearchTree
{
    class BinSearch<K, T> : IEnumerable<T> where K : IComparable
    {
        TreeItem<K, T> root;

        private void _Add(ref TreeItem<K, T> e, K key, T content)
        {
            if (e == null)
                e = new TreeItem<K, T>(key, content);
            else
            {
                if (e.key.CompareTo(key) > 0)
                    _Add(ref e.left, key, content);
                else
                    _Add(ref e.right, key, content);
            }
        }

        public void Add(K key, T content)
        {
            _Add(ref root, key, content);
        }

        private void _InOrder(List<T> l, TreeItem<K, T> e)
        {
            if(e != null)
            {
                _InOrder(l, e.left);
                l.Add(e.content);
                _InOrder(l, e.right);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> list = new List<T>();
            _InOrder(list, root);
            return list.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class TreeItem<K,T>
    {
        public K key;
        public T content;
        public TreeItem<K, T> left, right;

        public TreeItem(K key, T content)
        {
            this.key = key;
            this.content = content;
            left = null; right = null;
        }
    }
}
