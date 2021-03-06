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
    
    
    public partial class UnityCommandPayloadGenerator : UnityCommandPayloadGeneratorBase {
        
        public virtual string TransformText() {
            this.GenerationEnvironment = null;
            
            #line 3 "Templates\UnityCommandPayloadGenerator.tt"

    var generatedHeader = CommonGeneratorUtils.GetGeneratedHeader();
    var componentDetails = GetComponentDetails();
    var commandDetailsList = GetCommandDetailsList();

            
            #line default
            #line hidden
            
            #line 8 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( generatedHeader ));
            
            #line default
            #line hidden
            
            #line 8 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("\r\n\r\nusing System.Collections.Generic;\r\nusing Improbable.Worker;\r\nusing Improbable" +
                    ".Worker.Core;\r\n\r\nnamespace ");
            
            #line default
            #line hidden
            
            #line 14 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( qualifiedNamespace ));
            
            #line default
            #line hidden
            
            #line 14 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("\r\n{\r\n    public partial class ");
            
            #line default
            #line hidden
            
            #line 16 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( componentDetails.ComponentName ));
            
            #line default
            #line hidden
            
            #line 16 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("\r\n    {\r\n");
            
            #line default
            #line hidden
            
            #line 18 "Templates\UnityCommandPayloadGenerator.tt"
 foreach (var commandDetails in commandDetailsList) {
            
            #line default
            #line hidden
            
            #line 19 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("        public partial class ");
            
            #line default
            #line hidden
            
            #line 19 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.CommandName ));
            
            #line default
            #line hidden
            
            #line 19 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@"
        {
            /// <summary>
            ///     Please do not use the default constructor. Use CreateRequest instead.
            ///     Using CreateRequest will ensure a correctly formed structure.
            /// </summary>
            public struct Request
            {
                public EntityId TargetEntityId { get; internal set; }
                public ");
            
            #line default
            #line hidden
            
            #line 28 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 28 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" Payload { get; internal set; }
                public uint? TimeoutMillis { get; internal set; }
                public bool AllowShortCircuiting { get; internal set; }
                public System.Object Context { get; internal set; }
                public long RequestId { get; internal set; }
            }

            public static Request CreateRequest(EntityId targetEntityId,
                ");
            
            #line default
            #line hidden
            
            #line 36 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 36 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" request,
                uint? timeoutMillis = null,
                bool allowShortCircuiting = false,
                System.Object context = null)
            {
                return new Request
                {
                    TargetEntityId = targetEntityId,
                    Payload = request,
                    TimeoutMillis = timeoutMillis,
                    AllowShortCircuiting = allowShortCircuiting,
                    Context = context,
                    RequestId = global::Improbable.Gdk.Core.CommandRequestIdGenerator.GetNext(),
                };
            }

            public struct ReceivedRequest
            {
                public long RequestId { get; }
                public string CallerWorkerId { get; }
                public List<string> CallerAttributeSet { get; }
                public ");
            
            #line default
            #line hidden
            
            #line 57 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 57 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(" Payload { get; }\r\n\r\n                public ReceivedRequest(long requestId,\r\n    " +
                    "                string callerWorkerId,\r\n                    List<string> callerA" +
                    "ttributeSet,\r\n                    ");
            
            #line default
            #line hidden
            
            #line 62 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 62 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" request)
                {
                    RequestId = requestId;
                    CallerWorkerId = callerWorkerId;
                    CallerAttributeSet = callerAttributeSet;
                    Payload = request;
                }
            }

            /// <summary>
            ///     Please do not use the default constructor. Use CreateResponse or CreateFailure instead.
            ///     Using CreateResponse or CreateFailure will ensure a correctly formed structure.
            /// </summary>
            public struct Response
            {
                public long RequestId { get; internal set; }
                public ");
            
            #line default
            #line hidden
            
            #line 78 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnResponseType ));
            
            #line default
            #line hidden
            
            #line 78 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("? Payload { get; internal set; }\r\n                public string FailureMessage { " +
                    "get; internal set; }\r\n            }\r\n\r\n            public static Response Create" +
                    "Response(ReceivedRequest req, ");
            
            #line default
            #line hidden
            
            #line 82 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnResponseType ));
            
            #line default
            #line hidden
            
            #line 82 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" payload)
            {
                return new Response
                {
                    RequestId = req.RequestId,
                    Payload = payload,
                    FailureMessage = null,
                };
            }

            public static Response CreateResponseFailure(ReceivedRequest req, string failureMessage)
            {
                return new Response
                {
                    RequestId = req.RequestId,
                    Payload = null,
                    FailureMessage = failureMessage,
                };
            }

            public struct ReceivedResponse
            {
                public EntityId EntityId { get; }
                public string Message { get; }
                public StatusCode StatusCode { get; }
                public ");
            
            #line default
            #line hidden
            
            #line 107 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnResponseType ));
            
            #line default
            #line hidden
            
            #line 107 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("? ResponsePayload { get; }\r\n                public ");
            
            #line default
            #line hidden
            
            #line 108 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 108 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" RequestPayload { get; }
                public System.Object Context { get; }
                public long RequestId { get; }

                public ReceivedResponse(EntityId entityId,
                    string message,
                    StatusCode statusCode,
                    ");
            
            #line default
            #line hidden
            
            #line 115 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnResponseType ));
            
            #line default
            #line hidden
            
            #line 115 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("? response,\r\n                    ");
            
            #line default
            #line hidden
            
            #line 116 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture( commandDetails.FqnRequestType ));
            
            #line default
            #line hidden
            
            #line 116 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write(@" request,
                    System.Object context,
                    long requestId)
                {
                    EntityId = entityId;
                    Message = message;
                    StatusCode = statusCode;
                    ResponsePayload = response;
                    RequestPayload = request;
                    Context = context;
                    RequestId = requestId;
                }
            }
        }
");
            
            #line default
            #line hidden
            
            #line 130 "Templates\UnityCommandPayloadGenerator.tt"
 } 
            
            #line default
            #line hidden
            
            #line 131 "Templates\UnityCommandPayloadGenerator.tt"
            this.Write("    }\r\n}\r\n");
            
            #line default
            #line hidden
            return this.GenerationEnvironment.ToString();
        }
        
        public virtual void Initialize() {
        }
    }
    
    public class UnityCommandPayloadGeneratorBase {
        
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
