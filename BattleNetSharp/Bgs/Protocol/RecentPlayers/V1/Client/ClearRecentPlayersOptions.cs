using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.RecentPlayers.V1.Client
{
	// Token: 0x0200063E RID: 1598
	public sealed class ClearRecentPlayersOptions : IMessage<ClearRecentPlayersOptions>, IMessage, IEquatable<ClearRecentPlayersOptions>, IDeepCloneable<ClearRecentPlayersOptions>, IBufferMessage
	{
		// Token: 0x17002E5C RID: 11868
		// (get) Token: 0x060094AB RID: 38059 RVA: 0x0023F950 File Offset: 0x0023DB50
		[DebuggerNonUserCode]
		public static MessageParser<ClearRecentPlayersOptions> Parser
		{
			get
			{
				return ClearRecentPlayersOptions._parser;
			}
		}

		// Token: 0x17002E5D RID: 11869
		// (get) Token: 0x060094AC RID: 38060 RVA: 0x0023F968 File Offset: 0x0023DB68
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return RecentPlayersTypesReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002E5E RID: 11870
		// (get) Token: 0x060094AD RID: 38061 RVA: 0x0023F98C File Offset: 0x0023DB8C
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClearRecentPlayersOptions.Descriptor;
			}
		}

		// Token: 0x060094AE RID: 38062 RVA: 0x0023F9A3 File Offset: 0x0023DBA3
		[DebuggerNonUserCode]
		public ClearRecentPlayersOptions()
		{
		}

		// Token: 0x060094AF RID: 38063 RVA: 0x0023F9AD File Offset: 0x0023DBAD
		[DebuggerNonUserCode]
		public ClearRecentPlayersOptions(ClearRecentPlayersOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094B0 RID: 38064 RVA: 0x0023F9E0 File Offset: 0x0023DBE0
		[DebuggerNonUserCode]
		public ClearRecentPlayersOptions Clone()
		{
			return new ClearRecentPlayersOptions(this);
		}

		// Token: 0x17002E5F RID: 11871
		// (get) Token: 0x060094B1 RID: 38065 RVA: 0x0023F9F8 File Offset: 0x0023DBF8
		// (set) Token: 0x060094B2 RID: 38066 RVA: 0x0023FA29 File Offset: 0x0023DC29
		[DebuggerNonUserCode]
		public uint Program
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint programDefaultValue;
				if (flag)
				{
					programDefaultValue = this.program_;
				}
				else
				{
					programDefaultValue = ClearRecentPlayersOptions.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002E60 RID: 11872
		// (get) Token: 0x060094B3 RID: 38067 RVA: 0x0023FA44 File Offset: 0x0023DC44
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060094B4 RID: 38068 RVA: 0x0023FA61 File Offset: 0x0023DC61
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060094B5 RID: 38069 RVA: 0x0023FA74 File Offset: 0x0023DC74
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClearRecentPlayersOptions);
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x0023FA94 File Offset: 0x0023DC94
		[DebuggerNonUserCode]
		public bool Equals(ClearRecentPlayersOptions other)
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
					bool flag4 = this.Program != other.Program;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x0023FAEC File Offset: 0x0023DCEC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x0023FB3C File Offset: 0x0023DD3C
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060094B9 RID: 38073 RVA: 0x0023FB54 File Offset: 0x0023DD54
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x0023FB60 File Offset: 0x0023DD60
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Program);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x0023FBAC File Offset: 0x0023DDAC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x0023FBF0 File Offset: 0x0023DDF0
		[DebuggerNonUserCode]
		public void MergeFrom(ClearRecentPlayersOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060094BD RID: 38077 RVA: 0x0023FC39 File Offset: 0x0023DE39
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x0023FC44 File Offset: 0x0023DE44
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x040042FD RID: 17149
		private static readonly MessageParser<ClearRecentPlayersOptions> _parser = new MessageParser<ClearRecentPlayersOptions>(() => new ClearRecentPlayersOptions());

		// Token: 0x040042FE RID: 17150
		private UnknownFieldSet _unknownFields;

		// Token: 0x040042FF RID: 17151
		private int _hasBits0;

		// Token: 0x04004300 RID: 17152
		public const int ProgramFieldNumber = 1;

		// Token: 0x04004301 RID: 17153
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004302 RID: 17154
		private uint program_;
	}
}
