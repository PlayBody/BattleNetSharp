using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x0200060A RID: 1546
	public sealed class GenerateSSOTokenRequest : IMessage<GenerateSSOTokenRequest>, IMessage, IEquatable<GenerateSSOTokenRequest>, IDeepCloneable<GenerateSSOTokenRequest>, IBufferMessage
	{
		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x060090CF RID: 37071 RVA: 0x00232264 File Offset: 0x00230464
		[DebuggerNonUserCode]
		public static MessageParser<GenerateSSOTokenRequest> Parser
		{
			get
			{
				return GenerateSSOTokenRequest._parser;
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x060090D0 RID: 37072 RVA: 0x0023227C File Offset: 0x0023047C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[5];
			}
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x060090D1 RID: 37073 RVA: 0x002322A0 File Offset: 0x002304A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateSSOTokenRequest.Descriptor;
			}
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x002322B7 File Offset: 0x002304B7
		[DebuggerNonUserCode]
		public GenerateSSOTokenRequest()
		{
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x002322C1 File Offset: 0x002304C1
		[DebuggerNonUserCode]
		public GenerateSSOTokenRequest(GenerateSSOTokenRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x002322F4 File Offset: 0x002304F4
		[DebuggerNonUserCode]
		public GenerateSSOTokenRequest Clone()
		{
			return new GenerateSSOTokenRequest(this);
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x060090D5 RID: 37077 RVA: 0x0023230C File Offset: 0x0023050C
		// (set) Token: 0x060090D6 RID: 37078 RVA: 0x0023233D File Offset: 0x0023053D
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
					programDefaultValue = GenerateSSOTokenRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002D51 RID: 11601
		// (get) Token: 0x060090D7 RID: 37079 RVA: 0x00232358 File Offset: 0x00230558
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x00232375 File Offset: 0x00230575
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x00232388 File Offset: 0x00230588
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateSSOTokenRequest);
		}

		// Token: 0x060090DA RID: 37082 RVA: 0x002323A8 File Offset: 0x002305A8
		[DebuggerNonUserCode]
		public bool Equals(GenerateSSOTokenRequest other)
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

		// Token: 0x060090DB RID: 37083 RVA: 0x00232400 File Offset: 0x00230600
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

		// Token: 0x060090DC RID: 37084 RVA: 0x00232450 File Offset: 0x00230650
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x00232468 File Offset: 0x00230668
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x00232474 File Offset: 0x00230674
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

		// Token: 0x060090DF RID: 37087 RVA: 0x002324C0 File Offset: 0x002306C0
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

		// Token: 0x060090E0 RID: 37088 RVA: 0x00232504 File Offset: 0x00230704
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateSSOTokenRequest other)
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

		// Token: 0x060090E1 RID: 37089 RVA: 0x0023254D File Offset: 0x0023074D
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x00232558 File Offset: 0x00230758
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

		// Token: 0x0400416F RID: 16751
		private static readonly MessageParser<GenerateSSOTokenRequest> _parser = new MessageParser<GenerateSSOTokenRequest>(() => new GenerateSSOTokenRequest());

		// Token: 0x04004170 RID: 16752
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004171 RID: 16753
		private int _hasBits0;

		// Token: 0x04004172 RID: 16754
		public const int ProgramFieldNumber = 1;

		// Token: 0x04004173 RID: 16755
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004174 RID: 16756
		private uint program_;
	}
}
