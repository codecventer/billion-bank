﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.BilionBankWebServiceSoap")]
    public interface BilionBankWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        ProjectMVC.ServiceReference2.ClientResponse Client(ProjectMVC.ServiceReference2.ClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.ClientResponse> ClientAsync(ProjectMVC.ServiceReference2.ClientRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        ProjectMVC.ServiceReference2.AccountResponse Account(ProjectMVC.ServiceReference2.AccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.AccountResponse> AccountAsync(ProjectMVC.ServiceReference2.AccountRequest request);
        
        // CODEGEN: Generating message contract since element name toAccount from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Transfer", ReplyAction="*")]
        ProjectMVC.ServiceReference2.TransferResponse Transfer(ProjectMVC.ServiceReference2.TransferRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Transfer", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.TransferResponse> TransferAsync(ProjectMVC.ServiceReference2.TransferRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Client", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference2.ClientRequestBody Body;
        
        public ClientRequest() {
        }
        
        public ClientRequest(ProjectMVC.ServiceReference2.ClientRequestBody Body) {
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
        
        public ClientRequestBody() {
        }
        
        public ClientRequestBody(string name, long id, string email, string telephone, string address, string password, string question, string answer) {
            this.name = name;
            this.id = id;
            this.email = email;
            this.telephone = telephone;
            this.address = address;
            this.password = password;
            this.question = question;
            this.answer = answer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ClientResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference2.ClientResponseBody Body;
        
        public ClientResponse() {
        }
        
        public ClientResponse(ProjectMVC.ServiceReference2.ClientResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AccountRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Account", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference2.AccountRequestBody Body;
        
        public AccountRequest() {
        }
        
        public AccountRequest(ProjectMVC.ServiceReference2.AccountRequestBody Body) {
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
        public ProjectMVC.ServiceReference2.AccountResponseBody Body;
        
        public AccountResponse() {
        }
        
        public AccountResponse(ProjectMVC.ServiceReference2.AccountResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TransferRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Transfer", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference2.TransferRequestBody Body;
        
        public TransferRequest() {
        }
        
        public TransferRequest(ProjectMVC.ServiceReference2.TransferRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class TransferRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string toAccount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string fromAccount;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string date;
        
        public TransferRequestBody() {
        }
        
        public TransferRequestBody(string toAccount, string fromAccount, int amount, string date) {
            this.toAccount = toAccount;
            this.fromAccount = fromAccount;
            this.amount = amount;
            this.date = date;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TransferResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TransferResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference2.TransferResponseBody Body;
        
        public TransferResponse() {
        }
        
        public TransferResponse(ProjectMVC.ServiceReference2.TransferResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TransferResponseBody {
        
        public TransferResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BilionBankWebServiceSoapChannel : ProjectMVC.ServiceReference2.BilionBankWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BilionBankWebServiceSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ServiceReference2.BilionBankWebServiceSoap>, ProjectMVC.ServiceReference2.BilionBankWebServiceSoap {
        
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
        ProjectMVC.ServiceReference2.ClientResponse ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.Client(ProjectMVC.ServiceReference2.ClientRequest request) {
            return base.Channel.Client(request);
        }
        
        public void Client(string name, long id, string email, string telephone, string address, string password, string question, string answer) {
            ProjectMVC.ServiceReference2.ClientRequest inValue = new ProjectMVC.ServiceReference2.ClientRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            ProjectMVC.ServiceReference2.ClientResponse retVal = ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).Client(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.ClientResponse> ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.ClientAsync(ProjectMVC.ServiceReference2.ClientRequest request) {
            return base.Channel.ClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.ClientResponse> ClientAsync(string name, long id, string email, string telephone, string address, string password, string question, string answer) {
            ProjectMVC.ServiceReference2.ClientRequest inValue = new ProjectMVC.ServiceReference2.ClientRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            return ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).ClientAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReference2.AccountResponse ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.Account(ProjectMVC.ServiceReference2.AccountRequest request) {
            return base.Channel.Account(request);
        }
        
        public void Account(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReference2.AccountRequest inValue = new ProjectMVC.ServiceReference2.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            ProjectMVC.ServiceReference2.AccountResponse retVal = ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).Account(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.AccountResponse> ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.AccountAsync(ProjectMVC.ServiceReference2.AccountRequest request) {
            return base.Channel.AccountAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.AccountResponse> AccountAsync(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReference2.AccountRequest inValue = new ProjectMVC.ServiceReference2.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            return ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).AccountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReference2.TransferResponse ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.Transfer(ProjectMVC.ServiceReference2.TransferRequest request) {
            return base.Channel.Transfer(request);
        }
        
        public void Transfer(string toAccount, string fromAccount, int amount, string date) {
            ProjectMVC.ServiceReference2.TransferRequest inValue = new ProjectMVC.ServiceReference2.TransferRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.TransferRequestBody();
            inValue.Body.toAccount = toAccount;
            inValue.Body.fromAccount = fromAccount;
            inValue.Body.amount = amount;
            inValue.Body.date = date;
            ProjectMVC.ServiceReference2.TransferResponse retVal = ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).Transfer(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.TransferResponse> ProjectMVC.ServiceReference2.BilionBankWebServiceSoap.TransferAsync(ProjectMVC.ServiceReference2.TransferRequest request) {
            return base.Channel.TransferAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference2.TransferResponse> TransferAsync(string toAccount, string fromAccount, int amount, string date) {
            ProjectMVC.ServiceReference2.TransferRequest inValue = new ProjectMVC.ServiceReference2.TransferRequest();
            inValue.Body = new ProjectMVC.ServiceReference2.TransferRequestBody();
            inValue.Body.toAccount = toAccount;
            inValue.Body.fromAccount = fromAccount;
            inValue.Body.amount = amount;
            inValue.Body.date = date;
            return ((ProjectMVC.ServiceReference2.BilionBankWebServiceSoap)(this)).TransferAsync(inValue);
        }
    }
}
