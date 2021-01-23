using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryOdev
{
    class MyDictionary<K,V>
    {
        K[] key;
        K[] tempkey;
        V[] value;
        V[] tempvalue;

        public MyDictionary()
        {
            key = new K[0];
            value = new V[0];
        }

        public void Add(K _key, V _value)
        {
            tempkey = key;
            tempvalue = value;

            key = new K[key.Length + 1];
            value = new V[value.Length + 1];
            for (int i = 0; i < tempkey.Length; i++)
            {
                key[i] = tempkey[i];
            }
            key[key.Length - 1] = _key;

            for (int i = 0; i < tempvalue.Length; i++)
            {
                value[i] = tempvalue[i];
            }
            value[value.Length - 1] = _value;
        }

        public void Yazdir()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine("Key: " + key[i] + " Value: " + value[i]);
            }
        }
    }
}
