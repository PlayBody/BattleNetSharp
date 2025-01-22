using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004EA RID: 1258
	public sealed class GetClubActivityResponse : IMessage<GetClubActivityResponse>, IMessage, IEquatable<GetClubActivityResponse>, IDeepCloneable<GetClubActivityResponse>, IBufferMessage
	{
		// Token: 0x170026BB RID: 9915
		// (get) Token: 0x06007A56 RID: 31318 RVA: 0x001DB6E8 File Offset: 0x001D98E8
		[DebuggerNonUserCode]
		public static MessageParser<GetClubActivityResponse> Parser
		{
			get
			{
				return GetClubActivityResponse._parser;
			}
		}

		// Token: 0x170026BC RID: 9916
		// (get) Token: 0x06007A57 RID: 31319 RVA: 0x001DB700 File Offset: 0x001D9900
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[79];
			}
		}

		// Token: 0x170026BD RID: 9917
		// (get) Token: 0x06007A58 RID: 31320 RVA: 0x001DB724 File Offset: 0x001D9924
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetClubActivityResponse.Descriptor;
			}
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x001DB73B File Offset: 0x001D993B
		[DebuggerNonUserCode]
		public GetClubActivityResponse()
		{
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x001DB745 File Offset: 0x001D9945
		[DebuggerNonUserCode]
		public GetClubActivityResponse(GetClubActivityResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.continuation_ = other.continuation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x001DB778 File Offset: 0x001D9978
		[DebuggerNonUserCode]
		public GetClubActivityResponse Clone()
		{
			return new GetClubActivityResponse(this);
		}

		// Token: 0x170026BE RID: 9918
		// (get) Token: 0x06007A5C RID: 31324 RVA: 0x001DB790 File Offset: 0x001D9990
		// (set) Token: 0x06007A5D RID: 31325 RVA: 0x001DB7C1 File Offset: 0x001D99C1
		[DebuggerNonUserCode]
		public ulong Continuation
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong continuationDefaultValue;
				if (flag)
				{
					continuationDefaultValue = this.continuation_;
				}
				else
				{
					continuationDefaultValue = GetClubActivityResponse.ContinuationDefaultValue;
				}
				return continuationDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.continuation_ = value;
			}
		}

		// Token: 0x170026BF RID: 9919
		// (get) Token: 0x06007A5E RID: 31326 RVA: 0x001DB7DC File Offset: 0x001D99DC
		[DebuggerNonUserCode]
		public bool HasContinuation
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x001DB7F9 File Offset: 0x001D99F9
		[DebuggerNonUserCode]
		public void ClearContinuation()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x001DB80C File Offset: 0x001D9A0C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetClubActivityResponse);
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x001DB82C File Offset: 0x001D9A2C
		[DebuggerNonUserCode]
		public bool Equals(GetClubActivityResponse other)
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
					bool flag4 = this.Continuation != other.Continuation;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x001DB884 File Offset: 0x001D9A84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num ^= this.Continuation.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x001DB8D4 File Offset: 0x001D9AD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x001DB8EC File Offset: 0x001D9AEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x001DB8F8 File Offset: 0x001D9AF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x001DB944 File Offset: 0x001D9B44
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasContinuation = this.HasContinuation;
			if (hasContinuation)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.Continuation);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x001DB994 File Offset: 0x001D9B94
		[DebuggerNonUserCode]
		public void MergeFrom(GetClubActivityResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasContinuation = other.HasContinuation;
				if (hasContinuation)
				{
					this.Continuation = other.Continuation;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x001DB9DD File Offset: 0x001D9BDD
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x001DB9E8 File Offset: 0x001D9BE8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Continuation = input.ReadUInt64();
				}
			}
		}

		// Token: 0x04003771 RID: 14193
		private static readonly MessageParser<GetClubActivityResponse> _parser = new MessageParser<GetClubActivityResponse>(() => new GetClubActivityResponse());

		// Token: 0x04003772 RID: 14194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003773 RID: 14195
		private int _hasBits0;

		// Token: 0x04003774 RID: 14196
		public const int ContinuationFieldNumber = 2;

		// Token: 0x04003775 RID: 14197
		private static readonly ulong ContinuationDefaultValue = 0UL;

		// Token: 0x04003776 RID: 14198
		private ulong continuation_;
	}
}
