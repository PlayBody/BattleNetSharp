using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000043 RID: 67
	public sealed class TextureInformationRequest : IMessage<TextureInformationRequest>, IMessage, IEquatable<TextureInformationRequest>, IDeepCloneable<TextureInformationRequest>, IBufferMessage
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x00018C38 File Offset: 0x00016E38
		[DebuggerNonUserCode]
		public static MessageParser<TextureInformationRequest> Parser
		{
			get
			{
				return TextureInformationRequest._parser;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x0600054B RID: 1355 RVA: 0x00018C50 File Offset: 0x00016E50
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[44];
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x00018C74 File Offset: 0x00016E74
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TextureInformationRequest.Descriptor;
			}
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00018C8B File Offset: 0x00016E8B
		[DebuggerNonUserCode]
		public TextureInformationRequest()
		{
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00018C95 File Offset: 0x00016E95
		[DebuggerNonUserCode]
		public TextureInformationRequest(TextureInformationRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoHandle_ = other.snoHandle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00018CC8 File Offset: 0x00016EC8
		[DebuggerNonUserCode]
		public TextureInformationRequest Clone()
		{
			return new TextureInformationRequest(this);
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x00018CE0 File Offset: 0x00016EE0
		// (set) Token: 0x06000551 RID: 1361 RVA: 0x00018D11 File Offset: 0x00016F11
		[DebuggerNonUserCode]
		public int SnoHandle
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoHandleDefaultValue;
				if (flag)
				{
					snoHandleDefaultValue = this.snoHandle_;
				}
				else
				{
					snoHandleDefaultValue = TextureInformationRequest.SnoHandleDefaultValue;
				}
				return snoHandleDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoHandle_ = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00018D2C File Offset: 0x00016F2C
		[DebuggerNonUserCode]
		public bool HasSnoHandle
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00018D49 File Offset: 0x00016F49
		[DebuggerNonUserCode]
		public void ClearSnoHandle()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00018D5C File Offset: 0x00016F5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as TextureInformationRequest);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00018D7C File Offset: 0x00016F7C
		[DebuggerNonUserCode]
		public bool Equals(TextureInformationRequest other)
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
					bool flag4 = this.SnoHandle != other.SnoHandle;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00018DD4 File Offset: 0x00016FD4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num ^= this.SnoHandle.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00018E24 File Offset: 0x00017024
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00018E3C File Offset: 0x0001703C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00018E48 File Offset: 0x00017048
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00018E94 File Offset: 0x00017094
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoHandle = this.HasSnoHandle;
			if (hasSnoHandle)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoHandle);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00018EE4 File Offset: 0x000170E4
		[DebuggerNonUserCode]
		public void MergeFrom(TextureInformationRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoHandle = other.HasSnoHandle;
				if (hasSnoHandle)
				{
					this.SnoHandle = other.SnoHandle;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00018F2D File Offset: 0x0001712D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00018F38 File Offset: 0x00017138
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
					this.SnoHandle = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000238 RID: 568
		private static readonly MessageParser<TextureInformationRequest> _parser = new MessageParser<TextureInformationRequest>(() => new TextureInformationRequest());

		// Token: 0x04000239 RID: 569
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400023A RID: 570
		private int _hasBits0;

		// Token: 0x0400023B RID: 571
		public const int SnoHandleFieldNumber = 1;

		// Token: 0x0400023C RID: 572
		private static readonly int SnoHandleDefaultValue = 0;

		// Token: 0x0400023D RID: 573
		private int snoHandle_;
	}
}
