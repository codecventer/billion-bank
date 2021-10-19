﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectMVC.ServiceReferenceFromAccount {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceFromAccount.WebServiceFromAccountSoap")]
    public interface WebServiceFromAccountSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FromAccountBalance", ReplyAction="*")]
        int FromAccountBalance(int account);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/FromAccountBalance", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FromAccountBalanceAsync(int account);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceFromAccountSoapChannel : ProjectMVC.ServiceReferenceFromAccount.WebServiceFromAccountSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceFromAccountSoapClient : System.ServiceModel.ClientBase<ProjectMVC.ServiceReferenceFromAccount.WebServiceFromAccountSoap>, ProjectMVC.ServiceReferenceFromAccount.WebServiceFromAccountSoap {
        
        public WebServiceFromAccountSoapClient() {
        }
        
        public WebServiceFromAccountSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceFromAccountSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFromAccountSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceFromAccountSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int FromAccountBalance(int account) {
            return base.Channel.FromAccountBalance(account);
        }
        
        public System.Threading.Tasks.Task<int> FromAccountBalanceAsync(int account) {
            return base.Channel.FromAccountBalanceAsync(account);
        }
    }
}