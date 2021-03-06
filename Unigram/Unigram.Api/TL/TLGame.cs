// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLGame : TLObject 
	{
		[Flags]
		public enum Flag : Int32
		{
			Document = (1 << 0),
		}

		public bool HasDocument { get { return Flags.HasFlag(Flag.Document); } set { Flags = value ? (Flags | Flag.Document) : (Flags & ~Flag.Document); } }

		public Flag Flags { get; set; }
		public Int64 Id { get; set; }
		public Int64 AccessHash { get; set; }
		public String ShortName { get; set; }
		public String Title { get; set; }
		public String Description { get; set; }
		public TLPhotoBase Photo { get; set; }
		public TLDocumentBase Document { get; set; }

		public TLGame() { }
		public TLGame(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.Game; } }

		public override void Read(TLBinaryReader from)
		{
			Flags = (Flag)from.ReadInt32();
			Id = from.ReadInt64();
			AccessHash = from.ReadInt64();
			ShortName = from.ReadString();
			Title = from.ReadString();
			Description = from.ReadString();
			Photo = TLFactory.Read<TLPhotoBase>(from);
			if (HasDocument) Document = TLFactory.Read<TLDocumentBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			UpdateFlags();

			to.WriteInt32((Int32)Flags);
			to.WriteInt64(Id);
			to.WriteInt64(AccessHash);
			to.WriteString(ShortName ?? string.Empty);
			to.WriteString(Title ?? string.Empty);
			to.WriteString(Description ?? string.Empty);
			to.WriteObject(Photo);
			if (HasDocument) to.WriteObject(Document);
		}

		private void UpdateFlags()
		{
			HasDocument = Document != null;
		}
	}
}