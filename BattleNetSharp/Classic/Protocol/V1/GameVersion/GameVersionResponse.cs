using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.V1.GameVersion
{
	// Token: 0x02000769 RID: 1897
	public sealed class GameVersionResponse : IMessage<GameVersionResponse>, IMessage, IEquatable<GameVersionResponse>, IDeepCloneable<GameVersionResponse>, IBufferMessage
	{
		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600AE40 RID: 44608 RVA: 0x002A6B78 File Offset: 0x002A4D78
		[DebuggerNonUserCode]
		public static MessageParser<GameVersionResponse> Parser
		{
			get
			{
				return GameVersionResponse._parser;
			}
		}

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600AE41 RID: 44609 RVA: 0x002A6B90 File Offset: 0x002A4D90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameVersionReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600AE42 RID: 44610 RVA: 0x002A6BB4 File Offset: 0x002A4DB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameVersionResponse.Descriptor;
			}
		}

		// Token: 0x0600AE43 RID: 44611 RVA: 0x002A6BCB File Offset: 0x002A4DCB
		[DebuggerNonUserCode]
		public GameVersionResponse()
		{
		}

		// Token: 0x0600AE44 RID: 44612 RVA: 0x002A6BD5 File Offset: 0x002A4DD5
		[DebuggerNonUserCode]
		public GameVersionResponse(GameVersionResponse other)
			: this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AE45 RID: 44613 RVA: 0x002A6BFC File Offset: 0x002A4DFC
		[DebuggerNonUserCode]
		public GameVersionResponse Clone()
		{
			return new GameVersionResponse(this);
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600AE46 RID: 44614 RVA: 0x002A6C14 File Offset: 0x002A4E14
		// (set) Token: 0x0600AE47 RID: 44615 RVA: 0x002A6C35 File Offset: 0x002A4E35
		[DebuggerNonUserCode]
		public ByteString Data
		{
			get
			{
				return this.data_ ?? GameVersionResponse.DataDefaultValue;
			}
			set
			{
				this.data_ = ProtoPreconditions.CheckNotNull<ByteString>(value, "value");
			}
		}

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600AE48 RID: 44616 RVA: 0x002A6C4C File Offset: 0x002A4E4C
		[DebuggerNonUserCode]
		public bool HasData
		{
			get
			{
				return this.data_ != null;
			}
		}

		// Token: 0x0600AE49 RID: 44617 RVA: 0x002A6C6A File Offset: 0x002A4E6A
		[DebuggerNonUserCode]
		public void ClearData()
		{
			this.data_ = null;
		}

		// Token: 0x0600AE4A RID: 44618 RVA: 0x002A6C74 File Offset: 0x002A4E74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameVersionResponse);
		}

		// Token: 0x0600AE4B RID: 44619 RVA: 0x002A6C94 File Offset: 0x002A4E94
		[DebuggerNonUserCode]
		public bool Equals(GameVersionResponse other)
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
					bool flag4 = this.Data != other.Data;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AE4C RID: 44620 RVA: 0x002A6CEC File Offset: 0x002A4EEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasData = this.HasData;
			if (hasData)
			{
				num ^= this.Data.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AE4D RID: 44621 RVA: 0x002A6D38 File Offset: 0x002A4F38
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AE4E RID: 44622 RVA: 0x002A6D50 File Offset: 0x002A4F50
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AE4F RID: 44623 RVA: 0x002A6D5C File Offset: 0x002A4F5C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasData = this.HasData;
			if (hasData)
			{
				output.WriteRawTag(26);
				output.WriteBytes(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AE50 RID: 44624 RVA: 0x002A6DA8 File Offset: 0x002A4FA8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasData = this.HasData;
			if (hasData)
			{
				num += 1 + CodedOutputStream.ComputeBytesSize(this.Data);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AE51 RID: 44625 RVA: 0x002A6DF8 File Offset: 0x002A4FF8
		[DebuggerNonUserCode]
		public void MergeFrom(GameVersionResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasData = other.HasData;
				if (hasData)
				{
					this.Data = other.Data;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AE52 RID: 44626 RVA: 0x002A6E41 File Offset: 0x002A5041
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AE53 RID: 44627 RVA: 0x002A6E4C File Offset: 0x002A504C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadBytes();
				}
			}
		}

		// Token: 0x04004E85 RID: 20101
		private static readonly MessageParser<GameVersionResponse> _parser = new MessageParser<GameVersionResponse>(() => new GameVersionResponse());

		// Token: 0x04004E86 RID: 20102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E87 RID: 20103
		public const int DataFieldNumber = 3;

		// Token: 0x04004E88 RID: 20104
		private static readonly ByteString DataDefaultValue = ByteString.Empty;

		// Token: 0x04004E89 RID: 20105
		private ByteString data_;
	}
}
