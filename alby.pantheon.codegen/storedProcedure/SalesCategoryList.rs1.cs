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
	public partial class SalesCategoryList٠rs1 : acr.RowBase
	{
		public const string column٠SalesCategoryID  = "SalesCategoryID" ;
		public const string column٠SalesCategoryCode  = "SalesCategoryCode" ;
		public const string column٠SalesCategoryDescription  = "SalesCategoryDescription" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		public const string column٠DeletionIndicator  = "DeletionIndicator" ;
		 
		public int? SalesCategoryID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠SalesCategoryID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠SalesCategoryID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string SalesCategoryCode
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠SalesCategoryCode ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠SalesCategoryCode, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string SalesCategoryDescription
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠SalesCategoryDescription ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠SalesCategoryDescription, value, ref _dirtyˡ ) ; 
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
		 
		public string DeletionIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠DeletionIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠DeletionIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public SalesCategoryList٠rs1() : base()
		{
			base._dicˡ[ column٠SalesCategoryID ] = null ;
			base._dicˡ[ column٠SalesCategoryCode ] = null ;
			base._dicˡ[ column٠SalesCategoryDescription ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
			base._dicˡ[ column٠DeletionIndicator ] = null ;
		 
		}

	}

}
