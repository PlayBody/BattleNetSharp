using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace ToolChannelMsg
{
	// Token: 0x0200006D RID: 109
	public sealed class PlaySubzoneRequest : IMessage<PlaySubzoneRequest>, IMessage, IEquatable<PlaySubzoneRequest>, IDeepCloneable<PlaySubzoneRequest>, IBufferMessage
	{
		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x00025AA8 File Offset: 0x00023CA8
		[DebuggerNonUserCode]
		public static MessageParser<PlaySubzoneRequest> Parser
		{
			get
			{
				return PlaySubzoneRequest._parser;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00025AC0 File Offset: 0x00023CC0
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ToolReflection.Descriptor.MessageTypes[86];
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00025AE4 File Offset: 0x00023CE4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaySubzoneRequest.Descriptor;
			}
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x00025AFB File Offset: 0x00023CFB
		[DebuggerNonUserCode]
		public PlaySubzoneRequest()
		{
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00025B05 File Offset: 0x00023D05
		[DebuggerNonUserCode]
		public PlaySubzoneRequest(PlaySubzoneRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.snoSubzone_ = other.snoSubzone_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00025B38 File Offset: 0x00023D38
		[DebuggerNonUserCode]
		public PlaySubzoneRequest Clone()
		{
			return new PlaySubzoneRequest(this);
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x00025B50 File Offset: 0x00023D50
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00025B81 File Offset: 0x00023D81
		[DebuggerNonUserCode]
		public int SnoSubzone
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				int snoSubzoneDefaultValue;
				if (flag)
				{
					snoSubzoneDefaultValue = this.snoSubzone_;
				}
				else
				{
					snoSubzoneDefaultValue = PlaySubzoneRequest.SnoSubzoneDefaultValue;
				}
				return snoSubzoneDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.snoSubzone_ = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x00025B9C File Offset: 0x00023D9C
		[DebuggerNonUserCode]
		public bool HasSnoSubzone
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x00025BB9 File Offset: 0x00023DB9
		[DebuggerNonUserCode]
		public void ClearSnoSubzone()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00025BCC File Offset: 0x00023DCC
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaySubzoneRequest);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00025BEC File Offset: 0x00023DEC
		[DebuggerNonUserCode]
		public bool Equals(PlaySubzoneRequest other)
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
					bool flag4 = this.SnoSubzone != other.SnoSubzone;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00025C44 File Offset: 0x00023E44
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num ^= this.SnoSubzone.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00025C94 File Offset: 0x00023E94
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x00025CAC File Offset: 0x00023EAC
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00025CB8 File Offset: 0x00023EB8
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00025D04 File Offset: 0x00023F04
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSnoSubzone = this.HasSnoSubzone;
			if (hasSnoSubzone)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SnoSubzone);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00025D54 File Offset: 0x00023F54
		[DebuggerNonUserCode]
		public void MergeFrom(PlaySubzoneRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSnoSubzone = other.HasSnoSubzone;
				if (hasSnoSubzone)
				{
					this.SnoSubzone = other.SnoSubzone;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x00025D9D File Offset: 0x00023F9D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x00025DA8 File Offset: 0x00023FA8
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
					this.SnoSubzone = input.ReadInt32();
				}
			}
		}

		// Token: 0x040003C4 RID: 964
		private static readonly MessageParser<PlaySubzoneRequest> _parser = new MessageParser<PlaySubzoneRequest>(() => new PlaySubzoneRequest());

		// Token: 0x040003C5 RID: 965
		private UnknownFieldSet _unknownFields;

		// Token: 0x040003C6 RID: 966
		private int _hasBits0;

		// Token: 0x040003C7 RID: 967
		public const int SnoSubzoneFieldNumber = 1;

		// Token: 0x040003C8 RID: 968
		private static readonly int SnoSubzoneDefaultValue = 0;

		// Token: 0x040003C9 RID: 969
		private int snoSubzone_;
	}
}
