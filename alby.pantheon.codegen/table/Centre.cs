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
	public partial class Centre : acr.RowBase
	{
		public const string column٠PartyID  = "PartyID" ;
		public const string column٠CentreCode  = "CentreCode" ;
		public const string column٠CentreName  = "CentreName" ;
		public const string column٠CentreManagerName  = "CentreManagerName" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		public const string column٠SolicitorWebServiceGUID  = "SolicitorWebServiceGUID" ;
		 
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
		 
		public string CentreCode
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CentreCode ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CentreCode, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string CentreName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CentreName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CentreName, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string CentreManagerName
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CentreManagerName ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CentreManagerName, value, ref _dirtyˡ ) ; 
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
		 
		public Guid? SolicitorWebServiceGUID
		{
			get
			{
				return base.GetValueˡ<Guid?>( _dicˡ, column٠SolicitorWebServiceGUID ) ; 
			}
			set
			{
				base.SetValueˡ<Guid?>( _dicˡ, column٠SolicitorWebServiceGUID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public Centre() : base()
		{
			base._dicˡ[ column٠PartyID ] = null ;
			base._dicˡ[ column٠CentreCode ] = null ;
			base._dicˡ[ column٠CentreName ] = null ;
			base._dicˡ[ column٠CentreManagerName ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
			base._dicˡ[ column٠SolicitorWebServiceGUID ] = null ;
		 
			base._dicPKˡ[ column٠PartyID ] = null ;
		 
		}

	}

}

