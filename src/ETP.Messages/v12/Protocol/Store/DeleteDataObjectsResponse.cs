// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Store
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class DeleteDataObjectsResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""DeleteDataObjectsResponse"",""namespace"":""Energistics.Etp.v12.Protocol.Store"",""fields"":[{""name"":""deletedUris"",""type"":{""type"":""map"",""values"":{""type"":""record"",""name"":""ArrayOfString"",""namespace"":""Energistics.Etp.v12.Datatypes"",""fields"":[{""name"":""values"",""type"":{""type"":""array"",""items"":""string""}}],""fullName"":""Energistics.Etp.v12.Datatypes.ArrayOfString"",""depends"":[]}}}],""protocol"":""4"",""messageType"":""10"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.Store.DeleteDataObjectsResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.ArrayOfString""
]}");
		private IDictionary<string,Energistics.Etp.v12.Datatypes.ArrayOfString> _deletedUris;
		public virtual Schema Schema
		{
			get
			{
				return DeleteDataObjectsResponse._SCHEMA;
			}
		}
		public IDictionary<string,Energistics.Etp.v12.Datatypes.ArrayOfString> DeletedUris
		{
			get
			{
				return this._deletedUris;
			}
			set
			{
				this._deletedUris = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._deletedUris;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._deletedUris = (IDictionary<string,Energistics.Etp.v12.Datatypes.ArrayOfString>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
