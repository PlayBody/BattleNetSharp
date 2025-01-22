using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Bgs.Protocol
{
	// Token: 0x02000370 RID: 880
	public sealed class BGSMethodOptions : IMessage<BGSMethodOptions>, IMessage, IEquatable<BGSMethodOptions>, IDeepCloneable<BGSMethodOptions>, IBufferMessage
	{
		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06005A3E RID: 23102 RVA: 0x0015D390 File Offset: 0x0015B590
		[DebuggerNonUserCode]
		public static MessageParser<BGSMethodOptions> Parser
		{
			get
			{
				return BGSMethodOptions._parser;
			}
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06005A3F RID: 23103 RVA: 0x0015D3A8 File Offset: 0x0015B5A8
		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return MethodOptionsReflection.Descriptor.MessageTypes[0];
			}
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06005A40 RID: 23104 RVA: 0x0015D3CC File Offset: 0x0015B5CC
		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BGSMethodOptions.Descriptor;
			}
		}

		// Token: 0x06005A41 RID: 23105 RVA: 0x0015D3E3 File Offset: 0x0015B5E3
		[DebuggerNonUserCode]
		public BGSMethodOptions()
		{
		}

		// Token: 0x06005A42 RID: 23106 RVA: 0x0015D3F0 File Offset: 0x0015B5F0
		[DebuggerNonUserCode]
		public BGSMethodOptions(BGSMethodOptions other)
			: this()
		{
			this._hasBits0 = other._hasBits0;
			this.id_ = other.id_;
			this.clientIdentityRouting_ = other.clientIdentityRouting_;
			this.enableFanout_ = other.enableFanout_;
			this.legacyFanoutReplacement_ = other.legacyFanoutReplacement_;
			this.forwardKey_ = other.forwardKey_;
			this.idempotent_ = other.idempotent_;
			this.handleDestinationUnreachable_ = other.handleDestinationUnreachable_;
			this.customRegionResolver_ = other.customRegionResolver_;
			this.explicitRegionRouting_ = other.explicitRegionRouting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A43 RID: 23107 RVA: 0x0015D490 File Offset: 0x0015B690
		[DebuggerNonUserCode]
		public BGSMethodOptions Clone()
		{
			return new BGSMethodOptions(this);
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x0015D4A8 File Offset: 0x0015B6A8
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x0015D4D9 File Offset: 0x0015B6D9
		[DebuggerNonUserCode]
		public uint Id
		{
			get
			{
				bool flag = (this._hasBits0 & 1) != 0;
				uint idDefaultValue;
				if (flag)
				{
					idDefaultValue = this.id_;
				}
				else
				{
					idDefaultValue = BGSMethodOptions.IdDefaultValue;
				}
				return idDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.id_ = value;
			}
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x0015D4F4 File Offset: 0x0015B6F4
		[DebuggerNonUserCode]
		public bool HasId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x06005A47 RID: 23111 RVA: 0x0015D511 File Offset: 0x0015B711
		[DebuggerNonUserCode]
		public void ClearId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06005A48 RID: 23112 RVA: 0x0015D524 File Offset: 0x0015B724
		// (set) Token: 0x06005A49 RID: 23113 RVA: 0x0015D555 File Offset: 0x0015B755
		[DebuggerNonUserCode]
		public ClientIdentityRoutingType ClientIdentityRouting
		{
			get
			{
				bool flag = (this._hasBits0 & 2) != 0;
				ClientIdentityRoutingType clientIdentityRoutingDefaultValue;
				if (flag)
				{
					clientIdentityRoutingDefaultValue = this.clientIdentityRouting_;
				}
				else
				{
					clientIdentityRoutingDefaultValue = BGSMethodOptions.ClientIdentityRoutingDefaultValue;
				}
				return clientIdentityRoutingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.clientIdentityRouting_ = value;
			}
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06005A4A RID: 23114 RVA: 0x0015D570 File Offset: 0x0015B770
		[DebuggerNonUserCode]
		public bool HasClientIdentityRouting
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x06005A4B RID: 23115 RVA: 0x0015D58D File Offset: 0x0015B78D
		[DebuggerNonUserCode]
		public void ClearClientIdentityRouting()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06005A4C RID: 23116 RVA: 0x0015D5A0 File Offset: 0x0015B7A0
		// (set) Token: 0x06005A4D RID: 23117 RVA: 0x0015D5D1 File Offset: 0x0015B7D1
		[DebuggerNonUserCode]
		public bool EnableFanout
		{
			get
			{
				bool flag = (this._hasBits0 & 4) != 0;
				bool enableFanoutDefaultValue;
				if (flag)
				{
					enableFanoutDefaultValue = this.enableFanout_;
				}
				else
				{
					enableFanoutDefaultValue = BGSMethodOptions.EnableFanoutDefaultValue;
				}
				return enableFanoutDefaultValue;
			}
			set
			{
				this._hasBits0 |= 4;
				this.enableFanout_ = value;
			}
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06005A4E RID: 23118 RVA: 0x0015D5EC File Offset: 0x0015B7EC
		[DebuggerNonUserCode]
		public bool HasEnableFanout
		{
			get
			{
				return (this._hasBits0 & 4) != 0;
			}
		}

		// Token: 0x06005A4F RID: 23119 RVA: 0x0015D609 File Offset: 0x0015B809
		[DebuggerNonUserCode]
		public void ClearEnableFanout()
		{
			this._hasBits0 &= -5;
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06005A50 RID: 23120 RVA: 0x0015D61C File Offset: 0x0015B81C
		// (set) Token: 0x06005A51 RID: 23121 RVA: 0x0015D63D File Offset: 0x0015B83D
		[DebuggerNonUserCode]
		public string LegacyFanoutReplacement
		{
			get
			{
				return this.legacyFanoutReplacement_ ?? BGSMethodOptions.LegacyFanoutReplacementDefaultValue;
			}
			set
			{
				this.legacyFanoutReplacement_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06005A52 RID: 23122 RVA: 0x0015D654 File Offset: 0x0015B854
		[DebuggerNonUserCode]
		public bool HasLegacyFanoutReplacement
		{
			get
			{
				return this.legacyFanoutReplacement_ != null;
			}
		}

		// Token: 0x06005A53 RID: 23123 RVA: 0x0015D66F File Offset: 0x0015B86F
		[DebuggerNonUserCode]
		public void ClearLegacyFanoutReplacement()
		{
			this.legacyFanoutReplacement_ = null;
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06005A54 RID: 23124 RVA: 0x0015D67C File Offset: 0x0015B87C
		// (set) Token: 0x06005A55 RID: 23125 RVA: 0x0015D69D File Offset: 0x0015B89D
		[DebuggerNonUserCode]
		public string ForwardKey
		{
			get
			{
				return this.forwardKey_ ?? BGSMethodOptions.ForwardKeyDefaultValue;
			}
			set
			{
				this.forwardKey_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06005A56 RID: 23126 RVA: 0x0015D6B4 File Offset: 0x0015B8B4
		[DebuggerNonUserCode]
		public bool HasForwardKey
		{
			get
			{
				return this.forwardKey_ != null;
			}
		}

		// Token: 0x06005A57 RID: 23127 RVA: 0x0015D6CF File Offset: 0x0015B8CF
		[DebuggerNonUserCode]
		public void ClearForwardKey()
		{
			this.forwardKey_ = null;
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06005A58 RID: 23128 RVA: 0x0015D6DC File Offset: 0x0015B8DC
		// (set) Token: 0x06005A59 RID: 23129 RVA: 0x0015D70D File Offset: 0x0015B90D
		[DebuggerNonUserCode]
		public bool Idempotent
		{
			get
			{
				bool flag = (this._hasBits0 & 8) != 0;
				bool idempotentDefaultValue;
				if (flag)
				{
					idempotentDefaultValue = this.idempotent_;
				}
				else
				{
					idempotentDefaultValue = BGSMethodOptions.IdempotentDefaultValue;
				}
				return idempotentDefaultValue;
			}
			set
			{
				this._hasBits0 |= 8;
				this.idempotent_ = value;
			}
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06005A5A RID: 23130 RVA: 0x0015D728 File Offset: 0x0015B928
		[DebuggerNonUserCode]
		public bool HasIdempotent
		{
			get
			{
				return (this._hasBits0 & 8) != 0;
			}
		}

		// Token: 0x06005A5B RID: 23131 RVA: 0x0015D745 File Offset: 0x0015B945
		[DebuggerNonUserCode]
		public void ClearIdempotent()
		{
			this._hasBits0 &= -9;
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x0015D758 File Offset: 0x0015B958
		// (set) Token: 0x06005A5D RID: 23133 RVA: 0x0015D78A File Offset: 0x0015B98A
		[DebuggerNonUserCode]
		public bool HandleDestinationUnreachable
		{
			get
			{
				bool flag = (this._hasBits0 & 16) != 0;
				bool handleDestinationUnreachableDefaultValue;
				if (flag)
				{
					handleDestinationUnreachableDefaultValue = this.handleDestinationUnreachable_;
				}
				else
				{
					handleDestinationUnreachableDefaultValue = BGSMethodOptions.HandleDestinationUnreachableDefaultValue;
				}
				return handleDestinationUnreachableDefaultValue;
			}
			set
			{
				this._hasBits0 |= 16;
				this.handleDestinationUnreachable_ = value;
			}
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06005A5E RID: 23134 RVA: 0x0015D7A4 File Offset: 0x0015B9A4
		[DebuggerNonUserCode]
		public bool HasHandleDestinationUnreachable
		{
			get
			{
				return (this._hasBits0 & 16) != 0;
			}
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x0015D7C2 File Offset: 0x0015B9C2
		[DebuggerNonUserCode]
		public void ClearHandleDestinationUnreachable()
		{
			this._hasBits0 &= -17;
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x0015D7D4 File Offset: 0x0015B9D4
		// (set) Token: 0x06005A61 RID: 23137 RVA: 0x0015D7F5 File Offset: 0x0015B9F5
		[DebuggerNonUserCode]
		public string CustomRegionResolver
		{
			get
			{
				return this.customRegionResolver_ ?? BGSMethodOptions.CustomRegionResolverDefaultValue;
			}
			set
			{
				this.customRegionResolver_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x0015D80C File Offset: 0x0015BA0C
		[DebuggerNonUserCode]
		public bool HasCustomRegionResolver
		{
			get
			{
				return this.customRegionResolver_ != null;
			}
		}

		// Token: 0x06005A63 RID: 23139 RVA: 0x0015D827 File Offset: 0x0015BA27
		[DebuggerNonUserCode]
		public void ClearCustomRegionResolver()
		{
			this.customRegionResolver_ = null;
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06005A64 RID: 23140 RVA: 0x0015D834 File Offset: 0x0015BA34
		// (set) Token: 0x06005A65 RID: 23141 RVA: 0x0015D866 File Offset: 0x0015BA66
		[DebuggerNonUserCode]
		public bool ExplicitRegionRouting
		{
			get
			{
				bool flag = (this._hasBits0 & 32) != 0;
				bool explicitRegionRoutingDefaultValue;
				if (flag)
				{
					explicitRegionRoutingDefaultValue = this.explicitRegionRouting_;
				}
				else
				{
					explicitRegionRoutingDefaultValue = BGSMethodOptions.ExplicitRegionRoutingDefaultValue;
				}
				return explicitRegionRoutingDefaultValue;
			}
			set
			{
				this._hasBits0 |= 32;
				this.explicitRegionRouting_ = value;
			}
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06005A66 RID: 23142 RVA: 0x0015D880 File Offset: 0x0015BA80
		[DebuggerNonUserCode]
		public bool HasExplicitRegionRouting
		{
			get
			{
				return (this._hasBits0 & 32) != 0;
			}
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x0015D89E File Offset: 0x0015BA9E
		[DebuggerNonUserCode]
		public void ClearExplicitRegionRouting()
		{
			this._hasBits0 &= -33;
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x0015D8B0 File Offset: 0x0015BAB0
		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return this.Equals(other as BGSMethodOptions);
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x0015D8D0 File Offset: 0x0015BAD0
		[DebuggerNonUserCode]
		public bool Equals(BGSMethodOptions other)
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
					bool flag4 = this.Id != other.Id;
					if (flag4)
					{
						flag2 = false;
					}
					else
					{
						bool flag5 = this.ClientIdentityRouting != other.ClientIdentityRouting;
						if (flag5)
						{
							flag2 = false;
						}
						else
						{
							bool flag6 = this.EnableFanout != other.EnableFanout;
							if (flag6)
							{
								flag2 = false;
							}
							else
							{
								bool flag7 = this.LegacyFanoutReplacement != other.LegacyFanoutReplacement;
								if (flag7)
								{
									flag2 = false;
								}
								else
								{
									bool flag8 = this.ForwardKey != other.ForwardKey;
									if (flag8)
									{
										flag2 = false;
									}
									else
									{
										bool flag9 = this.Idempotent != other.Idempotent;
										if (flag9)
										{
											flag2 = false;
										}
										else
										{
											bool flag10 = this.HandleDestinationUnreachable != other.HandleDestinationUnreachable;
											if (flag10)
											{
												flag2 = false;
											}
											else
											{
												bool flag11 = this.CustomRegionResolver != other.CustomRegionResolver;
												if (flag11)
												{
													flag2 = false;
												}
												else
												{
													bool flag12 = this.ExplicitRegionRouting != other.ExplicitRegionRouting;
													flag2 = !flag12 && object.Equals(this._unknownFields, other._unknownFields);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
			return flag2;
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x0015DA14 File Offset: 0x0015BC14
		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			int num = 1;
			bool hasId = this.HasId;
			if (hasId)
			{
				num ^= this.Id.GetHashCode();
			}
			bool hasClientIdentityRouting = this.HasClientIdentityRouting;
			if (hasClientIdentityRouting)
			{
				num ^= this.ClientIdentityRouting.GetHashCode();
			}
			bool hasEnableFanout = this.HasEnableFanout;
			if (hasEnableFanout)
			{
				num ^= this.EnableFanout.GetHashCode();
			}
			bool hasLegacyFanoutReplacement = this.HasLegacyFanoutReplacement;
			if (hasLegacyFanoutReplacement)
			{
				num ^= this.LegacyFanoutReplacement.GetHashCode();
			}
			bool hasForwardKey = this.HasForwardKey;
			if (hasForwardKey)
			{
				num ^= this.ForwardKey.GetHashCode();
			}
			bool hasIdempotent = this.HasIdempotent;
			if (hasIdempotent)
			{
				num ^= this.Idempotent.GetHashCode();
			}
			bool hasHandleDestinationUnreachable = this.HasHandleDestinationUnreachable;
			if (hasHandleDestinationUnreachable)
			{
				num ^= this.HandleDestinationUnreachable.GetHashCode();
			}
			bool hasCustomRegionResolver = this.HasCustomRegionResolver;
			if (hasCustomRegionResolver)
			{
				num ^= this.CustomRegionResolver.GetHashCode();
			}
			bool hasExplicitRegionRouting = this.HasExplicitRegionRouting;
			if (hasExplicitRegionRouting)
			{
				num ^= this.ExplicitRegionRouting.GetHashCode();
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x0015DB50 File Offset: 0x0015BD50
		[DebuggerNonUserCode]
		public override string ToString()
		{
			return JsonFormatter.ToDiagnosticString(this);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x0015DB68 File Offset: 0x0015BD68
		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x0015DB74 File Offset: 0x0015BD74
		[DebuggerNonUserCode]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			bool hasId = this.HasId;
			if (hasId)
			{
				output.WriteRawTag(8);
				output.WriteUInt32(this.Id);
			}
			bool hasClientIdentityRouting = this.HasClientIdentityRouting;
			if (hasClientIdentityRouting)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ClientIdentityRouting);
			}
			bool hasEnableFanout = this.HasEnableFanout;
			if (hasEnableFanout)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.EnableFanout);
			}
			bool hasLegacyFanoutReplacement = this.HasLegacyFanoutReplacement;
			if (hasLegacyFanoutReplacement)
			{
				output.WriteRawTag(34);
				output.WriteString(this.LegacyFanoutReplacement);
			}
			bool hasForwardKey = this.HasForwardKey;
			if (hasForwardKey)
			{
				output.WriteRawTag(42);
				output.WriteString(this.ForwardKey);
			}
			bool hasIdempotent = this.HasIdempotent;
			if (hasIdempotent)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Idempotent);
			}
			bool hasHandleDestinationUnreachable = this.HasHandleDestinationUnreachable;
			if (hasHandleDestinationUnreachable)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.HandleDestinationUnreachable);
			}
			bool hasCustomRegionResolver = this.HasCustomRegionResolver;
			if (hasCustomRegionResolver)
			{
				output.WriteRawTag(66);
				output.WriteString(this.CustomRegionResolver);
			}
			bool hasExplicitRegionRouting = this.HasExplicitRegionRouting;
			if (hasExplicitRegionRouting)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.ExplicitRegionRouting);
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x0015DCDC File Offset: 0x0015BEDC
		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			int num = 0;
			bool hasId = this.HasId;
			if (hasId)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.Id);
			}
			bool hasClientIdentityRouting = this.HasClientIdentityRouting;
			if (hasClientIdentityRouting)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ClientIdentityRouting);
			}
			bool hasEnableFanout = this.HasEnableFanout;
			if (hasEnableFanout)
			{
				num += 2;
			}
			bool hasLegacyFanoutReplacement = this.HasLegacyFanoutReplacement;
			if (hasLegacyFanoutReplacement)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.LegacyFanoutReplacement);
			}
			bool hasForwardKey = this.HasForwardKey;
			if (hasForwardKey)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ForwardKey);
			}
			bool hasIdempotent = this.HasIdempotent;
			if (hasIdempotent)
			{
				num += 2;
			}
			bool hasHandleDestinationUnreachable = this.HasHandleDestinationUnreachable;
			if (hasHandleDestinationUnreachable)
			{
				num += 2;
			}
			bool hasCustomRegionResolver = this.HasCustomRegionResolver;
			if (hasCustomRegionResolver)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.CustomRegionResolver);
			}
			bool hasExplicitRegionRouting = this.HasExplicitRegionRouting;
			if (hasExplicitRegionRouting)
			{
				num += 2;
			}
			bool flag = this._unknownFields != null;
			if (flag)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x0015DDEC File Offset: 0x0015BFEC
		[DebuggerNonUserCode]
		public void MergeFrom(BGSMethodOptions other)
		{
			bool flag = other == null;
			if (!flag)
			{
				bool hasId = other.HasId;
				if (hasId)
				{
					this.Id = other.Id;
				}
				bool hasClientIdentityRouting = other.HasClientIdentityRouting;
				if (hasClientIdentityRouting)
				{
					this.ClientIdentityRouting = other.ClientIdentityRouting;
				}
				bool hasEnableFanout = other.HasEnableFanout;
				if (hasEnableFanout)
				{
					this.EnableFanout = other.EnableFanout;
				}
				bool hasLegacyFanoutReplacement = other.HasLegacyFanoutReplacement;
				if (hasLegacyFanoutReplacement)
				{
					this.LegacyFanoutReplacement = other.LegacyFanoutReplacement;
				}
				bool hasForwardKey = other.HasForwardKey;
				if (hasForwardKey)
				{
					this.ForwardKey = other.ForwardKey;
				}
				bool hasIdempotent = other.HasIdempotent;
				if (hasIdempotent)
				{
					this.Idempotent = other.Idempotent;
				}
				bool hasHandleDestinationUnreachable = other.HasHandleDestinationUnreachable;
				if (hasHandleDestinationUnreachable)
				{
					this.HandleDestinationUnreachable = other.HandleDestinationUnreachable;
				}
				bool hasCustomRegionResolver = other.HasCustomRegionResolver;
				if (hasCustomRegionResolver)
				{
					this.CustomRegionResolver = other.CustomRegionResolver;
				}
				bool hasExplicitRegionRouting = other.HasExplicitRegionRouting;
				if (hasExplicitRegionRouting)
				{
					this.ExplicitRegionRouting = other.ExplicitRegionRouting;
				}
				this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
			}
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x0015DF0C File Offset: 0x0015C10C
		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x0015DF18 File Offset: 0x0015C118
		[DebuggerNonUserCode]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) > 0U)
			{
				uint num2 = num;
				uint num3 = num2;
				if (num3 <= 34U)
				{
					if (num3 <= 16U)
					{
						if (num3 != 8U)
						{
							if (num3 != 16U)
							{
								goto IL_006A;
							}
							this.ClientIdentityRouting = (ClientIdentityRoutingType)input.ReadEnum();
						}
						else
						{
							this.Id = input.ReadUInt32();
						}
					}
					else if (num3 != 24U)
					{
						if (num3 != 34U)
						{
							goto IL_006A;
						}
						this.LegacyFanoutReplacement = input.ReadString();
					}
					else
					{
						this.EnableFanout = input.ReadBool();
					}
				}
				else if (num3 <= 48U)
				{
					if (num3 != 42U)
					{
						if (num3 != 48U)
						{
							goto IL_006A;
						}
						this.Idempotent = input.ReadBool();
					}
					else
					{
						this.ForwardKey = input.ReadString();
					}
				}
				else if (num3 != 56U)
				{
					if (num3 != 66U)
					{
						if (num3 != 72U)
						{
							goto IL_006A;
						}
						this.ExplicitRegionRouting = input.ReadBool();
					}
					else
					{
						this.CustomRegionResolver = input.ReadString();
					}
				}
				else
				{
					this.HandleDestinationUnreachable = input.ReadBool();
				}
				continue;
				IL_006A:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002916 RID: 10518
		private static readonly MessageParser<BGSMethodOptions> _parser = new MessageParser<BGSMethodOptions>(() => new BGSMethodOptions());

		// Token: 0x04002917 RID: 10519
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002918 RID: 10520
		private int _hasBits0;

		// Token: 0x04002919 RID: 10521
		public const int IdFieldNumber = 1;

		// Token: 0x0400291A RID: 10522
		private static readonly uint IdDefaultValue = 0U;

		// Token: 0x0400291B RID: 10523
		private uint id_;

		// Token: 0x0400291C RID: 10524
		public const int ClientIdentityRoutingFieldNumber = 2;

		// Token: 0x0400291D RID: 10525
		private static readonly ClientIdentityRoutingType ClientIdentityRoutingDefaultValue = ClientIdentityRoutingType.ClientIdentityRoutingDisabled;

		// Token: 0x0400291E RID: 10526
		private ClientIdentityRoutingType clientIdentityRouting_;

		// Token: 0x0400291F RID: 10527
		public const int EnableFanoutFieldNumber = 3;

		// Token: 0x04002920 RID: 10528
		private static readonly bool EnableFanoutDefaultValue = false;

		// Token: 0x04002921 RID: 10529
		private bool enableFanout_;

		// Token: 0x04002922 RID: 10530
		public const int LegacyFanoutReplacementFieldNumber = 4;

		// Token: 0x04002923 RID: 10531
		private static readonly string LegacyFanoutReplacementDefaultValue = "";

		// Token: 0x04002924 RID: 10532
		private string legacyFanoutReplacement_;

		// Token: 0x04002925 RID: 10533
		public const int ForwardKeyFieldNumber = 5;

		// Token: 0x04002926 RID: 10534
		private static readonly string ForwardKeyDefaultValue = "";

		// Token: 0x04002927 RID: 10535
		private string forwardKey_;

		// Token: 0x04002928 RID: 10536
		public const int IdempotentFieldNumber = 6;

		// Token: 0x04002929 RID: 10537
		private static readonly bool IdempotentDefaultValue = false;

		// Token: 0x0400292A RID: 10538
		private bool idempotent_;

		// Token: 0x0400292B RID: 10539
		public const int HandleDestinationUnreachableFieldNumber = 7;

		// Token: 0x0400292C RID: 10540
		private static readonly bool HandleDestinationUnreachableDefaultValue = false;

		// Token: 0x0400292D RID: 10541
		private bool handleDestinationUnreachable_;

		// Token: 0x0400292E RID: 10542
		public const int CustomRegionResolverFieldNumber = 8;

		// Token: 0x0400292F RID: 10543
		private static readonly string CustomRegionResolverDefaultValue = "";

		// Token: 0x04002930 RID: 10544
		private string customRegionResolver_;

		// Token: 0x04002931 RID: 10545
		public const int ExplicitRegionRoutingFieldNumber = 9;

		// Token: 0x04002932 RID: 10546
		private static readonly bool ExplicitRegionRoutingDefaultValue = false;

		// Token: 0x04002933 RID: 10547
		private bool explicitRegionRouting_;
	}
}
