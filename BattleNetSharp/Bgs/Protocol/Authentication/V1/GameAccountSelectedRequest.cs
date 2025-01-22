using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol.Authentication.V1
{
	// Token: 0x02000615 RID: 1557
	public sealed class GameAccountSelectedRequest : IMessage<GameAccountSelectedRequest>, IMessage, IEquatable<GameAccountSelectedRequest>, IDeepCloneable<GameAccountSelectedRequest>, IBufferMessage
	{
		// Token: 0x17002D9A RID: 11674
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x0023570C File Offset: 0x0023390C
		[DebuggerNonUserCode]
		public static MessageParser<GameAccountSelectedRequest> Parser
		{
			get
			{
				return GameAccountSelectedRequest._parser;
			}
		}

		// Token: 0x17002D9B RID: 11675
		// (get) Token: 0x060091E2 RID: 37346 RVA: 0x00235724 File Offset: 0x00233924
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return AuthenticationServiceReflection.Descriptor.MessageTypes[16];
			}
		}

		// Token: 0x17002D9C RID: 11676
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00235748 File Offset: 0x00233948
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameAccountSelectedRequest.Descriptor;
			}
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x0023575F File Offset: 0x0023395F
		[DebuggerNonUserCode]
		public GameAccountSelectedRequest()
		{
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x0023576C File Offset: 0x0023396C
		[DebuggerNonUserCode]
		public GameAccountSelectedRequest(GameAccountSelectedRequest other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.result_ = other.result_;
			this.gameAccountId_ = ((other.gameAccountId_ != null) ? other.gameAccountId_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x002357C8 File Offset: 0x002339C8
		[DebuggerNonUserCode]
		public GameAccountSelectedRequest Clone()
		{
			return new GameAccountSelectedRequest(this);
		}

		// Token: 0x17002D9D RID: 11677
		// (get) Token: 0x060091E7 RID: 37351 RVA: 0x002357E0 File Offset: 0x002339E0
		// (set) Token: 0x060091E8 RID: 37352 RVA: 0x00235811 File Offset: 0x00233A11
		[DebuggerNonUserCode]
		public uint Result
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint resultDefaultValue;
				if (flag)
				{
					resultDefaultValue = this.result_;
				}
				else
				{
					resultDefaultValue = GameAccountSelectedRequest.ResultDefaultValue;
				}
				return resultDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.result_ = value;
			}
		}

		// Token: 0x17002D9E RID: 11678
		// (get) Token: 0x060091E9 RID: 37353 RVA: 0x0023582C File Offset: 0x00233A2C
		[DebuggerNonUserCode]
		public bool HasResult
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00235849 File Offset: 0x00233A49
		[DebuggerNonUserCode]
		public void ClearResult()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17002D9F RID: 11679
		// (get) Token: 0x060091EB RID: 37355 RVA: 0x0023585C File Offset: 0x00233A5C
		// (set) Token: 0x060091EC RID: 37356 RVA: 0x00235874 File Offset: 0x00233A74
		[DebuggerNonUserCode]
		public EntityId GameAccountId
		{
			get
			{
				return this.gameAccountId_;
			}
			set
			{
				this.gameAccountId_ = value;
			}
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x00235880 File Offset: 0x00233A80
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameAccountSelectedRequest);
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x002358A0 File Offset: 0x00233AA0
		[DebuggerNonUserCode]
		public bool Equals(GameAccountSelectedRequest other)
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
					bool flag4 = this.Result != other.Result;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !object.Equals(this.GameAccountId, other.GameAccountId);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x00235914 File Offset: 0x00233B14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num ^= this.Result.GetHashCode();
			}
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num ^= this.GameAccountId.GetHashCode();
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x00235980 File Offset: 0x00233B80
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x00235998 File Offset: 0x00233B98
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x002359A4 File Offset: 0x00233BA4
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Result);
			}
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.GameAccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x00235A14 File Offset: 0x00233C14
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasResult = this.HasResult;
			if (hasResult)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Result);
			}
			bool flag = this.gameAccountId_ != null;
			if (flag)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GameAccountId);
			}
			bool flag2 = this._unknownFields != null;
			if (flag2)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x00235A84 File Offset: 0x00233C84
		[DebuggerNonUserCode]
		public void MergeFrom(GameAccountSelectedRequest other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasResult = other.HasResult;
				if (hasResult)
				{
					this.Result = other.Result;
				}
				bool flag2 = other.gameAccountId_ != null;
				if (flag2)
				{
					bool flag3 = this.gameAccountId_ == null;
					if (flag3)
					{
						this.GameAccountId = new EntityId();
					}
					this.GameAccountId.MergeFrom(other.GameAccountId);
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x00235B09 File Offset: 0x00233D09
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x00235B14 File Offset: 0x00233D14
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						bool flag = this.gameAccountId_ == null;
						if (flag)
						{
							this.GameAccountId = new EntityId();
						}
						input.ReadMessage(this.GameAccountId);
					}
				}
				else
				{
					this.Result = input.ReadUInt32();
				}
			}
		}

		// Token: 0x040041D0 RID: 16848
		private static readonly MessageParser<GameAccountSelectedRequest> _parser = new MessageParser<GameAccountSelectedRequest>(() => new GameAccountSelectedRequest());

		// Token: 0x040041D1 RID: 16849
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041D2 RID: 16850
		private int _hasBits0;

		// Token: 0x040041D3 RID: 16851
		public const int ResultFieldNumber = 1;

		// Token: 0x040041D4 RID: 16852
		private static readonly uint ResultDefaultValue = 0U;

		// Token: 0x040041D5 RID: 16853
		private uint result_;

		// Token: 0x040041D6 RID: 16854
		public const int GameAccountIdFieldNumber = 2;

		// Token: 0x040041D7 RID: 16855
		private EntityId gameAccountId_;
	}
}
