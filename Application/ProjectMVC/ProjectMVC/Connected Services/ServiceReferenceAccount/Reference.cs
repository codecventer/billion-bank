﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ServiceReferenceAccount {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceAccount.WebServiceAccountSoap")]
    public interface WebServiceAccountSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        ProjectMVC.ServiceReferenceAccount.AccountResponse Account(ProjectMVC.ServiceReferenceAccount.AccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceAccount.AccountResponse> AccountAsync(ProjectMVC.ServiceReferenceAccount.AccountRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AccountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Account", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReferenceAccount.AccountRequestBody Body;
        
        public AccountRequest() {
        }
        
        public AccountRequest(ProjectMVC.ServiceReferenceAccount.AccountRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AccountRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int accountNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string date;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int balance;
        
        public AccountRequestBody() {
        }
        
        public AccountRequestBody(int accountNumber, string name, string date, int balance) {
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
    public partial class AccountResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AccountResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReferenceAccount.AccountResponseBody Body;
        
        public AccountResponse() {
        }
        
        public AccountResponse(ProjectMVC.ServiceReferenceAccount.AccountResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AccountResponseBody {
        
        public AccountResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceAccountSoapChannel : ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceAccountSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap>, ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap {
        
        public WebServiceAccountSoapClient() {
        }
        
        public WebServiceAccountSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceAccountSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAccountSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceAccountSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReferenceAccount.AccountResponse ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap.Account(ProjectMVC.ServiceReferenceAccount.AccountRequest request) {
            return base.Channel.Account(request);
        }
        
        public void Account(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReferenceAccount.AccountRequest inValue = new ProjectMVC.ServiceReferenceAccount.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReferenceAccount.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            ProjectMVC.ServiceReferenceAccount.AccountResponse retVal = ((ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap)(this)).Account(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceAccount.AccountResponse> ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap.AccountAsync(ProjectMVC.ServiceReferenceAccount.AccountRequest request) {
            return base.Channel.AccountAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReferenceAccount.AccountResponse> AccountAsync(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReferenceAccount.AccountRequest inValue = new ProjectMVC.ServiceReferenceAccount.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReferenceAccount.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            return ((ProjectMVC.ServiceReferenceAccount.WebServiceAccountSoap)(this)).AccountAsync(inValue);
        }
    }
}
