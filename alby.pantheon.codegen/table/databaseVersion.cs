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

namespace alby.pantheon.codegen.table
{
	public partial class databaseVersion : acr.RowBase
	{
		public const string column٠version  = "version" ;
		public const string column٠application_version  = "application_version" ;
		public const string column٠runDate  = "runDate" ;
		public const string column٠description  = "description" ;
		public const string column٠branch  = "branch" ;
		 
		public int? version
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠version ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠version, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? application_version
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠application_version ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠application_version, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? runDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠runDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠runDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string description
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠description ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠description, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string branch
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠branch ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠branch, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public databaseVersion() : base()
		{
			base._dicˡ[ column٠version ] = null ;
			base._dicˡ[ column٠application_version ] = null ;
			base._dicˡ[ column٠runDate ] = null ;
			base._dicˡ[ column٠description ] = null ;
			base._dicˡ[ column٠branch ] = null ;
		 
		 
		}

	}

}
