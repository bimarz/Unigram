// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLDraftMessageEmpty : TLDraftMessageBase 
	{
		public TLDraftMessageEmpty() { }
		public TLDraftMessageEmpty(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.DraftMessageEmpty; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
		}
	}
}