using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V1
{
	// Token: 0x020005D2 RID: 1490
	public sealed class Notification : IMessage<Notification>, IMessage, IEquatable<Notification>, IDeepCloneable<Notification>, IBufferMessage
	{
		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06008C9B RID: 35995 RVA: 0x00221C80 File Offset: 0x0021FE80
		[DebuggerNonUserCode]
		public static MessageParser<Notification> Parser
		{
			get
			{
				return Notification._parser;
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06008C9C RID: 35996 RVA: 0x00221C98 File Offset: 0x0021FE98
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x06008C9D RID: 35997 RVA: 0x00221CBC File Offset: 0x0021FEBC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Notification.Descriptor;
			}
		}

		// Token: 0x06008C9E RID: 35998 RVA: 0x00221CD3 File Offset: 0x0021FED3
		[DebuggerNonUserCode]
		public Notification()
		{
		}

		// Token: 0x06008C9F RID: 35999 RVA: 0x00221CE8 File Offset: 0x0021FEE8
		[DebuggerNonUserCode]
		public Notification(Notification other)
			: this()
		{
			this.senderId_ = ((other.senderId_ != null) ? other.senderId_.Clone() : null);
			this.targetId_ = ((other.targetId_ != null) ? other.targetId_.Clone() : null);
			this.type_ = other.type_;
			this.attribute_ = other.attribute_.Clone();
			this.senderAccountId_ = ((other.senderAccountId_ != null) ? other.senderAccountId_.Clone() : null);
			this.targetAccountId_ = ((other.targetAccountId_ != null) ? other.targetAccountId_.Clone() : null);
			this.senderBattleTag_ = other.senderBattleTag_;
			this.targetBattleTag_ = other.targetBattleTag_;
			this.peer_ = ((other.peer_ != null) ? other.peer_.Clone() : null);
			this.forwardingIdentity_ = ((other.forwardingIdentity_ != null) ? other.forwardingIdentity_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CA0 RID: 36000 RVA: 0x00221DEC File Offset: 0x0021FFEC
		[DebuggerNonUserCode]
		public Notification Clone()
		{
			return new Notification(this);
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x06008CA1 RID: 36001 RVA: 0x00221E04 File Offset: 0x00220004
		// (set) Token: 0x06008CA2 RID: 36002 RVA: 0x00221E1C File Offset: 0x0022001C
		[DebuggerNonUserCode]
		public EntityId SenderId
		{
			get
			{
				return this.senderId_;
			}
			set
			{
				this.senderId_ = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x06008CA3 RID: 36003 RVA: 0x00221E28 File Offset: 0x00220028
		// (set) Token: 0x06008CA4 RID: 36004 RVA: 0x00221E40 File Offset: 0x00220040
		[DebuggerNonUserCode]
		public EntityId TargetId
		{
			get
			{
				return this.targetId_;
			}
			set
			{
				this.targetId_ = value;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x06008CA5 RID: 36005 RVA: 0x00221E4C File Offset: 0x0022004C
		// (set) Token: 0x06008CA6 RID: 36006 RVA: 0x00221E6D File Offset: 0x0022006D
		[DebuggerNonUserCode]
		public string Type
		{
			get
			{
				return this.type_ ?? Notification.TypeDefaultValue;
			}
			set
			{
				this.type_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x06008CA7 RID: 36007 RVA: 0x00221E84 File Offset: 0x00220084
		[DebuggerNonUserCode]
		public bool HasType
		{
			get
			{
				return this.type_ != null;
			}
		}

		// Token: 0x06008CA8 RID: 36008 RVA: 0x00221E9F File Offset: 0x0022009F
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.type_ = null;
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x06008CA9 RID: 36009 RVA: 0x00221EAC File Offset: 0x002200AC
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x06008CAA RID: 36010 RVA: 0x00221EC4 File Offset: 0x002200C4
		// (set) Token: 0x06008CAB RID: 36011 RVA: 0x00221EDC File Offset: 0x002200DC
		[DebuggerNonUserCode]
		public EntityId SenderAccountId
		{
			get
			{
				return this.senderAccountId_;
			}
			set
			{
				this.senderAccountId_ = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06008CAC RID: 36012 RVA: 0x00221EE8 File Offset: 0x002200E8
		// (set) Token: 0x06008CAD RID: 36013 RVA: 0x00221F00 File Offset: 0x00220100
		[DebuggerNonUserCode]
		public EntityId TargetAccountId
		{
			get
			{
				return this.targetAccountId_;
			}
			set
			{
				this.targetAccountId_ = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06008CAE RID: 36014 RVA: 0x00221F0C File Offset: 0x0022010C
		// (set) Token: 0x06008CAF RID: 36015 RVA: 0x00221F2D File Offset: 0x0022012D
		[DebuggerNonUserCode]
		public string SenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ ?? Notification.SenderBattleTagDefaultValue;
			}
			set
			{
				this.senderBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x06008CB0 RID: 36016 RVA: 0x00221F44 File Offset: 0x00220144
		[DebuggerNonUserCode]
		public bool HasSenderBattleTag
		{
			get
			{
				return this.senderBattleTag_ != null;
			}
		}

		// Token: 0x06008CB1 RID: 36017 RVA: 0x00221F5F File Offset: 0x0022015F
		[DebuggerNonUserCode]
		public void ClearSenderBattleTag()
		{
			this.senderBattleTag_ = null;
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x06008CB2 RID: 36018 RVA: 0x00221F6C File Offset: 0x0022016C
		// (set) Token: 0x06008CB3 RID: 36019 RVA: 0x00221F8D File Offset: 0x0022018D
		[DebuggerNonUserCode]
		public string TargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ ?? Notification.TargetBattleTagDefaultValue;
			}
			set
			{
				this.targetBattleTag_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x06008CB4 RID: 36020 RVA: 0x00221FA4 File Offset: 0x002201A4
		[DebuggerNonUserCode]
		public bool HasTargetBattleTag
		{
			get
			{
				return this.targetBattleTag_ != null;
			}
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x00221FBF File Offset: 0x002201BF
		[DebuggerNonUserCode]
		public void ClearTargetBattleTag()
		{
			this.targetBattleTag_ = null;
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x06008CB6 RID: 36022 RVA: 0x00221FCC File Offset: 0x002201CC
		// (set) Token: 0x06008CB7 RID: 36023 RVA: 0x00221FE4 File Offset: 0x002201E4
		[DebuggerNonUserCode]
		public ProcessId Peer
		{
			get
			{
				return this.peer_;
			}
			set
			{
				this.peer_ = value;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x06008CB8 RID: 36024 RVA: 0x00221FF0 File Offset: 0x002201F0
		// (set) Token: 0x06008CB9 RID: 36025 RVA: 0x00222008 File Offset: 0x00220208
		[DebuggerNonUserCode]
		public Identity ForwardingIdentity
		{
			get
			{
				return this.forwardingIdentity_;
			}
			set
			{
				this.forwardingIdentity_ = value;
			}
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x00222014 File Offset: 0x00220214
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Notification);
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x00222034 File Offset: 0x00220234
		[DebuggerNonUserCode]
		public bool Equals(Notification other)
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
					bool flag4 = !object.Equals(this.SenderId, other.SenderId);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.TargetId, other.TargetId);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Type != other.Type;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !this.attribute_.Equals(other.attribute_);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = !object.Equals(this.SenderAccountId, other.SenderAccountId);
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = !object.Equals(this.TargetAccountId, other.TargetAccountId);
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.SenderBattleTag != other.SenderBattleTag;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.TargetBattleTag != other.TargetBattleTag;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = !object.Equals(this.Peer, other.Peer);
													if (flag12)
													{
														flag2 = false;
													}
													else
													{
														bool flag13 = !object.Equals(this.ForwardingIdentity, other.ForwardingIdentity);
														flag2 = !flag13 && object.Equals(this._unknownFields, other._unknownFields);
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x002221AC File Offset: 0x002203AC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num ^= this.SenderId.GetHashCode();
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num ^= this.TargetId.GetHashCode();
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num ^= this.Type.GetHashCode();
			}
			num ^= this.attribute_.GetHashCode();
			bool flag3 = this.senderAccountId_ != null;
			if (flag3)
			{
				num ^= this.SenderAccountId.GetHashCode();
			}
			bool flag4 = this.targetAccountId_ != null;
			if (flag4)
			{
				num ^= this.TargetAccountId.GetHashCode();
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num ^= this.SenderBattleTag.GetHashCode();
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num ^= this.TargetBattleTag.GetHashCode();
			}
			bool flag5 = this.peer_ != null;
			if (flag5)
			{
				num ^= this.Peer.GetHashCode();
			}
			bool flag6 = this.forwardingIdentity_ != null;
			if (flag6)
			{
				num ^= this.ForwardingIdentity.GetHashCode();
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x002222E8 File Offset: 0x002204E8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00222300 File Offset: 0x00220500
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x0022230C File Offset: 0x0022050C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.senderId_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SenderId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TargetId);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Type);
			}
			this.attribute_.WriteTo(ref output, Notification._repeated_attribute_codec);
			bool flag3 = this.senderAccountId_ != null;
			if (flag3)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SenderAccountId);
			}
			bool flag4 = this.targetAccountId_ != null;
			if (flag4)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.TargetAccountId);
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				output.WriteRawTag(58);
				output.WriteString(this.SenderBattleTag);
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				output.WriteRawTag(66);
				output.WriteString(this.TargetBattleTag);
			}
			bool flag5 = this.peer_ != null;
			if (flag5)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.Peer);
			}
			bool flag6 = this.forwardingIdentity_ != null;
			if (flag6)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.ForwardingIdentity);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00222498 File Offset: 0x00220698
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.senderId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderId);
			}
			bool flag2 = this.targetId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetId);
			}
			bool hasType = this.HasType;
			if (hasType)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Type);
			}
			num += this.attribute_.CalculateSize(Notification._repeated_attribute_codec);
			bool flag3 = this.senderAccountId_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SenderAccountId);
			}
			bool flag4 = this.targetAccountId_ != null;
			if (flag4)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetAccountId);
			}
			bool hasSenderBattleTag = this.HasSenderBattleTag;
			if (hasSenderBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SenderBattleTag);
			}
			bool hasTargetBattleTag = this.HasTargetBattleTag;
			if (hasTargetBattleTag)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TargetBattleTag);
			}
			bool flag5 = this.peer_ != null;
			if (flag5)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Peer);
			}
			bool flag6 = this.forwardingIdentity_ != null;
			if (flag6)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ForwardingIdentity);
			}
			bool flag7 = this._unknownFields != null;
			if (flag7)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CC1 RID: 36033 RVA: 0x002225FC File Offset: 0x002207FC
		[DebuggerNonUserCode]
		public void MergeFrom(Notification other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.senderId_ != null;
				if (flag2)
				{
					bool flag3 = this.senderId_ == null;
					if (flag3)
					{
						this.SenderId = new EntityId();
					}
					this.SenderId.MergeFrom(other.SenderId);
				}
				bool flag4 = other.targetId_ != null;
				if (flag4)
				{
					bool flag5 = this.targetId_ == null;
					if (flag5)
					{
						this.TargetId = new EntityId();
					}
					this.TargetId.MergeFrom(other.TargetId);
				}
				bool hasType = other.HasType;
				if (hasType)
				{
					this.Type = other.Type;
				}
				this.attribute_.Add(other.attribute_);
				bool flag6 = other.senderAccountId_ != null;
				if (flag6)
				{
					bool flag7 = this.senderAccountId_ == null;
					if (flag7)
					{
						this.SenderAccountId = new EntityId();
					}
					this.SenderAccountId.MergeFrom(other.SenderAccountId);
				}
				bool flag8 = other.targetAccountId_ != null;
				if (flag8)
				{
					bool flag9 = this.targetAccountId_ == null;
					if (flag9)
					{
						this.TargetAccountId = new EntityId();
					}
					this.TargetAccountId.MergeFrom(other.TargetAccountId);
				}
				bool hasSenderBattleTag = other.HasSenderBattleTag;
				if (hasSenderBattleTag)
				{
					this.SenderBattleTag = other.SenderBattleTag;
				}
				bool hasTargetBattleTag = other.HasTargetBattleTag;
				if (hasTargetBattleTag)
				{
					this.TargetBattleTag = other.TargetBattleTag;
				}
				bool flag10 = other.peer_ != null;
				if (flag10)
				{
					bool flag11 = this.peer_ == null;
					if (flag11)
					{
						this.Peer = new ProcessId();
					}
					this.Peer.MergeFrom(other.Peer);
				}
				bool flag12 = other.forwardingIdentity_ != null;
				if (flag12)
				{
					bool flag13 = this.forwardingIdentity_ == null;
					if (flag13)
					{
						this.ForwardingIdentity = new Identity();
					}
					this.ForwardingIdentity.MergeFrom(other.ForwardingIdentity);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008CC2 RID: 36034 RVA: 0x0022280C File Offset: 0x00220A0C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x00222818 File Offset: 0x00220A18
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 42U)
				{
					if (num3 <= 18U)
					{
						if (num3 != 10U)
						{
							if (num3 != 18U)
							{
								goto IL_007B;
							}
							bool flag = this.targetId_ == null;
							if (flag)
							{
								this.TargetId = new EntityId();
							}
							input.ReadMessage(this.TargetId);
						}
						else
						{
							bool flag2 = this.senderId_ == null;
							if (flag2)
							{
								this.SenderId = new EntityId();
							}
							input.ReadMessage(this.SenderId);
						}
					}
					else if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 42U)
							{
								goto IL_007B;
							}
							bool flag3 = this.senderAccountId_ == null;
							if (flag3)
							{
								this.SenderAccountId = new EntityId();
							}
							input.ReadMessage(this.SenderAccountId);
						}
						else
						{
							this.attribute_.AddEntriesFrom(ref input, Notification._repeated_attribute_codec);
						}
					}
					else
					{
						this.Type = input.ReadString();
					}
				}
				else if (num3 <= 58U)
				{
					if (num3 != 50U)
					{
						if (num3 != 58U)
						{
							goto IL_007B;
						}
						this.SenderBattleTag = input.ReadString();
					}
					else
					{
						bool flag4 = this.targetAccountId_ == null;
						if (flag4)
						{
							this.TargetAccountId = new EntityId();
						}
						input.ReadMessage(this.TargetAccountId);
					}
				}
				else if (num3 != 66U)
				{
					if (num3 != 74U)
					{
						if (num3 != 82U)
						{
							goto IL_007B;
						}
						bool flag5 = this.forwardingIdentity_ == null;
						if (flag5)
						{
							this.ForwardingIdentity = new Identity();
						}
						input.ReadMessage(this.ForwardingIdentity);
					}
					else
					{
						bool flag6 = this.peer_ == null;
						if (flag6)
						{
							this.Peer = new ProcessId();
						}
						input.ReadMessage(this.Peer);
					}
				}
				else
				{
					this.TargetBattleTag = input.ReadString();
				}
				continue;
				IL_007B:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F97 RID: 16279
		private static readonly MessageParser<Notification> _parser = new MessageParser<Notification>(() => new Notification());

		// Token: 0x04003F98 RID: 16280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F99 RID: 16281
		public const int SenderIdFieldNumber = 1;

		// Token: 0x04003F9A RID: 16282
		private EntityId senderId_;

		// Token: 0x04003F9B RID: 16283
		public const int TargetIdFieldNumber = 2;

		// Token: 0x04003F9C RID: 16284
		private EntityId targetId_;

		// Token: 0x04003F9D RID: 16285
		public const int TypeFieldNumber = 3;

		// Token: 0x04003F9E RID: 16286
		private static readonly string TypeDefaultValue = "";

		// Token: 0x04003F9F RID: 16287
		private string type_;

		// Token: 0x04003FA0 RID: 16288
		public const int AttributeFieldNumber = 4;

		// Token: 0x04003FA1 RID: 16289
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(34U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04003FA2 RID: 16290
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04003FA3 RID: 16291
		public const int SenderAccountIdFieldNumber = 5;

		// Token: 0x04003FA4 RID: 16292
		private EntityId senderAccountId_;

		// Token: 0x04003FA5 RID: 16293
		public const int TargetAccountIdFieldNumber = 6;

		// Token: 0x04003FA6 RID: 16294
		private EntityId targetAccountId_;

		// Token: 0x04003FA7 RID: 16295
		public const int SenderBattleTagFieldNumber = 7;

		// Token: 0x04003FA8 RID: 16296
		private static readonly string SenderBattleTagDefaultValue = "";

		// Token: 0x04003FA9 RID: 16297
		private string senderBattleTag_;

		// Token: 0x04003FAA RID: 16298
		public const int TargetBattleTagFieldNumber = 8;

		// Token: 0x04003FAB RID: 16299
		private static readonly string TargetBattleTagDefaultValue = "";

		// Token: 0x04003FAC RID: 16300
		private string targetBattleTag_;

		// Token: 0x04003FAD RID: 16301
		public const int PeerFieldNumber = 9;

		// Token: 0x04003FAE RID: 16302
		private ProcessId peer_;

		// Token: 0x04003FAF RID: 16303
		public const int ForwardingIdentityFieldNumber = 10;

		// Token: 0x04003FB0 RID: 16304
		private Identity forwardingIdentity_;
	}
}
