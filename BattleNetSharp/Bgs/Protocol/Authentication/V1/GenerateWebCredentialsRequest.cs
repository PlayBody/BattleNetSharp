using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000616 RID: 1558
	public sealed class GenerateWebCredentialsRequest : IMessage<GenerateWebCredentialsRequest>, IMessage, IEquatable<GenerateWebCredentialsRequest>, IDeepCloneable<GenerateWebCredentialsRequest>, IBufferMessage
	{
		// Token: 0x17002DA0 RID: 11680
		// (get) Token: 0x060091F8 RID: 37368 RVA: 0x00235BBC File Offset: 0x00233DBC
		[DebuggerNonUserCode]
		public static MessageParser<GenerateWebCredentialsRequest> Parser
		{
			get
			{
				return GenerateWebCredentialsRequest._parser;
			}
		}

		// Token: 0x17002DA1 RID: 11681
		// (get) Token: 0x060091F9 RID: 37369 RVA: 0x00235BD4 File Offset: 0x00233DD4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[17];
			}
		}

		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x060091FA RID: 37370 RVA: 0x00235BF8 File Offset: 0x00233DF8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GenerateWebCredentialsRequest.Descriptor;
			}
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00235C0F File Offset: 0x00233E0F
		[DebuggerNonUserCode]
		public GenerateWebCredentialsRequest()
		{
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00235C19 File Offset: 0x00233E19
		[DebuggerNonUserCode]
		public GenerateWebCredentialsRequest(GenerateWebCredentialsRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00235C4C File Offset: 0x00233E4C
		[DebuggerNonUserCode]
		public GenerateWebCredentialsRequest Clone()
		{
			return new GenerateWebCredentialsRequest(this);
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x060091FE RID: 37374 RVA: 0x00235C64 File Offset: 0x00233E64
		// (set) Token: 0x060091FF RID: 37375 RVA: 0x00235C95 File Offset: 0x00233E95
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
					programDefaultValue = GenerateWebCredentialsRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x06009200 RID: 37376 RVA: 0x00235CB0 File Offset: 0x00233EB0
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00235CCD File Offset: 0x00233ECD
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x06009202 RID: 37378 RVA: 0x00235CE0 File Offset: 0x00233EE0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GenerateWebCredentialsRequest);
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00235D00 File Offset: 0x00233F00
		[DebuggerNonUserCode]
		public bool Equals(GenerateWebCredentialsRequest other)
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

		// Token: 0x06009204 RID: 37380 RVA: 0x00235D58 File Offset: 0x00233F58
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

		// Token: 0x06009205 RID: 37381 RVA: 0x00235DA8 File Offset: 0x00233FA8
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00235DC0 File Offset: 0x00233FC0
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00235DCC File Offset: 0x00233FCC
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

		// Token: 0x06009208 RID: 37384 RVA: 0x00235E18 File Offset: 0x00234018
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

		// Token: 0x06009209 RID: 37385 RVA: 0x00235E5C File Offset: 0x0023405C
		[DebuggerNonUserCode]
		public void MergeFrom(GenerateWebCredentialsRequest other)
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

		// Token: 0x0600920A RID: 37386 RVA: 0x00235EA5 File Offset: 0x002340A5
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x00235EB0 File Offset: 0x002340B0
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

		// Token: 0x040041D8 RID: 16856
		private static readonly MessageParser<GenerateWebCredentialsRequest> _parser = new MessageParser<GenerateWebCredentialsRequest>(() => new GenerateWebCredentialsRequest());

		// Token: 0x040041D9 RID: 16857
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041DA RID: 16858
		private int _hasBits0;

		// Token: 0x040041DB RID: 16859
		public const int ProgramFieldNumber = 1;

		// Token: 0x040041DC RID: 16860
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x040041DD RID: 16861
		private uint program_;
	}
}
