namespace Key_Value_Store
{
    //passing it as an object
    public struct KeyValue<T>
    {
        public readonly string Key;
        public readonly T Value;
        public KeyValue(string setKey, T setValue)
        {
            Key = setKey;
            Value = setValue;
        }
        
    }
}