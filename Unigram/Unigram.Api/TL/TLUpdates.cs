// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLUpdates : TLUpdatesBase 
	{
		public TLVector<TLUpdateBase> Updates { get; set; }
		public TLVector<TLUserBase> Users { get; set; }
		public TLVector<TLChatBase> Chats { get; set; }
		public Int32 Date { get; set; }
		public Int32 Seq { get; set; }

		public TLUpdates() { }
		public TLUpdates(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Updates; } }

		public override void Read(TLBinaryReader from)
		{
			Updates = TLFactory.Read<TLVector<TLUpdateBase>>(from);
			Users = TLFactory.Read<TLVector<TLUserBase>>(from);
			Chats = TLFactory.Read<TLVector<TLChatBase>>(from);
			Date = from.ReadInt32();
			Seq = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Updates);
			to.WriteObject(Users);
			to.WriteObject(Chats);
			to.WriteInt32(Date);
			to.WriteInt32(Seq);
		}
	}
}