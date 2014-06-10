using System.Collections;
using System.Collections.Generic;

namespace TradeGeckoApi.Model
{
    public class PaginationList<T> : IPaginationList<T>
    {
        private readonly IList<T> _source;
        private readonly PaginationModel _pagination;

        public PaginationList(IList<T> source, PaginationModel pagination)
        {
            _source = source;
            _pagination = pagination;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return _source.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T item)
        {
            _source.Add(item);
        }

        public void Clear()
        {
            _source.Clear();
        }

        public bool Contains(T item)
        {
            return _source.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _source.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _source.Remove(item);
        }

        public int Count
        {
            get { return _source.Count; }
        }

        public bool IsReadOnly
        {
            get { return _source.IsReadOnly; }
        }

        public int IndexOf(T item)
        {
            return _source.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            _source.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            _source.RemoveAt(index);
        }

        public T this[int index]
        {
            get { return _source[index]; }
            set { _source[index] = value; }
        }

        public int TotalRecords
        {
            get { return _pagination.TotalRecords; }
        }

        public int TotalPages
        {
            get { return _pagination.TotalPages; }
        }

        public bool FirstPage
        {
            get { return _pagination.FirstPage; }
        }

        public bool LastPage
        {
            get { return _pagination.LastPage; }
        }

        public bool OutOfBounds
        {
            get { return _pagination.OutOfBounds; }
        }

        public int Offset
        {
            get { return _pagination.Offset; }
        }
    }
}
