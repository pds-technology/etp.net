// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.GrowingObject
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ReplacePartsByRangeResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ReplacePartsByRangeResponse"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[],""protocol"":""6"",""messageType"":""18"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.ReplacePartsByRangeResponse"",""depends"":[]}");
		public virtual Schema Schema
		{
			get
			{
				return ReplacePartsByRangeResponse._SCHEMA;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
