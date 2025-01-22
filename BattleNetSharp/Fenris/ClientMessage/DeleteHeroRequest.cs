using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.ClientMessage
{
	// Token: 0x02000224 RID: 548
	public sealed class DeleteHeroRequest : IMessage<DeleteHeroRequest>, IMessage, IEquatable<DeleteHeroRequest>, IDeepCloneable<DeleteHeroRequest>, IBufferMessage
	{
		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x000ED5B4 File Offset: 0x000EB7B4
		[DebuggerNonUserCode]
		public static MessageParser<DeleteHeroRequest> Parser
		{
			get
			{
				return DeleteHeroRequest._parser;
			}
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x000ED5CC File Offset: 0x000EB7CC
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ClientMessageReflection.Descriptor.MessageTypes[20];
			}
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x000ED5F0 File Offset: 0x000EB7F0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DeleteHeroRequest.Descriptor;
			}
		}

		// Token: 0x06003BAA RID: 15274 RVA: 0x000ED607 File Offset: 0x000EB807
		[DebuggerNonUserCode]
		public DeleteHeroRequest()
		{
		}

		// Token: 0x06003BAB RID: 15275 RVA: 0x000ED611 File Offset: 0x000EB811
		[DebuggerNonUserCode]
		public DeleteHeroRequest(DeleteHeroRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.heroId_ = other.heroId_;
			this.deleteImmediately_ = other.deleteImmediately_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003BAC RID: 15276 RVA: 0x000ED650 File Offset: 0x000EB850
		[DebuggerNonUserCode]
		public DeleteHeroRequest Clone()
		{
			return new DeleteHeroRequest(this);
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x000ED668 File Offset: 0x000EB868
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x000ED689 File Offset: 0x000EB889
		[DebuggerNonUserCode]
		public string HeroId
		{
			get
			{
				return this.heroId_ ?? DeleteHeroRequest.HeroIdDefaultValue;
			}
			set
			{
				this.heroId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x000ED6A0 File Offset: 0x000EB8A0
		[DebuggerNonUserCode]
		public bool HasHeroId
		{
			get
			{
				return this.heroId_ != null;
			}
		}

		// Token: 0x06003BB0 RID: 15280 RVA: 0x000ED6BB File Offset: 0x000EB8BB
		[DebuggerNonUserCode]
		public void ClearHeroId()
		{
			this.heroId_ = null;
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x000ED6C8 File Offset: 0x000EB8C8
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x000ED6F9 File Offset: 0x000EB8F9
		[DebuggerNonUserCode]
		public bool DeleteImmediately
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				bool deleteImmediatelyDefaultValue;
				if (flag)
				{
					deleteImmediatelyDefaultValue = this.deleteImmediately_;
				}
				else
				{
					deleteImmediatelyDefaultValue = DeleteHeroRequest.DeleteImmediatelyDefaultValue;
				}
				return deleteImmediatelyDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.deleteImmediately_ = value;
			}
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x000ED714 File Offset: 0x000EB914
		[DebuggerNonUserCode]
		public bool HasDeleteImmediately
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06003BB4 RID: 15284 RVA: 0x000ED731 File Offset: 0x000EB931
		[DebuggerNonUserCode]
		public void ClearDeleteImmediately()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06003BB5 RID: 15285 RVA: 0x000ED744 File Offset: 0x000EB944
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as DeleteHeroRequest);
		}

		// Token: 0x06003BB6 RID: 15286 RVA: 0x000ED764 File Offset: 0x000EB964
		[DebuggerNonUserCode]
		public bool Equals(DeleteHeroRequest other)
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
					bool flag4 = this.HeroId != other.HeroId;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.DeleteImmediately != other.DeleteImmediately;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x06003BB7 RID: 15287 RVA: 0x000ED7D8 File Offset: 0x000EB9D8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num ^= this.HeroId.GetHashCode();
			}
			bool hasDeleteImmediately = this.HasDeleteImmediately;
			if (hasDeleteImmediately)
			{
				num ^= this.DeleteImmediately.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x000ED844 File Offset: 0x000EBA44
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06003BB9 RID: 15289 RVA: 0x000ED85C File Offset: 0x000EBA5C
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003BBA RID: 15290 RVA: 0x000ED868 File Offset: 0x000EBA68
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				output.WriteRawTag(10);
				output.WriteString(this.HeroId);
			}
			bool hasDeleteImmediately = this.HasDeleteImmediately;
			if (hasDeleteImmediately)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.DeleteImmediately);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x000ED8D8 File Offset: 0x000EBAD8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasHeroId = this.HasHeroId;
			if (hasHeroId)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.HeroId);
			}
			bool hasDeleteImmediately = this.HasDeleteImmediately;
			if (hasDeleteImmediately)
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

		// Token: 0x06003BBC RID: 15292 RVA: 0x000ED938 File Offset: 0x000EBB38
		[DebuggerNonUserCode]
		public void MergeFrom(DeleteHeroRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasHeroId = other.HasHeroId;
				if (hasHeroId)
				{
					this.HeroId = other.HeroId;
				}
				bool hasDeleteImmediately = other.HasDeleteImmediately;
				if (hasDeleteImmediately)
				{
					this.DeleteImmediately = other.DeleteImmediately;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003BBD RID: 15293 RVA: 0x000ED99A File Offset: 0x000EBB9A
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003BBE RID: 15294 RVA: 0x000ED9A8 File Offset: 0x000EBBA8
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
						this.DeleteImmediately = input.ReadBool();
					}
				}
				else
				{
					this.HeroId = input.ReadString();
				}
			}
		}

		// Token: 0x04001BA9 RID: 7081
		private static readonly MessageParser<DeleteHeroRequest> _parser = new MessageParser<DeleteHeroRequest>(() => new DeleteHeroRequest());

		// Token: 0x04001BAA RID: 7082
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001BAB RID: 7083
		private int _hasBits0;

		// Token: 0x04001BAC RID: 7084
		public const int HeroIdFieldNumber = 1;

		// Token: 0x04001BAD RID: 7085
		private static readonly string HeroIdDefaultValue = "";

		// Token: 0x04001BAE RID: 7086
		private string heroId_;

		// Token: 0x04001BAF RID: 7087
		public const int DeleteImmediatelyFieldNumber = 2;

		// Token: 0x04001BB0 RID: 7088
		private static readonly bool DeleteImmediatelyDefaultValue = false;

		// Token: 0x04001BB1 RID: 7089
		private bool deleteImmediately_;
	}
}
