using System;
using System.Diagnostics;
using Bgs.Protocol.Channel.V1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Presence.V1
{
    // Token: 0x02000B82 RID: 2946
    public sealed class ChannelState : IMessage<Bgs.Protocol.Presence.V1.ChannelState>, IMessage, IEquatable<Bgs.Protocol.Presence.V1.ChannelState>, IDeepCloneable<Bgs.Protocol.Presence.V1.ChannelState>, IBufferMessage
    {
        // Token: 0x17002CF4 RID: 11508
        // (get) Token: 0x0600A221 RID: 41505 RVA: 0x0023E1B0 File Offset: 0x0023C3B0
        [DebuggerNonUserCode]
        public static MessageParser<Bgs.Protocol.Presence.V1.ChannelState> Parser
        {
            get
            {
                return Bgs.Protocol.Presence.V1.ChannelState._parser;
            }
        }

        // Token: 0x17002CF5 RID: 11509
        // (get) Token: 0x0600A222 RID: 41506 RVA: 0x0023E1C8 File Offset: 0x0023C3C8
        [DebuggerNonUserCode]
        public static MessageDescriptor Descriptor
        {
            get
            {
                return PresenceTypesReflection.Descriptor.MessageTypes[5];
            }
        }

        // Token: 0x17002CF6 RID: 11510
        // (get) Token: 0x0600A223 RID: 41507 RVA: 0x0023E1EC File Offset: 0x0023C3EC
        [DebuggerNonUserCode]
        MessageDescriptor IMessage.Descriptor
        {
            get
            {
                return Bgs.Protocol.Presence.V1.ChannelState.Descriptor;
            }
        }

        // Token: 0x0600A224 RID: 41508 RVA: 0x0003DFA7 File Offset: 0x0003C1A7
        [DebuggerNonUserCode]
        public ChannelState()
        {
        }

        // Token: 0x0600A225 RID: 41509 RVA: 0x0023E204 File Offset: 0x0023C404
        [DebuggerNonUserCode]
        public ChannelState(Bgs.Protocol.Presence.V1.ChannelState other)
            : this()
        {
            this._hasBits0 = other._hasBits0;
            this.entityId_ = ((other.entityId_ != null) ? other.entityId_.Clone() : null);
            this.fieldOperation_ = other.fieldOperation_.Clone();
            this.healing_ = other.healing_;
            this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
        }

        // Token: 0x0600A226 RID: 41510 RVA: 0x0023E270 File Offset: 0x0023C470
        [DebuggerNonUserCode]
        public Bgs.Protocol.Presence.V1.ChannelState Clone()
        {
            return new Bgs.Protocol.Presence.V1.ChannelState(this);
        }

        // Token: 0x17002CF7 RID: 11511
        // (get) Token: 0x0600A227 RID: 41511 RVA: 0x0023E288 File Offset: 0x0023C488
        // (set) Token: 0x0600A228 RID: 41512 RVA: 0x0003DFBC File Offset: 0x0003C1BC
        [DebuggerNonUserCode]
        public EntityId EntityId
        {
            get
            {
                return this.entityId_;
            }
            set
            {
                this.entityId_ = value;
            }
        }

        // Token: 0x17002CF8 RID: 11512
        // (get) Token: 0x0600A229 RID: 41513 RVA: 0x0023E2A0 File Offset: 0x0023C4A0
        [DebuggerNonUserCode]
        public RepeatedField<FieldOperation> FieldOperation
        {
            get
            {
                return this.fieldOperation_;
            }
        }

        // Token: 0x17002CF9 RID: 11513
        // (get) Token: 0x0600A22A RID: 41514 RVA: 0x0023E2B8 File Offset: 0x0023C4B8
        // (set) Token: 0x0600A22B RID: 41515 RVA: 0x0003DFC6 File Offset: 0x0003C1C6
        [DebuggerNonUserCode]
        public bool Healing
        {
            get
            {
                bool flag = (this._hasBits0 & 1) != 0;
                bool healingDefaultValue;
                if (flag)
                {
                    healingDefaultValue = this.healing_;
                }
                else
                {
                    healingDefaultValue = Bgs.Protocol.Presence.V1.ChannelState.HealingDefaultValue;
                }
                return healingDefaultValue;
            }
            set
            {
                this._hasBits0 |= 1;
                this.healing_ = value;
            }
        }

        // Token: 0x17002CFA RID: 11514
        // (get) Token: 0x0600A22C RID: 41516 RVA: 0x0023E2EC File Offset: 0x0023C4EC
        [DebuggerNonUserCode]
        public bool HasHealing
        {
            get
            {
                return (this._hasBits0 & 1) != 0;
            }
        }

        // Token: 0x0600A22D RID: 41517 RVA: 0x0003DFDE File Offset: 0x0003C1DE
        [DebuggerNonUserCode]
        public void ClearHealing()
        {
            this._hasBits0 &= -2;
        }

        // Token: 0x0600A22E RID: 41518 RVA: 0x0023E30C File Offset: 0x0023C50C
        [DebuggerNonUserCode]
        public override bool Equals(object other)
        {
            return this.Equals(other as Bgs.Protocol.Presence.V1.ChannelState);
        }

        // Token: 0x0600A22F RID: 41519 RVA: 0x0023E32C File Offset: 0x0023C52C
        [DebuggerNonUserCode]
        public bool Equals(Bgs.Protocol.Presence.V1.ChannelState other)
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
                    bool flag4 = !object.Equals(this.EntityId, other.EntityId);
                    if (flag4)
                    {
                        flag2 = false;
                    }
                    else
                    {
                        bool flag5 = !this.fieldOperation_.Equals(other.fieldOperation_);
                        if (flag5)
                        {
                            flag2 = false;
                        }
                        else
                        {
                            bool flag6 = this.Healing != other.Healing;
                            flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
                        }
                    }
                }
            }
            return flag2;
        }

        // Token: 0x0600A230 RID: 41520 RVA: 0x0023E3C0 File Offset: 0x0023C5C0
        [DebuggerNonUserCode]
        public override int GetHashCode()
        {
            int num = 1;
            bool flag = this.entityId_ != null;
            if (flag)
            {
                num ^= this.EntityId.GetHashCode();
            }
            num ^= this.fieldOperation_.GetHashCode();
            bool hasHealing = this.HasHealing;
            if (hasHealing)
            {
                num ^= this.Healing.GetHashCode();
            }
            bool flag2 = this._unknownFields != null;
            if (flag2)
            {
                num ^= this._unknownFields.GetHashCode();
            }
            return num;
        }

        // Token: 0x0600A231 RID: 41521 RVA: 0x00057168 File Offset: 0x00055368
        [DebuggerNonUserCode]
        public override string ToString()
        {
            return JsonFormatter.ToDiagnosticString(this);
        }

        // Token: 0x0600A232 RID: 41522 RVA: 0x00003960 File Offset: 0x00001B60
        [DebuggerNonUserCode]
        public void WriteTo(CodedOutputStream output)
        {
            output.WriteRawMessage(this);
        }

        // Token: 0x0600A233 RID: 41523 RVA: 0x0023E43C File Offset: 0x0023C63C
        [DebuggerNonUserCode]
        void IBufferMessage.InternalWriteTo(ref WriteContext output)
        {
            bool flag = this.entityId_ != null;
            if (flag)
            {
                output.WriteRawTag(10);
                output.WriteMessage(this.EntityId);
            }
            this.fieldOperation_.WriteTo(ref output, Bgs.Protocol.Presence.V1.ChannelState._repeated_fieldOperation_codec);
            bool hasHealing = this.HasHealing;
            if (hasHealing)
            {
                output.WriteRawTag(24);
                output.WriteBool(this.Healing);
            }
            bool flag2 = this._unknownFields != null;
            if (flag2)
            {
                this._unknownFields.WriteTo(ref output);
            }
        }

        // Token: 0x0600A234 RID: 41524 RVA: 0x0023E4C0 File Offset: 0x0023C6C0
        [DebuggerNonUserCode]
        public int CalculateSize()
        {
            int num = 0;
            bool flag = this.entityId_ != null;
            if (flag)
            {
                num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityId);
            }
            num += this.fieldOperation_.CalculateSize(Bgs.Protocol.Presence.V1.ChannelState._repeated_fieldOperation_codec);
            bool hasHealing = this.HasHealing;
            if (hasHealing)
            {
                num += 2;
            }
            bool flag2 = this._unknownFields != null;
            if (flag2)
            {
                num += this._unknownFields.CalculateSize();
            }
            return num;
        }

        // Token: 0x0600A235 RID: 41525 RVA: 0x0023E538 File Offset: 0x0023C738
        [DebuggerNonUserCode]
        public void MergeFrom(Bgs.Protocol.Presence.V1.ChannelState other)
        {
            bool flag = other == null;
            if (!flag)
            {
                bool flag2 = other.entityId_ != null;
                if (flag2)
                {
                    bool flag3 = this.entityId_ == null;
                    if (flag3)
                    {
                        this.EntityId = new EntityId();
                    }
                    this.EntityId.MergeFrom(other.EntityId);
                }
                this.fieldOperation_.Add(other.fieldOperation_);
                bool hasHealing = other.HasHealing;
                if (hasHealing)
                {
                    this.Healing = other.Healing;
                }
                this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
            }
        }

        // Token: 0x0600A236 RID: 41526 RVA: 0x0000396B File Offset: 0x00001B6B
        [DebuggerNonUserCode]
        public void MergeFrom(CodedInputStream input)
        {
            input.ReadRawMessage(this);
        }

        // Token: 0x0600A237 RID: 41527 RVA: 0x0023E5D0 File Offset: 0x0023C7D0
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
                            this.Healing = input.ReadBool();
                        }
                    }
                    else
                    {
                        this.fieldOperation_.AddEntriesFrom(ref input, Bgs.Protocol.Presence.V1.ChannelState._repeated_fieldOperation_codec);
                    }
                }
                else
                {
                    bool flag = this.entityId_ == null;
                    if (flag)
                    {
                        this.EntityId = new EntityId();
                    }
                    input.ReadMessage(this.EntityId);
                }
            }
        }

        // Token: 0x040046FA RID: 18170
        private static readonly MessageParser<Bgs.Protocol.Presence.V1.ChannelState> _parser = new MessageParser<Bgs.Protocol.Presence.V1.ChannelState>(() => new Bgs.Protocol.Presence.V1.ChannelState());

        // Token: 0x040046FB RID: 18171
        private UnknownFieldSet _unknownFields;

        // Token: 0x040046FC RID: 18172
        private int _hasBits0;

        // Token: 0x040046FD RID: 18173
        public const int EntityIdFieldNumber = 1;

        // Token: 0x040046FE RID: 18174
        private EntityId entityId_;

        // Token: 0x040046FF RID: 18175
        public const int FieldOperationFieldNumber = 2;

        // Token: 0x04004700 RID: 18176
        private static readonly FieldCodec<FieldOperation> _repeated_fieldOperation_codec = FieldCodec.ForMessage<FieldOperation>(18U, Bgs.Protocol.Presence.V1.FieldOperation.Parser);

        // Token: 0x04004701 RID: 18177
        private readonly RepeatedField<FieldOperation> fieldOperation_ = new RepeatedField<FieldOperation>();

        // Token: 0x04004702 RID: 18178
        public const int HealingFieldNumber = 3;

        // Token: 0x04004703 RID: 18179
        private static readonly bool HealingDefaultValue = false;

        // Token: 0x04004704 RID: 18180
        private bool healing_;

<<<<<<< HEAD
		// Token: 0x0200108F RID: 4239
		[DebuggerNonUserCode]
		public static class Extensions
		{
			// Token: 0x040097DD RID: 38877
			public static readonly Extension<Bgs.Protocol.Channel.V1.ChannelState, ChannelState> Presence = new Extension<Bgs.Protocol.Channel.V1.ChannelState, ChannelState>(101, FieldCodec.ForMessage<ChannelState>(810U, ChannelState.Parser));
		}
	}
=======
        // Token: 0x02000B83 RID: 2947
        [DebuggerNonUserCode]
        public static class Extensions
        {
            // Token: 0x04004705 RID: 18181
            public static readonly Extension<Bgs.Protocol.Channel.V1.ChannelState, Bgs.Protocol.Presence.V1.ChannelState> Presence = new Extension<Bgs.Protocol.Channel.V1.ChannelState, Bgs.Protocol.Presence.V1.ChannelState>(101, FieldCodec.ForMessage<Bgs.Protocol.Presence.V1.ChannelState>(810U, Bgs.Protocol.Presence.V1.ChannelState.Parser));
        }
    }
>>>>>>> af1e099f8bc7c618aaccfe1feb2a846143c0312a
}
