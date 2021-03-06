// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.DiscoveryQuery
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class FindResources : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse("{\"type\":\"record\",\"name\":\"FindResources\",\"namespace\":\"Energistics.Etp.v12.Protocol" +
				".DiscoveryQuery\",\"fields\":[{\"name\":\"context\",\"type\":{\"type\":\"record\",\"name\":\"Con" +
				"textInfo\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"fields\":[{\"name\":\"" +
				"uri\",\"type\":\"string\"},{\"name\":\"depth\",\"type\":\"int\"},{\"name\":\"dataObjectTypes\",\"d" +
				"efault\":[],\"type\":{\"type\":\"array\",\"items\":\"string\"}},{\"name\":\"navigableEdges\",\"t" +
				"ype\":{\"type\":\"enum\",\"name\":\"RelationshipKind\",\"namespace\":\"Energistics.Etp.v12.D" +
				"atatypes.Object\",\"symbols\":[\"Primary\",\"Secondary\",\"Both\"],\"fullName\":\"Energistic" +
				"s.Etp.v12.Datatypes.Object.RelationshipKind\",\"depends\":[]}},{\"name\":\"includeSeco" +
				"ndaryTargets\",\"default\":false,\"type\":\"boolean\"},{\"name\":\"includeSecondarySources" +
				"\",\"default\":false,\"type\":\"boolean\"}],\"fullName\":\"Energistics.Etp.v12.Datatypes.O" +
				"bject.ContextInfo\",\"depends\":[\r\n  \"Energistics.Etp.v12.Datatypes.Object.Relation" +
				"shipKind\"\r\n]}},{\"name\":\"scope\",\"type\":{\"type\":\"enum\",\"name\":\"ContextScopeKind\",\"" +
				"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbols\":[\"self\",\"sources\",\"t" +
				"argets\",\"sourcesOrSelf\",\"targetsOrSelf\"],\"fullName\":\"Energistics.Etp.v12.Datatyp" +
				"es.Object.ContextScopeKind\",\"depends\":[]}},{\"name\":\"storeLastWriteFilter\",\"type\"" +
				":[\"null\",\"long\"]},{\"name\":\"activeStatusFilter\",\"type\":[\"null\",{\"type\":\"enum\",\"na" +
				"me\":\"ActiveStatusKind\",\"namespace\":\"Energistics.Etp.v12.Datatypes.Object\",\"symbo" +
				"ls\":[\"Active\",\"Inactive\"],\"fullName\":\"Energistics.Etp.v12.Datatypes.Object.Activ" +
				"eStatusKind\",\"depends\":[]}]}],\"protocol\":\"13\",\"messageType\":\"1\",\"senderRole\":\"cu" +
				"stomer\",\"protocolRoles\":\"store,customer\",\"multipartFlag\":false,\"fullName\":\"Energ" +
				"istics.Etp.v12.Protocol.DiscoveryQuery.FindResources\",\"depends\":[\r\n  \"Energistic" +
				"s.Etp.v12.Datatypes.Object.ContextInfo\",\r\n  \"Energistics.Etp.v12.Datatypes.Objec" +
				"t.ContextScopeKind\",\r\n  \"Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind\"\r" +
				"\n]}");
		private Energistics.Etp.v12.Datatypes.Object.ContextInfo _context;
		private Energistics.Etp.v12.Datatypes.Object.ContextScopeKind _scope;
		private System.Nullable<long> _storeLastWriteFilter;
		private System.Nullable<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind> _activeStatusFilter;
		public virtual Schema Schema
		{
			get
			{
				return FindResources._SCHEMA;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ContextInfo Context
		{
			get
			{
				return this._context;
			}
			set
			{
				this._context = value;
			}
		}
		public Energistics.Etp.v12.Datatypes.Object.ContextScopeKind Scope
		{
			get
			{
				return this._scope;
			}
			set
			{
				this._scope = value;
			}
		}
		public System.Nullable<long> StoreLastWriteFilter
		{
			get
			{
				return this._storeLastWriteFilter;
			}
			set
			{
				this._storeLastWriteFilter = value;
			}
		}
		public System.Nullable<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind> ActiveStatusFilter
		{
			get
			{
				return this._activeStatusFilter;
			}
			set
			{
				this._activeStatusFilter = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._context;
			case 1: return this._scope;
			case 2: return this._storeLastWriteFilter;
			case 3: return this._activeStatusFilter;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._context = (Energistics.Etp.v12.Datatypes.Object.ContextInfo)fieldValue; break;
			case 1: this._scope = (Energistics.Etp.v12.Datatypes.Object.ContextScopeKind)fieldValue; break;
			case 2: this._storeLastWriteFilter = (System.Nullable<long>)fieldValue; break;
			case 3: this._activeStatusFilter = fieldValue == null ? (System.Nullable<Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind>)null : (Energistics.Etp.v12.Datatypes.Object.ActiveStatusKind)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
