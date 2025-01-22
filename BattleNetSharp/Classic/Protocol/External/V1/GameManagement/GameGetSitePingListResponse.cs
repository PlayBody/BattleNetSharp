using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Classic.Protocol.External.V1.GameManagement
{
	// Token: 0x0200079B RID: 1947
	public sealed class GameGetSitePingListResponse : IMessage<GameGetSitePingListResponse>, IMessage, IEquatable<GameGetSitePingListResponse>, IDeepCloneable<GameGetSitePingListResponse>, IBufferMessage
	{
		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600B314 RID: 45844 RVA: 0x002B90EC File Offset: 0x002B72EC
		[DebuggerNonUserCode]
		public static MessageParser<GameGetSitePingListResponse> Parser
		{
			get
			{
				return GameGetSitePingListResponse._parser;
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600B315 RID: 45845 RVA: 0x002B9104 File Offset: 0x002B7304
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return GameManagementReflection.Descriptor.MessageTypes[15];
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600B316 RID: 45846 RVA: 0x002B9128 File Offset: 0x002B7328
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GameGetSitePingListResponse.Descriptor;
			}
		}

		// Token: 0x0600B317 RID: 45847 RVA: 0x002B913F File Offset: 0x002B733F
		[DebuggerNonUserCode]
		public GameGetSitePingListResponse()
		{
		}

		// Token: 0x0600B318 RID: 45848 RVA: 0x002B915F File Offset: 0x002B735F
		[DebuggerNonUserCode]
		public GameGetSitePingListResponse(GameGetSitePingListResponse other)
			: this()
		{
			this.gameSite_ = other.gameSite_.Clone();
			this.region_ = other.region_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B319 RID: 45849 RVA: 0x002B919C File Offset: 0x002B739C
		[DebuggerNonUserCode]
		public GameGetSitePingListResponse Clone()
		{
			return new GameGetSitePingListResponse(this);
		}

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600B31A RID: 45850 RVA: 0x002B91B4 File Offset: 0x002B73B4
		[DebuggerNonUserCode]
		public RepeatedField<GameSite> GameSite
		{
			get
			{
				return this.gameSite_;
			}
		}

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600B31B RID: 45851 RVA: 0x002B91CC File Offset: 0x002B73CC
		[DebuggerNonUserCode]
		public RepeatedField<string> Region
		{
			get
			{
				return this.region_;
			}
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x002B91E4 File Offset: 0x002B73E4
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as GameGetSitePingListResponse);
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x002B9204 File Offset: 0x002B7404
		[DebuggerNonUserCode]
		public bool Equals(GameGetSitePingListResponse other)
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
					bool flag4 = !this.gameSite_.Equals(other.gameSite_);
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = !this.region_.Equals(other.region_);
						flag2 = !flag5 && object.Equals(this._unknownFields, other._unknownFields);
					}
				}
			}
			return flag2;
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x002B927C File Offset: 0x002B747C
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gameSite_.GetHashCode();
			num ^= this.region_.GetHashCode();
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x002B92CC File Offset: 0x002B74CC
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x002B92E4 File Offset: 0x002B74E4
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x002B92F0 File Offset: 0x002B74F0
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gameSite_.WriteTo(ref output, GameGetSitePingListResponse._repeated_gameSite_codec);
			this.region_.WriteTo(ref output, GameGetSitePingListResponse._repeated_region_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x002B9340 File Offset: 0x002B7540
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gameSite_.CalculateSize(GameGetSitePingListResponse._repeated_gameSite_codec);
			num += this.region_.CalculateSize(GameGetSitePingListResponse._repeated_region_codec);
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x002B9398 File Offset: 0x002B7598
		[DebuggerNonUserCode]
		public void MergeFrom(GameGetSitePingListResponse other)
		{
			bool flag = other == null;
			if (!flag)
			{
				this.gameSite_.Add(other.gameSite_);
				this.region_.Add(other.region_);
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x002B93EC File Offset: 0x002B75EC
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x002B93F8 File Offset: 0x002B75F8
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
					if (num3 != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.region_.AddEntriesFrom(ref input, GameGetSitePingListResponse._repeated_region_codec);
					}
				}
				else
				{
					this.gameSite_.AddEntriesFrom(ref input, GameGetSitePingListResponse._repeated_gameSite_codec);
				}
			}
		}

		// Token: 0x040050DA RID: 20698
		private static readonly MessageParser<GameGetSitePingListResponse> _parser = new MessageParser<GameGetSitePingListResponse>(() => new GameGetSitePingListResponse());

		// Token: 0x040050DB RID: 20699
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050DC RID: 20700
		public const int GameSiteFieldNumber = 1;

		// Token: 0x040050DD RID: 20701
		private static readonly FieldCodec<GameSite> _repeated_gameSite_codec = FieldCodec.ForMessage<GameSite>(10U, Classic.Protocol.External.V1.GameManagement.GameSite.Parser);

		// Token: 0x040050DE RID: 20702
		private readonly RepeatedField<GameSite> gameSite_ = new RepeatedField<GameSite>();

		// Token: 0x040050DF RID: 20703
		public const int RegionFieldNumber = 2;

		// Token: 0x040050E0 RID: 20704
		private static readonly FieldCodec<string> _repeated_region_codec = FieldCodec.ForString(18U);

		// Token: 0x040050E1 RID: 20705
		private readonly RepeatedField<string> region_ = new RepeatedField<string>();
	}
}
