﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ProjectWebServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProjectWebServices.BilionBankWebServiceSoap")]
    public interface BilionBankWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ProjectMVC.ProjectWebServices.HelloWorldResponse HelloWorld(ProjectMVC.ProjectWebServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.HelloWorldResponse> HelloWorldAsync(ProjectMVC.ProjectWebServices.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        ProjectMVC.ProjectWebServices.ClientResponse Client(ProjectMVC.ProjectWebServices.ClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.ClientResponse> ClientAsync(ProjectMVC.ProjectWebServices.ClientRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ProjectWebServices.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ProjectMVC.ProjectWebServices.HelloWorldRequestBody Body) {
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
        public ProjectMVC.ProjectWebServices.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ProjectMVC.ProjectWebServices.HelloWorldResponseBody Body) {
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
    public partial class ClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Client", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ProjectWebServices.ClientRequestBody Body;
        
        public ClientRequest() {
        }
        
        public ClientRequest(ProjectMVC.ProjectWebServices.ClientRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ClientRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int accountNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string date;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int balance;
        
        public ClientRequestBody() {
        }
        
        public ClientRequestBody(int accountNumber, string name, string date, int balance) {
            this.accountNumber = accountNumber;
            this.name = name;
            this.date = date;
            this.balance = balance;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ClientResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ProjectWebServices.ClientResponseBody Body;
        
        public ClientResponse() {
        }
        
        public ClientResponse(ProjectMVC.ProjectWebServices.ClientResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ClientResponseBody {
        
        public ClientResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BilionBankWebServiceSoapChannel : ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BilionBankWebServiceSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap>, ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap {
        
        public BilionBankWebServiceSoapClient() {
        }
        
        public BilionBankWebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BilionBankWebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BilionBankWebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BilionBankWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ProjectWebServices.HelloWorldResponse ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap.HelloWorld(ProjectMVC.ProjectWebServices.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ProjectMVC.ProjectWebServices.HelloWorldRequest inValue = new ProjectMVC.ProjectWebServices.HelloWorldRequest();
            inValue.Body = new ProjectMVC.ProjectWebServices.HelloWorldRequestBody();
            ProjectMVC.ProjectWebServices.HelloWorldResponse retVal = ((ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.HelloWorldResponse> ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap.HelloWorldAsync(ProjectMVC.ProjectWebServices.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.HelloWorldResponse> HelloWorldAsync() {
            ProjectMVC.ProjectWebServices.HelloWorldRequest inValue = new ProjectMVC.ProjectWebServices.HelloWorldRequest();
            inValue.Body = new ProjectMVC.ProjectWebServices.HelloWorldRequestBody();
            return ((ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ProjectWebServices.ClientResponse ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap.Client(ProjectMVC.ProjectWebServices.ClientRequest request) {
            return base.Channel.Client(request);
        }
        
        public void Client(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ProjectWebServices.ClientRequest inValue = new ProjectMVC.ProjectWebServices.ClientRequest();
            inValue.Body = new ProjectMVC.ProjectWebServices.ClientRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            ProjectMVC.ProjectWebServices.ClientResponse retVal = ((ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap)(this)).Client(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.ClientResponse> ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap.ClientAsync(ProjectMVC.ProjectWebServices.ClientRequest request) {
            return base.Channel.ClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ProjectWebServices.ClientResponse> ClientAsync(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ProjectWebServices.ClientRequest inValue = new ProjectMVC.ProjectWebServices.ClientRequest();
            inValue.Body = new ProjectMVC.ProjectWebServices.ClientRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            return ((ProjectMVC.ProjectWebServices.BilionBankWebServiceSoap)(this)).ClientAsync(inValue);
        }
    }
}
