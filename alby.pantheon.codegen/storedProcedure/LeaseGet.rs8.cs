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
	public partial class LeaseGet٠rs8 : acr.RowBase
	{
		public const string column٠LeaseAdministrationID  = "LeaseAdministrationID" ;
		public const string column٠StaffID  = "StaffID" ;
		public const string column٠DeedOfConsentRequiredIndicator  = "DeedOfConsentRequiredIndicator" ;
		public const string column٠FranchiseID  = "FranchiseID" ;
		public const string column٠PaymentTypeID  = "PaymentTypeID" ;
		public const string column٠SendDocumentsTo  = "SendDocumentsTo" ;
		public const string column٠TenantRenewingIndicator  = "TenantRenewingIndicator" ;
		public const string column٠TenantRelocatingIndicator  = "TenantRelocatingIndicator" ;
		public const string column٠RelocationClauseRequiredIndicator  = "RelocationClauseRequiredIndicator" ;
		public const string column٠BankOrFinInstitIndicator  = "BankOrFinInstitIndicator" ;
		public const string column٠BankOrFinInstitSpecialConvenantsRequiredIndicator  = "BankOrFinInstitSpecialConvenantsRequiredIndicator" ;
		public const string column٠SpecialPrecinctConvenants  = "SpecialPrecinctConvenants" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? LeaseAdministrationID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠LeaseAdministrationID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠LeaseAdministrationID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? StaffID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠StaffID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠StaffID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string DeedOfConsentRequiredIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠DeedOfConsentRequiredIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠DeedOfConsentRequiredIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? FranchiseID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠FranchiseID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠FranchiseID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? PaymentTypeID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠PaymentTypeID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠PaymentTypeID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string SendDocumentsTo
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠SendDocumentsTo ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠SendDocumentsTo, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string TenantRenewingIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠TenantRenewingIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠TenantRenewingIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string TenantRelocatingIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠TenantRelocatingIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠TenantRelocatingIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string RelocationClauseRequiredIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠RelocationClauseRequiredIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠RelocationClauseRequiredIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string BankOrFinInstitIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠BankOrFinInstitIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠BankOrFinInstitIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string BankOrFinInstitSpecialConvenantsRequiredIndicator
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠BankOrFinInstitSpecialConvenantsRequiredIndicator ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠BankOrFinInstitSpecialConvenantsRequiredIndicator, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public string SpecialPrecinctConvenants
		{
			get
			{
				return base.GetValueˡ<string>( _dicˡ, column٠SpecialPrecinctConvenants ) ; 
			}
			set
			{
				base.SetValueˡ<string>( _dicˡ, column٠SpecialPrecinctConvenants, value, ref _dirtyˡ ) ; 
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
		 
		public LeaseGet٠rs8() : base()
		{
			base._dicˡ[ column٠LeaseAdministrationID ] = null ;
			base._dicˡ[ column٠StaffID ] = null ;
			base._dicˡ[ column٠DeedOfConsentRequiredIndicator ] = null ;
			base._dicˡ[ column٠FranchiseID ] = null ;
			base._dicˡ[ column٠PaymentTypeID ] = null ;
			base._dicˡ[ column٠SendDocumentsTo ] = null ;
			base._dicˡ[ column٠TenantRenewingIndicator ] = null ;
			base._dicˡ[ column٠TenantRelocatingIndicator ] = null ;
			base._dicˡ[ column٠RelocationClauseRequiredIndicator ] = null ;
			base._dicˡ[ column٠BankOrFinInstitIndicator ] = null ;
			base._dicˡ[ column٠BankOrFinInstitSpecialConvenantsRequiredIndicator ] = null ;
			base._dicˡ[ column٠SpecialPrecinctConvenants ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

