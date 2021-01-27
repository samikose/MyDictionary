using System;
using System.Collections.Generic;


namespace DictionaryPratik
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> AdYas = new Dictionary<string, int>();
            //AdYas.Add("Sami", 18);
            //AdYas.Add("Selinay", 19);
            //AdYas.Add("Ömer", 18);

            //foreach (var degerOku in AdYas)
            //{
            //    Console.WriteLine(degerOku);
            //}
            //var eleman = AdYas.Count();
            //Console.WriteLine();
            //Console.WriteLine("Eleman sayisi" + eleman );
            //Console.WriteLine();

            //AdYas.Remove("Selinay");
            //Console.WriteLine();
            //foreach (var degeroku in AdYas)
            //{
            //    Console.WriteLine(degeroku);
            //}

            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();
            AdYas.Add("Sami", 18);
            AdYas.Add("Selinay", 19);
            AdYas.Add("Ömer", 18);

            Console.WriteLine(AdYas.Count());
        }
    }
    class MyDictionary<K, V>
    {
        K[] key;
        K[] _tempKey;
        V[] value;
        V[] _tempValue;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }
        public void Add(K _key, V _value)
        {
            _tempKey = key;
            key = new K[key.Length + 1];
            _tempValue = value;
            value = new V[value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                _tempKey[i] = key[i];
                _tempValue[i] = value[i];
            }
            key[key.Length - 1] = _key;
            value[value.Length - 1] = _value;
        }
        public int Count()
        {
            return key.Length;
        }
    }



}