// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Discovery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class GetDeletedResourcesResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetDeletedResourcesResponse\",\"namespace\":\"Energistics.Et" +
				"p.v12.Protocol.Discovery\",\"fields\":[{\"name\":\"deletedResources\",\"default\":[],\"typ" +
				"e\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"DeletedResource\",\"namespace\"" +
				":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"uri\",\"type\":\"string\"}" +
				",{\"name\":\"dataObjectType\",\"type\":\"string\"},{\"name\":\"deletedTime\",\"type\":\"long\"}," +
				"{\"name\":\"customData\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\"" +
				",\"name\":\"DataValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"item\",\"type\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\"" +
				":\"record\",\"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":" +
				"\"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"n" +
				"ame\":\"ArrayOfNullableBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"field" +
				"s\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}],\"fullN" +
				"ame\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"depends\":[]},{\"type" +
				"\":\"record\",\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fiel" +
				"ds\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energi" +
				"stics.Etp.v12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"Array" +
				"OfNullableInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"va" +
				"lues\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}],\"fullName\":\"Energistics.E" +
				"tp.v12.Datatypes.ArrayOfNullableInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"Arra" +
				"yOfLong\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\"," +
				"\"type\":{\"type\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatyp" +
				"es.ArrayOfLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableLong\",\"nam" +
				"espace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type" +
				"\":\"array\",\"items\":[\"null\",\"long\"]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfNullableLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namesp" +
				"ace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"" +
				"array\",\"items\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat" +
				"\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics" +
				".Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"d" +
				"ouble\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]}" +
				",{\"type\":\"record\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Dataty" +
				"pes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"full" +
				"Name\":\"Energistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\",{\"type" +
				"\":\"record\",\"name\":\"AnySparseArray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"" +
				"fields\":[{\"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\"" +
				":\"AnySubarray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"st" +
				"art\",\"type\":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"AnyArray\",\"n" +
				"amespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"Arra" +
				"yOfBoolean\",\"ArrayOfInt\",\"ArrayOfLong\",\"ArrayOfFloat\",\"ArrayOfDouble\",\"ArrayOfSt" +
				"ring\",\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"depends\":[" +
				"\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Data" +
				"types.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDou" +
				"ble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}],\"fullName\":\"Energis" +
				"tics.Etp.v12.Datatypes.AnySubarray\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatype" +
				"s.AnyArray\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"de" +
				"pends\":[\r\n  \"Energistics.Etp.v12.Datatypes.AnySubarray\"\r\n]}]}],\"fullName\":\"Energ" +
				"istics.Etp.v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatype" +
				"s.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\r\n " +
				" \"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.A" +
				"rrayOfNullableInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energist" +
				"ics.Etp.v12.Datatypes.ArrayOfNullableLong\",\r\n  \"Energistics.Etp.v12.Datatypes.Ar" +
				"rayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.E" +
				"tp.v12.Datatypes.ArrayOfString\",\r\n  \"Energistics.Etp.v12.Datatypes.AnySparseArra" +
				"y\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.DeletedResource\",\"dep" +
				"ends\":[\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}}}],\"protocol\":\"3\",\"mess" +
				"ageType\":\"6\",\"senderRole\":\"store\",\"protocolRoles\":\"store,customer\",\"multipartFla" +
				"g\":true,\"fullName\":\"Energistics.Etp.v12.Protocol.Discovery.GetDeletedResourcesRe" +
				"sponse\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.DeletedResource\"\r\n]" +
				"}");
		private IList<Energistics.Etp.v12.Datatypes.Object.DeletedResource> _deletedResources;
		public virtual Schema Schema
		{
			get
			{
				return GetDeletedResourcesResponse._SCHEMA;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.Object.DeletedResource> DeletedResources
		{
			get
			{
				return this._deletedResources;
			}
			set
			{
				this._deletedResources = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._deletedResources;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._deletedResources = (IList<Energistics.Etp.v12.Datatypes.Object.DeletedResource>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
