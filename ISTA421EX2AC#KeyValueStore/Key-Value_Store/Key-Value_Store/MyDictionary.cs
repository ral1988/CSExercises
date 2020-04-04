using System;
using System.Collections.Generic;

namespace Key_Value_Store
{
    public class MyDictionary
    {
        KeyValue[] keyValues = new KeyValue[16];
        int intTrack = 0; 
        public Object this[string searchKey] 
        { 
            set 
            { 
                bool hasFound = false; 
                for (int i = 0; i < intTrack && hasFound!; ++i) 
                {
                    if (keyValues[i].key == searchKey)
                    {
                        hasFound = true;
                        keyValues[i] = new KeyValue(searchKey, value);
                    }
                }

                if (!hasFound)
                {
                    keyValues[intTrack++] = new KeyValue(searchKey, value);
                }

            }
            get
            {
                for (int i = 0; i < intTrack; ++i)
                {
                    if (keyValues[i].key == searchKey)
                        return keyValues[i].value;
                }

                throw new KeyNotFoundException($"Didn't find \"{searchKey}\" in MyDictionary");
            }
        }
    }
}
    
