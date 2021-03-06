// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Messages
{
	public partial class TLMessagesFavedStickers : TLMessagesFavedStickersBase 
	{
		public Int32 Hash { get; set; }
		public TLVector<TLStickerPack> Packs { get; set; }
		public TLVector<TLDocumentBase> Stickers { get; set; }

		public TLMessagesFavedStickers() { }
		public TLMessagesFavedStickers(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesFavedStickers; } }

		public override void Read(TLBinaryReader from)
		{
			Hash = from.ReadInt32();
			Packs = TLFactory.Read<TLVector<TLStickerPack>>(from);
			Stickers = TLFactory.Read<TLVector<TLDocumentBase>>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(Hash);
			to.WriteObject(Packs);
			to.WriteObject(Stickers);
		}
	}
}