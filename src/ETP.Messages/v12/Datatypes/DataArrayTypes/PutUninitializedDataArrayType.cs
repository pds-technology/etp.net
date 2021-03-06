// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.DataArrayTypes
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class PutUninitializedDataArrayType : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""PutUninitializedDataArrayType"",""namespace"":""Energistics.Etp.v12.Datatypes.DataArrayTypes"",""fields"":[{""name"":""uid"",""type"":{""type"":""record"",""name"":""DataArrayIdentifier"",""namespace"":""Energistics.Etp.v12.Datatypes.DataArrayTypes"",""fields"":[{""name"":""uri"",""type"":""string""},{""name"":""pathInResource"",""type"":""string""}],""fullName"":""Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier"",""depends"":[]}},{""name"":""metadata"",""type"":{""type"":""record"",""name"":""DataArrayMetadata"",""namespace"":""Energistics.Etp.v12.Datatypes.DataArrayTypes"",""fields"":[{""name"":""dimensions"",""type"":{""type"":""array"",""items"":""long""}},{""name"":""arrayType"",""type"":{""type"":""enum"",""name"":""AnyArrayType"",""namespace"":""Energistics.Etp.v12.Datatypes"",""symbols"":[""arrayOfBoolean"",""arrayOfInt"",""arrayOfLong"",""arrayOfFloat"",""arrayOfDouble"",""arrayOfString"",""bytes""],""fullName"":""Energistics.Etp.v12.Datatypes.AnyArrayType"",""depends"":[]}}],""fullName"":""Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.AnyArrayType""
]}}],""fullName"":""Energistics.Etp.v12.Datatypes.DataArrayTypes.PutUninitializedDataArrayType"",""depends"":[
  ""Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier"",
  ""Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata""
]}");
		private Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier _uid;
		private Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata _metadata;
		public virtual Schema Schema
		{
			get
			{
				return PutUninitializedDataArrayType._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier Uid
		{
			get
			{
				return this._uid;
			}
			set
			{
				this._uid = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata Metadata
		{
			get
			{
				return this._metadata;
			}
			set
			{
				this._metadata = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._uid;
			case 1: return this._metadata;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._uid = (Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayIdentifier)fieldValue; break;
			case 1: this._metadata = (Energistics.Etp.v12.Datatypes.DataArrayTypes.DataArrayMetadata)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
