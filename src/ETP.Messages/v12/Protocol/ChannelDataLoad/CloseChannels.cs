// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class CloseChannels : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""CloseChannels"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelDataLoad"",""fields"":[{""name"":""id"",""type"":{""type"":""map"",""values"":""long""}}],""protocol"":""22"",""messageType"":""3"",""senderRole"":""customer"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.ChannelDataLoad.CloseChannels"",""depends"":[]}");
		private IDictionary<string,System.Int64> _id;
		public virtual Schema Schema
		{
			get
			{
				return CloseChannels._SCHEMA;
			}
		}
		public IDictionary<string,System.Int64> Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._id;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._id = (IDictionary<string,System.Int64>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
