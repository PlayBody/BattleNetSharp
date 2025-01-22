using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.GameUtilities.V1
{
	// Token: 0x020005E2 RID: 1506
	public sealed class ServerRequest : IMessage<ServerRequest>, IMessage, IEquatable<ServerRequest>, IDeepCloneable<ServerRequest>, IBufferMessage
	{
		// Token: 0x17002C66 RID: 11366
		// (get) Token: 0x06008DAB RID: 36267 RVA: 0x0022657C File Offset: 0x0022477C
		[DebuggerNonUserCode]
		public static MessageParser<ServerRequest> Parser
		{
			get
			{
				return ServerRequest._parser;
			}
		}

		// Token: 0x17002C67 RID: 11367
		// (get) Token: 0x06008DAC RID: 36268 RVA: 0x00226594 File Offset: 0x00224794
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameUtilitiesServiceReflection.Descriptor.MessageTypes[2];
			}
		}

		// Token: 0x17002C68 RID: 11368
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x002265B8 File Offset: 0x002247B8
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ServerRequest.Descriptor;
			}
		}

		// Token: 0x06008DAE RID: 36270 RVA: 0x002265CF File Offset: 0x002247CF
		[DebuggerNonUserCode]
		public ServerRequest()
		{
		}

		// Token: 0x06008DAF RID: 36271 RVA: 0x002265E4 File Offset: 0x002247E4
		[DebuggerNonUserCode]
		public ServerRequest(ServerRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.attribute_ = other.attribute_.Clone();
			this.program_ = other.program_;
			this.host_ = ((other.host_ != null) ? other.host_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008DB0 RID: 36272 RVA: 0x00226650 File Offset: 0x00224850
		[DebuggerNonUserCode]
		public ServerRequest Clone()
		{
			return new ServerRequest(this);
		}

		// Token: 0x17002C69 RID: 11369
		// (get) Token: 0x06008DB1 RID: 36273 RVA: 0x00226668 File Offset: 0x00224868
		[DebuggerNonUserCode]
		public RepeatedField<Attribute> Attribute
		{
			get
			{
				return this.attribute_;
			}
		}

		// Token: 0x17002C6A RID: 11370
		// (get) Token: 0x06008DB2 RID: 36274 RVA: 0x00226680 File Offset: 0x00224880
		// (set) Token: 0x06008DB3 RID: 36275 RVA: 0x002266B1 File Offset: 0x002248B1
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
					programDefaultValue = ServerRequest.ProgramDefaultValue;
				}
				return programDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.program_ = value;
			}
		}

		// Token: 0x17002C6B RID: 11371
		// (get) Token: 0x06008DB4 RID: 36276 RVA: 0x002266CC File Offset: 0x002248CC
		[DebuggerNonUserCode]
		public bool HasProgram
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06008DB5 RID: 36277 RVA: 0x002266E9 File Offset: 0x002248E9
		[DebuggerNonUserCode]
		public void ClearProgram()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x06008DB6 RID: 36278 RVA: 0x002266FC File Offset: 0x002248FC
		// (set) Token: 0x06008DB7 RID: 36279 RVA: 0x00226714 File Offset: 0x00224914
		[DebuggerNonUserCode]
		public ProcessId Host
		{
			get
			{
				return this.host_;
			}
			set
			{
				this.host_ = value;
			}
		}

		// Token: 0x06008DB8 RID: 36280 RVA: 0x00226720 File Offset: 0x00224920
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as ServerRequest);
		}

		// Token: 0x06008DB9 RID: 36281 RVA: 0x00226740 File Offset: 0x00224940
		[DebuggerNonUserCode]
		public bool Equals(ServerRequest other)
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
					bool flag4 = !this.attribute_.Equals(other.attribute_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.Program != other.Program;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = !object.Equals(this.Host, other.Host);
							flag2 = !flag6 && object.Equals(this._unknownFields, other._unknownFields);
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06008DBA RID: 36282 RVA: 0x002267D4 File Offset: 0x002249D4
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.attribute_.GetHashCode();
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num ^= this.Program.GetHashCode();
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				num ^= this.Host.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008DBB RID: 36283 RVA: 0x00226850 File Offset: 0x00224A50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06008DBC RID: 36284 RVA: 0x00226868 File Offset: 0x00224A68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008DBD RID: 36285 RVA: 0x00226874 File Offset: 0x00224A74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attribute_.WriteTo(ref output, ServerRequest._repeated_attribute_codec);
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				output.WriteRawTag(21);
				output.WriteFixed32(this.Program);
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x002268F8 File Offset: 0x00224AF8
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.attribute_.CalculateSize(ServerRequest._repeated_attribute_codec);
			bool hasProgram = this.HasProgram;
			if (hasProgram)
			{
				num += 5;
			}
			bool flag = this.host_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Host);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008DBF RID: 36287 RVA: 0x00226970 File Offset: 0x00224B70
		[DebuggerNonUserCode]
		public void MergeFrom(ServerRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.attribute_.Add(other.attribute_);
				bool hasProgram = other.HasProgram;
				if (hasProgram)
				{
					this.Program = other.Program;
				}
				bool flag2 = other.host_ != null;
				if (flag2)
				{
					bool flag3 = this.host_ == null;
					if (flag3)
					{
						this.Host = new ProcessId();
					}
					this.Host.MergeFrom(other.Host);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06008DC0 RID: 36288 RVA: 0x00226A07 File Offset: 0x00224C07
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008DC1 RID: 36289 RVA: 0x00226A14 File Offset: 0x00224C14
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
					if (num3 != 21U)
					{
						if (num3 != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							bool flag = this.host_ == null;
							if (flag)
							{
								this.Host = new ProcessId();
							}
							input.ReadMessage(this.Host);
						}
					}
					else
					{
						this.Program = input.ReadFixed32();
					}
				}
				else
				{
					this.attribute_.AddEntriesFrom(ref input, ServerRequest._repeated_attribute_codec);
				}
			}
		}

		// Token: 0x0400400C RID: 16396
		private static readonly MessageParser<ServerRequest> _parser = new MessageParser<ServerRequest>(() => new ServerRequest());

		// Token: 0x0400400D RID: 16397
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400400E RID: 16398
		private int _hasBits0;

		// Token: 0x0400400F RID: 16399
		public const int AttributeFieldNumber = 1;

		// Token: 0x04004010 RID: 16400
		private static readonly FieldCodec<Attribute> _repeated_attribute_codec = FieldCodec.ForMessage<Attribute>(10U, Bgs.Protocol.Attribute.Parser);

		// Token: 0x04004011 RID: 16401
		private readonly RepeatedField<Attribute> attribute_ = new RepeatedField<Attribute>();

		// Token: 0x04004012 RID: 16402
		public const int ProgramFieldNumber = 2;

		// Token: 0x04004013 RID: 16403
		private static readonly uint ProgramDefaultValue = 0U;

		// Token: 0x04004014 RID: 16404
		private uint program_;

		// Token: 0x04004015 RID: 16405
		public const int HostFieldNumber = 3;

		// Token: 0x04004016 RID: 16406
		private ProcessId host_;
	}
}
