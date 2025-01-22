using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x020000FD RID: 253
	public sealed class EncryptedRootSnosResponse : IMessage<EncryptedRootSnosResponse>, IMessage, IEquatable<EncryptedRootSnosResponse>, IDeepCloneable<EncryptedRootSnosResponse>, IBufferMessage
	{
		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001843 RID: 6211 RVA: 0x00056C3C File Offset: 0x00054E3C
		[DebuggerNonUserCode]
		public static MessageParser<EncryptedRootSnosResponse> Parser
		{
			get
			{
				return EncryptedRootSnosResponse._parser;
			}
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00056C54 File Offset: 0x00054E54
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[230];
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x06001845 RID: 6213 RVA: 0x00056C7C File Offset: 0x00054E7C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EncryptedRootSnosResponse.Descriptor;
			}
		}

		// Token: 0x06001846 RID: 6214 RVA: 0x00056C93 File Offset: 0x00054E93
		[DebuggerNonUserCode]
		public EncryptedRootSnosResponse()
		{
		}

		// Token: 0x06001847 RID: 6215 RVA: 0x00056CA8 File Offset: 0x00054EA8
		[DebuggerNonUserCode]
		public EncryptedRootSnosResponse(EncryptedRootSnosResponse other)
			: this()
		{
			this.encryptedRootSnos_ = other.encryptedRootSnos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001848 RID: 6216 RVA: 0x00056CD4 File Offset: 0x00054ED4
		[DebuggerNonUserCode]
		public EncryptedRootSnosResponse Clone()
		{
			return new EncryptedRootSnosResponse(this);
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x00056CEC File Offset: 0x00054EEC
		[DebuggerNonUserCode]
		public RepeatedField<EncryptedSno> EncryptedRootSnos
		{
			get
			{
				return this.encryptedRootSnos_;
			}
		}

		// Token: 0x0600184A RID: 6218 RVA: 0x00056D04 File Offset: 0x00054F04
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EncryptedRootSnosResponse);
		}

		// Token: 0x0600184B RID: 6219 RVA: 0x00056D24 File Offset: 0x00054F24
		[DebuggerNonUserCode]
		public bool Equals(EncryptedRootSnosResponse other)
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
					bool flag4 = !this.encryptedRootSnos_.Equals(other.encryptedRootSnos_);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600184C RID: 6220 RVA: 0x00056D80 File Offset: 0x00054F80
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.encryptedRootSnos_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600184D RID: 6221 RVA: 0x00056DC0 File Offset: 0x00054FC0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00056DD8 File Offset: 0x00054FD8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00056DE4 File Offset: 0x00054FE4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.encryptedRootSnos_.WriteTo(ref output, EncryptedRootSnosResponse._repeated_encryptedRootSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00056E20 File Offset: 0x00055020
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.encryptedRootSnos_.CalculateSize(EncryptedRootSnosResponse._repeated_encryptedRootSnos_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001851 RID: 6225 RVA: 0x00056E68 File Offset: 0x00055068
		[DebuggerNonUserCode]
		public void MergeFrom(EncryptedRootSnosResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.encryptedRootSnos_.Add(other.encryptedRootSnos_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x00056EAA File Offset: 0x000550AA
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x00056EB8 File Offset: 0x000550B8
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
					this.encryptedRootSnos_.AddEntriesFrom(ref input, EncryptedRootSnosResponse._repeated_encryptedRootSnos_codec);
				}
			}
		}

		// Token: 0x040009B4 RID: 2484
		private static readonly MessageParser<EncryptedRootSnosResponse> _parser = new MessageParser<EncryptedRootSnosResponse>(() => new EncryptedRootSnosResponse());

		// Token: 0x040009B5 RID: 2485
		private UnknownFieldSet _unknownFields;

		// Token: 0x040009B6 RID: 2486
		public const int EncryptedRootSnosFieldNumber = 1;

		// Token: 0x040009B7 RID: 2487
		private static readonly FieldCodec<EncryptedSno> _repeated_encryptedRootSnos_codec = FieldCodec.ForMessage<EncryptedSno>(10U, EncryptedSno.Parser);

		// Token: 0x040009B8 RID: 2488
		private readonly RepeatedField<EncryptedSno> encryptedRootSnos_ = new RepeatedField<EncryptedSno>();
	}
}
