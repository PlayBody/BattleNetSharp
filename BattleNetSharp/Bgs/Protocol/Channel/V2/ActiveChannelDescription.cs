using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Channel.V2
{
	// Token: 0x020006A1 RID: 1697
	public sealed class ActiveChannelDescription : IMessage<ActiveChannelDescription>, IMessage, IEquatable<ActiveChannelDescription>, IDeepCloneable<ActiveChannelDescription>, IBufferMessage
	{
		// Token: 0x170030F5 RID: 12533
		// (get) Token: 0x06009D7E RID: 40318 RVA: 0x0026466C File Offset: 0x0026286C
		[DebuggerNonUserCode]
		public static MessageParser<ActiveChannelDescription> Parser
		{
			get
			{
				return ActiveChannelDescription._parser;
			}
		}

		// Token: 0x170030F6 RID: 12534
		// (get) Token: 0x06009D7F RID: 40319 RVA: 0x00264684 File Offset: 0x00262884
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ServerChannelTypesReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x170030F7 RID: 12535
		// (get) Token: 0x06009D80 RID: 40320 RVA: 0x002646A8 File Offset: 0x002628A8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActiveChannelDescription.Descriptor;
			}
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x002646BF File Offset: 0x002628BF
		[DebuggerNonUserCode]
		public ActiveChannelDescription()
		{
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x002646CC File Offset: 0x002628CC
		[DebuggerNonUserCode]
		public ActiveChannelDescription(ActiveChannelDescription other)
			: this()
		{
			this.type_ = ((other.type_ != null) ? other.type_.Clone() : null);
			this.channelId_ = ((other.channelId_ != null) ? other.channelId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x0026472C File Offset: 0x0026292C
		[DebuggerNonUserCode]
		public ActiveChannelDescription Clone()
		{
			return new ActiveChannelDescription(this);
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06009D84 RID: 40324 RVA: 0x00264744 File Offset: 0x00262944
		// (set) Token: 0x06009D85 RID: 40325 RVA: 0x0026475C File Offset: 0x0026295C
		[DebuggerNonUserCode]
		public UniqueChannelType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009D86 RID: 40326 RVA: 0x00264768 File Offset: 0x00262968
		// (set) Token: 0x06009D87 RID: 40327 RVA: 0x00264780 File Offset: 0x00262980
		[DebuggerNonUserCode]
		public ChannelId ChannelId
		{
			get
			{
				return this.channelId_;
			}
			set
			{
				this.channelId_ = value;
			}
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x0026478C File Offset: 0x0026298C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActiveChannelDescription);
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x002647AC File Offset: 0x002629AC
		[DebuggerNonUserCode]
		public bool Equals(ActiveChannelDescription other)
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
					bool flag4 = !object.Equals(this.Type, other.Type);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.ChannelId, other.ChannelId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x00264824 File Offset: 0x00262A24
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.type_ != null;
			if (flag)
			{
				num ^= this.Type.GetHashCode();
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num ^= this.ChannelId.GetHashCode();
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x00264890 File Offset: 0x00262A90
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x002648A8 File Offset: 0x00262AA8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x002648B4 File Offset: 0x00262AB4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.type_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Type);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.ChannelId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x00264928 File Offset: 0x00262B28
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.type_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Type);
			}
			bool flag2 = this.channelId_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ChannelId);
			}
			bool flag3 = this._unknownFields != null;
			if (flag3)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x0026499C File Offset: 0x00262B9C
		[DebuggerNonUserCode]
		public void MergeFrom(ActiveChannelDescription other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.type_ != null;
				if (flag2)
				{
					bool flag3 = this.type_ == null;
					if (flag3)
					{
						this.Type = new UniqueChannelType();
					}
					this.Type.MergeFrom(other.Type);
				}
				bool flag4 = other.channelId_ != null;
				if (flag4)
				{
					bool flag5 = this.channelId_ == null;
					if (flag5)
					{
						this.ChannelId = new ChannelId();
					}
					this.ChannelId.MergeFrom(other.ChannelId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x00264A49 File Offset: 0x00262C49
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x00264A54 File Offset: 0x00262C54
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.channelId_ == null;
						if (flag)
						{
							this.ChannelId = new ChannelId();
						}
						input.ReadMessage(this.ChannelId);
					}
				}
				else
				{
					bool flag2 = this.type_ == null;
					if (flag2)
					{
						this.Type = new UniqueChannelType();
					}
					input.ReadMessage(this.Type);
				}
			}
		}

		// Token: 0x04004715 RID: 18197
		private static readonly MessageParser<ActiveChannelDescription> _parser = new MessageParser<ActiveChannelDescription>(() => new ActiveChannelDescription());

		// Token: 0x04004716 RID: 18198
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004717 RID: 18199
		public const int TypeFieldNumber = 1;

		// Token: 0x04004718 RID: 18200
		private UniqueChannelType type_;

		// Token: 0x04004719 RID: 18201
		public const int ChannelIdFieldNumber = 2;

		// Token: 0x0400471A RID: 18202
		private ChannelId channelId_;
	}
}
