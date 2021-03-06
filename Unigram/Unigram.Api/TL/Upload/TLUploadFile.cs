// <auto-generated/>
using System;
using Telegram.Api.Native.TL;
using Telegram.Api.TL.Storage;

namespace Telegram.Api.TL.Upload
{
	public partial class TLUploadFile : TLUploadFileBase 
	{
		public TLStorageFileTypeBase Type { get; set; }
		public Int32 Mtime { get; set; }
		public Byte[] Bytes { get; set; }

		public TLUploadFile() { }
		public TLUploadFile(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.UploadFile; } }

		public override void Read(TLBinaryReader from)
		{
			Type = TLFactory.Read<TLStorageFileTypeBase>(from);
			Mtime = from.ReadInt32();
			Bytes = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteObject(Type);
			to.WriteInt32(Mtime);
			to.WriteByteArray(Bytes);
		}
	}
}