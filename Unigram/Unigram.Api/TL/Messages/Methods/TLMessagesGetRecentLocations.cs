// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages.Methods
{
	/// <summary>
	/// RCP method messages.getRecentLocations.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesMessages"/>
	/// </summary>
	public partial class TLMessagesGetRecentLocations : TLObject
	{
		public TLInputPeerBase Peer { get; set; }
		public Int32 Limit { get; set; }

		public TLMessagesGetRecentLocations() { }
		public TLMessagesGetRecentLocations(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetRecentLocations; } }

		public override void Read(TLBinaryReader from)
		{
			Peer = TLFactory.Read<TLInputPeerBase>(from);
			Limit = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Peer);
			to.WriteInt32(Limit);
		}
	}
}