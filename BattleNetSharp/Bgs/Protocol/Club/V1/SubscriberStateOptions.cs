using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Club.V1
{
	// Token: 0x02000467 RID: 1127
	public sealed class SubscriberStateOptions : IMessage<SubscriberStateOptions>, IMessage, IEquatable<SubscriberStateOptions>, IDeepCloneable<SubscriberStateOptions>, IBufferMessage
	{
		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06006E50 RID: 28240 RVA: 0x001AD51C File Offset: 0x001AB71C
		[DebuggerNonUserCode]
		public static MessageParser<SubscriberStateOptions> Parser
		{
			get
			{
				return SubscriberStateOptions._parser;
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06006E51 RID: 28241 RVA: 0x001AD534 File Offset: 0x001AB734
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClubMemberReflection.Descriptor.MessageTypes[11];
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x001AD558 File Offset: 0x001AB758
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SubscriberStateOptions.Descriptor;
			}
		}

		// Token: 0x06006E53 RID: 28243 RVA: 0x001AD56F File Offset: 0x001AB76F
		[DebuggerNonUserCode]
		public SubscriberStateOptions()
		{
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x001AD579 File Offset: 0x001AB779
		[DebuggerNonUserCode]
		public SubscriberStateOptions(SubscriberStateOptions other)
			: this()
		{
			this.voice_ = ((other.voice_ != null) ? other.voice_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x001AD5B0 File Offset: 0x001AB7B0
		[DebuggerNonUserCode]
		public SubscriberStateOptions Clone()
		{
			return new SubscriberStateOptions(this);
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x001AD5C8 File Offset: 0x001AB7C8
		// (set) Token: 0x06006E57 RID: 28247 RVA: 0x001AD5E0 File Offset: 0x001AB7E0
		[DebuggerNonUserCode]
		public MemberVoiceOptions Voice
		{
			get
			{
				return this.voice_;
			}
			set
			{
				this.voice_ = value;
			}
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x001AD5EC File Offset: 0x001AB7EC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SubscriberStateOptions);
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x001AD60C File Offset: 0x001AB80C
		[DebuggerNonUserCode]
		public bool Equals(SubscriberStateOptions other)
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
					bool flag4 = !object.Equals(this.Voice, other.Voice);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x001AD668 File Offset: 0x001AB868
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.voice_ != null;
			if (flag)
			{
				num ^= this.Voice.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E5B RID: 28251 RVA: 0x001AD6B8 File Offset: 0x001AB8B8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006E5C RID: 28252 RVA: 0x001AD6D0 File Offset: 0x001AB8D0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x001AD6DC File Offset: 0x001AB8DC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.voice_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Voice);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E5E RID: 28254 RVA: 0x001AD72C File Offset: 0x001AB92C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.voice_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Voice);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E5F RID: 28255 RVA: 0x001AD780 File Offset: 0x001AB980
		[DebuggerNonUserCode]
		public void MergeFrom(SubscriberStateOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.voice_ != null;
				if (flag2)
				{
					bool flag3 = this.voice_ == null;
					if (flag3)
					{
						this.Voice = new MemberVoiceOptions();
					}
					this.Voice.MergeFrom(other.Voice);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x001AD7EC File Offset: 0x001AB9EC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x001AD7F8 File Offset: 0x001AB9F8
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
					bool flag = this.voice_ == null;
					if (flag)
					{
						this.Voice = new MemberVoiceOptions();
					}
					input.ReadMessage(this.Voice);
				}
			}
		}

		// Token: 0x040032B6 RID: 12982
		private static readonly MessageParser<SubscriberStateOptions> _parser = new MessageParser<SubscriberStateOptions>(() => new SubscriberStateOptions());

		// Token: 0x040032B7 RID: 12983
		private UnknownFieldSet _unknownFields;

		// Token: 0x040032B8 RID: 12984
		public const int VoiceFieldNumber = 1;

		// Token: 0x040032B9 RID: 12985
		private MemberVoiceOptions voice_;
	}
}
