using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Key_Value_Store
{
    public class MyDictionary<KeyType, ValueType> 
        : IEnumerable<KeyValue<KeyType, ValueType>> where KeyType 
        : IComparable<KeyType>
    {
        private KeyValue<KeyType, ValueType>[] _keyValues = new KeyValue<KeyType, ValueType>[64];
        private int intTrack = 0; 

        public ValueType this[KeyType keytype] 
        { 
            set 
            { 
                bool hasFound = false; 
                for (int i = 0; i < intTrack && !hasFound; ++i) 
                {
                    if (_keyValues[i].Key.Equals(keytype))
                    {
                        hasFound = true;
                        _keyValues[i] = new KeyValue<KeyType, ValueType>(keytype, value);
                    }
                }

                if (!hasFound)
                {
                    _keyValues[intTrack++] = new KeyValue<KeyType, ValueType>(keytype, value);
                }

            }
            get
            {
                for (int i = 0; i < intTrack; ++i)
                {
                    if (_keyValues[i].Key.Equals(keytype))
                        return _keyValues[i].Value;
                }

                throw new KeyNotFoundException($"Didn't find \"{keytype}\" in MyDictionary");
            }
        }

        public IEnumerator<KeyValue<KeyType, ValueType>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
    
