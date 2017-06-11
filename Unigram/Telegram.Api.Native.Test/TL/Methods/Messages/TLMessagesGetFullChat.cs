// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Methods.Messages
{
	/// <summary>
	/// RCP method messages.getFullChat.
	/// Returns <see cref="Telegram.Api.TL.TLMessagesChatFull"/>
	/// </summary>
	public partial class TLMessagesGetFullChat : TLObject
	{
		public Int32 ChatId { get; set; }

		public TLMessagesGetFullChat() { }
		public TLMessagesGetFullChat(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.MessagesGetFullChat; } }

		public override void Read(TLBinaryReader from)
		{
			ChatId = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteInt32(ChatId);
		}
	}
}