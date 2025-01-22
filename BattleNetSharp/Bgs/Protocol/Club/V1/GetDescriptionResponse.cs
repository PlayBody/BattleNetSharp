using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004A1 RID: 1185
	public sealed class GetDescriptionResponse : IMessage<GetDescriptionResponse>, IMessage, IEquatable<GetDescriptionResponse>, IDeepCloneable<GetDescriptionResponse>, IBufferMessage
	{
		// Token: 0x170024C3 RID: 9411
		// (get) Token: 0x06007350 RID: 29520 RVA: 0x001C2738 File Offset: 0x001C0938
		[DebuggerNonUserCode]
		public static MessageParser<GetDescriptionResponse> Parser
		{
			get
			{
				return GetDescriptionResponse._parser;
			}
		}

		// Token: 0x170024C4 RID: 9412
		// (get) Token: 0x06007351 RID: 29521 RVA: 0x001C2750 File Offset: 0x001C0950
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubRequestReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170024C5 RID: 9413
		// (get) Token: 0x06007352 RID: 29522 RVA: 0x001C2774 File Offset: 0x001C0974
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDescriptionResponse.Descriptor;
			}
		}

		// Token: 0x06007353 RID: 29523 RVA: 0x001C278B File Offset: 0x001C098B
		[DebuggerNonUserCode]
		public GetDescriptionResponse()
		{
		}

		// Token: 0x06007354 RID: 29524 RVA: 0x001C2795 File Offset: 0x001C0995
		[DebuggerNonUserCode]
		public GetDescriptionResponse(GetDescriptionResponse other)
			: this()
		{
			this.club_ = ((other.club_ != null) ? other.club_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007355 RID: 29525 RVA: 0x001C27CC File Offset: 0x001C09CC
		[DebuggerNonUserCode]
		public GetDescriptionResponse Clone()
		{
			return new GetDescriptionResponse(this);
		}

		// Token: 0x170024C6 RID: 9414
		// (get) Token: 0x06007356 RID: 29526 RVA: 0x001C27E4 File Offset: 0x001C09E4
		// (set) Token: 0x06007357 RID: 29527 RVA: 0x001C27FC File Offset: 0x001C09FC
		[DebuggerNonUserCode]
		public ClubDescription Club
		{
			get
			{
				return this.club_;
			}
			set
			{
				this.club_ = value;
			}
		}

		// Token: 0x06007358 RID: 29528 RVA: 0x001C2808 File Offset: 0x001C0A08
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDescriptionResponse);
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x001C2828 File Offset: 0x001C0A28
		[DebuggerNonUserCode]
		public bool Equals(GetDescriptionResponse other)
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
					bool flag4 = !object.Equals(this.Club, other.Club);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x001C2884 File Offset: 0x001C0A84
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.club_ != null;
			if (flag)
			{
				num ^= this.Club.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x001C28D4 File Offset: 0x001C0AD4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x001C28EC File Offset: 0x001C0AEC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x001C28F8 File Offset: 0x001C0AF8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.club_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Club);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x001C2948 File Offset: 0x001C0B48
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.club_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Club);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x001C299C File Offset: 0x001C0B9C
		[DebuggerNonUserCode]
		public void MergeFrom(GetDescriptionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.club_ != null;
				if (flag2)
				{
					bool flag3 = this.club_ == null;
					if (flag3)
					{
						this.Club = new ClubDescription();
					}
					this.Club.MergeFrom(other.Club);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x001C2A08 File Offset: 0x001C0C08
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x001C2A14 File Offset: 0x001C0C14
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.club_ == null;
					if (flag)
					{
						this.Club = new ClubDescription();
					}
					input.ReadMessage(this.Club);
				}
			}
		}

		// Token: 0x040034B8 RID: 13496
		private static readonly MessageParser<GetDescriptionResponse> _parser = new MessageParser<GetDescriptionResponse>(() => new GetDescriptionResponse());

		// Token: 0x040034B9 RID: 13497
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034BA RID: 13498
		public const int ClubFieldNumber = 1;

		// Token: 0x040034BB RID: 13499
		private ClubDescription club_;
	}
}
