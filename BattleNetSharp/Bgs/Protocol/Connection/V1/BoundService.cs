using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Connection.V1
{
	// Token: 0x0200042F RID: 1071
	public sealed class BoundService : IMessage<BoundService>, IMessage, IEquatable<BoundService>, IDeepCloneable<BoundService>, IBufferMessage
	{
		// Token: 0x170021A9 RID: 8617
		// (get) Token: 0x06006951 RID: 26961 RVA: 0x00197EE0 File Offset: 0x001960E0
		[DebuggerNonUserCode]
		public static MessageParser<BoundService> Parser
		{
			get
			{
				return BoundService._parser;
			}
		}

		// Token: 0x170021AA RID: 8618
		// (get) Token: 0x06006952 RID: 26962 RVA: 0x00197EF8 File Offset: 0x001960F8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ConnectionServiceReflection.Descriptor.MessageTypes[4];
			}
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x06006953 RID: 26963 RVA: 0x00197F1C File Offset: 0x0019611C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoundService.Descriptor;
			}
		}

		// Token: 0x06006954 RID: 26964 RVA: 0x00197F33 File Offset: 0x00196133
		[DebuggerNonUserCode]
		public BoundService()
		{
		}

		// Token: 0x06006955 RID: 26965 RVA: 0x00197F3D File Offset: 0x0019613D
		[DebuggerNonUserCode]
		public BoundService(BoundService other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.hash_ = other.hash_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006956 RID: 26966 RVA: 0x00197F7C File Offset: 0x0019617C
		[DebuggerNonUserCode]
		public BoundService Clone()
		{
			return new BoundService(this);
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x06006957 RID: 26967 RVA: 0x00197F94 File Offset: 0x00196194
		// (set) Token: 0x06006958 RID: 26968 RVA: 0x00197FC5 File Offset: 0x001961C5
		[DebuggerNonUserCode]
		public uint Hash
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint hashDefaultValue;
				if (flag)
				{
					hashDefaultValue = this.hash_;
				}
				else
				{
					hashDefaultValue = BoundService.HashDefaultValue;
				}
				return hashDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.hash_ = value;
			}
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x06006959 RID: 26969 RVA: 0x00197FE0 File Offset: 0x001961E0
		[DebuggerNonUserCode]
		public bool HasHash
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600695A RID: 26970 RVA: 0x00197FFD File Offset: 0x001961FD
		[DebuggerNonUserCode]
		public void ClearHash()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170021AE RID: 8622
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x00198010 File Offset: 0x00196210
		// (set) Token: 0x0600695C RID: 26972 RVA: 0x00198041 File Offset: 0x00196241
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = BoundService.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.id_ = value;
			}
		}

		// Token: 0x170021AF RID: 8623
		// (get) Token: 0x0600695D RID: 26973 RVA: 0x0019805C File Offset: 0x0019625C
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600695E RID: 26974 RVA: 0x00198079 File Offset: 0x00196279
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600695F RID: 26975 RVA: 0x0019808C File Offset: 0x0019628C
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoundService);
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x001980AC File Offset: 0x001962AC
		[DebuggerNonUserCode]
		public bool Equals(BoundService other)
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
					bool flag4 = this.Hash != other.Hash;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Id != other.Id;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006961 RID: 26977 RVA: 0x00198120 File Offset: 0x00196320
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num ^= this.Hash.GetHashCode();
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x0019818C File Offset: 0x0019638C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x001981A4 File Offset: 0x001963A4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x001981B0 File Offset: 0x001963B0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Hash);
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(16);
				output.WriteUInt32(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00198220 File Offset: 0x00196420
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHash = this.HasHash;
			if (hasHash)
			{
				num += 5;
			}
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00198280 File Offset: 0x00196480
		[DebuggerNonUserCode]
		public void MergeFrom(BoundService other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHash = other.HasHash;
				if (hasHash)
				{
					this.Hash = other.Hash;
				}
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x001982E2 File Offset: 0x001964E2
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x001982F0 File Offset: 0x001964F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 13U)
				{
					if (num3 != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadUInt32();
					}
				}
				else
				{
					this.Hash = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04002FF3 RID: 12275
		private static readonly MessageParser<BoundService> _parser = new MessageParser<BoundService>(() => new BoundService());

		// Token: 0x04002FF4 RID: 12276
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF5 RID: 12277
		private int _hasBits0;

		// Token: 0x04002FF6 RID: 12278
		public const int HashFieldNumber = 1;

		// Token: 0x04002FF7 RID: 12279
		private static readonly uint HashDefaultValue = 0U;

		// Token: 0x04002FF8 RID: 12280
		private uint hash_;

		// Token: 0x04002FF9 RID: 12281
		public const int IdFieldNumber = 2;

		// Token: 0x04002FFA RID: 12282
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x04002FFB RID: 12283
		private uint id_;
	}
}
