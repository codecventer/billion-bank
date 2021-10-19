﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.WebServiceMain {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServiceMain.BilionBankWebServiceSoap")]
    public interface BilionBankWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        ProjectMVC.WebServiceMain.ClientResponse Client(ProjectMVC.WebServiceMain.ClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.WebServiceMain.ClientResponse> ClientAsync(ProjectMVC.WebServiceMain.ClientRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Client", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.WebServiceMain.ClientRequestBody Body;
        
        public ClientRequest() {
        }
        
        public ClientRequest(ProjectMVC.WebServiceMain.ClientRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ClientRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public long id;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string telephone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string address;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string question;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string answer;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=8)]
        public int numAccount;
        
        public ClientRequestBody() {
        }
        
        public ClientRequestBody(string name, long id, string email, string telephone, string address, string password, string question, string answer, int numAccount) {
            this.name = name;
            this.id = id;
            this.email = email;
            this.telephone = telephone;
            this.address = address;
            this.password = password;
            this.question = question;
            this.answer = answer;
            this.numAccount = numAccount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ClientResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.WebServiceMain.ClientResponseBody Body;
        
        public ClientResponse() {
        }
        
        public ClientResponse(ProjectMVC.WebServiceMain.ClientResponseBody Body) {
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
    public interface BilionBankWebServiceSoapChannel : ProjectMVC.WebServiceMain.BilionBankWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BilionBankWebServiceSoapClient : System.ServiceModel.ClientBase<ProjectMVC.WebServiceMain.BilionBankWebServiceSoap>, ProjectMVC.WebServiceMain.BilionBankWebServiceSoap {
        
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
        ProjectMVC.WebServiceMain.ClientResponse ProjectMVC.WebServiceMain.BilionBankWebServiceSoap.Client(ProjectMVC.WebServiceMain.ClientRequest request) {
            return base.Channel.Client(request);
        }
        
        public void Client(string name, long id, string email, string telephone, string address, string password, string question, string answer, int numAccount) {
            ProjectMVC.WebServiceMain.ClientRequest inValue = new ProjectMVC.WebServiceMain.ClientRequest();
            inValue.Body = new ProjectMVC.WebServiceMain.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            inValue.Body.numAccount = numAccount;
            ProjectMVC.WebServiceMain.ClientResponse retVal = ((ProjectMVC.WebServiceMain.BilionBankWebServiceSoap)(this)).Client(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.WebServiceMain.ClientResponse> ProjectMVC.WebServiceMain.BilionBankWebServiceSoap.ClientAsync(ProjectMVC.WebServiceMain.ClientRequest request) {
            return base.Channel.ClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.WebServiceMain.ClientResponse> ClientAsync(string name, long id, string email, string telephone, string address, string password, string question, string answer, int numAccount) {
            ProjectMVC.WebServiceMain.ClientRequest inValue = new ProjectMVC.WebServiceMain.ClientRequest();
            inValue.Body = new ProjectMVC.WebServiceMain.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            inValue.Body.numAccount = numAccount;
            return ((ProjectMVC.WebServiceMain.BilionBankWebServiceSoap)(this)).ClientAsync(inValue);
        }
    }
}
