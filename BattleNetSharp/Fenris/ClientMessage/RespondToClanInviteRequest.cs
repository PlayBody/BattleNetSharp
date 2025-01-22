using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000268 RID: 616
	public sealed class RespondToClanInviteRequest : IMessage<RespondToClanInviteRequest>, IMessage, IEquatable<RespondToClanInviteRequest>, IDeepCloneable<RespondToClanInviteRequest>, IBufferMessage
	{
		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x06004224 RID: 16932 RVA: 0x0010134C File Offset: 0x000FF54C
		[DebuggerNonUserCode]
		public static MessageParser<RespondToClanInviteRequest> Parser
		{
			get
			{
				return RespondToClanInviteRequest._parser;
			}
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x00101364 File Offset: 0x000FF564
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[88];
			}
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06004226 RID: 16934 RVA: 0x00101388 File Offset: 0x000FF588
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RespondToClanInviteRequest.Descriptor;
			}
		}

		// Token: 0x06004227 RID: 16935 RVA: 0x0010139F File Offset: 0x000FF59F
		[DebuggerNonUserCode]
		public RespondToClanInviteRequest()
		{
		}

		// Token: 0x06004228 RID: 16936 RVA: 0x001013A9 File Offset: 0x000FF5A9
		[DebuggerNonUserCode]
		public RespondToClanInviteRequest(RespondToClanInviteRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.clanId_ = other.clanId_;
			this.accept_ = other.accept_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004229 RID: 16937 RVA: 0x001013E8 File Offset: 0x000FF5E8
		[DebuggerNonUserCode]
		public RespondToClanInviteRequest Clone()
		{
			return new RespondToClanInviteRequest(this);
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x0600422A RID: 16938 RVA: 0x00101400 File Offset: 0x000FF600
		// (set) Token: 0x0600422B RID: 16939 RVA: 0x00101421 File Offset: 0x000FF621
		[DebuggerNonUserCode]
		public string ClanId
		{
			get
			{
				return this.clanId_ ?? RespondToClanInviteRequest.ClanIdDefaultValue;
			}
			set
			{
				this.clanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x0600422C RID: 16940 RVA: 0x00101438 File Offset: 0x000FF638
		[DebuggerNonUserCode]
		public bool HasClanId
		{
			get
			{
				return this.clanId_ != null;
			}
		}

		// Token: 0x0600422D RID: 16941 RVA: 0x00101453 File Offset: 0x000FF653
		[DebuggerNonUserCode]
		public void ClearClanId()
		{
			this.clanId_ = null;
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x0600422E RID: 16942 RVA: 0x00101460 File Offset: 0x000FF660
		// (set) Token: 0x0600422F RID: 16943 RVA: 0x00101491 File Offset: 0x000FF691
		[DebuggerNonUserCode]
		public bool Accept
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool acceptDefaultValue;
				if (flag)
				{
					acceptDefaultValue = this.accept_;
				}
				else
				{
					acceptDefaultValue = RespondToClanInviteRequest.AcceptDefaultValue;
				}
				return acceptDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.accept_ = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06004230 RID: 16944 RVA: 0x001014AC File Offset: 0x000FF6AC
		[DebuggerNonUserCode]
		public bool HasAccept
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06004231 RID: 16945 RVA: 0x001014C9 File Offset: 0x000FF6C9
		[DebuggerNonUserCode]
		public void ClearAccept()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06004232 RID: 16946 RVA: 0x001014DC File Offset: 0x000FF6DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RespondToClanInviteRequest);
		}

		// Token: 0x06004233 RID: 16947 RVA: 0x001014FC File Offset: 0x000FF6FC
		[DebuggerNonUserCode]
		public bool Equals(RespondToClanInviteRequest other)
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
					bool flag4 = this.ClanId != other.ClanId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Accept != other.Accept;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004234 RID: 16948 RVA: 0x00101570 File Offset: 0x000FF770
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num ^= this.ClanId.GetHashCode();
			}
			bool hasAccept = this.HasAccept;
			if (hasAccept)
			{
				num ^= this.Accept.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004235 RID: 16949 RVA: 0x001015DC File Offset: 0x000FF7DC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004236 RID: 16950 RVA: 0x001015F4 File Offset: 0x000FF7F4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004237 RID: 16951 RVA: 0x00101600 File Offset: 0x000FF800
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.ClanId);
			}
			bool hasAccept = this.HasAccept;
			if (hasAccept)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Accept);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004238 RID: 16952 RVA: 0x00101670 File Offset: 0x000FF870
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasClanId = this.HasClanId;
			if (hasClanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ClanId);
			}
			bool hasAccept = this.HasAccept;
			if (hasAccept)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004239 RID: 16953 RVA: 0x001016D0 File Offset: 0x000FF8D0
		[DebuggerNonUserCode]
		public void MergeFrom(RespondToClanInviteRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasClanId = other.HasClanId;
				if (hasClanId)
				{
					this.ClanId = other.ClanId;
				}
				bool hasAccept = other.HasAccept;
				if (hasAccept)
				{
					this.Accept = other.Accept;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600423A RID: 16954 RVA: 0x00101732 File Offset: 0x000FF932
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600423B RID: 16955 RVA: 0x00101740 File Offset: 0x000FF940
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Accept = input.ReadBool();
					}
				}
				else
				{
					this.ClanId = input.ReadString();
				}
			}
		}

		// Token: 0x04001DF4 RID: 7668
		private static readonly MessageParser<RespondToClanInviteRequest> _parser = new MessageParser<RespondToClanInviteRequest>(() => new RespondToClanInviteRequest());

		// Token: 0x04001DF5 RID: 7669
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001DF6 RID: 7670
		private int _hasBits0;

		// Token: 0x04001DF7 RID: 7671
		public const int ClanIdFieldNumber = 1;

		// Token: 0x04001DF8 RID: 7672
		private static readonly string ClanIdDefaultValue = "";

		// Token: 0x04001DF9 RID: 7673
		private string clanId_;

		// Token: 0x04001DFA RID: 7674
		public const int AcceptFieldNumber = 2;

		// Token: 0x04001DFB RID: 7675
		private static readonly bool AcceptDefaultValue = false;

		// Token: 0x04001DFC RID: 7676
		private bool accept_;
	}
}
