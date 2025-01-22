using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Session.V2.Client
{
	// Token: 0x02000560 RID: 1376
	public sealed class GetSignedSessionStateResponse : IMessage<GetSignedSessionStateResponse>, IMessage, IEquatable<GetSignedSessionStateResponse>, IDeepCloneable<GetSignedSessionStateResponse>, IBufferMessage
	{
		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x060084B9 RID: 33977 RVA: 0x00204368 File Offset: 0x00202568
		[DebuggerNonUserCode]
		public static MessageParser<GetSignedSessionStateResponse> Parser
		{
			get
			{
				return GetSignedSessionStateResponse._parser;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x060084BA RID: 33978 RVA: 0x00204380 File Offset: 0x00202580
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return SessionServiceReflection.Descriptor.MessageTypes[6];
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x060084BB RID: 33979 RVA: 0x002043A4 File Offset: 0x002025A4
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetSignedSessionStateResponse.Descriptor;
			}
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x002043BB File Offset: 0x002025BB
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse()
		{
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x002043C5 File Offset: 0x002025C5
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse(GetSignedSessionStateResponse other)
			: this()
		{
			this.signedToken_ = other.signedToken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x002043EC File Offset: 0x002025EC
		[DebuggerNonUserCode]
		public GetSignedSessionStateResponse Clone()
		{
			return new GetSignedSessionStateResponse(this);
		}

		// Token: 0x170029E6 RID: 10726
		// (get) Token: 0x060084BF RID: 33983 RVA: 0x00204404 File Offset: 0x00202604
		// (set) Token: 0x060084C0 RID: 33984 RVA: 0x00204425 File Offset: 0x00202625
		[DebuggerNonUserCode]
		public string SignedToken
		{
			get
			{
				return this.signedToken_ ?? GetSignedSessionStateResponse.SignedTokenDefaultValue;
			}
			set
			{
				this.signedToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x170029E7 RID: 10727
		// (get) Token: 0x060084C1 RID: 33985 RVA: 0x0020443C File Offset: 0x0020263C
		[DebuggerNonUserCode]
		public bool HasSignedToken
		{
			get
			{
				return this.signedToken_ != null;
			}
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x00204457 File Offset: 0x00202657
		[DebuggerNonUserCode]
		public void ClearSignedToken()
		{
			this.signedToken_ = null;
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x00204464 File Offset: 0x00202664
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetSignedSessionStateResponse);
		}

		// Token: 0x060084C4 RID: 33988 RVA: 0x00204484 File Offset: 0x00202684
		[DebuggerNonUserCode]
		public bool Equals(GetSignedSessionStateResponse other)
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
					bool flag4 = this.SignedToken != other.SignedToken;
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x002044DC File Offset: 0x002026DC
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasSignedToken = this.HasSignedToken;
			if (hasSignedToken)
			{
				num ^= this.SignedToken.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x00204528 File Offset: 0x00202728
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x00204540 File Offset: 0x00202740
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x0020454C File Offset: 0x0020274C
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasSignedToken = this.HasSignedToken;
			if (hasSignedToken)
			{
				output.WriteRawTag(10);
				output.WriteString(this.SignedToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060084C9 RID: 33993 RVA: 0x00204598 File Offset: 0x00202798
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasSignedToken = this.HasSignedToken;
			if (hasSignedToken)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SignedToken);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x002045E8 File Offset: 0x002027E8
		[DebuggerNonUserCode]
		public void MergeFrom(GetSignedSessionStateResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasSignedToken = other.HasSignedToken;
				if (hasSignedToken)
				{
					this.SignedToken = other.SignedToken;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x00204631 File Offset: 0x00202831
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x0020463C File Offset: 0x0020283C
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
					this.SignedToken = input.ReadString();
				}
			}
		}

		// Token: 0x04003C2B RID: 15403
		private static readonly MessageParser<GetSignedSessionStateResponse> _parser = new MessageParser<GetSignedSessionStateResponse>(() => new GetSignedSessionStateResponse());

		// Token: 0x04003C2C RID: 15404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C2D RID: 15405
		public const int SignedTokenFieldNumber = 1;

		// Token: 0x04003C2E RID: 15406
		private static readonly string SignedTokenDefaultValue = "";

		// Token: 0x04003C2F RID: 15407
		private string signedToken_;
	}
}
