using System;
using System.Diagnostics;
using Bgs.Protocol.V2;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V2.Server
{
	// Token: 0x020005FD RID: 1533
	public sealed class GetRegistrationsOptions : IMessage<GetRegistrationsOptions>, IMessage, IEquatable<GetRegistrationsOptions>, IDeepCloneable<GetRegistrationsOptions>, IBufferMessage
	{
		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x06008F9F RID: 36767 RVA: 0x0022D624 File Offset: 0x0022B824
		[DebuggerNonUserCode]
		public static MessageParser<GetRegistrationsOptions> Parser
		{
			get
			{
				return GetRegistrationsOptions._parser;
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x06008FA0 RID: 36768 RVA: 0x0022D63C File Offset: 0x0022B83C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceTypesReflection.Descriptor.MessageTypes[3];
			}
		}

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x06008FA1 RID: 36769 RVA: 0x0022D660 File Offset: 0x0022B860
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetRegistrationsOptions.Descriptor;
			}
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x0022D677 File Offset: 0x0022B877
		[DebuggerNonUserCode]
		public GetRegistrationsOptions()
		{
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x0022D684 File Offset: 0x0022B884
		[DebuggerNonUserCode]
		public GetRegistrationsOptions(GetRegistrationsOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.filter_ = ((other.filter_ != null) ? other.filter_.Clone() : null);
			this.maxServers_ = other.maxServers_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x0022D6E0 File Offset: 0x0022B8E0
		[DebuggerNonUserCode]
		public GetRegistrationsOptions Clone()
		{
			return new GetRegistrationsOptions(this);
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x06008FA5 RID: 36773 RVA: 0x0022D6F8 File Offset: 0x0022B8F8
		// (set) Token: 0x06008FA6 RID: 36774 RVA: 0x0022D710 File Offset: 0x0022B910
		[DebuggerNonUserCode]
		public AttributeFilter Filter
		{
			get
			{
				return this.filter_;
			}
			set
			{
				this.filter_ = value;
			}
		}

		// Token: 0x17002CEF RID: 11503
		// (get) Token: 0x06008FA7 RID: 36775 RVA: 0x0022D71C File Offset: 0x0022B91C
		// (set) Token: 0x06008FA8 RID: 36776 RVA: 0x0022D74D File Offset: 0x0022B94D
		[DebuggerNonUserCode]
		public uint MaxServers
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint maxServersDefaultValue;
				if (flag)
				{
					maxServersDefaultValue = this.maxServers_;
				}
				else
				{
					maxServersDefaultValue = GetRegistrationsOptions.MaxServersDefaultValue;
				}
				return maxServersDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.maxServers_ = value;
			}
		}

		// Token: 0x17002CF0 RID: 11504
		// (get) Token: 0x06008FA9 RID: 36777 RVA: 0x0022D768 File Offset: 0x0022B968
		[DebuggerNonUserCode]
		public bool HasMaxServers
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008FAA RID: 36778 RVA: 0x0022D785 File Offset: 0x0022B985
		[DebuggerNonUserCode]
		public void ClearMaxServers()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06008FAB RID: 36779 RVA: 0x0022D798 File Offset: 0x0022B998
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetRegistrationsOptions);
		}

		// Token: 0x06008FAC RID: 36780 RVA: 0x0022D7B8 File Offset: 0x0022B9B8
		[DebuggerNonUserCode]
		public bool Equals(GetRegistrationsOptions other)
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
					bool flag4 = !object.Equals(this.Filter, other.Filter);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.MaxServers != other.MaxServers;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008FAD RID: 36781 RVA: 0x0022D82C File Offset: 0x0022BA2C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.filter_ != null;
			if (flag)
			{
				num ^= this.Filter.GetHashCode();
			}
			bool hasMaxServers = this.HasMaxServers;
			if (hasMaxServers)
			{
				num ^= this.MaxServers.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008FAE RID: 36782 RVA: 0x0022D898 File Offset: 0x0022BA98
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008FAF RID: 36783 RVA: 0x0022D8B0 File Offset: 0x0022BAB0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008FB0 RID: 36784 RVA: 0x0022D8BC File Offset: 0x0022BABC
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.filter_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Filter);
			}
			bool hasMaxServers = this.HasMaxServers;
			if (hasMaxServers)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.MaxServers);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008FB1 RID: 36785 RVA: 0x0022D930 File Offset: 0x0022BB30
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.filter_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Filter);
			}
			bool hasMaxServers = this.HasMaxServers;
			if (hasMaxServers)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.MaxServers);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008FB2 RID: 36786 RVA: 0x0022D9A0 File Offset: 0x0022BBA0
		[DebuggerNonUserCode]
		public void MergeFrom(GetRegistrationsOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.filter_ != null;
				if (flag2)
				{
					bool flag3 = this.filter_ == null;
					if (flag3)
					{
						this.Filter = new AttributeFilter();
					}
					this.Filter.MergeFrom(other.Filter);
				}
				bool hasMaxServers = other.HasMaxServers;
				if (hasMaxServers)
				{
					this.MaxServers = other.MaxServers;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008FB3 RID: 36787 RVA: 0x0022DA25 File Offset: 0x0022BC25
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FB4 RID: 36788 RVA: 0x0022DA30 File Offset: 0x0022BC30
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
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxServers = input.ReadUInt32();
					}
				}
				else
				{
					bool flag = this.filter_ == null;
					if (flag)
					{
						this.Filter = new AttributeFilter();
					}
					input.ReadMessage(this.Filter);
				}
			}
		}

		// Token: 0x040040E1 RID: 16609
		private static readonly MessageParser<GetRegistrationsOptions> _parser = new MessageParser<GetRegistrationsOptions>(() => new GetRegistrationsOptions());

		// Token: 0x040040E2 RID: 16610
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040E3 RID: 16611
		private int _hasBits0;

		// Token: 0x040040E4 RID: 16612
		public const int FilterFieldNumber = 1;

		// Token: 0x040040E5 RID: 16613
		private AttributeFilter filter_;

		// Token: 0x040040E6 RID: 16614
		public const int MaxServersFieldNumber = 2;

		// Token: 0x040040E7 RID: 16615
		private static readonly uint MaxServersDefaultValue = 0U;

		// Token: 0x040040E8 RID: 16616
		private uint maxServers_;
	}
}
