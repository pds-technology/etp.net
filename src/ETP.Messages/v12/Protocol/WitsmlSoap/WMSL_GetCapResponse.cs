// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.WitsmlSoap
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class WMSL_GetCapResponse : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""WMSL_GetCapResponse"",""namespace"":""Energistics.Etp.v12.Protocol.WitsmlSoap"",""fields"":[{""name"":""Result"",""type"":""int""},{""name"":""CapabilitiesOut"",""type"":""string""},{""name"":""SuppMsgOut"",""type"":""string""}],""messageType"":""8"",""protocol"":""8"",""senderRole"":""store"",""protocolRoles"":""store,customer"",""fullName"":""Energistics.Etp.v12.Protocol.WitsmlSoap.WMSL_GetCapResponse"",""depends"":[]}");
		private int _Result;
		private string _CapabilitiesOut;
		private string _SuppMsgOut;
		public virtual Schema Schema
		{
			get
			{
				return WMSL_GetCapResponse._SCHEMA;
			}
		}
		public int Result
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
		public string CapabilitiesOut
		{
			get
			{
				return this._CapabilitiesOut;
			}
			set
			{
				this._CapabilitiesOut = value;
			}
		}
		public string SuppMsgOut
		{
			get
			{
				return this._SuppMsgOut;
			}
			set
			{
				this._SuppMsgOut = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._Result;
			case 1: return this._CapabilitiesOut;
			case 2: return this._SuppMsgOut;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._Result = (System.Int32)fieldValue; break;
			case 1: this._CapabilitiesOut = (System.String)fieldValue; break;
			case 2: this._SuppMsgOut = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}