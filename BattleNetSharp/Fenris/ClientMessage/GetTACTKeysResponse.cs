using System;
using System.Diagnostics;
using Fenris.TACTKey;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000214 RID: 532
	public sealed class GetTACTKeysResponse : IMessage<GetTACTKeysResponse>, IMessage, IEquatable<GetTACTKeysResponse>, IDeepCloneable<GetTACTKeysResponse>, IBufferMessage
	{
		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x060039E0 RID: 14816 RVA: 0x000E6F28 File Offset: 0x000E5128
		[DebuggerNonUserCode]
		public static MessageParser<GetTACTKeysResponse> Parser
		{
			get
			{
				return GetTACTKeysResponse._parser;
			}
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x000E6F40 File Offset: 0x000E5140
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x060039E2 RID: 14818 RVA: 0x000E6F64 File Offset: 0x000E5164
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetTACTKeysResponse.Descriptor;
			}
		}

		// Token: 0x060039E3 RID: 14819 RVA: 0x000E6F7B File Offset: 0x000E517B
		[DebuggerNonUserCode]
		public GetTACTKeysResponse()
		{
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x000E6F85 File Offset: 0x000E5185
		[DebuggerNonUserCode]
		public GetTACTKeysResponse(GetTACTKeysResponse other)
			: this()
		{
			this.keys_ = ((other.keys_ != null) ? other.keys_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060039E5 RID: 14821 RVA: 0x000E6FBC File Offset: 0x000E51BC
		[DebuggerNonUserCode]
		public GetTACTKeysResponse Clone()
		{
			return new GetTACTKeysResponse(this);
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x000E6FD4 File Offset: 0x000E51D4
		// (set) Token: 0x060039E7 RID: 14823 RVA: 0x000E6FEC File Offset: 0x000E51EC
		[DebuggerNonUserCode]
		public Keys Keys
		{
			get
			{
				return this.keys_;
			}
			set
			{
				this.keys_ = value;
			}
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x000E6FF8 File Offset: 0x000E51F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetTACTKeysResponse);
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x000E7018 File Offset: 0x000E5218
		[DebuggerNonUserCode]
		public bool Equals(GetTACTKeysResponse other)
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
					bool flag4 = !object.Equals(this.Keys, other.Keys);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x000E7074 File Offset: 0x000E5274
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.keys_ != null;
			if (flag)
			{
				num ^= this.Keys.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060039EB RID: 14827 RVA: 0x000E70C4 File Offset: 0x000E52C4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060039EC RID: 14828 RVA: 0x000E70DC File Offset: 0x000E52DC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x000E70E8 File Offset: 0x000E52E8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.keys_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Keys);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x000E7138 File Offset: 0x000E5338
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.keys_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Keys);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x000E718C File Offset: 0x000E538C
		[DebuggerNonUserCode]
		public void MergeFrom(GetTACTKeysResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.keys_ != null;
				if (flag2)
				{
					bool flag3 = this.keys_ == null;
					if (flag3)
					{
						this.Keys = new Keys();
					}
					this.Keys.MergeFrom(other.Keys);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x000E71F8 File Offset: 0x000E53F8
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060039F1 RID: 14833 RVA: 0x000E7204 File Offset: 0x000E5404
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
					bool flag = this.keys_ == null;
					if (flag)
					{
						this.Keys = new Keys();
					}
					input.ReadMessage(this.Keys);
				}
			}
		}

		// Token: 0x04001AE2 RID: 6882
		private static readonly MessageParser<GetTACTKeysResponse> _parser = new MessageParser<GetTACTKeysResponse>(() => new GetTACTKeysResponse());

		// Token: 0x04001AE3 RID: 6883
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001AE4 RID: 6884
		public const int KeysFieldNumber = 1;

		// Token: 0x04001AE5 RID: 6885
		private Keys keys_;
	}
}
