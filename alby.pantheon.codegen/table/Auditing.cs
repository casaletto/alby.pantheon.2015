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
	public partial class Auditing : acr.RowBase
	{
		public const string column٠AuditingGUID  = "AuditingGUID" ;
		public const string column٠ObjectName  = "ObjectName" ;
		public const string column٠UserName  = "UserName" ;
		 
		public Guid? AuditingGUID
		{
			get
			{
				return base.GetValueˡ<Guid?>( _dicˡ, column٠AuditingGUID ) ; 
			}
			set
			{
				base.SetValueˡ<Guid?>( _dicˡ, column٠AuditingGUID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string ObjectName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠ObjectName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠ObjectName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string UserName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠UserName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠UserName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public Auditing() : base()
		{
			base._dicˡ[ column٠AuditingGUID ] = null ;
			base._dicˡ[ column٠ObjectName ] = null ;
			base._dicˡ[ column٠UserName ] = null ;
		 
		 
		}

	}

}

