// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Datatypes.Object
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ObjectChange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ObjectChange\",\"namespace\":\"Energistics.Etp.v12.Datatypes" +
				".Object\",\"fields\":[{\"name\":\"changeKind\",\"type\":{\"type\":\"enum\",\"name\":\"ObjectChan" +
				"geKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"insert\",\"" +
				"update\",\"authorized\",\"joined\",\"unjoined\"],\"fullName\":\"Energistics.Etp.v12.Dataty" +
				"pes.Object.ObjectChangeKind\",\"depends\":[]}},{\"name\":\"changeTime\",\"type\":\"long\"}," +
				"{\"name\":\"dataObject\",\"type\":{\"type\":\"record\",\"name\":\"DataObject\",\"namespace\":\"En" +
				"ergistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"resource\",\"type\":{\"type\":" +
				"\"record\",\"name\":\"Resource\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"f" +
				"ields\":[{\"name\":\"uri\",\"type\":\"string\"},{\"name\":\"alternateUris\",\"default\":[],\"typ" +
				"e\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"dataObjectType\",\"type\":\"string\"}," +
				"{\"name\":\"name\",\"type\":\"string\"},{\"name\":\"sourceCount\",\"default\":null,\"type\":[\"nu" +
				"ll\",\"int\"]},{\"name\":\"targetCount\",\"default\":null,\"type\":[\"null\",\"int\"]},{\"name\":" +
				"\"lastChanged\",\"type\":\"long\"},{\"name\":\"storeLastWrite\",\"type\":\"long\"},{\"name\":\"cu" +
				"stomData\",\"default\":{},\"type\":{\"type\":\"map\",\"values\":{\"type\":\"record\",\"name\":\"Da" +
				"taValue\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"t" +
				"ype\":[\"null\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"" +
				"name\":\"ArrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"n" +
				"ame\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistic" +
				"s.Etp.v12.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"Array" +
				"OfNullableBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\"" +
				":\"values\",\"type\":{\"type\":\"array\",\"items\":[\"null\",\"boolean\"]}}],\"fullName\":\"Energ" +
				"istics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\"depends\":[]},{\"type\":\"record\"," +
				"\"name\":\"ArrayOfInt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name" +
				"\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v" +
				"12.Datatypes.ArrayOfInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableI" +
				"nt\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type" +
				"\":{\"type\":\"array\",\"items\":[\"null\",\"int\"]}}],\"fullName\":\"Energistics.Etp.v12.Data" +
				"types.ArrayOfNullableInt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"n" +
				"amespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"ty" +
				"pe\":\"array\",\"items\":\"long\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfL" +
				"ong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfNullableLong\",\"namespace\":\"En" +
				"ergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"" +
				"items\":[\"null\",\"long\"]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfNulla" +
				"bleLong\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energ" +
				"istics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"ite" +
				"ms\":\"float\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depends\"" +
				":[]},{\"type\":\"record\",\"name\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Da" +
				"tatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"" +
				"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type\":\"r" +
				"ecord\",\"name\":\"ArrayOfString\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"field" +
				"s\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Ener" +
				"gistics.Etp.v12.Datatypes.ArrayOfString\",\"depends\":[]},\"bytes\",{\"type\":\"record\"," +
				"\"name\":\"AnySparseArray\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"" +
				"name\":\"slices\",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"AnySubarr" +
				"ay\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"start\",\"type\"" +
				":\"long\"},{\"name\":\"slice\",\"type\":{\"type\":\"record\",\"name\":\"AnyArray\",\"namespace\":\"" +
				"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"ArrayOfBoolean\"" +
				",\"ArrayOfInt\",\"ArrayOfLong\",\"ArrayOfFloat\",\"ArrayOfDouble\",\"ArrayOfString\",\"byte" +
				"s\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnyArray\",\"depends\":[\r\n  \"Energi" +
				"stics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"Energistics.Etp.v12.Datatypes.Array" +
				"OfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12." +
				"Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"E" +
				"nergistics.Etp.v12.Datatypes.ArrayOfString\"\r\n]}}],\"fullName\":\"Energistics.Etp.v1" +
				"2.Datatypes.AnySubarray\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.AnyArray\"" +
				"\r\n]}}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.AnySparseArray\",\"depends\":[\r\n " +
				" \"Energistics.Etp.v12.Datatypes.AnySubarray\"\r\n]}]}],\"fullName\":\"Energistics.Etp." +
				"v12.Datatypes.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBo" +
				"olean\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNullableBoolean\",\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfNulla" +
				"bleInt\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\r\n  \"Energistics.Etp.v12" +
				".Datatypes.ArrayOfNullableLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\"" +
				",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Data" +
				"types.ArrayOfString\",\r\n  \"Energistics.Etp.v12.Datatypes.AnySparseArray\"\r\n]}}}],\"" +
				"fullName\":\"Energistics.Etp.v12.Datatypes.Object.Resource\",\"depends\":[\r\n  \"Energi" +
				"stics.Etp.v12.Datatypes.DataValue\"\r\n]}},{\"name\":\"format\",\"default\":\"xml\",\"type\":" +
				"\"string\"},{\"name\":\"blobId\",\"type\":[\"null\",{\"type\":\"fixed\",\"name\":\"Uuid\",\"namespa" +
				"ce\":\"Energistics.Etp.v12.Datatypes\",\"size\":16,\"fullName\":\"Energistics.Etp.v12.Da" +
				"tatypes.Uuid\",\"depends\":[]}]},{\"name\":\"data\",\"default\":\"\",\"type\":\"bytes\"}],\"full" +
				"Name\":\"Energistics.Etp.v12.Datatypes.Object.DataObject\",\"depends\":[\r\n  \"Energist" +
				"ics.Etp.v12.Datatypes.Object.Resource\",\r\n  \"Energistics.Etp.v12.Datatypes.Uuid\"\r" +
				"\n]}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.ObjectChange\",\"depends\":[" +
				"\r\n  \"Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind\",\r\n  \"Energistics.Etp" +
				".v12.Datatypes.Object.DataObject\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind _changeKind;
		private long _changeTime;
		private Energistics.Etp.v12.Datatypes.Object.DataObject _dataObject;
		public virtual Schema Schema
		{
			get
			{
				return ObjectChange._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind ChangeKind
		{
			get
			{
				return this._changeKind;
			}
			set
			{
				this._changeKind = value;
			}
		}
		public long ChangeTime
		{
			get
			{
				return this._changeTime;
			}
			set
			{
				this._changeTime = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.DataObject DataObject
		{
			get
			{
				return this._dataObject;
			}
			set
			{
				this._dataObject = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._changeKind;
			case 1: return this._changeTime;
			case 2: return this._dataObject;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._changeKind = (Energistics.Etp.v12.Datatypes.Object.ObjectChangeKind)fieldValue; break;
			case 1: this._changeTime = (System.Int64)fieldValue; break;
			case 2: this._dataObject = (Energistics.Etp.v12.Datatypes.Object.DataObject)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
