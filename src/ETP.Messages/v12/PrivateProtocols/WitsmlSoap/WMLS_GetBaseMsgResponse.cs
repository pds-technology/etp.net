// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.PrivateProtocols.WitsmlSoap
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class WMLS_GetBaseMsgResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""WMLS_GetBaseMsgResponse"",""namespace"":""Energistics.Etp.v12.PrivateProtocols.WitsmlSoap"",""fields"":[{""name"":""Result"",""type"":""string""}],""protocol"":""2100"",""messageType"":""6"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":false,""fullName"":""Energistics.Etp.v12.PrivateProtocols.WitsmlSoap.WMLS_GetBaseMsgResponse"",""depends"":[]}");
		private string _Result;
		public virtual Schema Schema
		{
			get
			{
				return WMLS_GetBaseMsgResponse._SCHEMA;
			}
		}
		public string Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._Result;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._Result = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
