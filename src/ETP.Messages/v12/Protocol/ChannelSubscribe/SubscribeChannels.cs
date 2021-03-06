// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class SubscribeChannels : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""SubscribeChannels"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelSubscribe"",""fields"":[{""name"":""channels"",""type"":{""type"":""map"",""values"":{""type"":""record"",""name"":""ChannelSubscribeInfo"",""namespace"":""Energistics.Etp.v12.Datatypes.ChannelData"",""fields"":[{""name"":""channelId"",""type"":""long""},{""name"":""startIndex"",""type"":{""type"":""record"",""name"":""IndexValue"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""item"",""type"":[""null"",""long"",""double""]}],""fullName"":""Energistics.Etp.v12.Datatypes.IndexValue"",""depends"":[]}},{""name"":""dataChanges"",""default"":true,""type"":""boolean""},{""name"":""requestLatestIndexCount"",""type"":[""null"",""int""]}],""fullName"":""Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.IndexValue""
]}}}],""protocol"":""21"",""messageType"":""3"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscribeChannels"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo""
]}");
		private IDictionary<string,Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo> _channels;
		public virtual Schema Schema
		{
			get
			{
				return SubscribeChannels._SCHEMA;
			}
		}
		public IDictionary<string,Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo> Channels
		{
			get
			{
				return this._channels;
			}
			set
			{
				this._channels = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channels;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channels = (IDictionary<string,Energistics.Etp.v12.Datatypes.ChannelData.ChannelSubscribeInfo>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
