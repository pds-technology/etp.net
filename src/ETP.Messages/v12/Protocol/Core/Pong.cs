// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class Pong : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""Pong"",""namespace"":""Energistics.Etp.v12.Protocol.Core"",""fields"":[{""name"":""currentDateTime"",""type"":""long""}],""protocol"":""0"",""messageType"":""9"",""senderRole"":""client,server"",""protocolRoles"":""client, server"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.Core.Pong"",""depends"":[]}");
		private long _currentDateTime;
		public virtual Schema Schema
		{
			get
			{
				return Pong._SCHEMA;
			}
		}
		public long CurrentDateTime
		{
			get
			{
				return this._currentDateTime;
			}
			set
			{
				this._currentDateTime = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._currentDateTime;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._currentDateTime = (System.Int64)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
