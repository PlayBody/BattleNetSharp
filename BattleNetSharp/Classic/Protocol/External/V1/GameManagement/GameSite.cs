using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200079A RID: 1946
	public sealed class GameSite : IMessage<GameSite>, IMessage, IEquatable<GameSite>, IDeepCloneable<GameSite>, IBufferMessage
	{
		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600B2FB RID: 45819 RVA: 0x002B8C84 File Offset: 0x002B6E84
		[DebuggerNonUserCode]
		public static MessageParser<GameSite> Parser
		{
			get
			{
				return GameSite._parser;
			}
		}

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600B2FC RID: 45820 RVA: 0x002B8C9C File Offset: 0x002B6E9C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[14];
			}
		}

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600B2FD RID: 45821 RVA: 0x002B8CC0 File Offset: 0x002B6EC0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSite.Descriptor;
			}
		}

		// Token: 0x0600B2FE RID: 45822 RVA: 0x002B8CD7 File Offset: 0x002B6ED7
		[DebuggerNonUserCode]
		public GameSite()
		{
		}

		// Token: 0x0600B2FF RID: 45823 RVA: 0x002B8CE1 File Offset: 0x002B6EE1
		[DebuggerNonUserCode]
		public GameSite(GameSite other)
			: this()
		{
			this.ipAddress_ = other.ipAddress_;
			this.region_ = other.region_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B300 RID: 45824 RVA: 0x002B8D14 File Offset: 0x002B6F14
		[DebuggerNonUserCode]
		public GameSite Clone()
		{
			return new GameSite(this);
		}

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600B301 RID: 45825 RVA: 0x002B8D2C File Offset: 0x002B6F2C
		// (set) Token: 0x0600B302 RID: 45826 RVA: 0x002B8D4D File Offset: 0x002B6F4D
		[DebuggerNonUserCode]
		public string IpAddress
		{
			get
			{
				return this.ipAddress_ ?? GameSite.IpAddressDefaultValue;
			}
			set
			{
				this.ipAddress_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600B303 RID: 45827 RVA: 0x002B8D64 File Offset: 0x002B6F64
		[DebuggerNonUserCode]
		public bool HasIpAddress
		{
			get
			{
				return this.ipAddress_ != null;
			}
		}

		// Token: 0x0600B304 RID: 45828 RVA: 0x002B8D7F File Offset: 0x002B6F7F
		[DebuggerNonUserCode]
		public void ClearIpAddress()
		{
			this.ipAddress_ = null;
		}

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600B305 RID: 45829 RVA: 0x002B8D8C File Offset: 0x002B6F8C
		// (set) Token: 0x0600B306 RID: 45830 RVA: 0x002B8DAD File Offset: 0x002B6FAD
		[DebuggerNonUserCode]
		public string Region
		{
			get
			{
				return this.region_ ?? GameSite.RegionDefaultValue;
			}
			set
			{
				this.region_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600B307 RID: 45831 RVA: 0x002B8DC4 File Offset: 0x002B6FC4
		[DebuggerNonUserCode]
		public bool HasRegion
		{
			get
			{
				return this.region_ != null;
			}
		}

		// Token: 0x0600B308 RID: 45832 RVA: 0x002B8DDF File Offset: 0x002B6FDF
		[DebuggerNonUserCode]
		public void ClearRegion()
		{
			this.region_ = null;
		}

		// Token: 0x0600B309 RID: 45833 RVA: 0x002B8DEC File Offset: 0x002B6FEC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSite);
		}

		// Token: 0x0600B30A RID: 45834 RVA: 0x002B8E0C File Offset: 0x002B700C
		[DebuggerNonUserCode]
		public bool Equals(GameSite other)
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
					bool flag4 = this.IpAddress != other.IpAddress;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Region != other.Region;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B30B RID: 45835 RVA: 0x002B8E80 File Offset: 0x002B7080
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num ^= this.IpAddress.GetHashCode();
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num ^= this.Region.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B30C RID: 45836 RVA: 0x002B8EE4 File Offset: 0x002B70E4
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B30D RID: 45837 RVA: 0x002B8EFC File Offset: 0x002B70FC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B30E RID: 45838 RVA: 0x002B8F08 File Offset: 0x002B7108
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				output.WriteRawTag(10);
				output.WriteString(this.IpAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				output.WriteRawTag(18);
				output.WriteString(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B30F RID: 45839 RVA: 0x002B8F78 File Offset: 0x002B7178
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasIpAddress = this.HasIpAddress;
			if (hasIpAddress)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.IpAddress);
			}
			bool hasRegion = this.HasRegion;
			if (hasRegion)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Region);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B310 RID: 45840 RVA: 0x002B8FE4 File Offset: 0x002B71E4
		[DebuggerNonUserCode]
		public void MergeFrom(GameSite other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasIpAddress = other.HasIpAddress;
				if (hasIpAddress)
				{
					this.IpAddress = other.IpAddress;
				}
				bool hasRegion = other.HasRegion;
				if (hasRegion)
				{
					this.Region = other.Region;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B311 RID: 45841 RVA: 0x002B9046 File Offset: 0x002B7246
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B312 RID: 45842 RVA: 0x002B9054 File Offset: 0x002B7254
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
						this.Region = input.ReadString();
					}
				}
				else
				{
					this.IpAddress = input.ReadString();
				}
			}
		}

		// Token: 0x040050D2 RID: 20690
		private static readonly MessageParser<GameSite> _parser = new MessageParser<GameSite>(() => new GameSite());

		// Token: 0x040050D3 RID: 20691
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050D4 RID: 20692
		public const int IpAddressFieldNumber = 1;

		// Token: 0x040050D5 RID: 20693
		private static readonly string IpAddressDefaultValue = "";

		// Token: 0x040050D6 RID: 20694
		private string ipAddress_;

		// Token: 0x040050D7 RID: 20695
		public const int RegionFieldNumber = 2;

		// Token: 0x040050D8 RID: 20696
		private static readonly string RegionDefaultValue = "";

		// Token: 0x040050D9 RID: 20697
		private string region_;
	}
}
