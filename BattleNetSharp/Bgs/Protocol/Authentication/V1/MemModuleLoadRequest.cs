using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000612 RID: 1554
	public sealed class MemModuleLoadRequest : IMessage<MemModuleLoadRequest>, IMessage, IEquatable<MemModuleLoadRequest>, IDeepCloneable<MemModuleLoadRequest>, IBufferMessage
	{
		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x00234AA4 File Offset: 0x00232CA4
		[DebuggerNonUserCode]
		public static MessageParser<MemModuleLoadRequest> Parser
		{
			get
			{
				return MemModuleLoadRequest._parser;
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600919F RID: 37279 RVA: 0x00234ABC File Offset: 0x00232CBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[13];
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00234AE0 File Offset: 0x00232CE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MemModuleLoadRequest.Descriptor;
			}
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x00234AF7 File Offset: 0x00232CF7
		[DebuggerNonUserCode]
		public MemModuleLoadRequest()
		{
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x00234B04 File Offset: 0x00232D04
		[DebuggerNonUserCode]
		public MemModuleLoadRequest(MemModuleLoadRequest other)
			: this()
		{
			this.handle_ = ((other.handle_ != null) ? other.handle_.Clone() : null);
			this.key_ = other.key_;
			this.input_ = other.input_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x00234B60 File Offset: 0x00232D60
		[DebuggerNonUserCode]
		public MemModuleLoadRequest Clone()
		{
			return new MemModuleLoadRequest(this);
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x060091A4 RID: 37284 RVA: 0x00234B78 File Offset: 0x00232D78
		// (set) Token: 0x060091A5 RID: 37285 RVA: 0x00234B90 File Offset: 0x00232D90
		[DebuggerNonUserCode]
		public ContentHandle Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x060091A6 RID: 37286 RVA: 0x00234B9C File Offset: 0x00232D9C
		// (set) Token: 0x060091A7 RID: 37287 RVA: 0x00234BBD File Offset: 0x00232DBD
		[DebuggerNonUserCode]
		public ByteString Key
		{
			get
			{
				return this.key_ ?? MemModuleLoadRequest.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x00234BD4 File Offset: 0x00232DD4
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x060091A9 RID: 37289 RVA: 0x00234BF2 File Offset: 0x00232DF2
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x060091AA RID: 37290 RVA: 0x00234BFC File Offset: 0x00232DFC
		// (set) Token: 0x060091AB RID: 37291 RVA: 0x00234C1D File Offset: 0x00232E1D
		[DebuggerNonUserCode]
		public ByteString Input
		{
			get
			{
				return this.input_ ?? MemModuleLoadRequest.InputDefaultValue;
			}
			set
			{
				this.input_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x060091AC RID: 37292 RVA: 0x00234C34 File Offset: 0x00232E34
		[DebuggerNonUserCode]
		public bool HasInput
		{
			get
			{
				return this.input_ != null;
			}
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x00234C52 File Offset: 0x00232E52
		[DebuggerNonUserCode]
		public void ClearInput()
		{
			this.input_ = null;
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x00234C5C File Offset: 0x00232E5C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MemModuleLoadRequest);
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x00234C7C File Offset: 0x00232E7C
		[DebuggerNonUserCode]
		public bool Equals(MemModuleLoadRequest other)
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
					bool flag4 = !object.Equals(this.Handle, other.Handle);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Key != other.Key;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Input != other.Input;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00234D0C File Offset: 0x00232F0C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasInput = this.HasInput;
			if (hasInput)
			{
				num ^= this.Input.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x00234D90 File Offset: 0x00232F90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x00234DA8 File Offset: 0x00232FA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x00234DB4 File Offset: 0x00232FB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.handle_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Handle);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.Key);
			}
			bool hasInput = this.HasInput;
			if (hasInput)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Input);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00234E48 File Offset: 0x00233048
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.handle_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Key);
			}
			bool hasInput = this.HasInput;
			if (hasInput)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Input);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00234ED8 File Offset: 0x002330D8
		[DebuggerNonUserCode]
		public void MergeFrom(MemModuleLoadRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.handle_ != null;
				if (flag2)
				{
					bool flag3 = this.handle_ == null;
					if (flag3)
					{
						this.Handle = new ContentHandle();
					}
					this.Handle.MergeFrom(other.Handle);
				}
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasInput = other.HasInput;
				if (hasInput)
				{
					this.Input = other.Input;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x00234F7B File Offset: 0x0023317B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x00234F88 File Offset: 0x00233188
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
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Input = input.ReadBytes();
						}
					}
					else
					{
						this.Key = input.ReadBytes();
					}
				}
				else
				{
					bool flag = this.handle_ == null;
					if (flag)
					{
						this.Handle = new ContentHandle();
					}
					input.ReadMessage(this.Handle);
				}
			}
		}

		// Token: 0x040041BD RID: 16829
		private static readonly MessageParser<MemModuleLoadRequest> _parser = new MessageParser<MemModuleLoadRequest>(() => new MemModuleLoadRequest());

		// Token: 0x040041BE RID: 16830
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041BF RID: 16831
		public const int HandleFieldNumber = 1;

		// Token: 0x040041C0 RID: 16832
		private ContentHandle handle_;

		// Token: 0x040041C1 RID: 16833
		public const int KeyFieldNumber = 2;

		// Token: 0x040041C2 RID: 16834
		private static readonly ByteString KeyDefaultValue = ByteString.Empty;

		// Token: 0x040041C3 RID: 16835
		private ByteString key_;

		// Token: 0x040041C4 RID: 16836
		public const int InputFieldNumber = 3;

		// Token: 0x040041C5 RID: 16837
		private static readonly ByteString InputDefaultValue = ByteString.Empty;

		// Token: 0x040041C6 RID: 16838
		private ByteString input_;
	}
}
