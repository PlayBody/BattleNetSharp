using System;
using System.Diagnostics;
using Bgs.Protocol.Account.V1;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Notification.V2.Client
{
	// Token: 0x020005DC RID: 1500
	public sealed class Filter : IMessage<Filter>, IMessage, IEquatable<Filter>, IDeepCloneable<Filter>, IBufferMessage
	{
		// Token: 0x17002C3D RID: 11325
		// (get) Token: 0x06008D26 RID: 36134 RVA: 0x00223FFC File Offset: 0x002221FC
		[DebuggerNonUserCode]
		public static MessageParser<Filter> Parser
		{
			get
			{
				return Filter._parser;
			}
		}

		// Token: 0x17002C3E RID: 11326
		// (get) Token: 0x06008D27 RID: 36135 RVA: 0x00224014 File Offset: 0x00222214
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return NotificationTypesReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x17002C3F RID: 11327
		// (get) Token: 0x06008D28 RID: 36136 RVA: 0x00224038 File Offset: 0x00222238
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Filter.Descriptor;
			}
		}

		// Token: 0x06008D29 RID: 36137 RVA: 0x0022404F File Offset: 0x0022224F
		[DebuggerNonUserCode]
		public Filter()
		{
		}

		// Token: 0x06008D2A RID: 36138 RVA: 0x00224060 File Offset: 0x00222260
		[DebuggerNonUserCode]
		public Filter(Filter other)
			: this()
		{
			Filter.TypeOneofCase typeCase = other.TypeCase;
			Filter.TypeOneofCase typeOneofCase = typeCase;
			if (typeOneofCase != Filter.TypeOneofCase.TitleId)
			{
				if (typeOneofCase == Filter.TypeOneofCase.Handle)
				{
					this.Handle = other.Handle.Clone();
				}
			}
			else
			{
				this.TitleId = other.TitleId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008D2B RID: 36139 RVA: 0x002240C0 File Offset: 0x002222C0
		[DebuggerNonUserCode]
		public Filter Clone()
		{
			return new Filter(this);
		}

		// Token: 0x17002C40 RID: 11328
		// (get) Token: 0x06008D2C RID: 36140 RVA: 0x002240D8 File Offset: 0x002222D8
		// (set) Token: 0x06008D2D RID: 36141 RVA: 0x00224100 File Offset: 0x00222300
		[DebuggerNonUserCode]
		public uint TitleId
		{
			get
			{
				return this.HasTitleId ? ((uint)this.type_) : 0U;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = Filter.TypeOneofCase.TitleId;
			}
		}

		// Token: 0x17002C41 RID: 11329
		// (get) Token: 0x06008D2E RID: 36142 RVA: 0x00224118 File Offset: 0x00222318
		[DebuggerNonUserCode]
		public bool HasTitleId
		{
			get
			{
				return this.typeCase_ == Filter.TypeOneofCase.TitleId;
			}
		}

		// Token: 0x06008D2F RID: 36143 RVA: 0x00224134 File Offset: 0x00222334
		[DebuggerNonUserCode]
		public void ClearTitleId()
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				this.ClearType();
			}
		}

		// Token: 0x17002C42 RID: 11330
		// (get) Token: 0x06008D30 RID: 36144 RVA: 0x00224158 File Offset: 0x00222358
		// (set) Token: 0x06008D31 RID: 36145 RVA: 0x00224181 File Offset: 0x00222381
		[DebuggerNonUserCode]
		public GameAccountHandle Handle
		{
			get
			{
				return (this.typeCase_ == Filter.TypeOneofCase.Handle) ? ((GameAccountHandle)this.type_) : null;
			}
			set
			{
				this.type_ = value;
				this.typeCase_ = ((value == null) ? Filter.TypeOneofCase.None : Filter.TypeOneofCase.Handle);
			}
		}

		// Token: 0x17002C43 RID: 11331
		// (get) Token: 0x06008D32 RID: 36146 RVA: 0x00224198 File Offset: 0x00222398
		[DebuggerNonUserCode]
		public Filter.TypeOneofCase TypeCase
		{
			get
			{
				return this.typeCase_;
			}
		}

		// Token: 0x06008D33 RID: 36147 RVA: 0x002241B0 File Offset: 0x002223B0
		[DebuggerNonUserCode]
		public void ClearType()
		{
			this.typeCase_ = Filter.TypeOneofCase.None;
			this.type_ = null;
		}

		// Token: 0x06008D34 RID: 36148 RVA: 0x002241C4 File Offset: 0x002223C4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Filter);
		}

		// Token: 0x06008D35 RID: 36149 RVA: 0x002241E4 File Offset: 0x002223E4
		[DebuggerNonUserCode]
		public bool Equals(Filter other)
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
					bool flag4 = this.TitleId != other.TitleId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.Handle, other.Handle);
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.TypeCase != other.TypeCase;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008D36 RID: 36150 RVA: 0x00224274 File Offset: 0x00222474
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num ^= this.TitleId.GetHashCode();
			}
			bool flag = this.typeCase_ == Filter.TypeOneofCase.Handle;
			if (flag)
			{
				num ^= this.Handle.GetHashCode();
			}
			num ^= (int)this.typeCase_;
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008D37 RID: 36151 RVA: 0x002242EC File Offset: 0x002224EC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008D38 RID: 36152 RVA: 0x00224304 File Offset: 0x00222504
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008D39 RID: 36153 RVA: 0x00224310 File Offset: 0x00222510
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.TitleId);
			}
			bool flag = this.typeCase_ == Filter.TypeOneofCase.Handle;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Handle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008D3A RID: 36154 RVA: 0x00224380 File Offset: 0x00222580
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasTitleId = this.HasTitleId;
			if (hasTitleId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.TitleId);
			}
			bool flag = this.typeCase_ == Filter.TypeOneofCase.Handle;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Handle);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008D3B RID: 36155 RVA: 0x002243F0 File Offset: 0x002225F0
		[DebuggerNonUserCode]
		public void MergeFrom(Filter other)
		{
			bool flag = other == null;
			if (!flag)
			{
				Filter.TypeOneofCase typeCase = other.TypeCase;
				Filter.TypeOneofCase typeOneofCase = typeCase;
				if (typeOneofCase != Filter.TypeOneofCase.TitleId)
				{
					if (typeOneofCase == Filter.TypeOneofCase.Handle)
					{
						bool flag2 = this.Handle == null;
						if (flag2)
						{
							this.Handle = new GameAccountHandle();
						}
						this.Handle.MergeFrom(other.Handle);
					}
				}
				else
				{
					this.TitleId = other.TitleId;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008D3C RID: 36156 RVA: 0x00224473 File Offset: 0x00222673
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008D3D RID: 36157 RVA: 0x00224480 File Offset: 0x00222680
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						GameAccountHandle gameAccountHandle = new GameAccountHandle();
						bool flag = this.typeCase_ == Filter.TypeOneofCase.Handle;
						if (flag)
						{
							gameAccountHandle.MergeFrom(this.Handle);
						}
						input.ReadMessage(gameAccountHandle);
						this.Handle = gameAccountHandle;
					}
				}
				else
				{
					this.TitleId = input.ReadUInt32();
				}
			}
		}

		// Token: 0x04003FD1 RID: 16337
		private static readonly MessageParser<Filter> _parser = new MessageParser<Filter>(() => new Filter());

		// Token: 0x04003FD2 RID: 16338
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FD3 RID: 16339
		public const int TitleIdFieldNumber = 1;

		// Token: 0x04003FD4 RID: 16340
		public const int HandleFieldNumber = 2;

		// Token: 0x04003FD5 RID: 16341
		private object type_;

		// Token: 0x04003FD6 RID: 16342
		private Filter.TypeOneofCase typeCase_ = Filter.TypeOneofCase.None;

		// Token: 0x020010C3 RID: 4291
		public enum TypeOneofCase
		{
			// Token: 0x04009806 RID: 38918
			None,
			// Token: 0x04009807 RID: 38919
			TitleId,
			// Token: 0x04009808 RID: 38920
			Handle
		}
	}
}
