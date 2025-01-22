using System;
using System.Collections.Generic;
using System.Linq;
using PacketDotNet.Utils;
using PacketDotNet.Utils.Converters;

namespace PacketDotNet
{
	// Token: 0x02000826 RID: 2086
	public class TlsPacket : Packet
	{
		// Token: 0x0600B557 RID: 46423 RVA: 0x002C399D File Offset: 0x002C1B9D
		public TlsPacket(ByteArraySegment byteArraySegment)
		{
			this.Header = new ByteArraySegment(byteArraySegment);
			this.Header.Length = 0;
			this.PayloadPacketOrData = new LazySlim<PacketOrByteArraySegment>(() => new PacketOrByteArraySegment
			{
				ByteArraySegment = this.Header.NextSegment()
			});
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600B558 RID: 46424 RVA: 0x002C39D7 File Offset: 0x002C1BD7
		// (set) Token: 0x0600B559 RID: 46425 RVA: 0x002C39FF File Offset: 0x002C1BFF
		public ushort DataOffset
		{
			get
			{
				return EndianBitConverter.Big.ToUInt16(this.Header.Bytes, this.Header.Offset + TlsFields.DataOffsetPosition);
			}
			set
			{
				EndianBitConverter.Big.CopyBytes(value, this.Header.Bytes, this.Header.Offset + TlsFields.DataOffsetPosition);
			}
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B55A RID: 46426 RVA: 0x002C3A2C File Offset: 0x002C1C2C
		public List<TlsRecordLayer> RecordLayers
		{
			get
			{
				List<TlsRecordLayer> list = new List<TlsRecordLayer>();
				byte[] array = this.PayloadPacketOrData.Value.ByteArraySegment.ActualBytes();
				while (array.Length != 0)
				{
					ContentType contentType = (ContentType)array[0];
					bool flag = contentType == ContentType.Handshake;
					TlsRecordLayer tlsRecordLayer;
					if (flag)
					{
						tlsRecordLayer = new TlsHandshakeRecord(array);
					}
					else
					{
						tlsRecordLayer = new TlsRecordLayer(array);
					}
					list.Add(tlsRecordLayer);
					array = array.Skip((int)tlsRecordLayer.TotalLength).ToArray<byte>();
				}
				return list;
			}
		}
	}
}
