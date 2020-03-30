// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelDataLoad
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ReplaceRange : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"ReplaceRange\",\"namespace\":\"Energistics.Etp.v12.Protocol." +
				"ChannelDataLoad\",\"fields\":[{\"name\":\"changedInterval\",\"type\":{\"type\":\"record\",\"na" +
				"me\":\"IndexInterval\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":" +
				"[{\"name\":\"startIndex\",\"type\":{\"type\":\"record\",\"name\":\"IndexValue\",\"namespace\":\"E" +
				"nergistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"null\",\"long\",\"do" +
				"uble\"]}],\"fullName\":\"Energistics.Etp.v12.Datatypes.IndexValue\",\"depends\":[]}},{\"" +
				"name\":\"endIndex\",\"type\":\"Energistics.Etp.v12.Datatypes.IndexValue\"},{\"name\":\"uom" +
				"\",\"type\":\"string\"},{\"name\":\"depthDatum\",\"default\":\"\",\"type\":\"string\"}],\"fullName" +
				"\":\"Energistics.Etp.v12.Datatypes.Object.IndexInterval\",\"depends\":[\r\n  \"Energisti" +
				"cs.Etp.v12.Datatypes.IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.IndexValue\"\r" +
				"\n]}},{\"name\":\"channelIds\",\"type\":{\"type\":\"array\",\"items\":\"long\"}},{\"name\":\"data\"" +
				",\"type\":{\"type\":\"array\",\"items\":{\"type\":\"record\",\"name\":\"DataItem\",\"namespace\":\"" +
				"Energistics.Etp.v12.Datatypes.ChannelData\",\"fields\":[{\"name\":\"channelId\",\"type\":" +
				"\"long\"},{\"name\":\"indexes\",\"type\":{\"type\":\"array\",\"items\":\"Energistics.Etp.v12.Da" +
				"tatypes.IndexValue\"}},{\"name\":\"value\",\"type\":{\"type\":\"record\",\"name\":\"DataValue\"" +
				",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"item\",\"type\":[\"n" +
				"ull\",\"boolean\",\"int\",\"long\",\"float\",\"double\",\"string\",{\"type\":\"record\",\"name\":\"A" +
				"rrayOfBoolean\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"va" +
				"lues\",\"type\":{\"type\":\"array\",\"items\":\"boolean\"}}],\"fullName\":\"Energistics.Etp.v1" +
				"2.Datatypes.ArrayOfBoolean\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfInt\",\"" +
				"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"t" +
				"ype\":\"array\",\"items\":\"int\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfI" +
				"nt\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfLong\",\"namespace\":\"Energistics" +
				".Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"l" +
				"ong\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes.ArrayOfLong\",\"depends\":[]},{\"t" +
				"ype\":\"record\",\"name\":\"ArrayOfFloat\",\"namespace\":\"Energistics.Etp.v12.Datatypes\"," +
				"\"fields\":[{\"name\":\"values\",\"type\":{\"type\":\"array\",\"items\":\"float\"}}],\"fullName\":" +
				"\"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\"depends\":[]},{\"type\":\"record\",\"nam" +
				"e\":\"ArrayOfDouble\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\"" +
				":\"values\",\"type\":{\"type\":\"array\",\"items\":\"double\"}}],\"fullName\":\"Energistics.Etp" +
				".v12.Datatypes.ArrayOfDouble\",\"depends\":[]},{\"type\":\"record\",\"name\":\"ArrayOfStri" +
				"ng\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"fields\":[{\"name\":\"values\",\"type" +
				"\":{\"type\":\"array\",\"items\":\"string\"}}],\"fullName\":\"Energistics.Etp.v12.Datatypes." +
				"ArrayOfString\",\"depends\":[]},\"bytes\"]}],\"fullName\":\"Energistics.Etp.v12.Datatype" +
				"s.DataValue\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfBoolean\",\r\n  \"" +
				"Energistics.Etp.v12.Datatypes.ArrayOfInt\",\r\n  \"Energistics.Etp.v12.Datatypes.Arr" +
				"ayOfLong\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfFloat\",\r\n  \"Energistics.Etp." +
				"v12.Datatypes.ArrayOfDouble\",\r\n  \"Energistics.Etp.v12.Datatypes.ArrayOfString\"\r\n" +
				"]}},{\"name\":\"valueAttributes\",\"default\":[],\"type\":{\"type\":\"array\",\"items\":{\"type" +
				"\":\"record\",\"name\":\"DataAttribute\",\"namespace\":\"Energistics.Etp.v12.Datatypes\",\"f" +
				"ields\":[{\"name\":\"attributeId\",\"type\":\"int\"},{\"name\":\"attributeValue\",\"type\":\"Dat" +
				"aValue\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.DataAttribute\",\"depends\":[\r\n" +
				"  \"Energistics.Etp.v12.Datatypes.DataValue\"\r\n]}}}],\"fullName\":\"Energistics.Etp.v" +
				"12.Datatypes.ChannelData.DataItem\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes" +
				".IndexValue\",\r\n  \"Energistics.Etp.v12.Datatypes.DataValue\",\r\n  \"Energistics.Etp." +
				"v12.Datatypes.DataAttribute\"\r\n]}}}],\"protocol\":\"22\",\"messageType\":\"6\",\"senderRol" +
				"e\":\"producer\",\"protocolRoles\":\"producer,consumer\",\"multipartFlag\":true,\"fullName" +
				"\":\"Energistics.Etp.v12.Protocol.ChannelDataLoad.ReplaceRange\",\"depends\":[\r\n  \"En" +
				"ergistics.Etp.v12.Datatypes.Object.IndexInterval\",\r\n  \"Energistics.Etp.v12.Datat" +
				"ypes.ChannelData.DataItem\"\r\n]}");
		private Energistics.Etp.v12.Datatypes.Object.IndexInterval _changedInterval;
		private IList<System.Int64> _channelIds;
		private IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> _data;
		public virtual Schema Schema
		{
			get
			{
				return ReplaceRange._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.IndexInterval ChangedInterval
		{
			get
			{
				return this._changedInterval;
			}
			set
			{
				this._changedInterval = value;
			}
		}
		public IList<System.Int64> ChannelIds
		{
			get
			{
				return this._channelIds;
			}
			set
			{
				this._channelIds = value;
			}
		}
		public IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem> Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._changedInterval;
			case 1: return this._channelIds;
			case 2: return this._data;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._changedInterval = (Energistics.Etp.v12.Datatypes.Object.IndexInterval)fieldValue; break;
			case 1: this._channelIds = (IList<System.Int64>)fieldValue; break;
			case 2: this._data = (IList<Energistics.Etp.v12.Datatypes.ChannelData.DataItem>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}