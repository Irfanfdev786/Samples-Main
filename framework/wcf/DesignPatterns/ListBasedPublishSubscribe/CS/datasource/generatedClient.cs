﻿//  Copyright (c) Microsoft Corporation.  All Rights Reserved.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.ServiceModel.Samples
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://Microsoft.ServiceModel.Samples", ConfigurationName="Microsoft.ServiceModel.Samples.ISampleContract", CallbackContract=typeof(Microsoft.ServiceModel.Samples.ISampleContractCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ISampleContract
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://Microsoft.ServiceModel.Samples/ISampleContract/Subscribe", ReplyAction="http://Microsoft.ServiceModel.Samples/ISampleContract/SubscribeResponse")]
        void Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://Microsoft.ServiceModel.Samples/ISampleContract/Unsubscribe", ReplyAction="http://Microsoft.ServiceModel.Samples/ISampleContract/UnsubscribeResponse")]
        void Unsubscribe();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ISampleContract/PublishPriceChange")]
        void PublishPriceChange(string item, double price, double change);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ISampleContractCallback
    {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://Microsoft.ServiceModel.Samples/ISampleContract/PriceChange")]
        void PriceChange(string item, double price, double change);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ISampleContractChannel : Microsoft.ServiceModel.Samples.ISampleContract, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class SampleContractClient : System.ServiceModel.DuplexClientBase<Microsoft.ServiceModel.Samples.ISampleContract>, Microsoft.ServiceModel.Samples.ISampleContract
    {
        
        public SampleContractClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance)
        {
        }
        
        public SampleContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName)
        {
        }
        
        public SampleContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public SampleContractClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress)
        {
        }
        
        public SampleContractClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress)
        {
        }
        
        public void Subscribe()
        {
            base.Channel.Subscribe();
        }
        
        public void Unsubscribe()
        {
            base.Channel.Unsubscribe();
        }
        
        public void PublishPriceChange(string item, double price, double change)
        {
            base.Channel.PublishPriceChange(item, price, change);
        }
    }
}
