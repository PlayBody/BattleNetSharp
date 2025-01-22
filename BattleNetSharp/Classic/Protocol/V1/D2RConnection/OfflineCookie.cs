using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x02000775 RID: 1909
	public sealed class OfflineCookie : IMessage<OfflineCookie>, IMessage, IEquatable<OfflineCookie>, IDeepCloneable<OfflineCookie>, IBufferMessage
	{
		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600AF9E RID: 44958 RVA: 0x002AC02C File Offset: 0x002AA22C
		[DebuggerNonUserCode]
		public static MessageParser<OfflineCookie> Parser
		{
			get
			{
				return OfflineCookie._parser;
			}
		}

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600AF9F RID: 44959 RVA: 0x002AC044 File Offset: 0x002AA244
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600AFA0 RID: 44960 RVA: 0x002AC068 File Offset: 0x002AA268
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OfflineCookie.Descriptor;
			}
		}

		// Token: 0x0600AFA1 RID: 44961 RVA: 0x002AC07F File Offset: 0x002AA27F
		[DebuggerNonUserCode]
		public OfflineCookie()
		{
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x002AC08C File Offset: 0x002AA28C
		[DebuggerNonUserCode]
		public OfflineCookie(OfflineCookie other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.methodName_ = other.methodName_;
			this.sessionKey64_ = other.sessionKey64_;
			this.sessionBytes_ = other.sessionBytes_;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x002AC0F0 File Offset: 0x002AA2F0
		[DebuggerNonUserCode]
		public OfflineCookie Clone()
		{
			return new OfflineCookie(this);
		}

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600AFA4 RID: 44964 RVA: 0x002AC108 File Offset: 0x002AA308
		// (set) Token: 0x0600AFA5 RID: 44965 RVA: 0x002AC129 File Offset: 0x002AA329
		[DebuggerNonUserCode]
		public string MethodName
		{
			get
			{
				return this.methodName_ ?? OfflineCookie.MethodNameDefaultValue;
			}
			set
			{
				this.methodName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600AFA6 RID: 44966 RVA: 0x002AC140 File Offset: 0x002AA340
		[DebuggerNonUserCode]
		public bool HasMethodName
		{
			get
			{
				return this.methodName_ != null;
			}
		}

		// Token: 0x0600AFA7 RID: 44967 RVA: 0x002AC15B File Offset: 0x002AA35B
		[DebuggerNonUserCode]
		public void ClearMethodName()
		{
			this.methodName_ = null;
		}

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600AFA8 RID: 44968 RVA: 0x002AC168 File Offset: 0x002AA368
		// (set) Token: 0x0600AFA9 RID: 44969 RVA: 0x002AC189 File Offset: 0x002AA389
		[DebuggerNonUserCode]
		public string SessionKey64
		{
			get
			{
				return this.sessionKey64_ ?? OfflineCookie.SessionKey64DefaultValue;
			}
			set
			{
				this.sessionKey64_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600AFAA RID: 44970 RVA: 0x002AC1A0 File Offset: 0x002AA3A0
		[DebuggerNonUserCode]
		public bool HasSessionKey64
		{
			get
			{
				return this.sessionKey64_ != null;
			}
		}

		// Token: 0x0600AFAB RID: 44971 RVA: 0x002AC1BB File Offset: 0x002AA3BB
		[DebuggerNonUserCode]
		public void ClearSessionKey64()
		{
			this.sessionKey64_ = null;
		}

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600AFAC RID: 44972 RVA: 0x002AC1C8 File Offset: 0x002AA3C8
		// (set) Token: 0x0600AFAD RID: 44973 RVA: 0x002AC1E9 File Offset: 0x002AA3E9
		[DebuggerNonUserCode]
		public ByteString SessionBytes
		{
			get
			{
				return this.sessionBytes_ ?? OfflineCookie.SessionBytesDefaultValue;
			}
			set
			{
				this.sessionBytes_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600AFAE RID: 44974 RVA: 0x002AC200 File Offset: 0x002AA400
		[DebuggerNonUserCode]
		public bool HasSessionBytes
		{
			get
			{
				return this.sessionBytes_ != null;
			}
		}

		// Token: 0x0600AFAF RID: 44975 RVA: 0x002AC21E File Offset: 0x002AA41E
		[DebuggerNonUserCode]
		public void ClearSessionBytes()
		{
			this.sessionBytes_ = null;
		}

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600AFB0 RID: 44976 RVA: 0x002AC228 File Offset: 0x002AA428
		// (set) Token: 0x0600AFB1 RID: 44977 RVA: 0x002AC259 File Offset: 0x002AA459
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = OfflineCookie.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600AFB2 RID: 44978 RVA: 0x002AC274 File Offset: 0x002AA474
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AFB3 RID: 44979 RVA: 0x002AC291 File Offset: 0x002AA491
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600AFB4 RID: 44980 RVA: 0x002AC2A4 File Offset: 0x002AA4A4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as OfflineCookie);
		}

		// Token: 0x0600AFB5 RID: 44981 RVA: 0x002AC2C4 File Offset: 0x002AA4C4
		[DebuggerNonUserCode]
		public bool Equals(OfflineCookie other)
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
					bool flag4 = this.MethodName != other.MethodName;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionKey64 != other.SessionKey64;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SessionBytes != other.SessionBytes;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Program != other.Program;
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x002AC370 File Offset: 0x002AA570
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				num ^= this.MethodName.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey64;
			if (hasSessionKey)
			{
				num ^= this.SessionKey64.GetHashCode();
			}
			bool hasSessionBytes = this.HasSessionBytes;
			if (hasSessionBytes)
			{
				num ^= this.SessionBytes.GetHashCode();
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x002AC40C File Offset: 0x002AA60C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x002AC424 File Offset: 0x002AA624
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFB9 RID: 44985 RVA: 0x002AC430 File Offset: 0x002AA630
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.MethodName);
			}
			bool hasSessionKey = this.HasSessionKey64;
			if (hasSessionKey)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SessionKey64);
			}
			bool hasSessionBytes = this.HasSessionBytes;
			if (hasSessionBytes)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.SessionBytes);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(32);
				output.WriteUInt32(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFBA RID: 44986 RVA: 0x002AC4E4 File Offset: 0x002AA6E4
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasMethodName = this.HasMethodName;
			if (hasMethodName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.MethodName);
			}
			bool hasSessionKey = this.HasSessionKey64;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SessionKey64);
			}
			bool hasSessionBytes = this.HasSessionBytes;
			if (hasSessionBytes)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionBytes);
			}
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AFBB RID: 44987 RVA: 0x002AC58C File Offset: 0x002AA78C
		[DebuggerNonUserCode]
		public void MergeFrom(OfflineCookie other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasMethodName = other.HasMethodName;
				if (hasMethodName)
				{
					this.MethodName = other.MethodName;
				}
				bool hasSessionKey = other.HasSessionKey64;
				if (hasSessionKey)
				{
					this.SessionKey64 = other.SessionKey64;
				}
				bool hasSessionBytes = other.HasSessionBytes;
				if (hasSessionBytes)
				{
					this.SessionBytes = other.SessionBytes;
				}
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AFBC RID: 44988 RVA: 0x002AC622 File Offset: 0x002AA822
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFBD RID: 44989 RVA: 0x002AC630 File Offset: 0x002AA830
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0029;
						}
						this.SessionKey64 = input.ReadString();
					}
					else
					{
						this.MethodName = input.ReadString();
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 32U)
					{
						goto IL_0029;
					}
					this.Program = input.ReadUInt32();
				}
				else
				{
					this.SessionBytes = input.ReadBytes();
				}
				continue;
				IL_0029:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F2F RID: 20271
		private static readonly MessageParser<OfflineCookie> _parser = new MessageParser<OfflineCookie>(() => new OfflineCookie());

		// Token: 0x04004F30 RID: 20272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F31 RID: 20273
		private int _hasBits0;

		// Token: 0x04004F32 RID: 20274
		public const int MethodNameFieldNumber = 1;

		// Token: 0x04004F33 RID: 20275
		private static readonly string MethodNameDefaultValue = "";

		// Token: 0x04004F34 RID: 20276
		private string methodName_;

		// Token: 0x04004F35 RID: 20277
		public const int SessionKey64FieldNumber = 2;

		// Token: 0x04004F36 RID: 20278
		private static readonly string SessionKey64DefaultValue = "";

		// Token: 0x04004F37 RID: 20279
		private string sessionKey64_;

		// Token: 0x04004F38 RID: 20280
		public const int SessionBytesFieldNumber = 3;

		// Token: 0x04004F39 RID: 20281
		private static readonly ByteString SessionBytesDefaultValue = ByteString.Empty;

		// Token: 0x04004F3A RID: 20282
		private ByteString sessionBytes_;

		// Token: 0x04004F3B RID: 20283
		public const int ProgramFieldNumber = 4;

		// Token: 0x04004F3C RID: 20284
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004F3D RID: 20285
		private uint program_;
	}
}
