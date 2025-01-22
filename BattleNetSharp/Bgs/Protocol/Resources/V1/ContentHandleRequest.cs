using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Resources.V1
{
	// Token: 0x020003DA RID: 986
	public sealed class ContentHandleRequest : IMessage<ContentHandleRequest>, IMessage, IEquatable<ContentHandleRequest>, IDeepCloneable<ContentHandleRequest>, IBufferMessage
	{
		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x0017D4DC File Offset: 0x0017B6DC
		[DebuggerNonUserCode]
		public static MessageParser<ContentHandleRequest> Parser
		{
			get
			{
				return ContentHandleRequest._parser;
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06006280 RID: 25216 RVA: 0x0017D4F4 File Offset: 0x0017B6F4
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return ResourceServiceReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06006281 RID: 25217 RVA: 0x0017D518 File Offset: 0x0017B718
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ContentHandleRequest.Descriptor;
			}
		}

		// Token: 0x06006282 RID: 25218 RVA: 0x0017D52F File Offset: 0x0017B72F
		[DebuggerNonUserCode]
		public ContentHandleRequest()
		{
		}

		// Token: 0x06006283 RID: 25219 RVA: 0x0017D53C File Offset: 0x0017B73C
		[DebuggerNonUserCode]
		public ContentHandleRequest(ContentHandleRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.program_ = other.program_;
			this.stream_ = other.stream_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006284 RID: 25220 RVA: 0x0017D594 File Offset: 0x0017B794
		[DebuggerNonUserCode]
		public ContentHandleRequest Clone()
		{
			return new ContentHandleRequest(this);
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x0017D5AC File Offset: 0x0017B7AC
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x0017D5DD File Offset: 0x0017B7DD
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
					programDefaultValue = ContentHandleRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x0017D5F8 File Offset: 0x0017B7F8
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06006288 RID: 25224 RVA: 0x0017D615 File Offset: 0x0017B815
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x0017D628 File Offset: 0x0017B828
		// (set) Token: 0x0600628A RID: 25226 RVA: 0x0017D659 File Offset: 0x0017B859
		[DebuggerNonUserCode]
		public uint Stream
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				uint streamDefaultValue;
				if (flag)
				{
					streamDefaultValue = this.stream_;
				}
				else
				{
					streamDefaultValue = ContentHandleRequest.StreamDefaultValue;
				}
				return streamDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.stream_ = value;
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x0017D674 File Offset: 0x0017B874
		[DebuggerNonUserCode]
		public bool HasStream
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600628C RID: 25228 RVA: 0x0017D691 File Offset: 0x0017B891
		[DebuggerNonUserCode]
		public void ClearStream()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x0017D6A4 File Offset: 0x0017B8A4
		// (set) Token: 0x0600628E RID: 25230 RVA: 0x0017D6D5 File Offset: 0x0017B8D5
		[DebuggerNonUserCode]
		public uint Version
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				uint versionDefaultValue;
				if (flag)
				{
					versionDefaultValue = this.version_;
				}
				else
				{
					versionDefaultValue = ContentHandleRequest.VersionDefaultValue;
				}
				return versionDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.version_ = value;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600628F RID: 25231 RVA: 0x0017D6F0 File Offset: 0x0017B8F0
		[DebuggerNonUserCode]
		public bool HasVersion
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06006290 RID: 25232 RVA: 0x0017D70D File Offset: 0x0017B90D
		[DebuggerNonUserCode]
		public void ClearVersion()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x06006291 RID: 25233 RVA: 0x0017D720 File Offset: 0x0017B920
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ContentHandleRequest);
		}

		// Token: 0x06006292 RID: 25234 RVA: 0x0017D740 File Offset: 0x0017B940
		[DebuggerNonUserCode]
		public bool Equals(ContentHandleRequest other)
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
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Stream != other.Stream;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.Version != other.Version;
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06006293 RID: 25235 RVA: 0x0017D7CC File Offset: 0x0017B9CC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				num ^= this.Stream.GetHashCode();
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				num ^= this.Version.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006294 RID: 25236 RVA: 0x0017D858 File Offset: 0x0017BA58
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06006295 RID: 25237 RVA: 0x0017D870 File Offset: 0x0017BA70
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006296 RID: 25238 RVA: 0x0017D87C File Offset: 0x0017BA7C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(13);
				output.WriteFixed32(this.Program);
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Stream);
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
			{
				output.WriteRawTag(29);
				output.WriteFixed32(this.Version);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006297 RID: 25239 RVA: 0x0017D90C File Offset: 0x0017BB0C
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool hasStream = this.HasStream;
			if (hasStream)
			{
				num += 5;
			}
			bool hasVersion = this.HasVersion;
			if (hasVersion)
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

		// Token: 0x06006298 RID: 25240 RVA: 0x0017D974 File Offset: 0x0017BB74
		[DebuggerNonUserCode]
		public void MergeFrom(ContentHandleRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool hasStream = other.HasStream;
				if (hasStream)
				{
					this.Stream = other.Stream;
				}
				bool hasVersion = other.HasVersion;
				if (hasVersion)
				{
					this.Version = other.Version;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x0017D9EF File Offset: 0x0017BBEF
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x0017D9FC File Offset: 0x0017BBFC
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
					if (num3 != 21U)
					{
						if (num3 != 29U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Version = input.ReadFixed32();
						}
					}
					else
					{
						this.Stream = input.ReadFixed32();
					}
				}
				else
				{
					this.Program = input.ReadFixed32();
				}
			}
		}

		// Token: 0x04002D01 RID: 11521
		private static readonly MessageParser<ContentHandleRequest> _parser = new MessageParser<ContentHandleRequest>(() => new ContentHandleRequest());

		// Token: 0x04002D02 RID: 11522
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D03 RID: 11523
		private int _hasBits0;

		// Token: 0x04002D04 RID: 11524
		public const int ProgramFieldNumber = 1;

		// Token: 0x04002D05 RID: 11525
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04002D06 RID: 11526
		private uint program_;

		// Token: 0x04002D07 RID: 11527
		public const int StreamFieldNumber = 2;

		// Token: 0x04002D08 RID: 11528
		private static readonly uint StreamDefaultValue = 0U;

		// Token: 0x04002D09 RID: 11529
		private uint stream_;

		// Token: 0x04002D0A RID: 11530
		public const int VersionFieldNumber = 3;

		// Token: 0x04002D0B RID: 11531
		private static readonly uint VersionDefaultValue = 1701729619U;

		// Token: 0x04002D0C RID: 11532
		private uint version_;
	}
}
