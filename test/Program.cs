using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            SortHelper<int> sort = new SortHelper<int>( );
            int[] vs = new int[] { 3, 32, 4, 1, 56 };
            sort.BubbleSort(vs, false);
            //
            Book book1 = new Book(32, "ddd");
            Book book2 = new Book(16, "df");
            Book book3 = new Book(99, "kk");
            Book book4 = new Book(10, "nn");
            Book[] bookArray = new Book[] { book1, book2, book3, book4 };
            SortHelper<Book> sortBook = new SortHelper<Book>( );
            sortBook.BubbleSort(bookArray, false);
            foreach(Book item in bookArray)
            {
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Title);
            }
            SupperCaculator caculator = new SupperCaculator( );
            caculator.SpeedSort<Book>(bookArray, true);
            foreach(Book item in bookArray)
            {
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Title);
            }

        }
        public class SortHelper<T> where T : IComparable
        {
            public void BubbleSort(T[] array, bool a)
            {
                int length = array.Length;
                for(int i = 0; i < length - 1; i++)
                {
                    for(int j = length - 1; j >= 1; j--)
                    {
                        if(a)
                        {
                            if(array[j].CompareTo(array[j - 1]) < 0)
                            {
                                T temp = array[j];
                                array[j] = array[j - 1];
                                array[j - 1] = temp;
                            }
                        }
                        else
                        {
                            if(array[j].CompareTo(array[j - 1]) > 0)
                            {
                                T temp = array[j];
                                array[j] = array[j - 1];
                                array[j - 1] = temp;
                            }
                        }
                    }
                }
            }
        }
        public class Book : IComparable
        {
            public int Price { get; }
            public string Title { get; }
            public Book( )
            {
            }
            public Book(int price, string titel)
            {
                this.Price = price;
                this.Title = titel;
            }
            public int CompareTo(object obj)
            {
                Book book2 = (Book)obj;
                return this.Price.CompareTo(book2.Price);
            }
        }
        public class SupperCaculator
        {
            public void SpeedSort<T>(T[] array, bool a) where T : IComparable
            {
                int length = array.Length;
                for(int i = 0; i < length - 1; i++)
                {
                    for(int j = length - 1; j >= 1; j--)
                    {
                        if(a)
                        {
                            if(array[j].CompareTo(array[j - 1]) < 0)
                            {
                                T temp = array[j];
                                array[j] = array[j - 1];
                                array[j - 1] = temp;
                            }
                        }
                        else
                        {
                            if(array[j].CompareTo(array[j - 1]) > 0)
                            {
                                T temp = array[j];
                                array[j] = array[j - 1];
                                array[j - 1] = temp;
                            }
                        }
                    }
                }
            }
        }

    }



    //public interface IEnglish
    //{
    //    string Speak( );
    //}
    //public class Speaker : IEnglish
    //{
    //    string IEnglish.Speak( )
    //    {
    //        return "English";
    //    }
    //}
    //隐藏式实现例子
    public interface IChinese
    {
        string Speak( );
    }
    public class Speaker : IChinese
    {
        public string Speak( )
        {
            return "中文";
        }
    }
}
