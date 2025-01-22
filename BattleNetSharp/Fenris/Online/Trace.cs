using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.Online
{
	// Token: 0x02000154 RID: 340
	public sealed class Trace : IMessage<Trace>, IMessage, IEquatable<Trace>, IDeepCloneable<Trace>, IBufferMessage
	{
		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002343 RID: 9027 RVA: 0x00088E54 File Offset: 0x00087054
		[DebuggerNonUserCode]
		public static MessageParser<Trace> Parser
		{
			get
			{
				return Trace._parser;
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002344 RID: 9028 RVA: 0x00088E6C File Offset: 0x0008706C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return OnlineReflection.Descriptor.MessageTypes[21];
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002345 RID: 9029 RVA: 0x00088E90 File Offset: 0x00087090
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Trace.Descriptor;
			}
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x00088EA7 File Offset: 0x000870A7
		[DebuggerNonUserCode]
		public Trace()
		{
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x00088EB4 File Offset: 0x000870B4
		[DebuggerNonUserCode]
		public Trace(Trace other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.spanId_ = other.spanId_;
			this.gameAccountId_ = other.gameAccountId_;
			this.name_ = other.name_;
			this.isTracked_ = other.isTracked_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00088F24 File Offset: 0x00087124
		[DebuggerNonUserCode]
		public Trace Clone()
		{
			return new Trace(this);
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00088F3C File Offset: 0x0008713C
		// (set) Token: 0x0600234A RID: 9034 RVA: 0x00088F5D File Offset: 0x0008715D
		[DebuggerNonUserCode]
		public string Id
		{
			get
			{
				return this.id_ ?? Trace.IdDefaultValue;
			}
			set
			{
				this.id_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00088F74 File Offset: 0x00087174
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return this.id_ != null;
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x00088F8F File Offset: 0x0008718F
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this.id_ = null;
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x00088F9C File Offset: 0x0008719C
		// (set) Token: 0x0600234E RID: 9038 RVA: 0x00088FBD File Offset: 0x000871BD
		[DebuggerNonUserCode]
		public string SpanId
		{
			get
			{
				return this.spanId_ ?? Trace.SpanIdDefaultValue;
			}
			set
			{
				this.spanId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x0600234F RID: 9039 RVA: 0x00088FD4 File Offset: 0x000871D4
		[DebuggerNonUserCode]
		public bool HasSpanId
		{
			get
			{
				return this.spanId_ != null;
			}
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x00088FEF File Offset: 0x000871EF
		[DebuggerNonUserCode]
		public void ClearSpanId()
		{
			this.spanId_ = null;
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002351 RID: 9041 RVA: 0x00088FFC File Offset: 0x000871FC
		// (set) Token: 0x06002352 RID: 9042 RVA: 0x0008902D File Offset: 0x0008722D
		[DebuggerNonUserCode]
		public uint GameAccountId
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint gameAccountIdDefaultValue;
				if (flag)
				{
					gameAccountIdDefaultValue = this.gameAccountId_;
				}
				else
				{
					gameAccountIdDefaultValue = Trace.GameAccountIdDefaultValue;
				}
				return gameAccountIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002353 RID: 9043 RVA: 0x00089048 File Offset: 0x00087248
		[DebuggerNonUserCode]
		public bool HasGameAccountId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00089065 File Offset: 0x00087265
		[DebuggerNonUserCode]
		public void ClearGameAccountId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002355 RID: 9045 RVA: 0x00089078 File Offset: 0x00087278
		// (set) Token: 0x06002356 RID: 9046 RVA: 0x00089099 File Offset: 0x00087299
		[DebuggerNonUserCode]
		public string Name
		{
			get
			{
				return this.name_ ?? Trace.NameDefaultValue;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x000890B0 File Offset: 0x000872B0
		[DebuggerNonUserCode]
		public bool HasName
		{
			get
			{
				return this.name_ != null;
			}
		}

		// Token: 0x06002358 RID: 9048 RVA: 0x000890CB File Offset: 0x000872CB
		[DebuggerNonUserCode]
		public void ClearName()
		{
			this.name_ = null;
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x000890D8 File Offset: 0x000872D8
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x00089109 File Offset: 0x00087309
		[DebuggerNonUserCode]
		public bool IsTracked
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				bool isTrackedDefaultValue;
				if (flag)
				{
					isTrackedDefaultValue = this.isTracked_;
				}
				else
				{
					isTrackedDefaultValue = Trace.IsTrackedDefaultValue;
				}
				return isTrackedDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.isTracked_ = value;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x0600235B RID: 9051 RVA: 0x00089124 File Offset: 0x00087324
		[DebuggerNonUserCode]
		public bool HasIsTracked
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x00089141 File Offset: 0x00087341
		[DebuggerNonUserCode]
		public void ClearIsTracked()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x00089154 File Offset: 0x00087354
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Trace);
		}

		// Token: 0x0600235E RID: 9054 RVA: 0x00089174 File Offset: 0x00087374
		[DebuggerNonUserCode]
		public bool Equals(Trace other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SpanId != other.SpanId;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.GameAccountId != other.GameAccountId;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.Name != other.Name;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.IsTracked != other.IsTracked;
									flag2 = !flag8 && object.Equals(this._unknownFields, other._unknownFields);
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x00089240 File Offset: 0x00087440
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				num ^= this.SpanId.GetHashCode();
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num ^= this.Name.GetHashCode();
			}
			bool hasIsTracked = this.HasIsTracked;
			if (hasIsTracked)
			{
				num ^= this.IsTracked.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x000892FC File Offset: 0x000874FC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00089314 File Offset: 0x00087514
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00089320 File Offset: 0x00087520
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.Id);
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				output.WriteRawTag(18);
				output.WriteString(this.SpanId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				output.WriteRawTag(24);
				output.WriteUInt32(this.GameAccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			bool hasIsTracked = this.HasIsTracked;
			if (hasIsTracked)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTracked);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002363 RID: 9059 RVA: 0x000893F8 File Offset: 0x000875F8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Id);
			}
			bool hasSpanId = this.HasSpanId;
			if (hasSpanId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SpanId);
			}
			bool hasGameAccountId = this.HasGameAccountId;
			if (hasGameAccountId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.GameAccountId);
			}
			bool hasName = this.HasName;
			if (hasName)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			bool hasIsTracked = this.HasIsTracked;
			if (hasIsTracked)
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

		// Token: 0x06002364 RID: 9060 RVA: 0x000894B4 File Offset: 0x000876B4
		[DebuggerNonUserCode]
		public void MergeFrom(Trace other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasSpanId = other.HasSpanId;
				if (hasSpanId)
				{
					this.SpanId = other.SpanId;
				}
				bool hasGameAccountId = other.HasGameAccountId;
				if (hasGameAccountId)
				{
					this.GameAccountId = other.GameAccountId;
				}
				bool hasName = other.HasName;
				if (hasName)
				{
					this.Name = other.Name;
				}
				bool hasIsTracked = other.HasIsTracked;
				if (hasIsTracked)
				{
					this.IsTracked = other.IsTracked;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06002365 RID: 9061 RVA: 0x00089568 File Offset: 0x00087768
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002366 RID: 9062 RVA: 0x00089574 File Offset: 0x00087774
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 18U)
				{
					if (num3 != 10U)
					{
						if (num3 != 18U)
						{
							goto IL_0033;
						}
						this.SpanId = input.ReadString();
					}
					else
					{
						this.Id = input.ReadString();
					}
				}
				else if (num3 != 24U)
				{
					if (num3 != 34U)
					{
						if (num3 != 40U)
						{
							goto IL_0033;
						}
						this.IsTracked = input.ReadBool();
					}
					else
					{
						this.Name = input.ReadString();
					}
				}
				else
				{
					this.GameAccountId = input.ReadUInt32();
				}
				continue;
				IL_0033:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04000F7B RID: 3963
		private static readonly MessageParser<Trace> _parser = new MessageParser<Trace>(() => new Trace());

		// Token: 0x04000F7C RID: 3964
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000F7D RID: 3965
		private int _hasBits0;

		// Token: 0x04000F7E RID: 3966
		public const int IdFieldNumber = 1;

		// Token: 0x04000F7F RID: 3967
		private static readonly string IdDefaultValue = "";

		// Token: 0x04000F80 RID: 3968
		private string id_;

		// Token: 0x04000F81 RID: 3969
		public const int SpanIdFieldNumber = 2;

		// Token: 0x04000F82 RID: 3970
		private static readonly string SpanIdDefaultValue = "";

		// Token: 0x04000F83 RID: 3971
		private string spanId_;

		// Token: 0x04000F84 RID: 3972
		public const int GameAccountIdFieldNumber = 3;

		// Token: 0x04000F85 RID: 3973
		private static readonly uint GameAccountIdDefaultValue = 0U;

		// Token: 0x04000F86 RID: 3974
		private uint gameAccountId_;

		// Token: 0x04000F87 RID: 3975
		public const int NameFieldNumber = 4;

		// Token: 0x04000F88 RID: 3976
		private static readonly string NameDefaultValue = "";

		// Token: 0x04000F89 RID: 3977
		private string name_;

		// Token: 0x04000F8A RID: 3978
		public const int IsTrackedFieldNumber = 5;

		// Token: 0x04000F8B RID: 3979
		private static readonly bool IsTrackedDefaultValue = false;

		// Token: 0x04000F8C RID: 3980
		private bool isTracked_;
	}
}
