using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200055C RID: 1372
	public sealed class RestoreSessionRequest : IMessage<RestoreSessionRequest>, IMessage, IEquatable<RestoreSessionRequest>, IDeepCloneable<RestoreSessionRequest>, IBufferMessage
	{
		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x06008467 RID: 33895 RVA: 0x0020332C File Offset: 0x0020152C
		[DebuggerNonUserCode]
		public static MessageParser<RestoreSessionRequest> Parser
		{
			get
			{
				return RestoreSessionRequest._parser;
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x06008468 RID: 33896 RVA: 0x00203344 File Offset: 0x00201544
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x06008469 RID: 33897 RVA: 0x00203368 File Offset: 0x00201568
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreSessionRequest.Descriptor;
			}
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x0020337F File Offset: 0x0020157F
		[DebuggerNonUserCode]
		public RestoreSessionRequest()
		{
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x0020338C File Offset: 0x0020158C
		[DebuggerNonUserCode]
		public RestoreSessionRequest(RestoreSessionRequest other)
			: this()
		{
			this.identity_ = ((other.identity_ != null) ? other.identity_.Clone() : null);
			this.sessionKey_ = other.sessionKey_;
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this.stateOptions_ = ((other.stateOptions_ != null) ? other.stateOptions_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x00203414 File Offset: 0x00201614
		[DebuggerNonUserCode]
		public RestoreSessionRequest Clone()
		{
			return new RestoreSessionRequest(this);
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600846D RID: 33901 RVA: 0x0020342C File Offset: 0x0020162C
		// (set) Token: 0x0600846E RID: 33902 RVA: 0x00203444 File Offset: 0x00201644
		[DebuggerNonUserCode]
		public Identity Identity
		{
			get
			{
				return this.identity_;
			}
			set
			{
				this.identity_ = value;
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600846F RID: 33903 RVA: 0x00203450 File Offset: 0x00201650
		// (set) Token: 0x06008470 RID: 33904 RVA: 0x00203471 File Offset: 0x00201671
		[DebuggerNonUserCode]
		public ByteString SessionKey
		{
			get
			{
				return this.sessionKey_ ?? RestoreSessionRequest.SessionKeyDefaultValue;
			}
			set
			{
				this.sessionKey_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x06008471 RID: 33905 RVA: 0x00203488 File Offset: 0x00201688
		[DebuggerNonUserCode]
		public bool HasSessionKey
		{
			get
			{
				return this.sessionKey_ != null;
			}
		}

		// Token: 0x06008472 RID: 33906 RVA: 0x002034A6 File Offset: 0x002016A6
		[DebuggerNonUserCode]
		public void ClearSessionKey()
		{
			this.sessionKey_ = null;
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x06008473 RID: 33907 RVA: 0x002034B0 File Offset: 0x002016B0
		// (set) Token: 0x06008474 RID: 33908 RVA: 0x002034C8 File Offset: 0x002016C8
		[DebuggerNonUserCode]
		public RestoreOptions Options
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

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x06008475 RID: 33909 RVA: 0x002034D4 File Offset: 0x002016D4
		// (set) Token: 0x06008476 RID: 33910 RVA: 0x002034EC File Offset: 0x002016EC
		[DebuggerNonUserCode]
		public StateOptions StateOptions
		{
			get
			{
				return this.stateOptions_;
			}
			set
			{
				this.stateOptions_ = value;
			}
		}

		// Token: 0x06008477 RID: 33911 RVA: 0x002034F8 File Offset: 0x002016F8
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreSessionRequest);
		}

		// Token: 0x06008478 RID: 33912 RVA: 0x00203518 File Offset: 0x00201718
		[DebuggerNonUserCode]
		public bool Equals(RestoreSessionRequest other)
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
					bool flag4 = !object.Equals(this.Identity, other.Identity);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SessionKey != other.SessionKey;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Options, other.Options);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.StateOptions, other.StateOptions);
								flag2 = !flag7 && object.Equals(this._unknownFields, other._unknownFields);
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008479 RID: 33913 RVA: 0x002035D0 File Offset: 0x002017D0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num ^= this.Identity.GetHashCode();
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num ^= this.SessionKey.GetHashCode();
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag3 = this.stateOptions_ != null;
			if (flag3)
			{
				num ^= this.StateOptions.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600847A RID: 33914 RVA: 0x00203674 File Offset: 0x00201874
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600847B RID: 33915 RVA: 0x0020368C File Offset: 0x0020188C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600847C RID: 33916 RVA: 0x00203698 File Offset: 0x00201898
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.identity_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Identity);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				output.WriteRawTag(18);
				output.WriteBytes(this.SessionKey);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Options);
			}
			bool flag3 = this.stateOptions_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.StateOptions);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600847D RID: 33917 RVA: 0x00203758 File Offset: 0x00201958
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.identity_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Identity);
			}
			bool hasSessionKey = this.HasSessionKey;
			if (hasSessionKey)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.SessionKey);
			}
			bool flag2 = this.options_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag3 = this.stateOptions_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.StateOptions);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600847E RID: 33918 RVA: 0x0020380C File Offset: 0x00201A0C
		[DebuggerNonUserCode]
		public void MergeFrom(RestoreSessionRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.identity_ != null;
				if (flag2)
				{
					bool flag3 = this.identity_ == null;
					if (flag3)
					{
						this.Identity = new Identity();
					}
					this.Identity.MergeFrom(other.Identity);
				}
				bool hasSessionKey = other.HasSessionKey;
				if (hasSessionKey)
				{
					this.SessionKey = other.SessionKey;
				}
				bool flag4 = other.options_ != null;
				if (flag4)
				{
					bool flag5 = this.options_ == null;
					if (flag5)
					{
						this.Options = new RestoreOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				bool flag6 = other.stateOptions_ != null;
				if (flag6)
				{
					bool flag7 = this.stateOptions_ == null;
					if (flag7)
					{
						this.StateOptions = new StateOptions();
					}
					this.StateOptions.MergeFrom(other.StateOptions);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600847F RID: 33919 RVA: 0x00203914 File Offset: 0x00201B14
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008480 RID: 33920 RVA: 0x00203920 File Offset: 0x00201B20
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
							goto IL_002F;
						}
						this.SessionKey = input.ReadBytes();
					}
					else
					{
						bool flag = this.identity_ == null;
						if (flag)
						{
							this.Identity = new Identity();
						}
						input.ReadMessage(this.Identity);
					}
				}
				else if (num3 != 26U)
				{
					if (num3 != 34U)
					{
						goto IL_002F;
					}
					bool flag2 = this.stateOptions_ == null;
					if (flag2)
					{
						this.StateOptions = new StateOptions();
					}
					input.ReadMessage(this.StateOptions);
				}
				else
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new RestoreOptions();
					}
					input.ReadMessage(this.Options);
				}
				continue;
				IL_002F:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C16 RID: 15382
		private static readonly MessageParser<RestoreSessionRequest> _parser = new MessageParser<RestoreSessionRequest>(() => new RestoreSessionRequest());

		// Token: 0x04003C17 RID: 15383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C18 RID: 15384
		public const int IdentityFieldNumber = 1;

		// Token: 0x04003C19 RID: 15385
		private Identity identity_;

		// Token: 0x04003C1A RID: 15386
		public const int SessionKeyFieldNumber = 2;

		// Token: 0x04003C1B RID: 15387
		private static readonly ByteString SessionKeyDefaultValue = ByteString.Empty;

		// Token: 0x04003C1C RID: 15388
		private ByteString sessionKey_;

		// Token: 0x04003C1D RID: 15389
		public const int OptionsFieldNumber = 3;

		// Token: 0x04003C1E RID: 15390
		private RestoreOptions options_;

		// Token: 0x04003C1F RID: 15391
		public const int StateOptionsFieldNumber = 4;

		// Token: 0x04003C20 RID: 15392
		private StateOptions stateOptions_;
	}
}
