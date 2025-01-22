using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000701 RID: 1793
	public sealed class GetStateResponse : IMessage<GetStateResponse>, IMessage, IEquatable<GetStateResponse>, IDeepCloneable<GetStateResponse>, IBufferMessage
	{
		// Token: 0x170032F4 RID: 13044
		// (get) Token: 0x0600A4CB RID: 42187 RVA: 0x00282298 File Offset: 0x00280498
		[DebuggerNonUserCode]
		public static MessageParser<GetStateResponse> Parser
		{
			get
			{
				return GetStateResponse._parser;
			}
		}

		// Token: 0x170032F5 RID: 13045
		// (get) Token: 0x0600A4CC RID: 42188 RVA: 0x002822B0 File Offset: 0x002804B0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170032F6 RID: 13046
		// (get) Token: 0x0600A4CD RID: 42189 RVA: 0x002822D4 File Offset: 0x002804D4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetStateResponse.Descriptor;
			}
		}

		// Token: 0x0600A4CE RID: 42190 RVA: 0x002822EB File Offset: 0x002804EB
		[DebuggerNonUserCode]
		public GetStateResponse()
		{
		}

		// Token: 0x0600A4CF RID: 42191 RVA: 0x002822F5 File Offset: 0x002804F5
		[DebuggerNonUserCode]
		public GetStateResponse(GetStateResponse other)
			: this()
		{
			this.state_ = ((other.state_ != null) ? other.state_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x0028232C File Offset: 0x0028052C
		[DebuggerNonUserCode]
		public GetStateResponse Clone()
		{
			return new GetStateResponse(this);
		}

		// Token: 0x170032F7 RID: 13047
		// (get) Token: 0x0600A4D1 RID: 42193 RVA: 0x00282344 File Offset: 0x00280544
		// (set) Token: 0x0600A4D2 RID: 42194 RVA: 0x0028235C File Offset: 0x0028055C
		[DebuggerNonUserCode]
		public BlockListState State
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

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x00282368 File Offset: 0x00280568
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetStateResponse);
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x00282388 File Offset: 0x00280588
		[DebuggerNonUserCode]
		public bool Equals(GetStateResponse other)
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
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x002823E4 File Offset: 0x002805E4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.state_ != null;
			if (flag)
			{
				num ^= this.State.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4D6 RID: 42198 RVA: 0x00282434 File Offset: 0x00280634
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4D7 RID: 42199 RVA: 0x0028244C File Offset: 0x0028064C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x00282458 File Offset: 0x00280658
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.state_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x002824A8 File Offset: 0x002806A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.state_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.State);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x002824FC File Offset: 0x002806FC
		[DebuggerNonUserCode]
		public void MergeFrom(GetStateResponse other)
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
						this.State = new BlockListState();
					}
					this.State.MergeFrom(other.State);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A4DB RID: 42203 RVA: 0x00282568 File Offset: 0x00280768
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x00282574 File Offset: 0x00280774
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
					bool flag = this.state_ == null;
					if (flag)
					{
						this.State = new BlockListState();
					}
					input.ReadMessage(this.State);
				}
			}
		}

		// Token: 0x04004A2F RID: 18991
		private static readonly MessageParser<GetStateResponse> _parser = new MessageParser<GetStateResponse>(() => new GetStateResponse());

		// Token: 0x04004A30 RID: 18992
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A31 RID: 18993
		public const int StateFieldNumber = 1;

		// Token: 0x04004A32 RID: 18994
		private BlockListState state_;
	}
}
