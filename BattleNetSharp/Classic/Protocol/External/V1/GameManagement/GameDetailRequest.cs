using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x02000793 RID: 1939
	public sealed class GameDetailRequest : IMessage<GameDetailRequest>, IMessage, IEquatable<GameDetailRequest>, IDeepCloneable<GameDetailRequest>, IBufferMessage
	{
		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600B214 RID: 45588 RVA: 0x002B593C File Offset: 0x002B3B3C
		[DebuggerNonUserCode]
		public static MessageParser<GameDetailRequest> Parser
		{
			get
			{
				return GameDetailRequest._parser;
			}
		}

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600B215 RID: 45589 RVA: 0x002B5954 File Offset: 0x002B3B54
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600B216 RID: 45590 RVA: 0x002B5978 File Offset: 0x002B3B78
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameDetailRequest.Descriptor;
			}
		}

		// Token: 0x0600B217 RID: 45591 RVA: 0x002B598F File Offset: 0x002B3B8F
		[DebuggerNonUserCode]
		public GameDetailRequest()
		{
		}

		// Token: 0x0600B218 RID: 45592 RVA: 0x002B5999 File Offset: 0x002B3B99
		[DebuggerNonUserCode]
		public GameDetailRequest(GameDetailRequest other)
			: this()
		{
			this.gameName_ = other.gameName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B219 RID: 45593 RVA: 0x002B59C0 File Offset: 0x002B3BC0
		[DebuggerNonUserCode]
		public GameDetailRequest Clone()
		{
			return new GameDetailRequest(this);
		}

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600B21A RID: 45594 RVA: 0x002B59D8 File Offset: 0x002B3BD8
		// (set) Token: 0x0600B21B RID: 45595 RVA: 0x002B59F9 File Offset: 0x002B3BF9
		[DebuggerNonUserCode]
		public string GameName
		{
			get
			{
				return this.gameName_ ?? GameDetailRequest.GameNameDefaultValue;
			}
			set
			{
				this.gameName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600B21C RID: 45596 RVA: 0x002B5A10 File Offset: 0x002B3C10
		[DebuggerNonUserCode]
		public bool HasGameName
		{
			get
			{
				return this.gameName_ != null;
			}
		}

		// Token: 0x0600B21D RID: 45597 RVA: 0x002B5A2B File Offset: 0x002B3C2B
		[DebuggerNonUserCode]
		public void ClearGameName()
		{
			this.gameName_ = null;
		}

		// Token: 0x0600B21E RID: 45598 RVA: 0x002B5A38 File Offset: 0x002B3C38
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameDetailRequest);
		}

		// Token: 0x0600B21F RID: 45599 RVA: 0x002B5A58 File Offset: 0x002B3C58
		[DebuggerNonUserCode]
		public bool Equals(GameDetailRequest other)
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
					bool flag4 = this.GameName != other.GameName;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600B220 RID: 45600 RVA: 0x002B5AB0 File Offset: 0x002B3CB0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num ^= this.GameName.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B221 RID: 45601 RVA: 0x002B5AFC File Offset: 0x002B3CFC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B222 RID: 45602 RVA: 0x002B5B14 File Offset: 0x002B3D14
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B223 RID: 45603 RVA: 0x002B5B20 File Offset: 0x002B3D20
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				output.WriteRawTag(10);
				output.WriteString(this.GameName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B224 RID: 45604 RVA: 0x002B5B6C File Offset: 0x002B3D6C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasGameName = this.HasGameName;
			if (hasGameName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.GameName);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B225 RID: 45605 RVA: 0x002B5BBC File Offset: 0x002B3DBC
		[DebuggerNonUserCode]
		public void MergeFrom(GameDetailRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasGameName = other.HasGameName;
				if (hasGameName)
				{
					this.GameName = other.GameName;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B226 RID: 45606 RVA: 0x002B5C05 File Offset: 0x002B3E05
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B227 RID: 45607 RVA: 0x002B5C10 File Offset: 0x002B3E10
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.GameName = input.ReadString();
				}
			}
		}

		// Token: 0x04005063 RID: 20579
		private static readonly MessageParser<GameDetailRequest> _parser = new MessageParser<GameDetailRequest>(() => new GameDetailRequest());

		// Token: 0x04005064 RID: 20580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005065 RID: 20581
		public const int GameNameFieldNumber = 1;

		// Token: 0x04005066 RID: 20582
		private static readonly string GameNameDefaultValue = "";

		// Token: 0x04005067 RID: 20583
		private string gameName_;
	}
}
