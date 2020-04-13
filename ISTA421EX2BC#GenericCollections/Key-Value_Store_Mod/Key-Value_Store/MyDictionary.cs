using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Key_Value_Store
{
    public class MyDictionary : IEnumerable<KeyValue<object>>
    {
        private KeyValue<object>[] keyValues = new KeyValue<Object>[64];
        private int intTrack = 0; 

        public Object this[string searchKey] 
        { 
            set 
            { 
                bool hasFound = false; 
                for (int i = 0; i < intTrack && !hasFound; ++i) 
                {
                    if (keyValues[i].Key == searchKey)
                    {
                        hasFound = true;
                        keyValues[i] = new KeyValue<Object>(searchKey, value);
                    }
                }

                if (!hasFound)
                {
                    keyValues[intTrack++] = new KeyValue<object>(searchKey, value);
                }

            }
            get
            {
                for (int i = 0; i < intTrack; ++i)
                {
                    if (keyValues[i].Key == searchKey)
                        return keyValues[i].Value;
                }

                throw new KeyNotFoundException($"Didn't find \"{searchKey}\" in MyDictionary");
            }
        }

        public IEnumerator<KeyValue<object>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
    
