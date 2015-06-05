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
	public partial class CostCentreOutgoingArchiveList٠rs1 : acr.RowBase
	{
		public const string column٠CostCentreOutgoingID  = "CostCentreOutgoingID" ;
		public const string column٠CostCentreStageID  = "CostCentreStageID" ;
		public const string column٠ArchiveDate  = "ArchiveDate" ;
		public const string column٠OperatingGLA  = "OperatingGLA" ;
		public const string column٠OperatingAmount  = "OperatingAmount" ;
		public const string column٠StatutoryGLA  = "StatutoryGLA" ;
		public const string column٠StatutoryAmount  = "StatutoryAmount" ;
		public const string column٠ACGeneralEnergyGLA  = "ACGeneralEnergyGLA" ;
		public const string column٠ACGeneralEnergyAmount  = "ACGeneralEnergyAmount" ;
		public const string column٠ACMaintenanceRepairGLA  = "ACMaintenanceRepairGLA" ;
		public const string column٠ACMaintenanceRepairAmount  = "ACMaintenanceRepairAmount" ;
		public const string column٠UpdateUserCode  = "UpdateUserCode" ;
		public const string column٠UpdateDateTime  = "UpdateDateTime" ;
		public const string column٠RowTimestamp  = "RowTimestamp" ;
		 
		public int? CostCentreOutgoingID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠CostCentreOutgoingID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠CostCentreOutgoingID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public int? CostCentreStageID
		{
			get
			{
				return base.GetValueˡ<int?>( _dicˡ, column٠CostCentreStageID ) ; 
			}
			set
			{
				base.SetValueˡ<int?>( _dicˡ, column٠CostCentreStageID, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public DateTime? ArchiveDate
		{
			get
			{
				return base.GetValueˡ<DateTime?>( _dicˡ, column٠ArchiveDate ) ; 
			}
			set
			{
				base.SetValueˡ<DateTime?>( _dicˡ, column٠ArchiveDate, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? OperatingGLA
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠OperatingGLA ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠OperatingGLA, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? OperatingAmount
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠OperatingAmount ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠OperatingAmount, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? StatutoryGLA
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠StatutoryGLA ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠StatutoryGLA, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? StatutoryAmount
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠StatutoryAmount ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠StatutoryAmount, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? ACGeneralEnergyGLA
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠ACGeneralEnergyGLA ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠ACGeneralEnergyGLA, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? ACGeneralEnergyAmount
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠ACGeneralEnergyAmount ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠ACGeneralEnergyAmount, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? ACMaintenanceRepairGLA
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠ACMaintenanceRepairGLA ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠ACMaintenanceRepairGLA, value, ref _dirtyˡ ) ; 
			}
		}
		 
		public decimal? ACMaintenanceRepairAmount
		{
			get
			{
				return base.GetValueˡ<decimal?>( _dicˡ, column٠ACMaintenanceRepairAmount ) ; 
			}
			set
			{
				base.SetValueˡ<decimal?>( _dicˡ, column٠ACMaintenanceRepairAmount, value, ref _dirtyˡ ) ; 
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
		 
		public CostCentreOutgoingArchiveList٠rs1() : base()
		{
			base._dicˡ[ column٠CostCentreOutgoingID ] = null ;
			base._dicˡ[ column٠CostCentreStageID ] = null ;
			base._dicˡ[ column٠ArchiveDate ] = null ;
			base._dicˡ[ column٠OperatingGLA ] = null ;
			base._dicˡ[ column٠OperatingAmount ] = null ;
			base._dicˡ[ column٠StatutoryGLA ] = null ;
			base._dicˡ[ column٠StatutoryAmount ] = null ;
			base._dicˡ[ column٠ACGeneralEnergyGLA ] = null ;
			base._dicˡ[ column٠ACGeneralEnergyAmount ] = null ;
			base._dicˡ[ column٠ACMaintenanceRepairGLA ] = null ;
			base._dicˡ[ column٠ACMaintenanceRepairAmount ] = null ;
			base._dicˡ[ column٠UpdateUserCode ] = null ;
			base._dicˡ[ column٠UpdateDateTime ] = null ;
			base._dicˡ[ column٠RowTimestamp ] = null ;
		 
		}

	}

}

