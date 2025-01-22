using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Blizzard.Telemetry
{
	// Token: 0x020002E3 RID: 739
	public sealed class FieldOptions : IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>, IBufferMessage
	{
		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x0012A3D4 File Offset: 0x001285D4
		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser
		{
			get
			{
				return FieldOptions._parser;
			}
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06004DF7 RID: 19959 RVA: 0x0012A3EC File Offset: 0x001285EC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TelemetryExtensionsReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x0012A410 File Offset: 0x00128610
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FieldOptions.Descriptor;
			}
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x0012A427 File Offset: 0x00128627
		[DebuggerNonUserCode]
		public FieldOptions()
		{
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x0012A434 File Offset: 0x00128634
		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.mappedType_ = other.mappedType_;
			this.elasticAnalyzer_ = other.elasticAnalyzer_;
			this.realtime_ = other.realtime_;
			this.elasticPathMove_ = other.elasticPathMove_;
			this.crmFieldName_ = other.crmFieldName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x0012A4A4 File Offset: 0x001286A4
		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return new FieldOptions(this);
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x0012A4BC File Offset: 0x001286BC
		// (set) Token: 0x06004DFD RID: 19965 RVA: 0x0012A4DD File Offset: 0x001286DD
		[DebuggerNonUserCode]
		public string MappedType
		{
			get
			{
				return this.mappedType_ ?? FieldOptions.MappedTypeDefaultValue;
			}
			set
			{
				this.mappedType_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x0012A4F4 File Offset: 0x001286F4
		[DebuggerNonUserCode]
		public bool HasMappedType
		{
			get
			{
				return this.mappedType_ != null;
			}
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x0012A50F File Offset: 0x0012870F
		[DebuggerNonUserCode]
		public void ClearMappedType()
		{
			this.mappedType_ = null;
		}

		// Token: 0x170018C1 RID: 6337
		// (get) Token: 0x06004E00 RID: 19968 RVA: 0x0012A51C File Offset: 0x0012871C
		// (set) Token: 0x06004E01 RID: 19969 RVA: 0x0012A53D File Offset: 0x0012873D
		[DebuggerNonUserCode]
		public string ElasticAnalyzer
		{
			get
			{
				return this.elasticAnalyzer_ ?? FieldOptions.ElasticAnalyzerDefaultValue;
			}
			set
			{
				this.elasticAnalyzer_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018C2 RID: 6338
		// (get) Token: 0x06004E02 RID: 19970 RVA: 0x0012A554 File Offset: 0x00128754
		[DebuggerNonUserCode]
		public bool HasElasticAnalyzer
		{
			get
			{
				return this.elasticAnalyzer_ != null;
			}
		}

		// Token: 0x06004E03 RID: 19971 RVA: 0x0012A56F File Offset: 0x0012876F
		[DebuggerNonUserCode]
		public void ClearElasticAnalyzer()
		{
			this.elasticAnalyzer_ = null;
		}

		// Token: 0x170018C3 RID: 6339
		// (get) Token: 0x06004E04 RID: 19972 RVA: 0x0012A57C File Offset: 0x0012877C
		// (set) Token: 0x06004E05 RID: 19973 RVA: 0x0012A5AD File Offset: 0x001287AD
		[DebuggerNonUserCode]
		public bool Realtime
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool realtimeDefaultValue;
				if (flag)
				{
					realtimeDefaultValue = this.realtime_;
				}
				else
				{
					realtimeDefaultValue = FieldOptions.RealtimeDefaultValue;
				}
				return realtimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.realtime_ = value;
			}
		}

		// Token: 0x170018C4 RID: 6340
		// (get) Token: 0x06004E06 RID: 19974 RVA: 0x0012A5C8 File Offset: 0x001287C8
		[DebuggerNonUserCode]
		public bool HasRealtime
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004E07 RID: 19975 RVA: 0x0012A5E5 File Offset: 0x001287E5
		[DebuggerNonUserCode]
		public void ClearRealtime()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170018C5 RID: 6341
		// (get) Token: 0x06004E08 RID: 19976 RVA: 0x0012A5F8 File Offset: 0x001287F8
		// (set) Token: 0x06004E09 RID: 19977 RVA: 0x0012A619 File Offset: 0x00128819
		[DebuggerNonUserCode]
		public string ElasticPathMove
		{
			get
			{
				return this.elasticPathMove_ ?? FieldOptions.ElasticPathMoveDefaultValue;
			}
			set
			{
				this.elasticPathMove_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018C6 RID: 6342
		// (get) Token: 0x06004E0A RID: 19978 RVA: 0x0012A630 File Offset: 0x00128830
		[DebuggerNonUserCode]
		public bool HasElasticPathMove
		{
			get
			{
				return this.elasticPathMove_ != null;
			}
		}

		// Token: 0x06004E0B RID: 19979 RVA: 0x0012A64B File Offset: 0x0012884B
		[DebuggerNonUserCode]
		public void ClearElasticPathMove()
		{
			this.elasticPathMove_ = null;
		}

		// Token: 0x170018C7 RID: 6343
		// (get) Token: 0x06004E0C RID: 19980 RVA: 0x0012A658 File Offset: 0x00128858
		// (set) Token: 0x06004E0D RID: 19981 RVA: 0x0012A679 File Offset: 0x00128879
		[DebuggerNonUserCode]
		public string CrmFieldName
		{
			get
			{
				return this.crmFieldName_ ?? FieldOptions.CrmFieldNameDefaultValue;
			}
			set
			{
				this.crmFieldName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170018C8 RID: 6344
		// (get) Token: 0x06004E0E RID: 19982 RVA: 0x0012A690 File Offset: 0x00128890
		[DebuggerNonUserCode]
		public bool HasCrmFieldName
		{
			get
			{
				return this.crmFieldName_ != null;
			}
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x0012A6AB File Offset: 0x001288AB
		[DebuggerNonUserCode]
		public void ClearCrmFieldName()
		{
			this.crmFieldName_ = null;
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x0012A6B8 File Offset: 0x001288B8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as FieldOptions);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x0012A6D8 File Offset: 0x001288D8
		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
		{
			bool flag = other == null;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = other == this;
				if (flag3)
				{
					flag2 = true;
				}
				else
				{
					bool flag4 = this.MappedType != other.MappedType;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ElasticAnalyzer != other.ElasticAnalyzer;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Realtime != other.Realtime;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.ElasticPathMove != other.ElasticPathMove;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.CrmFieldName != other.CrmFieldName;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004E12 RID: 19986 RVA: 0x0012A7A4 File Offset: 0x001289A4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMappedType = this.HasMappedType;
			if (hasMappedType)
			{
				num ^= this.MappedType.GetHashCode();
			}
			bool hasElasticAnalyzer = this.HasElasticAnalyzer;
			if (hasElasticAnalyzer)
			{
				num ^= this.ElasticAnalyzer.GetHashCode();
			}
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				num ^= this.Realtime.GetHashCode();
			}
			bool hasElasticPathMove = this.HasElasticPathMove;
			if (hasElasticPathMove)
			{
				num ^= this.ElasticPathMove.GetHashCode();
			}
			bool hasCrmFieldName = this.HasCrmFieldName;
			if (hasCrmFieldName)
			{
				num ^= this.CrmFieldName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004E13 RID: 19987 RVA: 0x0012A85C File Offset: 0x00128A5C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004E14 RID: 19988 RVA: 0x0012A874 File Offset: 0x00128A74
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E15 RID: 19989 RVA: 0x0012A880 File Offset: 0x00128A80
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMappedType = this.HasMappedType;
			if (hasMappedType)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MappedType);
			}
			bool hasElasticAnalyzer = this.HasElasticAnalyzer;
			if (hasElasticAnalyzer)
			{
				output.WriteRawTag(162, 6);
				output.WriteString(this.ElasticAnalyzer);
			}
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				output.WriteRawTag(192, 12);
				output.WriteBool(this.Realtime);
			}
			bool hasElasticPathMove = this.HasElasticPathMove;
			if (hasElasticPathMove)
			{
				output.WriteRawTag(226, 18);
				output.WriteString(this.ElasticPathMove);
			}
			bool hasCrmFieldName = this.HasCrmFieldName;
			if (hasCrmFieldName)
			{
				output.WriteRawTag(130, 25);
				output.WriteString(this.CrmFieldName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x0012A96C File Offset: 0x00128B6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMappedType = this.HasMappedType;
			if (hasMappedType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MappedType);
			}
			bool hasElasticAnalyzer = this.HasElasticAnalyzer;
			if (hasElasticAnalyzer)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ElasticAnalyzer);
			}
			bool hasRealtime = this.HasRealtime;
			if (hasRealtime)
			{
				num += 3;
			}
			bool hasElasticPathMove = this.HasElasticPathMove;
			if (hasElasticPathMove)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.ElasticPathMove);
			}
			bool hasCrmFieldName = this.HasCrmFieldName;
			if (hasCrmFieldName)
			{
				num += 2 + CodedOutputStream.ComputeStringSize(this.CrmFieldName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004E17 RID: 19991 RVA: 0x0012AA28 File Offset: 0x00128C28
		[DebuggerNonUserCode]
		public void MergeFrom(FieldOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMappedType = other.HasMappedType;
				if (hasMappedType)
				{
					this.MappedType = other.MappedType;
				}
				bool hasElasticAnalyzer = other.HasElasticAnalyzer;
				if (hasElasticAnalyzer)
				{
					this.ElasticAnalyzer = other.ElasticAnalyzer;
				}
				bool hasRealtime = other.HasRealtime;
				if (hasRealtime)
				{
					this.Realtime = other.Realtime;
				}
				bool hasElasticPathMove = other.HasElasticPathMove;
				if (hasElasticPathMove)
				{
					this.ElasticPathMove = other.ElasticPathMove;
				}
				bool hasCrmFieldName = other.HasCrmFieldName;
				if (hasCrmFieldName)
				{
					this.CrmFieldName = other.CrmFieldName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004E18 RID: 19992 RVA: 0x0012AADC File Offset: 0x00128CDC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E19 RID: 19993 RVA: 0x0012AAE8 File Offset: 0x00128CE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 802U)
				{
					if (num3 != 10U)
					{
						if (num3 != 802U)
						{
							goto IL_0042;
						}
						this.ElasticAnalyzer = input.ReadString();
					}
					else
					{
						this.MappedType = input.ReadString();
					}
				}
				else if (num3 != 1600U)
				{
					if (num3 != 2402U)
					{
						if (num3 != 3202U)
						{
							goto IL_0042;
						}
						this.CrmFieldName = input.ReadString();
					}
					else
					{
						this.ElasticPathMove = input.ReadString();
					}
				}
				else
				{
					this.Realtime = input.ReadBool();
				}
				continue;
				IL_0042:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040022C5 RID: 8901
		private static readonly MessageParser<FieldOptions> _parser = new MessageParser<FieldOptions>(() => new FieldOptions());

		// Token: 0x040022C6 RID: 8902
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022C7 RID: 8903
		private int _hasBits0;

		// Token: 0x040022C8 RID: 8904
		public const int MappedTypeFieldNumber = 1;

		// Token: 0x040022C9 RID: 8905
		private static readonly string MappedTypeDefaultValue = "";

		// Token: 0x040022CA RID: 8906
		private string mappedType_;

		// Token: 0x040022CB RID: 8907
		public const int ElasticAnalyzerFieldNumber = 100;

		// Token: 0x040022CC RID: 8908
		private static readonly string ElasticAnalyzerDefaultValue = "";

		// Token: 0x040022CD RID: 8909
		private string elasticAnalyzer_;

		// Token: 0x040022CE RID: 8910
		public const int RealtimeFieldNumber = 200;

		// Token: 0x040022CF RID: 8911
		private static readonly bool RealtimeDefaultValue = false;

		// Token: 0x040022D0 RID: 8912
		private bool realtime_;

		// Token: 0x040022D1 RID: 8913
		public const int ElasticPathMoveFieldNumber = 300;

		// Token: 0x040022D2 RID: 8914
		private static readonly string ElasticPathMoveDefaultValue = "";

		// Token: 0x040022D3 RID: 8915
		private string elasticPathMove_;

		// Token: 0x040022D4 RID: 8916
		public const int CrmFieldNameFieldNumber = 400;

		// Token: 0x040022D5 RID: 8917
		private static readonly string CrmFieldNameDefaultValue = "";

		// Token: 0x040022D6 RID: 8918
		private string crmFieldName_;
	}
}
