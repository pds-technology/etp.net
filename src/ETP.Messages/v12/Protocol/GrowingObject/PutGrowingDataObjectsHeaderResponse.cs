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
	
	public partial class PutGrowingDataObjectsHeaderResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""PutGrowingDataObjectsHeaderResponse"",""namespace"":""Energistics.Etp.v12.Protocol.GrowingObject"",""fields"":[{""name"":""uris"",""type"":{""type"":""map"",""values"":""string""}}],""protocol"":""6"",""messageType"":""17"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.GrowingObject.PutGrowingDataObjectsHeaderResponse"",""depends"":[]}");
		private IDictionary<string,System.String> _uris;
		public virtual Schema Schema
		{
			get
			{
				return PutGrowingDataObjectsHeaderResponse._SCHEMA;
			}
		}
		public IDictionary<string,System.String> Uris
		{
			get
			{
				return this._uris;
			}
			set
			{
				this._uris = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uris;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uris = (IDictionary<string,System.String>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}