using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x02000685 RID: 1669
	public sealed class ChannelId : IMessage<ChannelId>, IMessage, IEquatable<ChannelId>, IDeepCloneable<ChannelId>, IBufferMessage
	{
		// Token: 0x17003022 RID: 12322
		// (get) Token: 0x06009AC7 RID: 39623 RVA: 0x00259F64 File Offset: 0x00258164
		[DebuggerNonUserCode]
		public static MessageParser<ChannelId> Parser
		{
			get
			{
				return ChannelId._parser;
			}
		}

		// Token: 0x17003023 RID: 12323
		// (get) Token: 0x06009AC8 RID: 39624 RVA: 0x00259F7C File Offset: 0x0025817C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ChannelTypesReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17003024 RID: 12324
		// (get) Token: 0x06009AC9 RID: 39625 RVA: 0x00259FA0 File Offset: 0x002581A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChannelId.Descriptor;
			}
		}

		// Token: 0x06009ACA RID: 39626 RVA: 0x00259FB7 File Offset: 0x002581B7
		[DebuggerNonUserCode]
		public ChannelId()
		{
		}

		// Token: 0x06009ACB RID: 39627 RVA: 0x00259FC4 File Offset: 0x002581C4
		[DebuggerNonUserCode]
		public ChannelId(ChannelId other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ACC RID: 39628 RVA: 0x0025A020 File Offset: 0x00258220
		[DebuggerNonUserCode]
		public ChannelId Clone()
		{
			return new ChannelId(this);
		}

		// Token: 0x17003025 RID: 12325
		// (get) Token: 0x06009ACD RID: 39629 RVA: 0x0025A038 File Offset: 0x00258238
		// (set) Token: 0x06009ACE RID: 39630 RVA: 0x0025A050 File Offset: 0x00258250
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x17003026 RID: 12326
		// (get) Token: 0x06009ACF RID: 39631 RVA: 0x0025A05C File Offset: 0x0025825C
		// (set) Token: 0x06009AD0 RID: 39632 RVA: 0x0025A08D File Offset: 0x0025828D
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = ChannelId.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17003027 RID: 12327
		// (get) Token: 0x06009AD1 RID: 39633 RVA: 0x0025A0A8 File Offset: 0x002582A8
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009AD2 RID: 39634 RVA: 0x0025A0C5 File Offset: 0x002582C5
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009AD3 RID: 39635 RVA: 0x0025A0D8 File Offset: 0x002582D8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChannelId);
		}

		// Token: 0x06009AD4 RID: 39636 RVA: 0x0025A0F8 File Offset: 0x002582F8
		[DebuggerNonUserCode]
		public bool Equals(ChannelId other)
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
					bool flag4 = !object.Equals(this.Host, other.Host);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009AD5 RID: 39637 RVA: 0x0025A16C File Offset: 0x0025836C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AD6 RID: 39638 RVA: 0x0025A1D8 File Offset: 0x002583D8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009AD7 RID: 39639 RVA: 0x0025A1F0 File Offset: 0x002583F0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AD8 RID: 39640 RVA: 0x0025A1FC File Offset: 0x002583FC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Host);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Id);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AD9 RID: 39641 RVA: 0x0025A270 File Offset: 0x00258470
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 5;
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009ADA RID: 39642 RVA: 0x0025A2D4 File Offset: 0x002584D4
		[DebuggerNonUserCode]
		public void MergeFrom(ChannelId other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x0025A359 File Offset: 0x00258559
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x0025A364 File Offset: 0x00258564
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					if (num3 != 29U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadFixed32();
					}
				}
				else
				{
					bool flag = this.host_ == null;
					if (flag)
					{
						this.Host = new ProcessId();
					}
					input.ReadMessage(this.Host);
				}
			}
		}

		// Token: 0x040045DA RID: 17882
		private static readonly MessageParser<ChannelId> _parser = new MessageParser<ChannelId>(() => new ChannelId());

		// Token: 0x040045DB RID: 17883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045DC RID: 17884
		private int _hasBits0;

		// Token: 0x040045DD RID: 17885
		public const int HostFieldNumber = 2;

		// Token: 0x040045DE RID: 17886
		private ProcessId host_;

		// Token: 0x040045DF RID: 17887
		public const int IdFieldNumber = 3;

		// Token: 0x040045E0 RID: 17888
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x040045E1 RID: 17889
		private uint id_;
	}
}
