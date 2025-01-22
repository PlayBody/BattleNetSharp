using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x02000036 RID: 54
	public sealed class SetAxeSharpBuildSmokeTestedMessage : IMessage<SetAxeSharpBuildSmokeTestedMessage>, IMessage, IEquatable<SetAxeSharpBuildSmokeTestedMessage>, IDeepCloneable<SetAxeSharpBuildSmokeTestedMessage>, IBufferMessage
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003CC RID: 972 RVA: 0x0001378C File Offset: 0x0001198C
		[DebuggerNonUserCode]
		public static MessageParser<SetAxeSharpBuildSmokeTestedMessage> Parser
		{
			get
			{
				return SetAxeSharpBuildSmokeTestedMessage._parser;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000137A4 File Offset: 0x000119A4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[31];
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x060003CE RID: 974 RVA: 0x000137C8 File Offset: 0x000119C8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetAxeSharpBuildSmokeTestedMessage.Descriptor;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000137DF File Offset: 0x000119DF
		[DebuggerNonUserCode]
		public SetAxeSharpBuildSmokeTestedMessage()
		{
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x000137E9 File Offset: 0x000119E9
		[DebuggerNonUserCode]
		public SetAxeSharpBuildSmokeTestedMessage(SetAxeSharpBuildSmokeTestedMessage other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.buildSmokeTested_ = other.buildSmokeTested_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0001381C File Offset: 0x00011A1C
		[DebuggerNonUserCode]
		public SetAxeSharpBuildSmokeTestedMessage Clone()
		{
			return new SetAxeSharpBuildSmokeTestedMessage(this);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00013834 File Offset: 0x00011A34
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00013865 File Offset: 0x00011A65
		[DebuggerNonUserCode]
		public bool BuildSmokeTested
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool buildSmokeTestedDefaultValue;
				if (flag)
				{
					buildSmokeTestedDefaultValue = this.buildSmokeTested_;
				}
				else
				{
					buildSmokeTestedDefaultValue = SetAxeSharpBuildSmokeTestedMessage.BuildSmokeTestedDefaultValue;
				}
				return buildSmokeTestedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.buildSmokeTested_ = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00013880 File Offset: 0x00011A80
		[DebuggerNonUserCode]
		public bool HasBuildSmokeTested
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0001389D File Offset: 0x00011A9D
		[DebuggerNonUserCode]
		public void ClearBuildSmokeTested()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000138B0 File Offset: 0x00011AB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetAxeSharpBuildSmokeTestedMessage);
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x000138D0 File Offset: 0x00011AD0
		[DebuggerNonUserCode]
		public bool Equals(SetAxeSharpBuildSmokeTestedMessage other)
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
					bool flag4 = this.BuildSmokeTested != other.BuildSmokeTested;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00013928 File Offset: 0x00011B28
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasBuildSmokeTested = this.HasBuildSmokeTested;
			if (hasBuildSmokeTested)
			{
				num ^= this.BuildSmokeTested.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00013978 File Offset: 0x00011B78
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00013990 File Offset: 0x00011B90
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x0001399C File Offset: 0x00011B9C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasBuildSmokeTested = this.HasBuildSmokeTested;
			if (hasBuildSmokeTested)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.BuildSmokeTested);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x000139E8 File Offset: 0x00011BE8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasBuildSmokeTested = this.HasBuildSmokeTested;
			if (hasBuildSmokeTested)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00013A2C File Offset: 0x00011C2C
		[DebuggerNonUserCode]
		public void MergeFrom(SetAxeSharpBuildSmokeTestedMessage other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasBuildSmokeTested = other.HasBuildSmokeTested;
				if (hasBuildSmokeTested)
				{
					this.BuildSmokeTested = other.BuildSmokeTested;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00013A75 File Offset: 0x00011C75
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00013A80 File Offset: 0x00011C80
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuildSmokeTested = input.ReadBool();
				}
			}
		}

		// Token: 0x04000190 RID: 400
		private static readonly MessageParser<SetAxeSharpBuildSmokeTestedMessage> _parser = new MessageParser<SetAxeSharpBuildSmokeTestedMessage>(() => new SetAxeSharpBuildSmokeTestedMessage());

		// Token: 0x04000191 RID: 401
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000192 RID: 402
		private int _hasBits0;

		// Token: 0x04000193 RID: 403
		public const int BuildSmokeTestedFieldNumber = 1;

		// Token: 0x04000194 RID: 404
		private static readonly bool BuildSmokeTestedDefaultValue = false;

		// Token: 0x04000195 RID: 405
		private bool buildSmokeTested_;
	}
}
