using System;

namespace Key_Value_Store
{
    class MyLinkedList<T>
    {
        //Housekeeping
        private bool hasValue = false;

        //Linked list-required
        private T value = default;
        private MyLinkedList<T> rest = null;

        private bool IsEndOfList => rest == null;

        public MyLinkedList(T value, MyLinkedList<T> rest)
        {
            this.value = value;
            this.rest = rest;

        }

        public T this [int index]

        {
            get
            {
                if (index == 0) return value;
                if (rest == null) throw new IndexOutOfRangeException();

                return rest[index - 1];
            }
        }

        static MyLinkedList<T> Singleton(T value) => new MyLinkedList<T>(value, null);
        static MyLinkedList<T> Concatenate(MyLinkedList<T> list1, MyLinkedList<T> list2)
        {
            if (list1.IsEndOfList) return new MyLinkedList<T>(list1.value, null);

            return new MyLinkedList<T>(list1.value, Concatenate(list1.rest, list2));
        }

        static void TestMyLinkedList()
        {

        }
    }
}