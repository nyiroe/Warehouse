﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MnbService
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrenciesRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrenciesRequestBody : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrenciesResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrenciesResponseBody : object
    {
        
        private string GetCurrenciesResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetCurrenciesResult
        {
            get
            {
                return this.GetCurrenciesResultField;
            }
            set
            {
                this.GetCurrenciesResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrencyUnitsRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsRequestBody : object
    {
        
        private string currencyNamesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string currencyNames
        {
            get
            {
                return this.currencyNamesField;
            }
            set
            {
                this.currencyNamesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrencyUnitsResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrencyUnitsResponseBody : object
    {
        
        private string GetCurrencyUnitsResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetCurrencyUnitsResult
        {
            get
            {
                return this.GetCurrencyUnitsResultField;
            }
            set
            {
                this.GetCurrencyUnitsResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrentExchangeRatesRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrentExchangeRatesRequestBody : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetCurrentExchangeRatesResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetCurrentExchangeRatesResponseBody : object
    {
        
        private string GetCurrentExchangeRatesResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetCurrentExchangeRatesResult
        {
            get
            {
                return this.GetCurrentExchangeRatesResultField;
            }
            set
            {
                this.GetCurrentExchangeRatesResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDateIntervalRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetDateIntervalRequestBody : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetDateIntervalResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetDateIntervalResponseBody : object
    {
        
        private string GetDateIntervalResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetDateIntervalResult
        {
            get
            {
                return this.GetDateIntervalResultField;
            }
            set
            {
                this.GetDateIntervalResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetExchangeRatesRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesRequestBody : object
    {
        
        private string startDateField;
        
        private string endDateField;
        
        private string currencyNamesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string currencyNames
        {
            get
            {
                return this.currencyNamesField;
            }
            set
            {
                this.currencyNamesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetExchangeRatesResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetExchangeRatesResponseBody : object
    {
        
        private string GetExchangeRatesResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetExchangeRatesResult
        {
            get
            {
                return this.GetExchangeRatesResultField;
            }
            set
            {
                this.GetExchangeRatesResultField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfoRequestBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetInfoRequestBody : object
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GetInfoResponseBody", Namespace="http://www.mnb.hu/webservices/")]
    public partial class GetInfoResponseBody : object
    {
        
        private string GetInfoResultField;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string GetInfoResult
        {
            get
            {
                return this.GetInfoResultField;
            }
            set
            {
                this.GetInfoResultField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.mnb.hu/webservices/", ConfigurationName="MnbService.MNBArfolyamServiceSoap")]
    public interface MNBArfolyamServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencies", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrenciesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrenciesStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetCurrenciesResponse> GetCurrenciesAsync(MnbService.GetCurrenciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencyUnits", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencyUnitsResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrencyUnitsStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetCurrencyUnitsResponse> GetCurrencyUnitsAsync(MnbService.GetCurrencyUnitsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrentExchangeRates", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrentExchangeRatesRespo" +
            "nse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetCurrentExchangeRatesStrin" +
            "gFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetCurrentExchangeRatesResponse> GetCurrentExchangeRatesAsync(MnbService.GetCurrentExchangeRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetDateInterval", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetDateIntervalResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetDateIntervalStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetDateIntervalResponse> GetDateIntervalAsync(MnbService.GetDateIntervalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetExchangeRates", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetExchangeRatesResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetExchangeRatesStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetExchangeRatesResponse> GetExchangeRatesAsync(MnbService.GetExchangeRatesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetInfo", ReplyAction="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetInfoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(string), Action="http://www.mnb.hu/webservices/MNBArfolyamServiceSoap/GetInfoStringFault", Name="string", Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        System.Threading.Tasks.Task<MnbService.GetInfoResponse> GetInfoAsync(MnbService.GetInfoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrenciesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrenciesRequestBody GetCurrencies;
        
        public GetCurrenciesRequest()
        {
        }
        
        public GetCurrenciesRequest(MnbService.GetCurrenciesRequestBody GetCurrencies)
        {
            this.GetCurrencies = GetCurrencies;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrenciesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrenciesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrenciesResponseBody GetCurrenciesResponse1;
        
        public GetCurrenciesResponse()
        {
        }
        
        public GetCurrenciesResponse(MnbService.GetCurrenciesResponseBody GetCurrenciesResponse1)
        {
            this.GetCurrenciesResponse1 = GetCurrenciesResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrencyUnitsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrencyUnitsRequestBody GetCurrencyUnits;
        
        public GetCurrencyUnitsRequest()
        {
        }
        
        public GetCurrencyUnitsRequest(MnbService.GetCurrencyUnitsRequestBody GetCurrencyUnits)
        {
            this.GetCurrencyUnits = GetCurrencyUnits;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrencyUnitsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrencyUnitsResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrencyUnitsResponseBody GetCurrencyUnitsResponse1;
        
        public GetCurrencyUnitsResponse()
        {
        }
        
        public GetCurrencyUnitsResponse(MnbService.GetCurrencyUnitsResponseBody GetCurrencyUnitsResponse1)
        {
            this.GetCurrencyUnitsResponse1 = GetCurrencyUnitsResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentExchangeRatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates;
        
        public GetCurrentExchangeRatesRequest()
        {
        }
        
        public GetCurrentExchangeRatesRequest(MnbService.GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates)
        {
            this.GetCurrentExchangeRates = GetCurrentExchangeRates;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCurrentExchangeRatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCurrentExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetCurrentExchangeRatesResponseBody GetCurrentExchangeRatesResponse1;
        
        public GetCurrentExchangeRatesResponse()
        {
        }
        
        public GetCurrentExchangeRatesResponse(MnbService.GetCurrentExchangeRatesResponseBody GetCurrentExchangeRatesResponse1)
        {
            this.GetCurrentExchangeRatesResponse1 = GetCurrentExchangeRatesResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateIntervalRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetDateIntervalRequestBody GetDateInterval;
        
        public GetDateIntervalRequest()
        {
        }
        
        public GetDateIntervalRequest(MnbService.GetDateIntervalRequestBody GetDateInterval)
        {
            this.GetDateInterval = GetDateInterval;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetDateIntervalResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetDateIntervalResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetDateIntervalResponseBody GetDateIntervalResponse1;
        
        public GetDateIntervalResponse()
        {
        }
        
        public GetDateIntervalResponse(MnbService.GetDateIntervalResponseBody GetDateIntervalResponse1)
        {
            this.GetDateIntervalResponse1 = GetDateIntervalResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetExchangeRatesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetExchangeRatesRequestBody GetExchangeRates;
        
        public GetExchangeRatesRequest()
        {
        }
        
        public GetExchangeRatesRequest(MnbService.GetExchangeRatesRequestBody GetExchangeRates)
        {
            this.GetExchangeRates = GetExchangeRates;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetExchangeRatesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetExchangeRatesResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetExchangeRatesResponseBody GetExchangeRatesResponse1;
        
        public GetExchangeRatesResponse()
        {
        }
        
        public GetExchangeRatesResponse(MnbService.GetExchangeRatesResponseBody GetExchangeRatesResponse1)
        {
            this.GetExchangeRatesResponse1 = GetExchangeRatesResponse1;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetInfoRequestBody GetInfo;
        
        public GetInfoRequest()
        {
        }
        
        public GetInfoRequest(MnbService.GetInfoRequestBody GetInfo)
        {
            this.GetInfo = GetInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetInfoResponse", Namespace="http://www.mnb.hu/webservices/", Order=0)]
        public MnbService.GetInfoResponseBody GetInfoResponse1;
        
        public GetInfoResponse()
        {
        }
        
        public GetInfoResponse(MnbService.GetInfoResponseBody GetInfoResponse1)
        {
            this.GetInfoResponse1 = GetInfoResponse1;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface MNBArfolyamServiceSoapChannel : MnbService.MNBArfolyamServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class MNBArfolyamServiceSoapClient : System.ServiceModel.ClientBase<MnbService.MNBArfolyamServiceSoap>, MnbService.MNBArfolyamServiceSoap
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MNBArfolyamServiceSoapClient() : 
                base(MNBArfolyamServiceSoapClient.GetDefaultBinding(), MNBArfolyamServiceSoapClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CustomBinding_MNBArfolyamServiceSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MNBArfolyamServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(MNBArfolyamServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), MNBArfolyamServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MNBArfolyamServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MNBArfolyamServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MNBArfolyamServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MNBArfolyamServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MNBArfolyamServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetCurrenciesResponse> MnbService.MNBArfolyamServiceSoap.GetCurrenciesAsync(MnbService.GetCurrenciesRequest request)
        {
            return base.Channel.GetCurrenciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetCurrenciesResponse> GetCurrenciesAsync(MnbService.GetCurrenciesRequestBody GetCurrencies)
        {
            MnbService.GetCurrenciesRequest inValue = new MnbService.GetCurrenciesRequest();
            inValue.GetCurrencies = GetCurrencies;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetCurrenciesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetCurrencyUnitsResponse> MnbService.MNBArfolyamServiceSoap.GetCurrencyUnitsAsync(MnbService.GetCurrencyUnitsRequest request)
        {
            return base.Channel.GetCurrencyUnitsAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetCurrencyUnitsResponse> GetCurrencyUnitsAsync(MnbService.GetCurrencyUnitsRequestBody GetCurrencyUnits)
        {
            MnbService.GetCurrencyUnitsRequest inValue = new MnbService.GetCurrencyUnitsRequest();
            inValue.GetCurrencyUnits = GetCurrencyUnits;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetCurrencyUnitsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetCurrentExchangeRatesResponse> MnbService.MNBArfolyamServiceSoap.GetCurrentExchangeRatesAsync(MnbService.GetCurrentExchangeRatesRequest request)
        {
            return base.Channel.GetCurrentExchangeRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetCurrentExchangeRatesResponse> GetCurrentExchangeRatesAsync(MnbService.GetCurrentExchangeRatesRequestBody GetCurrentExchangeRates)
        {
            MnbService.GetCurrentExchangeRatesRequest inValue = new MnbService.GetCurrentExchangeRatesRequest();
            inValue.GetCurrentExchangeRates = GetCurrentExchangeRates;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetCurrentExchangeRatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetDateIntervalResponse> MnbService.MNBArfolyamServiceSoap.GetDateIntervalAsync(MnbService.GetDateIntervalRequest request)
        {
            return base.Channel.GetDateIntervalAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetDateIntervalResponse> GetDateIntervalAsync(MnbService.GetDateIntervalRequestBody GetDateInterval)
        {
            MnbService.GetDateIntervalRequest inValue = new MnbService.GetDateIntervalRequest();
            inValue.GetDateInterval = GetDateInterval;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetDateIntervalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetExchangeRatesResponse> MnbService.MNBArfolyamServiceSoap.GetExchangeRatesAsync(MnbService.GetExchangeRatesRequest request)
        {
            return base.Channel.GetExchangeRatesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetExchangeRatesResponse> GetExchangeRatesAsync(MnbService.GetExchangeRatesRequestBody GetExchangeRates)
        {
            MnbService.GetExchangeRatesRequest inValue = new MnbService.GetExchangeRatesRequest();
            inValue.GetExchangeRates = GetExchangeRates;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetExchangeRatesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MnbService.GetInfoResponse> MnbService.MNBArfolyamServiceSoap.GetInfoAsync(MnbService.GetInfoRequest request)
        {
            return base.Channel.GetInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<MnbService.GetInfoResponse> GetInfoAsync(MnbService.GetInfoRequestBody GetInfo)
        {
            MnbService.GetInfoRequest inValue = new MnbService.GetInfoRequest();
            inValue.GetInfo = GetInfo;
            return ((MnbService.MNBArfolyamServiceSoap)(this)).GetInfoAsync(inValue);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CustomBinding_MNBArfolyamServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CustomBinding_MNBArfolyamServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://www.mnb.hu/arfolyamok.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MNBArfolyamServiceSoapClient.GetBindingForEndpoint(EndpointConfiguration.CustomBinding_MNBArfolyamServiceSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MNBArfolyamServiceSoapClient.GetEndpointAddress(EndpointConfiguration.CustomBinding_MNBArfolyamServiceSoap);
        }
        
        public enum EndpointConfiguration
        {
            
            CustomBinding_MNBArfolyamServiceSoap,
        }
    }
}
