using System;
using System.Diagnostics;
using Fenris.Hero;
using Fenris.ItemCrafting;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Account
{
	// Token: 0x020002D9 RID: 729
	public sealed class Discoveries : IMessage<Discoveries>, IMessage, IEquatable<Discoveries>, IDeepCloneable<Discoveries>, IBufferMessage
	{
		// Token: 0x17001879 RID: 6265
		// (get) Token: 0x06004D1B RID: 19739 RVA: 0x00126FA8 File Offset: 0x001251A8
		[DebuggerNonUserCode]
		public static MessageParser<Discoveries> Parser
		{
			get
			{
				return Discoveries._parser;
			}
		}

		// Token: 0x1700187A RID: 6266
		// (get) Token: 0x06004D1C RID: 19740 RVA: 0x00126FC0 File Offset: 0x001251C0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountReflection.Descriptor.MessageTypes[7];
			}
		}

		// Token: 0x1700187B RID: 6267
		// (get) Token: 0x06004D1D RID: 19741 RVA: 0x00126FE4 File Offset: 0x001251E4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Discoveries.Descriptor;
			}
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00126FFB File Offset: 0x001251FB
		[DebuggerNonUserCode]
		public Discoveries()
		{
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x00127008 File Offset: 0x00125208
		[DebuggerNonUserCode]
		public Discoveries(Discoveries other)
			: this()
		{
			this.transmogData_ = ((other.transmogData_ != null) ? other.transmogData_.Clone() : null);
			this.seenTutorials_ = ((other.seenTutorials_ != null) ? other.seenTutorials_.Clone() : null);
			this.mount_ = ((other.mount_ != null) ? other.mount_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00127084 File Offset: 0x00125284
		[DebuggerNonUserCode]
		public Discoveries Clone()
		{
			return new Discoveries(this);
		}

		// Token: 0x1700187C RID: 6268
		// (get) Token: 0x06004D21 RID: 19745 RVA: 0x0012709C File Offset: 0x0012529C
		// (set) Token: 0x06004D22 RID: 19746 RVA: 0x001270B4 File Offset: 0x001252B4
		[DebuggerNonUserCode]
		public CrafterTransmogData TransmogData
		{
			get
			{
				return this.transmogData_;
			}
			set
			{
				this.transmogData_ = value;
			}
		}

		// Token: 0x1700187D RID: 6269
		// (get) Token: 0x06004D23 RID: 19747 RVA: 0x001270C0 File Offset: 0x001252C0
		// (set) Token: 0x06004D24 RID: 19748 RVA: 0x001270D8 File Offset: 0x001252D8
		[DebuggerNonUserCode]
		public AssetListDataStore SeenTutorials
		{
			get
			{
				return this.seenTutorials_;
			}
			set
			{
				this.seenTutorials_ = value;
			}
		}

		// Token: 0x1700187E RID: 6270
		// (get) Token: 0x06004D25 RID: 19749 RVA: 0x001270E4 File Offset: 0x001252E4
		// (set) Token: 0x06004D26 RID: 19750 RVA: 0x001270FC File Offset: 0x001252FC
		[DebuggerNonUserCode]
		public MountSavedData Mount
		{
			get
			{
				return this.mount_;
			}
			set
			{
				this.mount_ = value;
			}
		}

		// Token: 0x06004D27 RID: 19751 RVA: 0x00127108 File Offset: 0x00125308
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Discoveries);
		}

		// Token: 0x06004D28 RID: 19752 RVA: 0x00127128 File Offset: 0x00125328
		[DebuggerNonUserCode]
		public bool Equals(Discoveries other)
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
					bool flag4 = !object.Equals(this.TransmogData, other.TransmogData);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.SeenTutorials, other.SeenTutorials);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Mount, other.Mount);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06004D29 RID: 19753 RVA: 0x001271C0 File Offset: 0x001253C0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.transmogData_ != null;
			if (flag)
			{
				num ^= this.TransmogData.GetHashCode();
			}
			bool flag2 = this.seenTutorials_ != null;
			if (flag2)
			{
				num ^= this.SeenTutorials.GetHashCode();
			}
			bool flag3 = this.mount_ != null;
			if (flag3)
			{
				num ^= this.Mount.GetHashCode();
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004D2A RID: 19754 RVA: 0x00127248 File Offset: 0x00125448
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06004D2B RID: 19755 RVA: 0x00127260 File Offset: 0x00125460
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004D2C RID: 19756 RVA: 0x0012726C File Offset: 0x0012546C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.transmogData_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.TransmogData);
			}
			bool flag2 = this.seenTutorials_ != null;
			if (flag2)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.SeenTutorials);
			}
			bool flag3 = this.mount_ != null;
			if (flag3)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Mount);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004D2D RID: 19757 RVA: 0x00127308 File Offset: 0x00125508
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.transmogData_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TransmogData);
			}
			bool flag2 = this.seenTutorials_ != null;
			if (flag2)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SeenTutorials);
			}
			bool flag3 = this.mount_ != null;
			if (flag3)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Mount);
			}
			bool flag4 = this._unknownFields != null;
			if (flag4)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004D2E RID: 19758 RVA: 0x0012739C File Offset: 0x0012559C
		[DebuggerNonUserCode]
		public void MergeFrom(Discoveries other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.transmogData_ != null;
				if (flag2)
				{
					bool flag3 = this.transmogData_ == null;
					if (flag3)
					{
						this.TransmogData = new CrafterTransmogData();
					}
					this.TransmogData.MergeFrom(other.TransmogData);
				}
				bool flag4 = other.seenTutorials_ != null;
				if (flag4)
				{
					bool flag5 = this.seenTutorials_ == null;
					if (flag5)
					{
						this.SeenTutorials = new AssetListDataStore();
					}
					this.SeenTutorials.MergeFrom(other.SeenTutorials);
				}
				bool flag6 = other.mount_ != null;
				if (flag6)
				{
					bool flag7 = this.mount_ == null;
					if (flag7)
					{
						this.Mount = new MountSavedData();
					}
					this.Mount.MergeFrom(other.Mount);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06004D2F RID: 19759 RVA: 0x00127489 File Offset: 0x00125689
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004D30 RID: 19760 RVA: 0x00127494 File Offset: 0x00125694
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
					if (num3 != 26U)
					{
						if (num3 != 34U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.mount_ == null;
							if (flag)
							{
								this.Mount = new MountSavedData();
							}
							input.ReadMessage(this.Mount);
						}
					}
					else
					{
						bool flag2 = this.seenTutorials_ == null;
						if (flag2)
						{
							this.SeenTutorials = new AssetListDataStore();
						}
						input.ReadMessage(this.SeenTutorials);
					}
				}
				else
				{
					bool flag3 = this.transmogData_ == null;
					if (flag3)
					{
						this.TransmogData = new CrafterTransmogData();
					}
					input.ReadMessage(this.TransmogData);
				}
			}
		}

		// Token: 0x04002262 RID: 8802
		private static readonly MessageParser<Discoveries> _parser = new MessageParser<Discoveries>(() => new Discoveries());

		// Token: 0x04002263 RID: 8803
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002264 RID: 8804
		public const int TransmogDataFieldNumber = 2;

		// Token: 0x04002265 RID: 8805
		private CrafterTransmogData transmogData_;

		// Token: 0x04002266 RID: 8806
		public const int SeenTutorialsFieldNumber = 3;

		// Token: 0x04002267 RID: 8807
		private AssetListDataStore seenTutorials_;

		// Token: 0x04002268 RID: 8808
		public const int MountFieldNumber = 4;

		// Token: 0x04002269 RID: 8809
		private MountSavedData mount_;
	}
}
