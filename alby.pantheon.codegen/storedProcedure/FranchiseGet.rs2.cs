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
	public partial class FranchiseGet٠rs2 : acr.RowBase
	{
		public const string column٠CommunicationID  = "CommunicationID" ;
		public const string column٠PartyID  = "PartyID" ;
		public const string column٠CommunicationTypeDescription  = "CommunicationTypeDescription" ;
		public const string column٠CommunicationDetail  = "CommunicationDetail" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? CommunicationID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠CommunicationID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠CommunicationID, value, ref _dirtyˡ ) ; 
			}
		}
		 
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
		 
		public string CommunicationTypeDescription
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CommunicationTypeDescription ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CommunicationTypeDescription, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string CommunicationDetail
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠CommunicationDetail ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠CommunicationDetail, value, ref _dirtyˡ ) ; 
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
		 
		public FranchiseGet٠rs2() : base()
		{
			base._dicˡ[ column٠CommunicationID ] = null ;
			base._dicˡ[ column٠PartyID ] = null ;
			base._dicˡ[ column٠CommunicationTypeDescription ] = null ;
			base._dicˡ[ column٠CommunicationDetail ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

