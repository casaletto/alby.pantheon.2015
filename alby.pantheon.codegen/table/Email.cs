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
	public partial class Email : acr.RowBase
	{
		public const string column٠EmailID  = "EmailID" ;
		public const string column٠FromAddress  = "FromAddress" ;
		public const string column٠ToAddress  = "ToAddress" ;
		public const string column٠Subject  = "Subject" ;
		public const string column٠Body  = "Body" ;
		public const string column٠Attachments  = "Attachments" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? EmailID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠EmailID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠EmailID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string FromAddress
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠FromAddress ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠FromAddress, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string ToAddress
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠ToAddress ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠ToAddress, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Subject
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Subject ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Subject, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Body
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Body ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Body, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string Attachments
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠Attachments ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠Attachments, value, ref _dirtyˡ ) ; 
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
		 
		public Email() : base()
		{
			base._dicˡ[ column٠EmailID ] = null ;
			base._dicˡ[ column٠FromAddress ] = null ;
			base._dicˡ[ column٠ToAddress ] = null ;
			base._dicˡ[ column٠Subject ] = null ;
			base._dicˡ[ column٠Body ] = null ;
			base._dicˡ[ column٠Attachments ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
			base._dicPKˡ[ column٠EmailID ] = null ;
		 
		}

	}

}

