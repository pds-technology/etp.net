// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.SupportedTypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetSupportedTypesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""GetSupportedTypesResponse"",""namespace"":""Energistics.Etp.v12.Protocol.SupportedTypes"",""fields"":[{""name"":""supportedTypes"",""default"":[],""type"":{""type"":""array"",""items"":{""type"":""record"",""name"":""SupportedType"",""namespace"":""Energistics.Etp.v12.Datatypes.Object"",""fields"":[{""name"":""dataObjectType"",""type"":""string""},{""name"":""objectCount"",""type"":[""null"",""int""]}],""fullName"":""Energistics.Etp.v12.Datatypes.Object.SupportedType"",""depends"":[]}}}],""protocol"":""25"",""messageType"":""2"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""multipartFlag"":true,""fullName"":""Energistics.Etp.v12.Protocol.SupportedTypes.GetSupportedTypesResponse"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.Object.SupportedType""
]}");
		private IList<Energistics.Etp.v12.Datatypes.Object.SupportedType> _supportedTypes;
		public virtual Schema Schema
		{
			get
			{
				return GetSupportedTypesResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.Object.SupportedType> SupportedTypes
		{
			get
			{
				return this._supportedTypes;
			}
			set
			{
				this._supportedTypes = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._supportedTypes;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._supportedTypes = (IList<Energistics.Etp.v12.Datatypes.Object.SupportedType>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}