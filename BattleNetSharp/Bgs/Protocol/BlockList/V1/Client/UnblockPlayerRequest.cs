using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.BlockList.V1.Client
{
	// Token: 0x02000703 RID: 1795
	public sealed class UnblockPlayerRequest : IMessage<UnblockPlayerRequest>, IMessage, IEquatable<UnblockPlayerRequest>, IDeepCloneable<UnblockPlayerRequest>, IBufferMessage
	{
		// Token: 0x170032FC RID: 13052
		// (get) Token: 0x0600A4F1 RID: 42225 RVA: 0x00282968 File Offset: 0x00280B68
		[DebuggerNonUserCode]
		public static MessageParser<UnblockPlayerRequest> Parser
		{
			get
			{
				return UnblockPlayerRequest._parser;
			}
		}

		// Token: 0x170032FD RID: 13053
		// (get) Token: 0x0600A4F2 RID: 42226 RVA: 0x00282980 File Offset: 0x00280B80
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return BlockListServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170032FE RID: 13054
		// (get) Token: 0x0600A4F3 RID: 42227 RVA: 0x002829A4 File Offset: 0x00280BA4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UnblockPlayerRequest.Descriptor;
			}
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x002829BB File Offset: 0x00280BBB
		[DebuggerNonUserCode]
		public UnblockPlayerRequest()
		{
		}

		// Token: 0x0600A4F5 RID: 42229 RVA: 0x002829C5 File Offset: 0x00280BC5
		[DebuggerNonUserCode]
		public UnblockPlayerRequest(UnblockPlayerRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4F6 RID: 42230 RVA: 0x002829FC File Offset: 0x00280BFC
		[DebuggerNonUserCode]
		public UnblockPlayerRequest Clone()
		{
			return new UnblockPlayerRequest(this);
		}

		// Token: 0x170032FF RID: 13055
		// (get) Token: 0x0600A4F7 RID: 42231 RVA: 0x00282A14 File Offset: 0x00280C14
		// (set) Token: 0x0600A4F8 RID: 42232 RVA: 0x00282A2C File Offset: 0x00280C2C
		[DebuggerNonUserCode]
		public UnblockPlayerOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x00282A38 File Offset: 0x00280C38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as UnblockPlayerRequest);
		}

		// Token: 0x0600A4FA RID: 42234 RVA: 0x00282A58 File Offset: 0x00280C58
		[DebuggerNonUserCode]
		public bool Equals(UnblockPlayerRequest other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600A4FB RID: 42235 RVA: 0x00282AB4 File Offset: 0x00280CB4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x00282B04 File Offset: 0x00280D04
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x00282B1C File Offset: 0x00280D1C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x00282B28 File Offset: 0x00280D28
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x00282B78 File Offset: 0x00280D78
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x00282BCC File Offset: 0x00280DCC
		[DebuggerNonUserCode]
		public void MergeFrom(UnblockPlayerRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new UnblockPlayerOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x00282C38 File Offset: 0x00280E38
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x00282C44 File Offset: 0x00280E44
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new UnblockPlayerOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x04004A37 RID: 18999
		private static readonly MessageParser<UnblockPlayerRequest> _parser = new MessageParser<UnblockPlayerRequest>(() => new UnblockPlayerRequest());

		// Token: 0x04004A38 RID: 19000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A39 RID: 19001
		public const int OptionsFieldNumber = 2;

		// Token: 0x04004A3A RID: 19002
		private UnblockPlayerOptions options_;
	}
}
