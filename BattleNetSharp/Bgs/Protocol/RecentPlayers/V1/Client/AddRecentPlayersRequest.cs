using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x02000638 RID: 1592
	public sealed class AddRecentPlayersRequest : IMessage<AddRecentPlayersRequest>, IMessage, IEquatable<AddRecentPlayersRequest>, IDeepCloneable<AddRecentPlayersRequest>, IBufferMessage
	{
		// Token: 0x17002E46 RID: 11846
		// (get) Token: 0x06009451 RID: 37969 RVA: 0x0023E404 File Offset: 0x0023C604
		[DebuggerNonUserCode]
		public static MessageParser<AddRecentPlayersRequest> Parser
		{
			get
			{
				return AddRecentPlayersRequest._parser;
			}
		}

		// Token: 0x17002E47 RID: 11847
		// (get) Token: 0x06009452 RID: 37970 RVA: 0x0023E41C File Offset: 0x0023C61C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002E48 RID: 11848
		// (get) Token: 0x06009453 RID: 37971 RVA: 0x0023E440 File Offset: 0x0023C640
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddRecentPlayersRequest.Descriptor;
			}
		}

		// Token: 0x06009454 RID: 37972 RVA: 0x0023E457 File Offset: 0x0023C657
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest()
		{
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x0023E461 File Offset: 0x0023C661
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest(AddRecentPlayersRequest other)
			: this()
		{
			this.options_ = ((other.options_ != null) ? other.options_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x0023E498 File Offset: 0x0023C698
		[DebuggerNonUserCode]
		public AddRecentPlayersRequest Clone()
		{
			return new AddRecentPlayersRequest(this);
		}

		// Token: 0x17002E49 RID: 11849
		// (get) Token: 0x06009457 RID: 37975 RVA: 0x0023E4B0 File Offset: 0x0023C6B0
		// (set) Token: 0x06009458 RID: 37976 RVA: 0x0023E4C8 File Offset: 0x0023C6C8
		[DebuggerNonUserCode]
		public AddRecentPlayersOptions Options
		{
			get
			{
				return this.options_;
			}
			set
			{
				this.options_ = value;
			}
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x0023E4D4 File Offset: 0x0023C6D4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddRecentPlayersRequest);
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x0023E4F4 File Offset: 0x0023C6F4
		[DebuggerNonUserCode]
		public bool Equals(AddRecentPlayersRequest other)
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
					bool flag4 = !object.Equals(this.Options, other.Options);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x0023E550 File Offset: 0x0023C750
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.options_ != null;
			if (flag)
			{
				num ^= this.Options.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x0023E5A0 File Offset: 0x0023C7A0
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x0023E5B8 File Offset: 0x0023C7B8
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x0023E5C4 File Offset: 0x0023C7C4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.options_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600945F RID: 37983 RVA: 0x0023E614 File Offset: 0x0023C814
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.options_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Options);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009460 RID: 37984 RVA: 0x0023E668 File Offset: 0x0023C868
		[DebuggerNonUserCode]
		public void MergeFrom(AddRecentPlayersRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.options_ != null;
				if (flag2)
				{
					bool flag3 = this.options_ == null;
					if (flag3)
					{
						this.Options = new AddRecentPlayersOptions();
					}
					this.Options.MergeFrom(other.Options);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06009461 RID: 37985 RVA: 0x0023E6D4 File Offset: 0x0023C8D4
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009462 RID: 37986 RVA: 0x0023E6E0 File Offset: 0x0023C8E0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.options_ == null;
					if (flag)
					{
						this.Options = new AddRecentPlayersOptions();
					}
					input.ReadMessage(this.Options);
				}
			}
		}

		// Token: 0x040042D4 RID: 17108
		private static readonly MessageParser<AddRecentPlayersRequest> _parser = new MessageParser<AddRecentPlayersRequest>(() => new AddRecentPlayersRequest());

		// Token: 0x040042D5 RID: 17109
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042D6 RID: 17110
		public const int OptionsFieldNumber = 2;

		// Token: 0x040042D7 RID: 17111
		private AddRecentPlayersOptions options_;
	}
}
