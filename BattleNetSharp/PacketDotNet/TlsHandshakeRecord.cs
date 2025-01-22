using System;
using System.Collections.Generic;
using System.Linq;

namespace PacketDotNet
{
	// Token: 0x02000828 RID: 2088
	public class TlsHandshakeRecord : TlsRecordLayer
	{
		// Token: 0x0600B565 RID: 46437 RVA: 0x002C3B7A File Offset: 0x002C1D7A
		public TlsHandshakeRecord(byte[] bytes)
			: base(bytes)
		{
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600B566 RID: 46438 RVA: 0x002C3B88 File Offset: 0x002C1D88
		public List<HandshakeProtocol> HandshakeProtocols
		{
			get
			{
				List<HandshakeProtocol> list = new List<HandshakeProtocol>();
				byte[] array = base.Data;
				while (array.Length != 0)
				{
					HandshakeType handshakeType = (HandshakeType)array[0];
					bool flag = handshakeType == HandshakeType.ClientHello;
					HandshakeProtocol handshakeProtocol;
					if (flag)
					{
						handshakeProtocol = new ClientHelloProtocol(array);
					}
					else
					{
						bool flag2 = handshakeType == HandshakeType.ServerHello;
						if (flag2)
						{
							handshakeProtocol = new ServerHelloProtocol(array);
						}
						else
						{
							handshakeProtocol = new HandshakeProtocol(array);
						}
					}
					list.Add(handshakeProtocol);
					array = array.Skip((int)handshakeProtocol.TotalLength).ToArray<byte>();
				}
				return list;
			}
		}
	}
}
