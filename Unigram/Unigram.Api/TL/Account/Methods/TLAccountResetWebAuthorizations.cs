// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL.Account.Methods
{
	/// <summary>
	/// RCP method account.resetWebAuthorizations.
	/// Returns <see cref="Telegram.Api.TL.TLBool"/>
	/// </summary>
	public partial class TLAccountResetWebAuthorizations : TLObject
	{
		public TLAccountResetWebAuthorizations() { }
		public TLAccountResetWebAuthorizations(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.AccountResetWebAuthorizations; } }

		public override void Read(TLBinaryReader from)
		{
		}

		public override void Write(TLBinaryWriter to)
		{
		}
	}
}