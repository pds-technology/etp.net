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
	
	public partial class GetGrowingDataObjectsHeaderResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"GetGrowingDataObjectsHeaderResponse\",\"namespace\":\"Energi" +
				"stics.Etp.v12.Protocol.GrowingObject\",\"fields\":[{\"name\":\"dataObjects\",\"type\":{\"t" +
				"ype\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataObject\",\"namespace\":\"Energistic" +
				"s.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"resource\",\"type\":{\"type\":\"record\"" +
				",\"name\":\"Resource\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[" +
				"{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"alternateUris\",\"default\":[],\"type\":{\"typ" +
				"e\":\"array\",\"items\":\"string\"}},{\"name\":\"dataObjectType\",\"type\":\"string\"},{\"name\":" +
				"\"name\",\"type\":\"string\"},{\"name\":\"sourceCount\",\"default\":null,\"type\":[\"null\",\"int" +
				"\"]},{\"name\":\"targetCount\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":\"lastCha" +
				"nged\",\"type\":\"long\"},{\"name\":\"storeLastWrite\",\"type\":\"long\"},{\"name\":\"customData" +
				"\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"DataValue\"" +
				",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"n" +
				"ull\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"A" +
				"rrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"va" +
				"lues\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v1" +
				"2.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullab" +
				"leBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values" +
				"\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}],\"fullName\":\"Energistics.E" +
				"tp.v12.Datatypes.ArrayOfNullableBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"" +
				"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"value" +
				"s\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12.Datat" +
				"ypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableInt\",\"nam" +
				"espace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type" +
				"\":\"array\",\"items\":[\"null\",\"int\"]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Ar" +
				"rayOfNullableInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"namespace" +
				"\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"arr" +
				"ay\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"de" +
				"pends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableLong\",\"namespace\":\"Energistic" +
				"s.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":[" +
				"\"null\",\"long\"]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfNullableLong\"" +
				",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energistics.E" +
				"tp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"flo" +
				"at\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"t" +
				"ype\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Datatypes\"" +
				",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName" +
				"\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type\":\"record\",\"" +
				"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"na" +
				"me\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Energistics." +
				"Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\",{\"type\":\"record\",\"name\":\"" +
				"AnySparseArray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"s" +
				"lices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"AnySubarray\",\"nam" +
				"espace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"start\",\"type\":\"long\"}" +
				",{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"AnyArray\",\"namespace\":\"Energist" +
				"ics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"ArrayOfBoolean\",\"ArrayO" +
				"fInt\",\"ArrayOfLong\",\"ArrayOfFloat\",\"ArrayOfDouble\",\"ArrayOfString\",\"bytes\"]}],\"f" +
				"ullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"depends\":[\r\n  \"Energistics.Et" +
				"p.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r" +
				"\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12.Datatype" +
				"s.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}],\"fullName\":\"Energistics.Etp.v12.Dataty" +
				"pes.AnySubarray\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.AnyArray\"\r\n]}}}]," +
				"\"fullName\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"depends\":[\r\n  \"Energi" +
				"stics.Etp.v12.Datatypes.AnySubarray\"\r\n]}]}],\"fullName\":\"Energistics.Etp.v12.Data" +
				"types.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r" +
				"\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\r\n  \"Energistics.Etp.v" +
				"12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableInt\"," +
				"\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12.Datatyp" +
				"es.ArrayOfNullableLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes.Ar" +
				"rayOfString\",\r\n  \"Energistics.Etp.v12.Datatypes.AnySparseArray\"\r\n]}}}],\"fullName" +
				"\":\"Energistics.Etp.v12.Datatypes.Object.Resource\",\"depends\":[\r\n  \"Energistics.Et" +
				"p.v12.Datatypes.DataValue\"\r\n]}},{\"name\":\"format\",\"default\":\"xml\",\"type\":\"string\"" +
				"},{\"name\":\"blobId\",\"type\":[\"null\",{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespace\":\"Ene" +
				"rgistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Datatypes." +
				"Uuid\",\"depends\":[]}]},{\"name\":\"data\",\"default\":\"\",\"type\":\"bytes\"}],\"fullName\":\"E" +
				"nergistics.Etp.v12.Datatypes.Object.DataObject\",\"depends\":[\r\n  \"Energistics.Etp." +
				"v12.Datatypes.Object.Resource\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r\n]}}}],\"" +
				"protocol\":\"6\",\"messageType\":\"15\",\"senderRole\":\"store\",\"protocolRoles\":\"store,cus" +
				"tomer\",\"multipartFlag\":true,\"fullName\":\"Energistics.Etp.v12.Protocol.GrowingObje" +
				"ct.GetGrowingDataObjectsHeaderResponse\",\"depends\":[\r\n  \"Energistics.Etp.v12.Data" +
				"types.Object.DataObject\"\r\n]}");
		private IDictionary<string,Energistics.Etp.v12.Datatypes.Object.DataObject> _dataObjects;
		public virtual Schema Schema
		{
			get
			{
				return GetGrowingDataObjectsHeaderResponse._SCHEMA;
			}
		}
		public IDictionary<string,Energistics.Etp.v12.Datatypes.Object.DataObject> DataObjects
		{
			get
			{
				return this._dataObjects;
			}
			set
			{
				this._dataObjects = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._dataObjects;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._dataObjects = (IDictionary<string,Energistics.Etp.v12.Datatypes.Object.DataObject>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}