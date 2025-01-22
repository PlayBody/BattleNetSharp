using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Publication.V2.Client
{
	// Token: 0x02000596 RID: 1430
	public sealed class Filter : IMessage<Filter>, IMessage, IEquatable<Filter>, IDeepCloneable<Filter>, IBufferMessage
	{
		// Token: 0x17002AF5 RID: 10997
		// (get) Token: 0x06008876 RID: 34934 RVA: 0x002124BC File Offset: 0x002106BC
		[DebuggerNonUserCode]
		public static MessageParser<Filter> Parser
		{
			get
			{
				return Filter._parser;
			}
		}

		// Token: 0x17002AF6 RID: 10998
		// (get) Token: 0x06008877 RID: 34935 RVA: 0x002124D4 File Offset: 0x002106D4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return PublicationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002AF7 RID: 10999
		// (get) Token: 0x06008878 RID: 34936 RVA: 0x002124F8 File Offset: 0x002106F8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Filter.Descriptor;
			}
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0021250F File Offset: 0x0021070F
		[DebuggerNonUserCode]
		public Filter()
		{
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x00212519 File Offset: 0x00210719
		[DebuggerNonUserCode]
		public Filter(Filter other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.titleId_ = other.titleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0021254C File Offset: 0x0021074C
		[DebuggerNonUserCode]
		public Filter Clone()
		{
			return new Filter(this);
		}

		// Token: 0x17002AF8 RID: 11000
		// (get) Token: 0x0600887C RID: 34940 RVA: 0x00212564 File Offset: 0x00210764
		// (set) Token: 0x0600887D RID: 34941 RVA: 0x00212595 File Offset: 0x00210795
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint titleIdDefaultValue;
				if (flag)
				{
					titleIdDefaultValue = this.titleId_;
				}
				else
				{
					titleIdDefaultValue = Filter.TitleIdDefaultValue;
				}
				return titleIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.titleId_ = value;
			}
		}

		// Token: 0x17002AF9 RID: 11001
		// (get) Token: 0x0600887E RID: 34942 RVA: 0x002125B0 File Offset: 0x002107B0
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600887F RID: 34943 RVA: 0x002125CD File Offset: 0x002107CD
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008880 RID: 34944 RVA: 0x002125E0 File Offset: 0x002107E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Filter);
		}

		// Token: 0x06008881 RID: 34945 RVA: 0x00212600 File Offset: 0x00210800
		[DebuggerNonUserCode]
		public bool Equals(Filter other)
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
					bool flag4 = this.TitleId != other.TitleId;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06008882 RID: 34946 RVA: 0x00212658 File Offset: 0x00210858
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008883 RID: 34947 RVA: 0x002126A8 File Offset: 0x002108A8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008884 RID: 34948 RVA: 0x002126C0 File Offset: 0x002108C0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x002126CC File Offset: 0x002108CC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x00212718 File Offset: 0x00210918
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x00212768 File Offset: 0x00210968
		[DebuggerNonUserCode]
		public void MergeFrom(Filter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTitleId = other.HasTitleId;
				if (hasTitleId)
				{
					this.TitleId = other.TitleId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008888 RID: 34952 RVA: 0x002127B1 File Offset: 0x002109B1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x002127BC File Offset: 0x002109BC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.TitleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003DCF RID: 15823
		private static readonly MessageParser<Filter> _parser = new MessageParser<Filter>(() => new Filter());

		// Token: 0x04003DD0 RID: 15824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003DD1 RID: 15825
		private int _hasBits0;

		// Token: 0x04003DD2 RID: 15826
		public const int TitleIdFieldNumber = 1;

		// Token: 0x04003DD3 RID: 15827
		private static readonly uint TitleIdDefaultValue = 0U;

		// Token: 0x04003DD4 RID: 15828
		private uint titleId_;
	}
}
