using System;

namespace Key_Value_Store
{
    //passing it as an object
    public struct KeyValue<KeyType, ValueType>
    {
        public readonly KeyType Key;
        public readonly ValueType Value;
        public KeyValue(KeyType key, ValueType value)
        {
            Key = key;
            Value = value;
        }
        
    }
}