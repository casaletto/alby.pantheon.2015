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
	public partial class LogEntryGet٠rs1 : acr.RowBase
	{
		public const string column٠LogEntryGuid  = "LogEntryGuid" ;
		public const string column٠LeaseID  = "LeaseID" ;
		public const string column٠Severity  = "Severity" ;
		public const string column٠Text  = "Text" ;
		public const string column٠Source  = "Source" ;
		public const string column٠LogDate  = "LogDate" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public Guid? LogEntryGuid
		{
			get
			{
				return base.GetValueˡ<Guid?>( _dicˡ, column٠LogEntryGuid ) ; 
			}
			set
			{
				base.SetValueˡ<Guid?>( _dicˡ, column٠LogEntryGuid, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? LeaseID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Severity
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Severity ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Severity, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Text
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Text ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Text, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Source
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Source ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Source, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? LogDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠LogDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠LogDate, value, ref _dirtyˡ ) ; 
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
		 
		public LogEntryGet٠rs1() : base()
		{
			base._dicˡ[ column٠LogEntryGuid ] = null ;
			base._dicˡ[ column٠LeaseID ] = null ;
			base._dicˡ[ column٠Severity ] = null ;
			base._dicˡ[ column٠Text ] = null ;
			base._dicˡ[ column٠Source ] = null ;
			base._dicˡ[ column٠LogDate ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

