using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x0200071B RID: 1819
	public sealed class GetGameAccountStateResponse : IMessage<GetGameAccountStateResponse>, IMessage, IEquatable<GetGameAccountStateResponse>, IDeepCloneable<GetGameAccountStateResponse>, IBufferMessage
	{
		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600A6AF RID: 42671 RVA: 0x00289154 File Offset: 0x00287354
		[DebuggerNonUserCode]
		public static MessageParser<GetGameAccountStateResponse> Parser
		{
			get
			{
				return GetGameAccountStateResponse._parser;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600A6B0 RID: 42672 RVA: 0x0028916C File Offset: 0x0028736C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountServiceReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17003374 RID: 13172
		// (get) Token: 0x0600A6B1 RID: 42673 RVA: 0x00289190 File Offset: 0x00287390
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetGameAccountStateResponse.Descriptor;
			}
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x002891A7 File Offset: 0x002873A7
		[DebuggerNonUserCode]
		public GetGameAccountStateResponse()
		{
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x002891B4 File Offset: 0x002873B4
		[DebuggerNonUserCode]
		public GetGameAccountStateResponse(GetGameAccountStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this.tags_ = ((other.tags_ != null) ? other.tags_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x00289214 File Offset: 0x00287414
		[DebuggerNonUserCode]
		public GetGameAccountStateResponse Clone()
		{
			return new GetGameAccountStateResponse(this);
		}

		// Token: 0x17003375 RID: 13173
		// (get) Token: 0x0600A6B5 RID: 42677 RVA: 0x0028922C File Offset: 0x0028742C
		// (set) Token: 0x0600A6B6 RID: 42678 RVA: 0x00289244 File Offset: 0x00287444
		[DebuggerNonUserCode]
		public GameAccountState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x17003376 RID: 13174
		// (get) Token: 0x0600A6B7 RID: 42679 RVA: 0x00289250 File Offset: 0x00287450
		// (set) Token: 0x0600A6B8 RID: 42680 RVA: 0x00289268 File Offset: 0x00287468
		[DebuggerNonUserCode]
		public GameAccountFieldTags Tags
		{
			get
			{
				return this.tags_;
			}
			set
			{
				this.tags_ = value;
			}
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x00289274 File Offset: 0x00287474
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetGameAccountStateResponse);
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x00289294 File Offset: 0x00287494
		[DebuggerNonUserCode]
		public bool Equals(GetGameAccountStateResponse other)
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
					bool flag4 = !object.Equals(this.State, other.State);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Tags, other.Tags);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x0028930C File Offset: 0x0028750C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				num ^= this.Tags.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x00289378 File Offset: 0x00287578
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x00289390 File Offset: 0x00287590
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x0028939C File Offset: 0x0028759C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Tags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x00289410 File Offset: 0x00287610
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this.tags_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Tags);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x00289484 File Offset: 0x00287684
		[DebuggerNonUserCode]
		public void MergeFrom(GetGameAccountStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.state_ != null;
				if (flag2)
				{
					bool flag3 = this.state_ == null;
					if (flag3)
					{
						this.State = new GameAccountState();
					}
					this.State.MergeFrom(other.State);
				}
				bool flag4 = other.tags_ != null;
				if (flag4)
				{
					bool flag5 = this.tags_ == null;
					if (flag5)
					{
						this.Tags = new GameAccountFieldTags();
					}
					this.Tags.MergeFrom(other.Tags);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x00289531 File Offset: 0x00287731
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x0028953C File Offset: 0x0028773C
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
						bool flag = this.tags_ == null;
						if (flag)
						{
							this.Tags = new GameAccountFieldTags();
						}
						input.ReadMessage(this.Tags);
					}
				}
				else
				{
					bool flag2 = this.state_ == null;
					if (flag2)
					{
						this.State = new GameAccountState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x04004ADA RID: 19162
		private static readonly MessageParser<GetGameAccountStateResponse> _parser = new MessageParser<GetGameAccountStateResponse>(() => new GetGameAccountStateResponse());

		// Token: 0x04004ADB RID: 19163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004ADC RID: 19164
		public const int StateFieldNumber = 1;

		// Token: 0x04004ADD RID: 19165
		private GameAccountState state_;

		// Token: 0x04004ADE RID: 19166
		public const int TagsFieldNumber = 2;

		// Token: 0x04004ADF RID: 19167
		private GameAccountFieldTags tags_;
	}
}
