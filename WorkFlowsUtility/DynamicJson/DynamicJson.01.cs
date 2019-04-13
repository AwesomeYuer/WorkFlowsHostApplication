/*--------------------------------------------------------------------------
* DynamicJson
* add Indexer[Key/Index]
*--------------------------------------------------------------------------*/
namespace Microshaoft
{
    using System;
    using System.Dynamic;
    using System.Linq;
    using System.Xml.Linq;
    public partial class DynamicJson : DynamicObject
    {
        public object _value = null;
        public object Value
        {
            get
            {
                if (_isValue)
                {
                    return _value;
                }
                else
                {
                    throw new Exception("It is not a Value!");
                }
            }
        }
        private bool _isValue = false;
        public bool IsValue
        {
            get
            {
                return _isValue;
            }

        }

        public T GetValue<T>()
        {
            return (T)Value;
        }

        public DynamicJson this[string key]
        {
            get
            {
                var x = xml.Element(key);
                var value = default(dynamic);
                var r = XElementToDynamicJson(x, out value);
                if (r == null)
                {
                    _value = value;
                    r = this;
                    _isValue = true;
                }
                return r;
            }
        }
        public DynamicJson this[int index]
        {
            get
            {
                var x = xml
                            .Elements()
                            .ElementAt(index);
                var value = default(dynamic);
                var r = XElementToDynamicJson(x, out value);
                if (r == null)
                {
                    _value = value;
                    r = this;
                    _isValue = true;
                }
                return r;
            }
        }
        private DynamicJson XElementToDynamicJson
                                (
                                    XElement x
                                    , out dynamic value
                                )
        {
            DynamicJson r = null;
            if (TryGet(x, out value))
            {
                r = value as DynamicJson;
            }
            else
            {
                throw new Exception("no member");
            }
            return r;
        }

        //public DynamicJson ParseAsDynamicJson(string json)
        //{
        //    var j = Parse(json);
        //    var r = (DynamicJson)j;
        //    return r;


        //}
    }
}

