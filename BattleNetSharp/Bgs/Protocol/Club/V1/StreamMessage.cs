using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x020004FC RID: 1276
	public sealed class StreamMessage : IMessage<StreamMessage>, IMessage, IEquatable<StreamMessage>, IDeepCloneable<StreamMessage>, IBufferMessage
	{
		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x06007CB8 RID: 31928 RVA: 0x001E5AA4 File Offset: 0x001E3CA4
		[DebuggerNonUserCode]
		public static MessageParser<StreamMessage> Parser
		{
			get
			{
				return StreamMessage._parser;
			}
		}

		// Token: 0x1700279A RID: 10138
		// (get) Token: 0x06007CB9 RID: 31929 RVA: 0x001E5ABC File Offset: 0x001E3CBC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubStreamReflection.Descriptor.MessageTypes[9];
			}
		}

		// Token: 0x1700279B RID: 10139
		// (get) Token: 0x06007CBA RID: 31930 RVA: 0x001E5AE0 File Offset: 0x001E3CE0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StreamMessage.Descriptor;
			}
		}

		// Token: 0x06007CBB RID: 31931 RVA: 0x001E5AF7 File Offset: 0x001E3CF7
		[DebuggerNonUserCode]
		public StreamMessage()
		{
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x001E5B0C File Offset: 0x001E3D0C
		[DebuggerNonUserCode]
		public StreamMessage(StreamMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = ((other.id_ != null) ? other.id_.Clone() : null);
			this.author_ = ((other.author_ != null) ? other.author_.Clone() : null);
			this.contentChain_ = other.contentChain_.Clone();
			this.destroyer_ = ((other.destroyer_ != null) ? other.destroyer_.Clone() : null);
			this.destroyed_ = other.destroyed_;
			this.destroyTime_ = other.destroyTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x001E5BBC File Offset: 0x001E3DBC
		[DebuggerNonUserCode]
		public StreamMessage Clone()
		{
			return new StreamMessage(this);
		}

		// Token: 0x1700279C RID: 10140
		// (get) Token: 0x06007CBE RID: 31934 RVA: 0x001E5BD4 File Offset: 0x001E3DD4
		// (set) Token: 0x06007CBF RID: 31935 RVA: 0x001E5BEC File Offset: 0x001E3DEC
		[DebuggerNonUserCode]
		public MessageId Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x06007CC0 RID: 31936 RVA: 0x001E5BF8 File Offset: 0x001E3DF8
		// (set) Token: 0x06007CC1 RID: 31937 RVA: 0x001E5C10 File Offset: 0x001E3E10
		[DebuggerNonUserCode]
		public MemberDescription Author
		{
			get
			{
				return this.author_;
			}
			set
			{
				this.author_ = value;
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x06007CC2 RID: 31938 RVA: 0x001E5C1C File Offset: 0x001E3E1C
		[DebuggerNonUserCode]
		public RepeatedField<ContentChain> ContentChain
		{
			get
			{
				return this.contentChain_;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x06007CC3 RID: 31939 RVA: 0x001E5C34 File Offset: 0x001E3E34
		// (set) Token: 0x06007CC4 RID: 31940 RVA: 0x001E5C4C File Offset: 0x001E3E4C
		[DebuggerNonUserCode]
		public MemberDescription Destroyer
		{
			get
			{
				return this.destroyer_;
			}
			set
			{
				this.destroyer_ = value;
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x06007CC5 RID: 31941 RVA: 0x001E5C58 File Offset: 0x001E3E58
		// (set) Token: 0x06007CC6 RID: 31942 RVA: 0x001E5C89 File Offset: 0x001E3E89
		[DebuggerNonUserCode]
		public bool Destroyed
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool destroyedDefaultValue;
				if (flag)
				{
					destroyedDefaultValue = this.destroyed_;
				}
				else
				{
					destroyedDefaultValue = StreamMessage.DestroyedDefaultValue;
				}
				return destroyedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.destroyed_ = value;
			}
		}

		// Token: 0x170027A1 RID: 10145
		// (get) Token: 0x06007CC7 RID: 31943 RVA: 0x001E5CA4 File Offset: 0x001E3EA4
		[DebuggerNonUserCode]
		public bool HasDestroyed
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06007CC8 RID: 31944 RVA: 0x001E5CC1 File Offset: 0x001E3EC1
		[DebuggerNonUserCode]
		public void ClearDestroyed()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027A2 RID: 10146
		// (get) Token: 0x06007CC9 RID: 31945 RVA: 0x001E5CD4 File Offset: 0x001E3ED4
		// (set) Token: 0x06007CCA RID: 31946 RVA: 0x001E5D05 File Offset: 0x001E3F05
		[DebuggerNonUserCode]
		public ulong DestroyTime
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong destroyTimeDefaultValue;
				if (flag)
				{
					destroyTimeDefaultValue = this.destroyTime_;
				}
				else
				{
					destroyTimeDefaultValue = StreamMessage.DestroyTimeDefaultValue;
				}
				return destroyTimeDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.destroyTime_ = value;
			}
		}

		// Token: 0x170027A3 RID: 10147
		// (get) Token: 0x06007CCB RID: 31947 RVA: 0x001E5D20 File Offset: 0x001E3F20
		[DebuggerNonUserCode]
		public bool HasDestroyTime
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06007CCC RID: 31948 RVA: 0x001E5D3D File Offset: 0x001E3F3D
		[DebuggerNonUserCode]
		public void ClearDestroyTime()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x06007CCD RID: 31949 RVA: 0x001E5D50 File Offset: 0x001E3F50
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as StreamMessage);
		}

		// Token: 0x06007CCE RID: 31950 RVA: 0x001E5D70 File Offset: 0x001E3F70
		[DebuggerNonUserCode]
		public bool Equals(StreamMessage other)
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
					bool flag4 = !object.Equals(this.Id, other.Id);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Author, other.Author);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !this.contentChain_.Equals(other.contentChain_);
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = !object.Equals(this.Destroyer, other.Destroyer);
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.Destroyed != other.Destroyed;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.DestroyTime != other.DestroyTime;
										flag2 = !flag9 && object.Equals(this._unknownFields, other._unknownFields);
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06007CCF RID: 31951 RVA: 0x001E5E68 File Offset: 0x001E4068
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.id_ != null;
			if (flag)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				num ^= this.Author.GetHashCode();
			}
			num ^= this.contentChain_.GetHashCode();
			bool flag3 = this.destroyer_ != null;
			if (flag3)
			{
				num ^= this.Destroyer.GetHashCode();
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				num ^= this.Destroyed.GetHashCode();
			}
			bool hasDestroyTime = this.HasDestroyTime;
			if (hasDestroyTime)
			{
				num ^= this.DestroyTime.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007CD0 RID: 31952 RVA: 0x001E5F3C File Offset: 0x001E413C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06007CD1 RID: 31953 RVA: 0x001E5F54 File Offset: 0x001E4154
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CD2 RID: 31954 RVA: 0x001E5F60 File Offset: 0x001E4160
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.id_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Id);
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Author);
			}
			this.contentChain_.WriteTo(ref output, StreamMessage._repeated_contentChain_codec);
			bool flag3 = this.destroyer_ != null;
			if (flag3)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Destroyer);
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				output.WriteRawTag(128, 1);
				output.WriteBool(this.Destroyed);
			}
			bool hasDestroyTime = this.HasDestroyTime;
			if (hasDestroyTime)
			{
				output.WriteRawTag(136, 1);
				output.WriteUInt64(this.DestroyTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CD3 RID: 31955 RVA: 0x001E605C File Offset: 0x001E425C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.id_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Id);
			}
			bool flag2 = this.author_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Author);
			}
			num += this.contentChain_.CalculateSize(StreamMessage._repeated_contentChain_codec);
			bool flag3 = this.destroyer_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Destroyer);
			}
			bool hasDestroyed = this.HasDestroyed;
			if (hasDestroyed)
			{
				num += 3;
			}
			bool hasDestroyTime = this.HasDestroyTime;
			if (hasDestroyTime)
			{
				num += 2 + CodedOutputStream.ComputeUInt64Size(this.DestroyTime);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007CD4 RID: 31956 RVA: 0x001E6134 File Offset: 0x001E4334
		[DebuggerNonUserCode]
		public void MergeFrom(StreamMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.id_ != null;
				if (flag2)
				{
					bool flag3 = this.id_ == null;
					if (flag3)
					{
						this.Id = new MessageId();
					}
					this.Id.MergeFrom(other.Id);
				}
				bool flag4 = other.author_ != null;
				if (flag4)
				{
					bool flag5 = this.author_ == null;
					if (flag5)
					{
						this.Author = new MemberDescription();
					}
					this.Author.MergeFrom(other.Author);
				}
				this.contentChain_.Add(other.contentChain_);
				bool flag6 = other.destroyer_ != null;
				if (flag6)
				{
					bool flag7 = this.destroyer_ == null;
					if (flag7)
					{
						this.Destroyer = new MemberDescription();
					}
					this.Destroyer.MergeFrom(other.Destroyer);
				}
				bool hasDestroyed = other.HasDestroyed;
				if (hasDestroyed)
				{
					this.Destroyed = other.Destroyed;
				}
				bool hasDestroyTime = other.HasDestroyTime;
				if (hasDestroyTime)
				{
					this.DestroyTime = other.DestroyTime;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06007CD5 RID: 31957 RVA: 0x001E6269 File Offset: 0x001E4469
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CD6 RID: 31958 RVA: 0x001E6274 File Offset: 0x001E4474
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 50U)
				{
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							if (num3 != 50U)
							{
								goto IL_004C;
							}
							this.contentChain_.AddEntriesFrom(ref input, StreamMessage._repeated_contentChain_codec);
						}
						else
						{
							bool flag = this.author_ == null;
							if (flag)
							{
								this.Author = new MemberDescription();
							}
							input.ReadMessage(this.Author);
						}
					}
					else
					{
						bool flag2 = this.id_ == null;
						if (flag2)
						{
							this.Id = new MessageId();
						}
						input.ReadMessage(this.Id);
					}
				}
				else if (num3 != 122U)
				{
					if (num3 != 128U)
					{
						if (num3 != 136U)
						{
							goto IL_004C;
						}
						this.DestroyTime = input.ReadUInt64();
					}
					else
					{
						this.Destroyed = input.ReadBool();
					}
				}
				else
				{
					bool flag3 = this.destroyer_ == null;
					if (flag3)
					{
						this.Destroyer = new MemberDescription();
					}
					input.ReadMessage(this.Destroyer);
				}
				continue;
				IL_004C:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040038B5 RID: 14517
		private static readonly MessageParser<StreamMessage> _parser = new MessageParser<StreamMessage>(() => new StreamMessage());

		// Token: 0x040038B6 RID: 14518
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038B7 RID: 14519
		private int _hasBits0;

		// Token: 0x040038B8 RID: 14520
		public const int IdFieldNumber = 3;

		// Token: 0x040038B9 RID: 14521
		private MessageId id_;

		// Token: 0x040038BA RID: 14522
		public const int AuthorFieldNumber = 4;

		// Token: 0x040038BB RID: 14523
		private MemberDescription author_;

		// Token: 0x040038BC RID: 14524
		public const int ContentChainFieldNumber = 6;

		// Token: 0x040038BD RID: 14525
		private static readonly FieldCodec<ContentChain> _repeated_contentChain_codec = FieldCodec.ForMessage<ContentChain>(50U, Bgs.Protocol.Club.V1.ContentChain.Parser);

		// Token: 0x040038BE RID: 14526
		private readonly RepeatedField<ContentChain> contentChain_ = new RepeatedField<ContentChain>();

		// Token: 0x040038BF RID: 14527
		public const int DestroyerFieldNumber = 15;

		// Token: 0x040038C0 RID: 14528
		private MemberDescription destroyer_;

		// Token: 0x040038C1 RID: 14529
		public const int DestroyedFieldNumber = 16;

		// Token: 0x040038C2 RID: 14530
		private static readonly bool DestroyedDefaultValue = false;

		// Token: 0x040038C3 RID: 14531
		private bool destroyed_;

		// Token: 0x040038C4 RID: 14532
		public const int DestroyTimeFieldNumber = 17;

		// Token: 0x040038C5 RID: 14533
		private static readonly ulong DestroyTimeDefaultValue = 0UL;

		// Token: 0x040038C6 RID: 14534
		private ulong destroyTime_;
	}
}
