﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name nuevaNotacion from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CambiarNotacion", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse CambiarNotacion(WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CambiarNotacion", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse> CambiarNotacionAsync(WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest request);
        
        // CODEGEN: Generating message contract since element name operation from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EvaluarOpeInfija", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse EvaluarOpeInfija(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EvaluarOpeInfija", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse> EvaluarOpeInfijaAsync(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest request);
        
        // CODEGEN: Generating message contract since element name expression from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EvaluarOpePrefija", ReplyAction="*")]
        WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse EvaluarOpePrefija(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/EvaluarOpePrefija", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse> EvaluarOpePrefijaAsync(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WindowsFormsApplication1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CambiarNotacionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CambiarNotacion", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequestBody Body;
        
        public CambiarNotacionRequest() {
        }
        
        public CambiarNotacionRequest(WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CambiarNotacionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string nuevaNotacion;
        
        public CambiarNotacionRequestBody() {
        }
        
        public CambiarNotacionRequestBody(string nuevaNotacion) {
            this.nuevaNotacion = nuevaNotacion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CambiarNotacionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CambiarNotacionResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponseBody Body;
        
        public CambiarNotacionResponse() {
        }
        
        public CambiarNotacionResponse(WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class CambiarNotacionResponseBody {
        
        public CambiarNotacionResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EvaluarOpeInfijaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EvaluarOpeInfija", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequestBody Body;
        
        public EvaluarOpeInfijaRequest() {
        }
        
        public EvaluarOpeInfijaRequest(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EvaluarOpeInfijaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string operation;
        
        public EvaluarOpeInfijaRequestBody() {
        }
        
        public EvaluarOpeInfijaRequestBody(string operation) {
            this.operation = operation;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EvaluarOpeInfijaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EvaluarOpeInfijaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponseBody Body;
        
        public EvaluarOpeInfijaResponse() {
        }
        
        public EvaluarOpeInfijaResponse(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EvaluarOpeInfijaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double EvaluarOpeInfijaResult;
        
        public EvaluarOpeInfijaResponseBody() {
        }
        
        public EvaluarOpeInfijaResponseBody(double EvaluarOpeInfijaResult) {
            this.EvaluarOpeInfijaResult = EvaluarOpeInfijaResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EvaluarOpePrefijaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EvaluarOpePrefija", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequestBody Body;
        
        public EvaluarOpePrefijaRequest() {
        }
        
        public EvaluarOpePrefijaRequest(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EvaluarOpePrefijaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string expression;
        
        public EvaluarOpePrefijaRequestBody() {
        }
        
        public EvaluarOpePrefijaRequestBody(string expression) {
            this.expression = expression;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class EvaluarOpePrefijaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="EvaluarOpePrefijaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponseBody Body;
        
        public EvaluarOpePrefijaResponse() {
        }
        
        public EvaluarOpePrefijaResponse(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class EvaluarOpePrefijaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double EvaluarOpePrefijaResult;
        
        public EvaluarOpePrefijaResponseBody() {
        }
        
        public EvaluarOpePrefijaResponseBody(double EvaluarOpePrefijaResult) {
            this.EvaluarOpePrefijaResult = EvaluarOpePrefijaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : WindowsFormsApplication1.ServiceReference1.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.WebServiceSoap>, WindowsFormsApplication1.ServiceReference1.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.HelloWorldResponse WindowsFormsApplication1.ServiceReference1.WebServiceSoap.HelloWorld(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WindowsFormsApplication1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody();
            WindowsFormsApplication1.ServiceReference1.HelloWorldResponse retVal = ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> WindowsFormsApplication1.ServiceReference1.WebServiceSoap.HelloWorldAsync(WindowsFormsApplication1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            WindowsFormsApplication1.ServiceReference1.HelloWorldRequest inValue = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.HelloWorldRequestBody();
            return ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse WindowsFormsApplication1.ServiceReference1.WebServiceSoap.CambiarNotacion(WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest request) {
            return base.Channel.CambiarNotacion(request);
        }
        
        public void CambiarNotacion(string nuevaNotacion) {
            WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest inValue = new WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequestBody();
            inValue.Body.nuevaNotacion = nuevaNotacion;
            WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse retVal = ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).CambiarNotacion(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse> WindowsFormsApplication1.ServiceReference1.WebServiceSoap.CambiarNotacionAsync(WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest request) {
            return base.Channel.CambiarNotacionAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.CambiarNotacionResponse> CambiarNotacionAsync(string nuevaNotacion) {
            WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest inValue = new WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.CambiarNotacionRequestBody();
            inValue.Body.nuevaNotacion = nuevaNotacion;
            return ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).CambiarNotacionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse WindowsFormsApplication1.ServiceReference1.WebServiceSoap.EvaluarOpeInfija(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest request) {
            return base.Channel.EvaluarOpeInfija(request);
        }
        
        public double EvaluarOpeInfija(string operation) {
            WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest inValue = new WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequestBody();
            inValue.Body.operation = operation;
            WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse retVal = ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).EvaluarOpeInfija(inValue);
            return retVal.Body.EvaluarOpeInfijaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse> WindowsFormsApplication1.ServiceReference1.WebServiceSoap.EvaluarOpeInfijaAsync(WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest request) {
            return base.Channel.EvaluarOpeInfijaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaResponse> EvaluarOpeInfijaAsync(string operation) {
            WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest inValue = new WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.EvaluarOpeInfijaRequestBody();
            inValue.Body.operation = operation;
            return ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).EvaluarOpeInfijaAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse WindowsFormsApplication1.ServiceReference1.WebServiceSoap.EvaluarOpePrefija(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest request) {
            return base.Channel.EvaluarOpePrefija(request);
        }
        
        public double EvaluarOpePrefija(string expression) {
            WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest inValue = new WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequestBody();
            inValue.Body.expression = expression;
            WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse retVal = ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).EvaluarOpePrefija(inValue);
            return retVal.Body.EvaluarOpePrefijaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse> WindowsFormsApplication1.ServiceReference1.WebServiceSoap.EvaluarOpePrefijaAsync(WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest request) {
            return base.Channel.EvaluarOpePrefijaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaResponse> EvaluarOpePrefijaAsync(string expression) {
            WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest inValue = new WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequest();
            inValue.Body = new WindowsFormsApplication1.ServiceReference1.EvaluarOpePrefijaRequestBody();
            inValue.Body.expression = expression;
            return ((WindowsFormsApplication1.ServiceReference1.WebServiceSoap)(this)).EvaluarOpePrefijaAsync(inValue);
        }
    }
}
