using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000145 RID: 325
	public sealed class PingConnectionInfoList : IMessage<PingConnectionInfoList>, IMessage, IEquatable<PingConnectionInfoList>, IDeepCloneable<PingConnectionInfoList>, IBufferMessage
	{
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x060021A2 RID: 8610 RVA: 0x0008384C File Offset: 0x00081A4C
		[DebuggerNonUserCode]
		public static MessageParser<PingConnectionInfoList> Parser
		{
			get
			{
				return PingConnectionInfoList._parser;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x060021A3 RID: 8611 RVA: 0x00083864 File Offset: 0x00081A64
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x060021A4 RID: 8612 RVA: 0x00083888 File Offset: 0x00081A88
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PingConnectionInfoList.Descriptor;
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0008389F File Offset: 0x00081A9F
		[DebuggerNonUserCode]
		public PingConnectionInfoList()
		{
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x000838B4 File Offset: 0x00081AB4
		[DebuggerNonUserCode]
		public PingConnectionInfoList(PingConnectionInfoList other)
			: this()
		{
			this.connectionInfos_ = other.connectionInfos_.Clone();
			this.trace_ = ((other.trace_ != null) ? other.trace_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00083908 File Offset: 0x00081B08
		[DebuggerNonUserCode]
		public PingConnectionInfoList Clone()
		{
			return new PingConnectionInfoList(this);
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x060021A8 RID: 8616 RVA: 0x00083920 File Offset: 0x00081B20
		[DebuggerNonUserCode]
		public RepeatedField<PingConnectionInfo> ConnectionInfos
		{
			get
			{
				return this.connectionInfos_;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x060021A9 RID: 8617 RVA: 0x00083938 File Offset: 0x00081B38
		// (set) Token: 0x060021AA RID: 8618 RVA: 0x00083950 File Offset: 0x00081B50
		[DebuggerNonUserCode]
		public Trace Trace
		{
			get
			{
				return this.trace_;
			}
			set
			{
				this.trace_ = value;
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0008395C File Offset: 0x00081B5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PingConnectionInfoList);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0008397C File Offset: 0x00081B7C
		[DebuggerNonUserCode]
		public bool Equals(PingConnectionInfoList other)
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
					bool flag4 = !this.connectionInfos_.Equals(other.connectionInfos_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Trace, other.Trace);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000839F4 File Offset: 0x00081BF4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.connectionInfos_.GetHashCode();
			bool flag = this.trace_ != null;
			if (flag)
			{
				num ^= this.Trace.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x00083A50 File Offset: 0x00081C50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x00083A68 File Offset: 0x00081C68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00083A74 File Offset: 0x00081C74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.connectionInfos_.WriteTo(ref output, PingConnectionInfoList._repeated_connectionInfos_codec);
			bool flag = this.trace_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Trace);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x00083AD8 File Offset: 0x00081CD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.connectionInfos_.CalculateSize(PingConnectionInfoList._repeated_connectionInfos_codec);
			bool flag = this.trace_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Trace);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x00083B3C File Offset: 0x00081D3C
		[DebuggerNonUserCode]
		public void MergeFrom(PingConnectionInfoList other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.connectionInfos_.Add(other.connectionInfos_);
				bool flag2 = other.trace_ != null;
				if (flag2)
				{
					bool flag3 = this.trace_ == null;
					if (flag3)
					{
						this.Trace = new Trace();
					}
					this.Trace.MergeFrom(other.Trace);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x00083BBA File Offset: 0x00081DBA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00083BC8 File Offset: 0x00081DC8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 10U)
				{
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.trace_ == null;
						if (flag)
						{
							this.Trace = new Trace();
						}
						input.ReadMessage(this.Trace);
					}
				}
				else
				{
					this.connectionInfos_.AddEntriesFrom(ref input, PingConnectionInfoList._repeated_connectionInfos_codec);
				}
			}
		}

		// Token: 0x04000EE7 RID: 3815
		private static readonly MessageParser<PingConnectionInfoList> _parser = new MessageParser<PingConnectionInfoList>(() => new PingConnectionInfoList());

		// Token: 0x04000EE8 RID: 3816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000EE9 RID: 3817
		public const int ConnectionInfosFieldNumber = 1;

		// Token: 0x04000EEA RID: 3818
		private static readonly FieldCodec<PingConnectionInfo> _repeated_connectionInfos_codec = FieldCodec.ForMessage<PingConnectionInfo>(10U, PingConnectionInfo.Parser);

		// Token: 0x04000EEB RID: 3819
		private readonly RepeatedField<PingConnectionInfo> connectionInfos_ = new RepeatedField<PingConnectionInfo>();

		// Token: 0x04000EEC RID: 3820
		public const int TraceFieldNumber = 2;

		// Token: 0x04000EED RID: 3821
		private Trace trace_;
	}
}
