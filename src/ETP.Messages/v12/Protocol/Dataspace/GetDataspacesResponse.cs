// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Dataspace
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetDataspacesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetDataspacesResponse\",\"namespace\":\"Energistics.Etp.v12." +
				"Protocol.Dataspace\",\"fields\":[{\"name\":\"dataspaces\",\"default\":[],\"type\":{\"type\":\"" +
				"array\",\"items\":{\"type\":\"record\",\"name\":\"Dataspace\",\"namespace\":\"Energistics.Etp." +
				"v12.Datatypes.Object\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"path\",\"d" +
				"efault\":\"\",\"type\":\"string\"},{\"name\":\"lastChanged\",\"default\":null,\"type\":[\"null\"," +
				"\"long\"]},{\"name\":\"customData\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\"" +
				":\"record\",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields" +
				"\":[{\"name\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string" +
				"\",{\"type\":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Data" +
				"types\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"f" +
				"ullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"r" +
				"ecord\",\"name\":\"ArrayOfNullableBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatype" +
				"s\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}" +
				"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"depends\":[" +
				"]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatyp" +
				"es\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName" +
				"\":\"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"nam" +
				"e\":\"ArrayOfNullableInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"" +
				"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}],\"fullName\":\"Ener" +
				"gistics.Etp.v12.Datatypes.ArrayOfNullableInt\",\"depends\":[]},{\"type\":\"record\",\"na" +
				"me\":\"ArrayOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":" +
				"\"values\",\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v1" +
				"2.Datatypes.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableL" +
				"ong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"typ" +
				"e\":{\"type\":\"array\",\"items\":[\"null\",\"long\"]}}],\"fullName\":\"Energistics.Etp.v12.Da" +
				"tatypes.ArrayOfNullableLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat" +
				"\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":" +
				"{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Arr" +
				"ayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"En" +
				"ergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"" +
				"items\":\"double\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"dep" +
				"ends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v" +
				"12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"" +
				"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"byte" +
				"s\",{\"type\":\"record\",\"name\":\"AnySparseArray\",\"namespace\":\"Energistics.Etp.v12.Dat" +
				"atypes\",\"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"recor" +
				"d\",\"name\":\"AnySubarray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"" +
				"name\":\"start\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"Any" +
				"Array\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"typ" +
				"e\":[\"ArrayOfBoolean\",\"ArrayOfInt\",\"ArrayOfLong\",\"ArrayOfFloat\",\"ArrayOfDouble\",\"" +
				"ArrayOfString\",\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"d" +
				"epends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp" +
				".v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"" +
				"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}],\"fullName\"" +
				":\"Energistics.Etp.v12.Datatypes.AnySubarray\",\"depends\":[\r\n  \"Energistics.Etp.v12" +
				".Datatypes.AnyArray\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnySparseA" +
				"rray\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.AnySubarray\"\r\n]}]}],\"fullNam" +
				"e\":\"Energistics.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12" +
				".Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoo" +
				"lean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Da" +
				"tatypes.ArrayOfNullableInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  " +
				"\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\",\r\n  \"Energistics.Etp.v12.Dat" +
				"atypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Ener" +
				"gistics.Etp.v12.Datatypes.ArrayOfString\",\r\n  \"Energistics.Etp.v12.Datatypes.AnyS" +
				"parseArray\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.Dataspace\",\"" +
				"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}}}],\"protocol\":\"24\",\"" +
				"messageType\":\"2\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"multipar" +
				"tFlag\":true,\"fullName\":\"Energistics.Etp.v12.Protocol.Dataspace.GetDataspacesResp" +
				"onse\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.Dataspace\"\r\n]}");
		private IList<Energistics.Etp.v12.Datatypes.Object.Dataspace> _dataspaces;
		public virtual Schema Schema
		{
			get
			{
				return GetDataspacesResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.Object.Dataspace> Dataspaces
		{
			get
			{
				return this._dataspaces;
			}
			set
			{
				this._dataspaces = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dataspaces;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dataspaces = (IList<Energistics.Etp.v12.Datatypes.Object.Dataspace>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
