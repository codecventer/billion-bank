﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ServiceReference6 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference6.BilionBankWebServiceSoap")]
    public interface BilionBankWebServiceSoap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        ProjectMVC.ServiceReference6.ClientResponse Client(ProjectMVC.ServiceReference6.ClientRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Client", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.ClientResponse> ClientAsync(ProjectMVC.ServiceReference6.ClientRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        ProjectMVC.ServiceReference6.AccountResponse Account(ProjectMVC.ServiceReference6.AccountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Account", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AccountResponse> AccountAsync(ProjectMVC.ServiceReference6.AccountRequest request);
        
        // CODEGEN: Generating message contract since element name date from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTransaction", ReplyAction="*")]
        ProjectMVC.ServiceReference6.AddTransactionResponse AddTransaction(ProjectMVC.ServiceReference6.AddTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddTransaction", ReplyAction="*")]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AddTransactionResponse> AddTransactionAsync(ProjectMVC.ServiceReference6.AddTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Deduct", ReplyAction="*")]
        void Deduct(int fromAccount, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Deduct", ReplyAction="*")]
        System.Threading.Tasks.Task DeductAsync(int fromAccount, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Increase", ReplyAction="*")]
        void Increase(int toAccount, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Increase", ReplyAction="*")]
        System.Threading.Tasks.Task IncreaseAsync(int toAccount, int amount);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ClientRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Client", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference6.ClientRequestBody Body;
        
        public ClientRequest() {
        }
        
        public ClientRequest(ProjectMVC.ServiceReference6.ClientRequestBody Body) {
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
        public ProjectMVC.ServiceReference6.ClientResponseBody Body;
        
        public ClientResponse() {
        }
        
        public ClientResponse(ProjectMVC.ServiceReference6.ClientResponseBody Body) {
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
        public ProjectMVC.ServiceReference6.AccountRequestBody Body;
        
        public AccountRequest() {
        }
        
        public AccountRequest(ProjectMVC.ServiceReference6.AccountRequestBody Body) {
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
        public ProjectMVC.ServiceReference6.AccountResponseBody Body;
        
        public AccountResponse() {
        }
        
        public AccountResponse(ProjectMVC.ServiceReference6.AccountResponseBody Body) {
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
    public partial class AddTransactionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTransaction", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference6.AddTransactionRequestBody Body;
        
        public AddTransactionRequest() {
        }
        
        public AddTransactionRequest(ProjectMVC.ServiceReference6.AddTransactionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddTransactionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int toAccount;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int fromAccount;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int amount;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string date;
        
        public AddTransactionRequestBody() {
        }
        
        public AddTransactionRequestBody(int toAccount, int fromAccount, int amount, string date) {
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
    public partial class AddTransactionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddTransactionResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProjectMVC.ServiceReference6.AddTransactionResponseBody Body;
        
        public AddTransactionResponse() {
        }
        
        public AddTransactionResponse(ProjectMVC.ServiceReference6.AddTransactionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddTransactionResponseBody {
        
        public AddTransactionResponseBody() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BilionBankWebServiceSoapChannel : ProjectMVC.ServiceReference6.BilionBankWebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BilionBankWebServiceSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ServiceReference6.BilionBankWebServiceSoap>, ProjectMVC.ServiceReference6.BilionBankWebServiceSoap {
        
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
        ProjectMVC.ServiceReference6.ClientResponse ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.Client(ProjectMVC.ServiceReference6.ClientRequest request) {
            return base.Channel.Client(request);
        }
        
        public void Client(string name, long id, string email, string telephone, string address, string password, string question, string answer) {
            ProjectMVC.ServiceReference6.ClientRequest inValue = new ProjectMVC.ServiceReference6.ClientRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            ProjectMVC.ServiceReference6.ClientResponse retVal = ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).Client(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.ClientResponse> ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.ClientAsync(ProjectMVC.ServiceReference6.ClientRequest request) {
            return base.Channel.ClientAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.ClientResponse> ClientAsync(string name, long id, string email, string telephone, string address, string password, string question, string answer) {
            ProjectMVC.ServiceReference6.ClientRequest inValue = new ProjectMVC.ServiceReference6.ClientRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.ClientRequestBody();
            inValue.Body.name = name;
            inValue.Body.id = id;
            inValue.Body.email = email;
            inValue.Body.telephone = telephone;
            inValue.Body.address = address;
            inValue.Body.password = password;
            inValue.Body.question = question;
            inValue.Body.answer = answer;
            return ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).ClientAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReference6.AccountResponse ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.Account(ProjectMVC.ServiceReference6.AccountRequest request) {
            return base.Channel.Account(request);
        }
        
        public void Account(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReference6.AccountRequest inValue = new ProjectMVC.ServiceReference6.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            ProjectMVC.ServiceReference6.AccountResponse retVal = ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).Account(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AccountResponse> ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.AccountAsync(ProjectMVC.ServiceReference6.AccountRequest request) {
            return base.Channel.AccountAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AccountResponse> AccountAsync(int accountNumber, string name, string date, int balance) {
            ProjectMVC.ServiceReference6.AccountRequest inValue = new ProjectMVC.ServiceReference6.AccountRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.AccountRequestBody();
            inValue.Body.accountNumber = accountNumber;
            inValue.Body.name = name;
            inValue.Body.date = date;
            inValue.Body.balance = balance;
            return ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).AccountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProjectMVC.ServiceReference6.AddTransactionResponse ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.AddTransaction(ProjectMVC.ServiceReference6.AddTransactionRequest request) {
            return base.Channel.AddTransaction(request);
        }
        
        public void AddTransaction(int toAccount, int fromAccount, int amount, string date) {
            ProjectMVC.ServiceReference6.AddTransactionRequest inValue = new ProjectMVC.ServiceReference6.AddTransactionRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.AddTransactionRequestBody();
            inValue.Body.toAccount = toAccount;
            inValue.Body.fromAccount = fromAccount;
            inValue.Body.amount = amount;
            inValue.Body.date = date;
            ProjectMVC.ServiceReference6.AddTransactionResponse retVal = ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).AddTransaction(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AddTransactionResponse> ProjectMVC.ServiceReference6.BilionBankWebServiceSoap.AddTransactionAsync(ProjectMVC.ServiceReference6.AddTransactionRequest request) {
            return base.Channel.AddTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProjectMVC.ServiceReference6.AddTransactionResponse> AddTransactionAsync(int toAccount, int fromAccount, int amount, string date) {
            ProjectMVC.ServiceReference6.AddTransactionRequest inValue = new ProjectMVC.ServiceReference6.AddTransactionRequest();
            inValue.Body = new ProjectMVC.ServiceReference6.AddTransactionRequestBody();
            inValue.Body.toAccount = toAccount;
            inValue.Body.fromAccount = fromAccount;
            inValue.Body.amount = amount;
            inValue.Body.date = date;
            return ((ProjectMVC.ServiceReference6.BilionBankWebServiceSoap)(this)).AddTransactionAsync(inValue);
        }
        
        public void Deduct(int fromAccount, int amount) {
            base.Channel.Deduct(fromAccount, amount);
        }
        
        public System.Threading.Tasks.Task DeductAsync(int fromAccount, int amount) {
            return base.Channel.DeductAsync(fromAccount, amount);
        }
        
        public void Increase(int toAccount, int amount) {
            base.Channel.Increase(toAccount, amount);
        }
        
        public System.Threading.Tasks.Task IncreaseAsync(int toAccount, int amount) {
            return base.Channel.IncreaseAsync(toAccount, amount);
        }
    }
}