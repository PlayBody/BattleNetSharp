using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Fenris.TACTKey
{
	// Token: 0x0200010F RID: 271
	public sealed class Keys : IMessage<Keys>, IMessage, IEquatable<Keys>, IDeepCloneable<Keys>, IBufferMessage
	{
		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060019D5 RID: 6613 RVA: 0x0005C1D0 File Offset: 0x0005A3D0
		[DebuggerNonUserCode]
		public static MessageParser<Keys> Parser
		{
			get
			{
				return Keys._parser;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060019D6 RID: 6614 RVA: 0x0005C1E8 File Offset: 0x0005A3E8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return TACTKeyReflection.Descriptor.MessageTypes[1];
			}
		}

		// Token: 0x1700079F RID: 1951
		// (get) Token: 0x060019D7 RID: 6615 RVA: 0x0005C20C File Offset: 0x0005A40C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return Keys.Descriptor;
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0005C223 File Offset: 0x0005A423
		[DebuggerNonUserCode]
		public Keys()
		{
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0005C238 File Offset: 0x0005A438
		[DebuggerNonUserCode]
		public Keys(Keys other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.keys_ = other.keys_.Clone();
			this.secondsUntilRefresh_ = other.secondsUntilRefresh_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060019DA RID: 6618 RVA: 0x0005C288 File Offset: 0x0005A488
		[DebuggerNonUserCode]
		public Keys Clone()
		{
			return new Keys(this);
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060019DB RID: 6619 RVA: 0x0005C2A0 File Offset: 0x0005A4A0
		[DebuggerNonUserCode]
		public RepeatedField<Key> Keys_
		{
			get
			{
				return this.keys_;
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x0005C2B8 File Offset: 0x0005A4B8
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0005C2E9 File Offset: 0x0005A4E9
		[DebuggerNonUserCode]
		public ulong SecondsUntilRefresh
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				ulong secondsUntilRefreshDefaultValue;
				if (flag)
				{
					secondsUntilRefreshDefaultValue = this.secondsUntilRefresh_;
				}
				else
				{
					secondsUntilRefreshDefaultValue = Keys.SecondsUntilRefreshDefaultValue;
				}
				return secondsUntilRefreshDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.secondsUntilRefresh_ = value;
			}
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0005C304 File Offset: 0x0005A504
		[DebuggerNonUserCode]
		public bool HasSecondsUntilRefresh
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0005C321 File Offset: 0x0005A521
		[DebuggerNonUserCode]
		public void ClearSecondsUntilRefresh()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0005C334 File Offset: 0x0005A534
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as Keys);
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0005C354 File Offset: 0x0005A554
		[DebuggerNonUserCode]
		public bool Equals(Keys other)
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
					bool flag4 = !this.keys_.Equals(other.keys_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.SecondsUntilRefresh != other.SecondsUntilRefresh;
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0005C3C8 File Offset: 0x0005A5C8
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.keys_.GetHashCode();
			bool hasSecondsUntilRefresh = this.HasSecondsUntilRefresh;
			if (hasSecondsUntilRefresh)
			{
				num ^= this.SecondsUntilRefresh.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0005C428 File Offset: 0x0005A628
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0005C440 File Offset: 0x0005A640
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0005C44C File Offset: 0x0005A64C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.keys_.WriteTo(ref output, Keys._repeated_keys_codec);
			bool hasSecondsUntilRefresh = this.HasSecondsUntilRefresh;
			if (hasSecondsUntilRefresh)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(this.SecondsUntilRefresh);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0005C4AC File Offset: 0x0005A6AC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.keys_.CalculateSize(Keys._repeated_keys_codec);
			bool hasSecondsUntilRefresh = this.HasSecondsUntilRefresh;
			if (hasSecondsUntilRefresh)
			{
				num += 1 + CodedOutputStream.ComputeUInt64Size(this.SecondsUntilRefresh);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0005C510 File Offset: 0x0005A710
		[DebuggerNonUserCode]
		public void MergeFrom(Keys other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.keys_.Add(other.keys_);
				bool hasSecondsUntilRefresh = other.HasSecondsUntilRefresh;
				if (hasSecondsUntilRefresh)
				{
					this.SecondsUntilRefresh = other.SecondsUntilRefresh;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0005C56B File Offset: 0x0005A76B
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0005C578 File Offset: 0x0005A778
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
						this.SecondsUntilRefresh = input.ReadUInt64();
					}
				}
				else
				{
					this.keys_.AddEntriesFrom(ref input, Keys._repeated_keys_codec);
				}
			}
		}

		// Token: 0x04000A52 RID: 2642
		private static readonly MessageParser<Keys> _parser = new MessageParser<Keys>(() => new Keys());

		// Token: 0x04000A53 RID: 2643
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000A54 RID: 2644
		private int _hasBits0;

		// Token: 0x04000A55 RID: 2645
		public const int Keys_FieldNumber = 1;

		// Token: 0x04000A56 RID: 2646
		private static readonly FieldCodec<Key> _repeated_keys_codec = FieldCodec.ForMessage<Key>(10U, Key.Parser);

		// Token: 0x04000A57 RID: 2647
		private readonly RepeatedField<Key> keys_ = new RepeatedField<Key>();

		// Token: 0x04000A58 RID: 2648
		public const int SecondsUntilRefreshFieldNumber = 2;

		// Token: 0x04000A59 RID: 2649
		private static readonly ulong SecondsUntilRefreshDefaultValue = 0UL;

		// Token: 0x04000A5A RID: 2650
		private ulong secondsUntilRefresh_;
	}
}
