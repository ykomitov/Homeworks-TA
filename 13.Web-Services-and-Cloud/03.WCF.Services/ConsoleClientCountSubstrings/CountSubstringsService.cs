﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="ICountSubstringsService")]
public interface ICountSubstringsService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountSubstringsService/CountSubstringRepetitionsWithinString", ReplyAction="http://tempuri.org/ICountSubstringsService/CountSubstringRepetitionsWithinStringR" +
        "esponse")]
    int CountSubstringRepetitionsWithinString(string substring, string originalString);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICountSubstringsService/CountSubstringRepetitionsWithinString", ReplyAction="http://tempuri.org/ICountSubstringsService/CountSubstringRepetitionsWithinStringR" +
        "esponse")]
    System.Threading.Tasks.Task<int> CountSubstringRepetitionsWithinStringAsync(string substring, string originalString);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface ICountSubstringsServiceChannel : ICountSubstringsService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class CountSubstringsServiceClient : System.ServiceModel.ClientBase<ICountSubstringsService>, ICountSubstringsService
{
    
    public CountSubstringsServiceClient()
    {
    }
    
    public CountSubstringsServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public CountSubstringsServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CountSubstringsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public CountSubstringsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public int CountSubstringRepetitionsWithinString(string substring, string originalString)
    {
        return base.Channel.CountSubstringRepetitionsWithinString(substring, originalString);
    }
    
    public System.Threading.Tasks.Task<int> CountSubstringRepetitionsWithinStringAsync(string substring, string originalString)
    {
        return base.Channel.CountSubstringRepetitionsWithinStringAsync(substring, originalString);
    }
}
