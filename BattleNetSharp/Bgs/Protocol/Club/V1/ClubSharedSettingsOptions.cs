using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000473 RID: 1139
	public sealed class ClubSharedSettingsOptions : IMessage<ClubSharedSettingsOptions>, IMessage, IEquatable<ClubSharedSettingsOptions>, IDeepCloneable<ClubSharedSettingsOptions>, IBufferMessage
	{
		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x06006F4E RID: 28494 RVA: 0x001B0EA8 File Offset: 0x001AF0A8
		[DebuggerNonUserCode]
		public static MessageParser<ClubSharedSettingsOptions> Parser
		{
			get
			{
				return ClubSharedSettingsOptions._parser;
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06006F4F RID: 28495 RVA: 0x001B0EC0 File Offset: 0x001AF0C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMembershipTypesReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06006F50 RID: 28496 RVA: 0x001B0EE4 File Offset: 0x001AF0E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClubSharedSettingsOptions.Descriptor;
			}
		}

		// Token: 0x06006F51 RID: 28497 RVA: 0x001B0EFB File Offset: 0x001AF0FB
		[DebuggerNonUserCode]
		public ClubSharedSettingsOptions()
		{
		}

		// Token: 0x06006F52 RID: 28498 RVA: 0x001B0F05 File Offset: 0x001AF105
		[DebuggerNonUserCode]
		public ClubSharedSettingsOptions(ClubSharedSettingsOptions other)
			: this()
		{
			this.clubPosition_ = ((other.clubPosition_ != null) ? other.clubPosition_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F53 RID: 28499 RVA: 0x001B0F3C File Offset: 0x001AF13C
		[DebuggerNonUserCode]
		public ClubSharedSettingsOptions Clone()
		{
			return new ClubSharedSettingsOptions(this);
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06006F54 RID: 28500 RVA: 0x001B0F54 File Offset: 0x001AF154
		// (set) Token: 0x06006F55 RID: 28501 RVA: 0x001B0F6C File Offset: 0x001AF16C
		[DebuggerNonUserCode]
		public ClubPosition ClubPosition
		{
			get
			{
				return this.clubPosition_;
			}
			set
			{
				this.clubPosition_ = value;
			}
		}

		// Token: 0x06006F56 RID: 28502 RVA: 0x001B0F78 File Offset: 0x001AF178
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClubSharedSettingsOptions);
		}

		// Token: 0x06006F57 RID: 28503 RVA: 0x001B0F98 File Offset: 0x001AF198
		[DebuggerNonUserCode]
		public bool Equals(ClubSharedSettingsOptions other)
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
					bool flag4 = !object.Equals(this.ClubPosition, other.ClubPosition);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006F58 RID: 28504 RVA: 0x001B0FF4 File Offset: 0x001AF1F4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				num ^= this.ClubPosition.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F59 RID: 28505 RVA: 0x001B1044 File Offset: 0x001AF244
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006F5A RID: 28506 RVA: 0x001B105C File Offset: 0x001AF25C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F5B RID: 28507 RVA: 0x001B1068 File Offset: 0x001AF268
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.ClubPosition);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F5C RID: 28508 RVA: 0x001B10B8 File Offset: 0x001AF2B8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.clubPosition_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ClubPosition);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F5D RID: 28509 RVA: 0x001B110C File Offset: 0x001AF30C
		[DebuggerNonUserCode]
		public void MergeFrom(ClubSharedSettingsOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.clubPosition_ != null;
				if (flag2)
				{
					bool flag3 = this.clubPosition_ == null;
					if (flag3)
					{
						this.ClubPosition = new ClubPosition();
					}
					this.ClubPosition.MergeFrom(other.ClubPosition);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006F5E RID: 28510 RVA: 0x001B1178 File Offset: 0x001AF378
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F5F RID: 28511 RVA: 0x001B1184 File Offset: 0x001AF384
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
					bool flag = this.clubPosition_ == null;
					if (flag)
					{
						this.ClubPosition = new ClubPosition();
					}
					input.ReadMessage(this.ClubPosition);
				}
			}
		}

		// Token: 0x04003316 RID: 13078
		private static readonly MessageParser<ClubSharedSettingsOptions> _parser = new MessageParser<ClubSharedSettingsOptions>(() => new ClubSharedSettingsOptions());

		// Token: 0x04003317 RID: 13079
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003318 RID: 13080
		public const int ClubPositionFieldNumber = 1;

		// Token: 0x04003319 RID: 13081
		private ClubPosition clubPosition_;
	}
}
