using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Matchmaking.V1
{
	// Token: 0x020003E4 RID: 996
	public sealed class MatchmakerControlProperties : IMessage<MatchmakerControlProperties>, IMessage, IEquatable<MatchmakerControlProperties>, IDeepCloneable<MatchmakerControlProperties>, IBufferMessage
	{
		// Token: 0x17001FF4 RID: 8180
		// (get) Token: 0x06006330 RID: 25392 RVA: 0x0017FEB8 File Offset: 0x0017E0B8
		[DebuggerNonUserCode]
		public static MessageParser<MatchmakerControlProperties> Parser
		{
			get
			{
				return MatchmakerControlProperties._parser;
			}
		}

		// Token: 0x17001FF5 RID: 8181
		// (get) Token: 0x06006331 RID: 25393 RVA: 0x0017FED0 File Offset: 0x0017E0D0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameMatchmakingTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001FF6 RID: 8182
		// (get) Token: 0x06006332 RID: 25394 RVA: 0x0017FEF4 File Offset: 0x0017E0F4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchmakerControlProperties.Descriptor;
			}
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x0017FF0B File Offset: 0x0017E10B
		[DebuggerNonUserCode]
		public MatchmakerControlProperties()
		{
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x0017FF15 File Offset: 0x0017E115
		[DebuggerNonUserCode]
		public MatchmakerControlProperties(MatchmakerControlProperties other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.acceptNewEntries_ = other.acceptNewEntries_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006335 RID: 25397 RVA: 0x0017FF48 File Offset: 0x0017E148
		[DebuggerNonUserCode]
		public MatchmakerControlProperties Clone()
		{
			return new MatchmakerControlProperties(this);
		}

		// Token: 0x17001FF7 RID: 8183
		// (get) Token: 0x06006336 RID: 25398 RVA: 0x0017FF60 File Offset: 0x0017E160
		// (set) Token: 0x06006337 RID: 25399 RVA: 0x0017FF91 File Offset: 0x0017E191
		[DebuggerNonUserCode]
		public bool AcceptNewEntries
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool acceptNewEntriesDefaultValue;
				if (flag)
				{
					acceptNewEntriesDefaultValue = this.acceptNewEntries_;
				}
				else
				{
					acceptNewEntriesDefaultValue = MatchmakerControlProperties.AcceptNewEntriesDefaultValue;
				}
				return acceptNewEntriesDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.acceptNewEntries_ = value;
			}
		}

		// Token: 0x17001FF8 RID: 8184
		// (get) Token: 0x06006338 RID: 25400 RVA: 0x0017FFAC File Offset: 0x0017E1AC
		[DebuggerNonUserCode]
		public bool HasAcceptNewEntries
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006339 RID: 25401 RVA: 0x0017FFC9 File Offset: 0x0017E1C9
		[DebuggerNonUserCode]
		public void ClearAcceptNewEntries()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x0600633A RID: 25402 RVA: 0x0017FFDC File Offset: 0x0017E1DC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchmakerControlProperties);
		}

		// Token: 0x0600633B RID: 25403 RVA: 0x0017FFFC File Offset: 0x0017E1FC
		[DebuggerNonUserCode]
		public bool Equals(MatchmakerControlProperties other)
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
					bool flag4 = this.AcceptNewEntries != other.AcceptNewEntries;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600633C RID: 25404 RVA: 0x00180054 File Offset: 0x0017E254
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasAcceptNewEntries = this.HasAcceptNewEntries;
			if (hasAcceptNewEntries)
			{
				num ^= this.AcceptNewEntries.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600633D RID: 25405 RVA: 0x001800A4 File Offset: 0x0017E2A4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600633E RID: 25406 RVA: 0x001800BC File Offset: 0x0017E2BC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600633F RID: 25407 RVA: 0x001800C8 File Offset: 0x0017E2C8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasAcceptNewEntries = this.HasAcceptNewEntries;
			if (hasAcceptNewEntries)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.AcceptNewEntries);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006340 RID: 25408 RVA: 0x00180114 File Offset: 0x0017E314
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasAcceptNewEntries = this.HasAcceptNewEntries;
			if (hasAcceptNewEntries)
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

		// Token: 0x06006341 RID: 25409 RVA: 0x00180158 File Offset: 0x0017E358
		[DebuggerNonUserCode]
		public void MergeFrom(MatchmakerControlProperties other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasAcceptNewEntries = other.HasAcceptNewEntries;
				if (hasAcceptNewEntries)
				{
					this.AcceptNewEntries = other.AcceptNewEntries;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006342 RID: 25410 RVA: 0x001801A1 File Offset: 0x0017E3A1
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006343 RID: 25411 RVA: 0x001801AC File Offset: 0x0017E3AC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.AcceptNewEntries = input.ReadBool();
				}
			}
		}

		// Token: 0x04002D49 RID: 11593
		private static readonly MessageParser<MatchmakerControlProperties> _parser = new MessageParser<MatchmakerControlProperties>(() => new MatchmakerControlProperties());

		// Token: 0x04002D4A RID: 11594
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D4B RID: 11595
		private int _hasBits0;

		// Token: 0x04002D4C RID: 11596
		public const int AcceptNewEntriesFieldNumber = 1;

		// Token: 0x04002D4D RID: 11597
		private static readonly bool AcceptNewEntriesDefaultValue = true;

		// Token: 0x04002D4E RID: 11598
		private bool acceptNewEntries_;
	}
}
