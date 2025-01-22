using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000711 RID: 1809
	public sealed class ResolveAccountResponse : IMessage<ResolveAccountResponse>, IMessage, IEquatable<ResolveAccountResponse>, IDeepCloneable<ResolveAccountResponse>, IBufferMessage
	{
		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A5CF RID: 42447 RVA: 0x00286270 File Offset: 0x00284470
		[DebuggerNonUserCode]
		public static MessageParser<ResolveAccountResponse> Parser
		{
			get
			{
				return ResolveAccountResponse._parser;
			}
		}

		// Token: 0x17003339 RID: 13113
		// (get) Token: 0x0600A5D0 RID: 42448 RVA: 0x00286288 File Offset: 0x00284488
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700333A RID: 13114
		// (get) Token: 0x0600A5D1 RID: 42449 RVA: 0x002862AC File Offset: 0x002844AC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ResolveAccountResponse.Descriptor;
			}
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x002862C3 File Offset: 0x002844C3
		[DebuggerNonUserCode]
		public ResolveAccountResponse()
		{
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x002862CD File Offset: 0x002844CD
		[DebuggerNonUserCode]
		public ResolveAccountResponse(ResolveAccountResponse other)
			: this()
		{
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x00286304 File Offset: 0x00284504
		[DebuggerNonUserCode]
		public ResolveAccountResponse Clone()
		{
			return new ResolveAccountResponse(this);
		}

		// Token: 0x1700333B RID: 13115
		// (get) Token: 0x0600A5D5 RID: 42453 RVA: 0x0028631C File Offset: 0x0028451C
		// (set) Token: 0x0600A5D6 RID: 42454 RVA: 0x00286334 File Offset: 0x00284534
		[DebuggerNonUserCode]
		public AccountId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x00286340 File Offset: 0x00284540
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ResolveAccountResponse);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x00286360 File Offset: 0x00284560
		[DebuggerNonUserCode]
		public bool Equals(ResolveAccountResponse other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x002863BC File Offset: 0x002845BC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
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

		// Token: 0x0600A5DA RID: 42458 RVA: 0x0028640C File Offset: 0x0028460C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x00286424 File Offset: 0x00284624
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x00286430 File Offset: 0x00284630
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Id);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x00286480 File Offset: 0x00284680
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x002864D4 File Offset: 0x002846D4
		[DebuggerNonUserCode]
		public void MergeFrom(ResolveAccountResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new AccountId();
					}
					this.Id.MergeFrom(other.Id);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x00286540 File Offset: 0x00284740
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x0028654C File Offset: 0x0028474C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.id_ == null;
					if (flag)
					{
						this.Id = new AccountId();
					}
					input.ReadMessage(this.Id);
				}
			}
		}

		// Token: 0x04004A90 RID: 19088
		private static readonly MessageParser<ResolveAccountResponse> _parser = new MessageParser<ResolveAccountResponse>(() => new ResolveAccountResponse());

		// Token: 0x04004A91 RID: 19089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A92 RID: 19090
		public const int IdFieldNumber = 12;

		// Token: 0x04004A93 RID: 19091
		private AccountId id_;
	}
}
