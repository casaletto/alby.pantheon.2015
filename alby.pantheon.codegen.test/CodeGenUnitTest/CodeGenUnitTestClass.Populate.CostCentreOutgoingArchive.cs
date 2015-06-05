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

using nu = NUnit.Framework;
using t = alby.pantheon.codegen.table ;

namespace alby.pantheon.codegen.test
{
	public partial class CodeGenUnitTestClass : acr.CodeGenUnitTestBase
	{
		protected void Populate٠CostCentreOutgoingArchive( bool insert, t.CostCentreOutgoingArchive obj )
		{
			if ( insert )
			{
				obj.CostCentreOutgoingID = toint( factory٠CostCentreOutgoingArchiveFactory.GetNextIdˡ( _connection, t.CostCentreOutgoingArchive.column٠CostCentreOutgoingID, true ).ToString() ) ;
				obj.CostCentreStageID = obj1٠CostCentreStage != null ? obj1٠CostCentreStage.CostCentreStageID : obj0٠CostCentreStage.CostCentreStageID ;
				obj.ArchiveDate = new DateTime(1900,1,1) ;
				obj.OperatingGLA = -1.0m ;
				obj.OperatingAmount = -1.0m ;
				obj.StatutoryGLA = -1.0m ;
				obj.StatutoryAmount = -1.0m ;
				obj.ACGeneralEnergyGLA = -1.0m ;
				obj.ACGeneralEnergyAmount = -1.0m ;
				obj.ACMaintenanceRepairGLA = -1.0m ;
				obj.ACMaintenanceRepairAmount = -1.0m ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
			}
			else // update
			{
				obj.ArchiveDate = new DateTime(1901,12,31) ;
				obj.OperatingGLA = -2.0m ;
				obj.OperatingAmount = -2.0m ;
				obj.StatutoryGLA = -2.0m ;
				obj.StatutoryAmount = -2.0m ;
				obj.ACGeneralEnergyGLA = -2.0m ;
				obj.ACGeneralEnergyAmount = -2.0m ;
				obj.ACMaintenanceRepairGLA = -2.0m ;
				obj.ACMaintenanceRepairAmount = -2.0m ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
			}
			 
		}
	}

}

