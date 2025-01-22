using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Account.V1
{
	// Token: 0x02000747 RID: 1863
	public sealed class GameSessionUpdateInfo : IMessage<GameSessionUpdateInfo>, IMessage, IEquatable<GameSessionUpdateInfo>, IDeepCloneable<GameSessionUpdateInfo>, IBufferMessage
	{
		// Token: 0x170034FF RID: 13567
		// (get) Token: 0x0600AB71 RID: 43889 RVA: 0x0029C264 File Offset: 0x0029A464
		[DebuggerNonUserCode]
		public static MessageParser<GameSessionUpdateInfo> Parser
		{
			get
			{
				return GameSessionUpdateInfo._parser;
			}
		}

		// Token: 0x17003500 RID: 13568
		// (get) Token: 0x0600AB72 RID: 43890 RVA: 0x0029C27C File Offset: 0x0029A47C
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AccountTypesReflection.Descriptor.MessageTypes[23];
			}
		}

		// Token: 0x17003501 RID: 13569
		// (get) Token: 0x0600AB73 RID: 43891 RVA: 0x0029C2A0 File Offset: 0x0029A4A0
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameSessionUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0600AB74 RID: 43892 RVA: 0x0029C2B7 File Offset: 0x0029A4B7
		[DebuggerNonUserCode]
		public GameSessionUpdateInfo()
		{
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x0029C2C1 File Offset: 0x0029A4C1
		[DebuggerNonUserCode]
		public GameSessionUpdateInfo(GameSessionUpdateInfo other)
			: this()
		{
			this.cais_ = ((other.cais_ != null) ? other.cais_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x0029C2F8 File Offset: 0x0029A4F8
		[DebuggerNonUserCode]
		public GameSessionUpdateInfo Clone()
		{
			return new GameSessionUpdateInfo(this);
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600AB77 RID: 43895 RVA: 0x0029C310 File Offset: 0x0029A510
		// (set) Token: 0x0600AB78 RID: 43896 RVA: 0x0029C328 File Offset: 0x0029A528
		[DebuggerNonUserCode]
		public CAIS Cais
		{
			get
			{
				return this.cais_;
			}
			set
			{
				this.cais_ = value;
			}
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x0029C334 File Offset: 0x0029A534
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameSessionUpdateInfo);
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x0029C354 File Offset: 0x0029A554
		[DebuggerNonUserCode]
		public bool Equals(GameSessionUpdateInfo other)
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
					bool flag4 = !object.Equals(this.Cais, other.Cais);
					flag2 = !flag4 && object.Equals(this._unknownFields, other._unknownFields);
				}
			}
			return flag2;
		}

		// Token: 0x0600AB7B RID: 43899 RVA: 0x0029C3B0 File Offset: 0x0029A5B0
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool flag = this.cais_ != null;
			if (flag)
			{
				num ^= this.Cais.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x0029C400 File Offset: 0x0029A600
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x0029C418 File Offset: 0x0029A618
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x0029C424 File Offset: 0x0029A624
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool flag = this.cais_ != null;
			if (flag)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Cais);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x0029C474 File Offset: 0x0029A674
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool flag = this.cais_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Cais);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x0029C4C8 File Offset: 0x0029A6C8
		[DebuggerNonUserCode]
		public void MergeFrom(GameSessionUpdateInfo other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool flag2 = other.cais_ != null;
				if (flag2)
				{
					bool flag3 = this.cais_ == null;
					if (flag3)
					{
						this.Cais = new CAIS();
					}
					this.Cais.MergeFrom(other.Cais);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x0029C534 File Offset: 0x0029A734
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x0029C540 File Offset: 0x0029A740
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					bool flag = this.cais_ == null;
					if (flag)
					{
						this.Cais = new CAIS();
					}
					input.ReadMessage(this.Cais);
				}
			}
		}

		// Token: 0x04004D41 RID: 19777
		private static readonly MessageParser<GameSessionUpdateInfo> _parser = new MessageParser<GameSessionUpdateInfo>(() => new GameSessionUpdateInfo());

		// Token: 0x04004D42 RID: 19778
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D43 RID: 19779
		public const int CaisFieldNumber = 8;

		// Token: 0x04004D44 RID: 19780
		private CAIS cais_;
	}
}
