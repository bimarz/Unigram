// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputPaymentCredentialsSaved : TLInputPaymentCredentialsBase 
	{
		public String Id { get; set; }
		public Byte[] TmpPassword { get; set; }

		public TLInputPaymentCredentialsSaved() { }
		public TLInputPaymentCredentialsSaved(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputPaymentCredentialsSaved; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			TmpPassword = from.ReadByteArray();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Id ?? string.Empty);
			to.WriteByteArray(TmpPassword);
		}
	}
}