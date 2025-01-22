using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Fenris.DemonSummoning
{
	// Token: 0x020001FE RID: 510
	public sealed class EquippedScroll : IMessage<EquippedScroll>, IMessage, IEquatable<EquippedScroll>, IDeepCloneable<EquippedScroll>, IBufferMessage
	{
		// Token: 0x17001245 RID: 4677
		// (get) Token: 0x060037F2 RID: 14322 RVA: 0x000DD510 File Offset: 0x000DB710
		[DebuggerNonUserCode]
		public static MessageParser<EquippedScroll> Parser
		{
			get
			{
				return EquippedScroll._parser;
			}
		}

		// Token: 0x17001246 RID: 4678
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x000DD528 File Offset: 0x000DB728
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return DemonSummoningReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17001247 RID: 4679
		// (get) Token: 0x060037F4 RID: 14324 RVA: 0x000DD54C File Offset: 0x000DB74C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EquippedScroll.Descriptor;
			}
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x000DD563 File Offset: 0x000DB763
		[DebuggerNonUserCode]
		public EquippedScroll()
		{
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x000DD56D File Offset: 0x000DB76D
		[DebuggerNonUserCode]
		public EquippedScroll(EquippedScroll other)
			: this()
		{
			this.scroll_ = ((other.scroll_ != null) ? other.scroll_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x000DD5A4 File Offset: 0x000DB7A4
		[DebuggerNonUserCode]
		public EquippedScroll Clone()
		{
			return new EquippedScroll(this);
		}

		// Token: 0x17001248 RID: 4680
		// (get) Token: 0x060037F8 RID: 14328 RVA: 0x000DD5BC File Offset: 0x000DB7BC
		// (set) Token: 0x060037F9 RID: 14329 RVA: 0x000DD5D4 File Offset: 0x000DB7D4
		[DebuggerNonUserCode]
		public Scroll Scroll
		{
			get
			{
				return this.scroll_;
			}
			set
			{
				this.scroll_ = value;
			}
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x000DD5E0 File Offset: 0x000DB7E0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as EquippedScroll);
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x000DD600 File Offset: 0x000DB800
		[DebuggerNonUserCode]
		public bool Equals(EquippedScroll other)
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
					bool flag4 = !object.Equals(this.Scroll, other.Scroll);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x000DD65C File Offset: 0x000DB85C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.scroll_ != null;
			if (flag)
			{
				num ^= this.Scroll.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x000DD6AC File Offset: 0x000DB8AC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x000DD6C4 File Offset: 0x000DB8C4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060037FF RID: 14335 RVA: 0x000DD6D0 File Offset: 0x000DB8D0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.scroll_ != null;
			if (flag)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Scroll);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003800 RID: 14336 RVA: 0x000DD720 File Offset: 0x000DB920
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.scroll_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Scroll);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000DD774 File Offset: 0x000DB974
		[DebuggerNonUserCode]
		public void MergeFrom(EquippedScroll other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.scroll_ != null;
				if (flag2)
				{
					bool flag3 = this.scroll_ == null;
					if (flag3)
					{
						this.Scroll = new Scroll();
					}
					this.Scroll.MergeFrom(other.Scroll);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000DD7E0 File Offset: 0x000DB9E0
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x000DD7EC File Offset: 0x000DB9EC
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
					bool flag = this.scroll_ == null;
					if (flag)
					{
						this.Scroll = new Scroll();
					}
					input.ReadMessage(this.Scroll);
				}
			}
		}

		// Token: 0x04001A1E RID: 6686
		private static readonly MessageParser<EquippedScroll> _parser = new MessageParser<EquippedScroll>(() => new EquippedScroll());

		// Token: 0x04001A1F RID: 6687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001A20 RID: 6688
		public const int ScrollFieldNumber = 1;

		// Token: 0x04001A21 RID: 6689
		private Scroll scroll_;
	}
}
