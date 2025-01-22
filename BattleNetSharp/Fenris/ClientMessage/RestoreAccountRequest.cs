using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x0200023C RID: 572
	public sealed class RestoreAccountRequest : IMessage<RestoreAccountRequest>, IMessage, IEquatable<RestoreAccountRequest>, IDeepCloneable<RestoreAccountRequest>, IBufferMessage
	{
		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x06003DC7 RID: 15815 RVA: 0x000F3B78 File Offset: 0x000F1D78
		[DebuggerNonUserCode]
		public static MessageParser<RestoreAccountRequest> Parser
		{
			get
			{
				return RestoreAccountRequest._parser;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x06003DC8 RID: 15816 RVA: 0x000F3B90 File Offset: 0x000F1D90
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[44];
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x000F3BB4 File Offset: 0x000F1DB4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RestoreAccountRequest.Descriptor;
			}
		}

		// Token: 0x06003DCA RID: 15818 RVA: 0x000F3BCB File Offset: 0x000F1DCB
		[DebuggerNonUserCode]
		public RestoreAccountRequest()
		{
		}

		// Token: 0x06003DCB RID: 15819 RVA: 0x000F3BD8 File Offset: 0x000F1DD8
		[DebuggerNonUserCode]
		public RestoreAccountRequest(RestoreAccountRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.targetGameAccount_ = other.targetGameAccount_;
			this.sourceGameAccount_ = other.sourceGameAccount_;
			this.snapshotVersion_ = other.snapshotVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003DCC RID: 15820 RVA: 0x000F3C30 File Offset: 0x000F1E30
		[DebuggerNonUserCode]
		public RestoreAccountRequest Clone()
		{
			return new RestoreAccountRequest(this);
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x06003DCD RID: 15821 RVA: 0x000F3C48 File Offset: 0x000F1E48
		// (set) Token: 0x06003DCE RID: 15822 RVA: 0x000F3C79 File Offset: 0x000F1E79
		[DebuggerNonUserCode]
		public uint TargetGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint targetGameAccountDefaultValue;
				if (flag)
				{
					targetGameAccountDefaultValue = this.targetGameAccount_;
				}
				else
				{
					targetGameAccountDefaultValue = RestoreAccountRequest.TargetGameAccountDefaultValue;
				}
				return targetGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.targetGameAccount_ = value;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x06003DCF RID: 15823 RVA: 0x000F3C94 File Offset: 0x000F1E94
		[DebuggerNonUserCode]
		public bool HasTargetGameAccount
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003DD0 RID: 15824 RVA: 0x000F3CB1 File Offset: 0x000F1EB1
		[DebuggerNonUserCode]
		public void ClearTargetGameAccount()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x06003DD1 RID: 15825 RVA: 0x000F3CC4 File Offset: 0x000F1EC4
		// (set) Token: 0x06003DD2 RID: 15826 RVA: 0x000F3CF5 File Offset: 0x000F1EF5
		[DebuggerNonUserCode]
		public uint SourceGameAccount
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint sourceGameAccountDefaultValue;
				if (flag)
				{
					sourceGameAccountDefaultValue = this.sourceGameAccount_;
				}
				else
				{
					sourceGameAccountDefaultValue = RestoreAccountRequest.SourceGameAccountDefaultValue;
				}
				return sourceGameAccountDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.sourceGameAccount_ = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x06003DD3 RID: 15827 RVA: 0x000F3D10 File Offset: 0x000F1F10
		[DebuggerNonUserCode]
		public bool HasSourceGameAccount
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x000F3D2D File Offset: 0x000F1F2D
		[DebuggerNonUserCode]
		public void ClearSourceGameAccount()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06003DD5 RID: 15829 RVA: 0x000F3D40 File Offset: 0x000F1F40
		// (set) Token: 0x06003DD6 RID: 15830 RVA: 0x000F3D71 File Offset: 0x000F1F71
		[DebuggerNonUserCode]
		public ulong SnapshotVersion
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				ulong snapshotVersionDefaultValue;
				if (flag)
				{
					snapshotVersionDefaultValue = this.snapshotVersion_;
				}
				else
				{
					snapshotVersionDefaultValue = RestoreAccountRequest.SnapshotVersionDefaultValue;
				}
				return snapshotVersionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.snapshotVersion_ = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06003DD7 RID: 15831 RVA: 0x000F3D8C File Offset: 0x000F1F8C
		[DebuggerNonUserCode]
		public bool HasSnapshotVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06003DD8 RID: 15832 RVA: 0x000F3DA9 File Offset: 0x000F1FA9
		[DebuggerNonUserCode]
		public void ClearSnapshotVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06003DD9 RID: 15833 RVA: 0x000F3DBC File Offset: 0x000F1FBC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as RestoreAccountRequest);
		}

		// Token: 0x06003DDA RID: 15834 RVA: 0x000F3DDC File Offset: 0x000F1FDC
		[DebuggerNonUserCode]
		public bool Equals(RestoreAccountRequest other)
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
					bool flag4 = this.TargetGameAccount != other.TargetGameAccount;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SourceGameAccount != other.SourceGameAccount;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.SnapshotVersion != other.SnapshotVersion;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003DDB RID: 15835 RVA: 0x000F3E68 File Offset: 0x000F2068
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTargetGameAccount = this.HasTargetGameAccount;
			if (hasTargetGameAccount)
			{
				num ^= this.TargetGameAccount.GetHashCode();
			}
			bool hasSourceGameAccount = this.HasSourceGameAccount;
			if (hasSourceGameAccount)
			{
				num ^= this.SourceGameAccount.GetHashCode();
			}
			bool hasSnapshotVersion = this.HasSnapshotVersion;
			if (hasSnapshotVersion)
			{
				num ^= this.SnapshotVersion.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x000F3EF4 File Offset: 0x000F20F4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x000F3F0C File Offset: 0x000F210C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x000F3F18 File Offset: 0x000F2118
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTargetGameAccount = this.HasTargetGameAccount;
			if (hasTargetGameAccount)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TargetGameAccount);
			}
			bool hasSourceGameAccount = this.HasSourceGameAccount;
			if (hasSourceGameAccount)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.SourceGameAccount);
			}
			bool hasSnapshotVersion = this.HasSnapshotVersion;
			if (hasSnapshotVersion)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(this.SnapshotVersion);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003DDF RID: 15839 RVA: 0x000F3FA8 File Offset: 0x000F21A8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTargetGameAccount = this.HasTargetGameAccount;
			if (hasTargetGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TargetGameAccount);
			}
			bool hasSourceGameAccount = this.HasSourceGameAccount;
			if (hasSourceGameAccount)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.SourceGameAccount);
			}
			bool hasSnapshotVersion = this.HasSnapshotVersion;
			if (hasSnapshotVersion)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SnapshotVersion);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003DE0 RID: 15840 RVA: 0x000F4034 File Offset: 0x000F2234
		[DebuggerNonUserCode]
		public void MergeFrom(RestoreAccountRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasTargetGameAccount = other.HasTargetGameAccount;
				if (hasTargetGameAccount)
				{
					this.TargetGameAccount = other.TargetGameAccount;
				}
				bool hasSourceGameAccount = other.HasSourceGameAccount;
				if (hasSourceGameAccount)
				{
					this.SourceGameAccount = other.SourceGameAccount;
				}
				bool hasSnapshotVersion = other.HasSnapshotVersion;
				if (hasSnapshotVersion)
				{
					this.SnapshotVersion = other.SnapshotVersion;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x000F40AF File Offset: 0x000F22AF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003DE2 RID: 15842 RVA: 0x000F40BC File Offset: 0x000F22BC
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
						if (num3 != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SnapshotVersion = input.ReadUInt64();
						}
					}
					else
					{
						this.SourceGameAccount = input.ReadUInt32();
					}
				}
				else
				{
					this.TargetGameAccount = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04001C59 RID: 7257
		private static readonly MessageParser<RestoreAccountRequest> _parser = new MessageParser<RestoreAccountRequest>(() => new RestoreAccountRequest());

		// Token: 0x04001C5A RID: 7258
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001C5B RID: 7259
		private int _hasBits0;

		// Token: 0x04001C5C RID: 7260
		public const int TargetGameAccountFieldNumber = 1;

		// Token: 0x04001C5D RID: 7261
		private static readonly uint TargetGameAccountDefaultValue = 0U;

		// Token: 0x04001C5E RID: 7262
		private uint targetGameAccount_;

		// Token: 0x04001C5F RID: 7263
		public const int SourceGameAccountFieldNumber = 2;

		// Token: 0x04001C60 RID: 7264
		private static readonly uint SourceGameAccountDefaultValue = 0U;

		// Token: 0x04001C61 RID: 7265
		private uint sourceGameAccount_;

		// Token: 0x04001C62 RID: 7266
		public const int SnapshotVersionFieldNumber = 3;

		// Token: 0x04001C63 RID: 7267
		private static readonly ulong SnapshotVersionDefaultValue = 0UL;

		// Token: 0x04001C64 RID: 7268
		private ulong snapshotVersion_;
	}
}
