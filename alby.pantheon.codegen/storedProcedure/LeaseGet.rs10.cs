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
	public partial class LeaseGet٠rs10 : acr.RowBase
	{
		public const string column٠LeaseTypeID  = "LeaseTypeID" ;
		public const string column٠LeaseTypeDescription  = "LeaseTypeDescription" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? LeaseTypeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseTypeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseTypeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string LeaseTypeDescription
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠LeaseTypeDescription ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠LeaseTypeDescription, value, ref _dirtyˡ ) ; 
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
		 
		public LeaseGet٠rs10() : base()
		{
			base._dicˡ[ column٠LeaseTypeID ] = null ;
			base._dicˡ[ column٠LeaseTypeDescription ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

