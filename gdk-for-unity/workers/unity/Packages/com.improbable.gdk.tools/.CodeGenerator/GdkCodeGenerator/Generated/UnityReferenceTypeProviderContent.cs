﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Improbable.Gdk.CodeGenerator {
    using System;
    using Improbable.CodeGeneration.Jobs;
    
    
    public partial class UnityReferenceTypeProviderContent : UnityReferenceTypeProviderContentBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write("public static class ");
            
            #line default
            #line hidden
            
            #line 3 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Name ));
            
            #line default
            #line hidden
            
            #line 3 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write("Provider \r\n{\r\n    private static readonly Dictionary<uint, ");
            
            #line default
            #line hidden
            
            #line 5 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeName ));
            
            #line default
            #line hidden
            
            #line 5 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write("> Storage = new Dictionary<uint, ");
            
            #line default
            #line hidden
            
            #line 5 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeName ));
            
            #line default
            #line hidden
            
            #line 5 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(@">();
    private static readonly Dictionary<uint, global::Unity.Entities.World> WorldMapping = new Dictionary<uint, Unity.Entities.World>();

    private static uint nextHandle = 0;

    public static uint Allocate(global::Unity.Entities.World world)
    {
        var handle = GetNextHandle();

        Storage.Add(handle, default(");
            
            #line default
            #line hidden
            
            #line 14 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeName ));
            
            #line default
            #line hidden
            
            #line 14 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write("));\r\n        WorldMapping.Add(handle, world);\r\n\r\n        return handle;\r\n    }\r\n\r" +
                    "\n    public static ");
            
            #line default
            #line hidden
            
            #line 20 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeName ));
            
            #line default
            #line hidden
            
            #line 20 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(" Get(uint handle)\r\n    {\r\n        if (!Storage.TryGetValue(handle, out var value)" +
                    ")\r\n        {\r\n            throw new ArgumentException($\"");
            
            #line default
            #line hidden
            
            #line 24 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Name ));
            
            #line default
            #line hidden
            
            #line 24 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write("Provider does not contain handle {handle}\");\r\n        }\r\n\r\n        return value;\r" +
                    "\n    }\r\n\r\n    public static void Set(uint handle, ");
            
            #line default
            #line hidden
            
            #line 30 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( TypeName ));
            
            #line default
            #line hidden
            
            #line 30 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(" value)\r\n    {\r\n        if (!Storage.ContainsKey(handle))\r\n        {\r\n           " +
                    " throw new ArgumentException($\"");
            
            #line default
            #line hidden
            
            #line 34 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( Name ));
            
            #line default
            #line hidden
            
            #line 34 "Templates\UnityReferenceTypeProviderContent.tt"
            this.Write(@"Provider does not contain handle {handle}"");
        }

        Storage[handle] = value;
    }

    public static void Free(uint handle)
    {
        Storage.Remove(handle);
        WorldMapping.Remove(handle);
    }

    public static void CleanDataInWorld(global::Unity.Entities.World world)
    {
        var handles = WorldMapping.Where(pair => pair.Value == world).Select(pair => pair.Key).ToList();

        foreach (var handle in handles)
        {
            Free(handle);
        }
    }

    private static uint GetNextHandle() 
    {
        nextHandle++;
        
        while (Storage.ContainsKey(nextHandle))
        {
            nextHandle++;
        }

        return nextHandle;
    }
}
");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class UnityReferenceTypeProviderContentBase {
        
        private global::System.Text.StringBuilder builder;
        
        private global::System.Collections.Generic.IDictionary<string, object> session;
        
        private global::System.CodeDom.Compiler.CompilerErrorCollection errors;
        
        private string currentIndent = string.Empty;
        
        private global::System.Collections.Generic.Stack<int> indents;
        
        private ToStringInstanceHelper _toStringHelper = new ToStringInstanceHelper();
        
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session {
            get {
                return this.session;
            }
            set {
                this.session = value;
            }
        }
        
        public global::System.Text.StringBuilder GenerationEnvironment {
            get {
                if ((this.builder == null)) {
                    this.builder = new global::System.Text.StringBuilder();
                }
                return this.builder;
            }
            set {
                this.builder = value;
            }
        }
        
        protected global::System.CodeDom.Compiler.CompilerErrorCollection Errors {
            get {
                if ((this.errors == null)) {
                    this.errors = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errors;
            }
        }
        
        public string CurrentIndent {
            get {
                return this.currentIndent;
            }
        }
        
        private global::System.Collections.Generic.Stack<int> Indents {
            get {
                if ((this.indents == null)) {
                    this.indents = new global::System.Collections.Generic.Stack<int>();
                }
                return this.indents;
            }
        }
        
        public ToStringInstanceHelper ToStringHelper {
            get {
                return this._toStringHelper;
            }
        }
        
        public void Error(string message) {
            this.Errors.Add(new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message));
        }
        
        public void Warning(string message) {
            global::System.CodeDom.Compiler.CompilerError val = new global::System.CodeDom.Compiler.CompilerError(null, -1, -1, null, message);
            val.IsWarning = true;
            this.Errors.Add(val);
        }
        
        public string PopIndent() {
            if ((this.Indents.Count == 0)) {
                return string.Empty;
            }
            int lastPos = (this.currentIndent.Length - this.Indents.Pop());
            string last = this.currentIndent.Substring(lastPos);
            this.currentIndent = this.currentIndent.Substring(0, lastPos);
            return last;
        }
        
        public void PushIndent(string indent) {
            this.Indents.Push(indent.Length);
            this.currentIndent = (this.currentIndent + indent);
        }
        
        public void ClearIndent() {
            this.currentIndent = string.Empty;
            this.Indents.Clear();
        }
        
        public void Write(string textToAppend) {
            this.GenerationEnvironment.Append(textToAppend);
        }
        
        public void Write(string format, params object[] args) {
            this.GenerationEnvironment.AppendFormat(format, args);
        }
        
        public void WriteLine(string textToAppend) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendLine(textToAppend);
        }
        
        public void WriteLine(string format, params object[] args) {
            this.GenerationEnvironment.Append(this.currentIndent);
            this.GenerationEnvironment.AppendFormat(format, args);
            this.GenerationEnvironment.AppendLine();
        }
        
        public class ToStringInstanceHelper {
            
            private global::System.IFormatProvider formatProvider = global::System.Globalization.CultureInfo.InvariantCulture;
            
            public global::System.IFormatProvider FormatProvider {
                get {
                    return this.formatProvider;
                }
                set {
                    if ((value != null)) {
                        this.formatProvider = value;
                    }
                }
            }
            
            public string ToStringWithCulture(object objectToConvert) {
                if ((objectToConvert == null)) {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                global::System.Type type = objectToConvert.GetType();
                global::System.Type iConvertibleType = typeof(global::System.IConvertible);
                if (iConvertibleType.IsAssignableFrom(type)) {
                    return ((global::System.IConvertible)(objectToConvert)).ToString(this.formatProvider);
                }
                global::System.Reflection.MethodInfo methInfo = type.GetMethod("ToString", new global::System.Type[] {
                            iConvertibleType});
                if ((methInfo != null)) {
                    return ((string)(methInfo.Invoke(objectToConvert, new object[] {
                                this.formatProvider})));
                }
                return objectToConvert.ToString();
            }
        }
    }
}
