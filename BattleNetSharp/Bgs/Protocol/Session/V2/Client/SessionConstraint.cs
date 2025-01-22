using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x0200056D RID: 1389
	public sealed class SessionConstraint : IMessage<SessionConstraint>, IMessage, IEquatable<SessionConstraint>, IDeepCloneable<SessionConstraint>, IBufferMessage
	{
		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x060085A8 RID: 34216 RVA: 0x002079BC File Offset: 0x00205BBC
		[DebuggerNonUserCode]
		public static MessageParser<SessionConstraint> Parser
		{
			get
			{
				return SessionConstraint._parser;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x002079D4 File Offset: 0x00205BD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x060085AA RID: 34218 RVA: 0x002079F8 File Offset: 0x00205BF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SessionConstraint.Descriptor;
			}
		}

		// Token: 0x060085AB RID: 34219 RVA: 0x00207A0F File Offset: 0x00205C0F
		[DebuggerNonUserCode]
		public SessionConstraint()
		{
		}

		// Token: 0x060085AC RID: 34220 RVA: 0x00207A19 File Offset: 0x00205C19
		[DebuggerNonUserCode]
		public SessionConstraint(SessionConstraint other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.parentalControlsActive_ = other.parentalControlsActive_;
			this.nextPcKickTimeMs_ = other.nextPcKickTimeMs_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060085AD RID: 34221 RVA: 0x00207A58 File Offset: 0x00205C58
		[DebuggerNonUserCode]
		public SessionConstraint Clone()
		{
			return new SessionConstraint(this);
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x060085AE RID: 34222 RVA: 0x00207A70 File Offset: 0x00205C70
		// (set) Token: 0x060085AF RID: 34223 RVA: 0x00207AA1 File Offset: 0x00205CA1
		[DebuggerNonUserCode]
		public bool ParentalControlsActive
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool parentalControlsActiveDefaultValue;
				if (flag)
				{
					parentalControlsActiveDefaultValue = this.parentalControlsActive_;
				}
				else
				{
					parentalControlsActiveDefaultValue = SessionConstraint.ParentalControlsActiveDefaultValue;
				}
				return parentalControlsActiveDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.parentalControlsActive_ = value;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x060085B0 RID: 34224 RVA: 0x00207ABC File Offset: 0x00205CBC
		[DebuggerNonUserCode]
		public bool HasParentalControlsActive
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060085B1 RID: 34225 RVA: 0x00207AD9 File Offset: 0x00205CD9
		[DebuggerNonUserCode]
		public void ClearParentalControlsActive()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x060085B2 RID: 34226 RVA: 0x00207AEC File Offset: 0x00205CEC
		// (set) Token: 0x060085B3 RID: 34227 RVA: 0x00207B1D File Offset: 0x00205D1D
		[DebuggerNonUserCode]
		public ulong NextPcKickTimeMs
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ulong nextPcKickTimeMsDefaultValue;
				if (flag)
				{
					nextPcKickTimeMsDefaultValue = this.nextPcKickTimeMs_;
				}
				else
				{
					nextPcKickTimeMsDefaultValue = SessionConstraint.NextPcKickTimeMsDefaultValue;
				}
				return nextPcKickTimeMsDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.nextPcKickTimeMs_ = value;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x060085B4 RID: 34228 RVA: 0x00207B38 File Offset: 0x00205D38
		[DebuggerNonUserCode]
		public bool HasNextPcKickTimeMs
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x060085B5 RID: 34229 RVA: 0x00207B55 File Offset: 0x00205D55
		[DebuggerNonUserCode]
		public void ClearNextPcKickTimeMs()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x060085B6 RID: 34230 RVA: 0x00207B68 File Offset: 0x00205D68
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SessionConstraint);
		}

		// Token: 0x060085B7 RID: 34231 RVA: 0x00207B88 File Offset: 0x00205D88
		[DebuggerNonUserCode]
		public bool Equals(SessionConstraint other)
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
					bool flag4 = this.ParentalControlsActive != other.ParentalControlsActive;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.NextPcKickTimeMs != other.NextPcKickTimeMs;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060085B8 RID: 34232 RVA: 0x00207BFC File Offset: 0x00205DFC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num ^= this.ParentalControlsActive.GetHashCode();
			}
			bool hasNextPcKickTimeMs = this.HasNextPcKickTimeMs;
			if (hasNextPcKickTimeMs)
			{
				num ^= this.NextPcKickTimeMs.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060085B9 RID: 34233 RVA: 0x00207C6C File Offset: 0x00205E6C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060085BA RID: 34234 RVA: 0x00207C84 File Offset: 0x00205E84
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060085BB RID: 34235 RVA: 0x00207C90 File Offset: 0x00205E90
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.ParentalControlsActive);
			}
			bool hasNextPcKickTimeMs = this.HasNextPcKickTimeMs;
			if (hasNextPcKickTimeMs)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.NextPcKickTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060085BC RID: 34236 RVA: 0x00207D00 File Offset: 0x00205F00
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasParentalControlsActive = this.HasParentalControlsActive;
			if (hasParentalControlsActive)
			{
				num += 2;
			}
			bool hasNextPcKickTimeMs = this.HasNextPcKickTimeMs;
			if (hasNextPcKickTimeMs)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.NextPcKickTimeMs);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060085BD RID: 34237 RVA: 0x00207D60 File Offset: 0x00205F60
		[DebuggerNonUserCode]
		public void MergeFrom(SessionConstraint other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasParentalControlsActive = other.HasParentalControlsActive;
				if (hasParentalControlsActive)
				{
					this.ParentalControlsActive = other.ParentalControlsActive;
				}
				bool hasNextPcKickTimeMs = other.HasNextPcKickTimeMs;
				if (hasNextPcKickTimeMs)
				{
					this.NextPcKickTimeMs = other.NextPcKickTimeMs;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060085BE RID: 34238 RVA: 0x00207DC2 File Offset: 0x00205FC2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060085BF RID: 34239 RVA: 0x00207DD0 File Offset: 0x00205FD0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 8U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextPcKickTimeMs = input.ReadUInt64();
					}
				}
				else
				{
					this.ParentalControlsActive = input.ReadBool();
				}
			}
		}

		// Token: 0x04003CA3 RID: 15523
		private static readonly MessageParser<SessionConstraint> _parser = new MessageParser<SessionConstraint>(() => new SessionConstraint());

		// Token: 0x04003CA4 RID: 15524
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CA5 RID: 15525
		private int _hasBits0;

		// Token: 0x04003CA6 RID: 15526
		public const int ParentalControlsActiveFieldNumber = 1;

		// Token: 0x04003CA7 RID: 15527
		private static readonly bool ParentalControlsActiveDefaultValue = false;

		// Token: 0x04003CA8 RID: 15528
		private bool parentalControlsActive_;

		// Token: 0x04003CA9 RID: 15529
		public const int NextPcKickTimeMsFieldNumber = 2;

		// Token: 0x04003CAA RID: 15530
		private static readonly ulong NextPcKickTimeMsDefaultValue = 0UL;

		// Token: 0x04003CAB RID: 15531
		private ulong nextPcKickTimeMs_;
	}
}
