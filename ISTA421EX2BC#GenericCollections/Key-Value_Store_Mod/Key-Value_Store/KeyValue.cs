﻿namespace Key_Value_Store
{
    public struct KeyValue
    {
        public readonly string key; 
        public readonly object value;
        
        public KeyValue(string key, object value)
        {
            this.key = key;
            this.value = value;
        }
        
    }
}