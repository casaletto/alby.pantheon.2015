﻿
// This file was automatically generated by the code gen tool - do not modify.

using System ;
using scg = System.Collections.Generic ;
using sd = System.Data ;
using sds = System.Data.SqlClient ;
using sr = System.Reflection ;
using mst = Microsoft.SqlServer.Types ;
using mss = Microsoft.SqlServer.Server ;
using acr = alby.codegen.runtime ;
using ns = alby.pantheon.codegen;

namespace alby.pantheon.codegen.storedProcedure
{
	public partial class PartyGet٠rs3 : acr.RowBase
	{
		public const string column٠PartyID  = "PartyID" ;
		public const string column٠Salutation  = "Salutation" ;
		public const string column٠GivenName  = "GivenName" ;
		public const string column٠FamilyName  = "FamilyName" ;
		public const string column٠Name  = "Name" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? PartyID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠PartyID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠PartyID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Salutation
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Salutation ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Salutation, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string GivenName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠GivenName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠GivenName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string FamilyName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠FamilyName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠FamilyName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Name
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Name ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Name, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string UpdateUserCode
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠UpdateUserCode ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠UpdateUserCode, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? UpdateDateTime
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠UpdateDateTime ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠UpdateDateTime, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public byte[] RowTimestamp
		{
			get
			{
				return base.GetValueˡ<byte[]>( _dicˡ, column٠RowTimestamp ) ; 
			}
			set
			{
				base.SetValueˡ<byte[]>( _dicˡ, column٠RowTimestamp, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public PartyGet٠rs3() : base()
		{
			base._dicˡ[ column٠PartyID ] = null ;
			base._dicˡ[ column٠Salutation ] = null ;
			base._dicˡ[ column٠GivenName ] = null ;
			base._dicˡ[ column٠FamilyName ] = null ;
			base._dicˡ[ column٠Name ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

