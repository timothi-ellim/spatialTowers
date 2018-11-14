// ===========
// DO NOT EDIT - this file is automatically regenerated.
// ===========

using System.Linq;
using Improbable.Gdk.Core;

namespace Improbable.Gdk.Tests.BlittableTypes
{ 
    
    public struct FirstCommandRequest
    {
        public int Field;
    
        public FirstCommandRequest(int field)
        {
            Field = field;
        }
    
        public static class Serialization
        {
            public static void Serialize(FirstCommandRequest instance, global::Improbable.Worker.Core.SchemaObject obj)
            {
                {
                    obj.AddInt32(1, instance.Field);
                }
            }
    
            public static FirstCommandRequest Deserialize(global::Improbable.Worker.Core.SchemaObject obj)
            {
                var instance = new FirstCommandRequest();
                {
                    instance.Field = obj.GetInt32(1);
                }
                return instance;
            }
        }
    }
    
}
