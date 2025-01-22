using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.D2RConnection
{
	// Token: 0x0200076D RID: 1901
	public sealed class LoginResponse : IMessage<LoginResponse>, IMessage, IEquatable<LoginResponse>, IDeepCloneable<LoginResponse>, IBufferMessage
	{
		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600AE7A RID: 44666 RVA: 0x002A7C20 File Offset: 0x002A5E20
		[DebuggerNonUserCode]
		public static MessageParser<LoginResponse> Parser
		{
			get
			{
				return LoginResponse._parser;
			}
		}

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600AE7B RID: 44667 RVA: 0x002A7C38 File Offset: 0x002A5E38
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return D2RConnectionReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600AE7C RID: 44668 RVA: 0x002A7C5C File Offset: 0x002A5E5C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoginResponse.Descriptor;
			}
		}

		// Token: 0x0600AE7D RID: 44669 RVA: 0x002A7C73 File Offset: 0x002A5E73
		[DebuggerNonUserCode]
		public LoginResponse()
		{
		}

		// Token: 0x0600AE7E RID: 44670 RVA: 0x002A7C80 File Offset: 0x002A5E80
		[DebuggerNonUserCode]
		public LoginResponse(LoginResponse other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.url_ = other.url_;
			this.key_ = other.key_;
			this.unk_ = other.unk_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE7F RID: 44671 RVA: 0x002A7CD8 File Offset: 0x002A5ED8
		[DebuggerNonUserCode]
		public LoginResponse Clone()
		{
			return new LoginResponse(this);
		}

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600AE80 RID: 44672 RVA: 0x002A7CF0 File Offset: 0x002A5EF0
		// (set) Token: 0x0600AE81 RID: 44673 RVA: 0x002A7D11 File Offset: 0x002A5F11
		[DebuggerNonUserCode]
		public string Url
		{
			get
			{
				return this.url_ ?? LoginResponse.UrlDefaultValue;
			}
			set
			{
				this.url_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600AE82 RID: 44674 RVA: 0x002A7D28 File Offset: 0x002A5F28
		[DebuggerNonUserCode]
		public bool HasUrl
		{
			get
			{
				return this.url_ != null;
			}
		}

		// Token: 0x0600AE83 RID: 44675 RVA: 0x002A7D43 File Offset: 0x002A5F43
		[DebuggerNonUserCode]
		public void ClearUrl()
		{
			this.url_ = null;
		}

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600AE84 RID: 44676 RVA: 0x002A7D50 File Offset: 0x002A5F50
		// (set) Token: 0x0600AE85 RID: 44677 RVA: 0x002A7D71 File Offset: 0x002A5F71
		[DebuggerNonUserCode]
		public string Key
		{
			get
			{
				return this.key_ ?? LoginResponse.KeyDefaultValue;
			}
			set
			{
				this.key_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600AE86 RID: 44678 RVA: 0x002A7D88 File Offset: 0x002A5F88
		[DebuggerNonUserCode]
		public bool HasKey
		{
			get
			{
				return this.key_ != null;
			}
		}

		// Token: 0x0600AE87 RID: 44679 RVA: 0x002A7DA3 File Offset: 0x002A5FA3
		[DebuggerNonUserCode]
		public void ClearKey()
		{
			this.key_ = null;
		}

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600AE88 RID: 44680 RVA: 0x002A7DB0 File Offset: 0x002A5FB0
		// (set) Token: 0x0600AE89 RID: 44681 RVA: 0x002A7DE1 File Offset: 0x002A5FE1
		[DebuggerNonUserCode]
		public int Unk
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int unkDefaultValue;
				if (flag)
				{
					unkDefaultValue = this.unk_;
				}
				else
				{
					unkDefaultValue = LoginResponse.UnkDefaultValue;
				}
				return unkDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.unk_ = value;
			}
		}

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600AE8A RID: 44682 RVA: 0x002A7DFC File Offset: 0x002A5FFC
		[DebuggerNonUserCode]
		public bool HasUnk
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x002A7E19 File Offset: 0x002A6019
		[DebuggerNonUserCode]
		public void ClearUnk()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x002A7E2C File Offset: 0x002A602C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoginResponse);
		}

		// Token: 0x0600AE8D RID: 44685 RVA: 0x002A7E4C File Offset: 0x002A604C
		[DebuggerNonUserCode]
		public bool Equals(LoginResponse other)
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
					bool flag4 = this.Url != other.Url;
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
							bool flag6 = this.Unk != other.Unk;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600AE8E RID: 44686 RVA: 0x002A7ED8 File Offset: 0x002A60D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num ^= this.Url.GetHashCode();
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num ^= this.Key.GetHashCode();
			}
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				num ^= this.Unk.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE8F RID: 44687 RVA: 0x002A7F5C File Offset: 0x002A615C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE90 RID: 44688 RVA: 0x002A7F74 File Offset: 0x002A6174
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE91 RID: 44689 RVA: 0x002A7F80 File Offset: 0x002A6180
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Url);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Key);
			}
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Unk);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE92 RID: 44690 RVA: 0x002A8010 File Offset: 0x002A6210
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasUrl = this.HasUrl;
			if (hasUrl)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Url);
			}
			bool hasKey = this.HasKey;
			if (hasKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Key);
			}
			bool hasUnk = this.HasUnk;
			if (hasUnk)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Unk);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE93 RID: 44691 RVA: 0x002A809C File Offset: 0x002A629C
		[DebuggerNonUserCode]
		public void MergeFrom(LoginResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasUrl = other.HasUrl;
				if (hasUrl)
				{
					this.Url = other.Url;
				}
				bool hasKey = other.HasKey;
				if (hasKey)
				{
					this.Key = other.Key;
				}
				bool hasUnk = other.HasUnk;
				if (hasUnk)
				{
					this.Unk = other.Unk;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE94 RID: 44692 RVA: 0x002A8117 File Offset: 0x002A6317
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE95 RID: 44693 RVA: 0x002A8124 File Offset: 0x002A6324
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Unk = input.ReadInt32();
						}
					}
					else
					{
						this.Key = input.ReadString();
					}
				}
				else
				{
					this.Url = input.ReadString();
				}
			}
		}

		// Token: 0x04004E9E RID: 20126
		private static readonly MessageParser<LoginResponse> _parser = new MessageParser<LoginResponse>(() => new LoginResponse());

		// Token: 0x04004E9F RID: 20127
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EA0 RID: 20128
		private int _hasBits0;

		// Token: 0x04004EA1 RID: 20129
		public const int UrlFieldNumber = 1;

		// Token: 0x04004EA2 RID: 20130
		private static readonly string UrlDefaultValue = "";

		// Token: 0x04004EA3 RID: 20131
		private string url_;

		// Token: 0x04004EA4 RID: 20132
		public const int KeyFieldNumber = 2;

		// Token: 0x04004EA5 RID: 20133
		private static readonly string KeyDefaultValue = "";

		// Token: 0x04004EA6 RID: 20134
		private string key_;

		// Token: 0x04004EA7 RID: 20135
		public const int UnkFieldNumber = 3;

		// Token: 0x04004EA8 RID: 20136
		private static readonly int UnkDefaultValue = 0;

		// Token: 0x04004EA9 RID: 20137
		private int unk_;
	}
}
