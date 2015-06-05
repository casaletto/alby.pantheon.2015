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
		protected void Populate٠FitoutDetail( bool insert, t.FitoutDetail obj )
		{
			if ( insert )
			{
				obj.FitoutDetailID = toint( factory٠FitoutDetailFactory.GetNextIdˡ( _connection, t.FitoutDetail.column٠FitoutDetailID, true ).ToString() ) ;
				obj.FitoutContribution = -1.0m ;
				obj.FitoutPeriod = -100 ;
				obj.IncentiveBudget = -1.0m ;
				obj.HandoverDate = "@" ;
				obj.ArchitectFeesPayableIndicator = "@" ;
				obj.ArchitectFees = -1.0m ;
				obj.EngineerFeesPayableIndicator = "@" ;
				obj.EngineerFees = -1.0m ;
				obj.SmallShopDesignerFeesPayableIndicator = "@" ;
				obj.SmallShopDesignerFees = -1.0m ;
				obj.SurveyFeePayableIndicator = "@" ;
				obj.SurveyFees = -1.0m ;
				obj.TenantCoordinationFeesPayable = "@" ;
				obj.TenantCoordinationFees = -1.0m ;
				obj.AgreementToLeaseIndicator = "@" ;
				obj.DevelopmentApprovalsRequiredIndicator = "@" ;
				obj.DevelopmentApprovalsDueDate = "@" ;
				obj.ConceptPlanSubmitDate = "@" ;
				obj.FullWorkingDrawingsSubmitDate = "@" ;
				obj.PracticalCompletionDateLessor = "@" ;
				obj.EstimatedOpeningDate = "@" ;
				obj.RefurbishmentRequiredIndicator = "@" ;
				obj.FitoutPlanSubmitDate = "@" ;
				obj.PracticalCompletionDateLessee = "@" ;
				obj.DevelopmentDesignFormSubmitDate = "@" ;
				obj.LessorWorksCost = -1.0m ;
				obj.UpdateUserCode = "@" ;
				obj.UpdateDateTime = new DateTime(1900,1,1) ;
				obj.SmallShopDesignerLessorFee = -1.0m ;
				obj.SmallShopDesignerBillingDate = new DateTime(1900,1,1) ;
			}
			else // update
			{
				obj.FitoutContribution = -2.0m ;
				obj.FitoutPeriod = -200 ;
				obj.IncentiveBudget = -2.0m ;
				obj.HandoverDate = "#" ;
				obj.ArchitectFeesPayableIndicator = "#" ;
				obj.ArchitectFees = -2.0m ;
				obj.EngineerFeesPayableIndicator = "#" ;
				obj.EngineerFees = -2.0m ;
				obj.SmallShopDesignerFeesPayableIndicator = "#" ;
				obj.SmallShopDesignerFees = -2.0m ;
				obj.SurveyFeePayableIndicator = "#" ;
				obj.SurveyFees = -2.0m ;
				obj.TenantCoordinationFeesPayable = "#" ;
				obj.TenantCoordinationFees = -2.0m ;
				obj.AgreementToLeaseIndicator = "#" ;
				obj.DevelopmentApprovalsRequiredIndicator = "#" ;
				obj.DevelopmentApprovalsDueDate = "#" ;
				obj.ConceptPlanSubmitDate = "#" ;
				obj.FullWorkingDrawingsSubmitDate = "#" ;
				obj.PracticalCompletionDateLessor = "#" ;
				obj.EstimatedOpeningDate = "#" ;
				obj.RefurbishmentRequiredIndicator = "#" ;
				obj.FitoutPlanSubmitDate = "#" ;
				obj.PracticalCompletionDateLessee = "#" ;
				obj.DevelopmentDesignFormSubmitDate = "#" ;
				obj.LessorWorksCost = -2.0m ;
				obj.UpdateUserCode = "#" ;
				obj.UpdateDateTime = new DateTime(1901,12,31) ;
				obj.SmallShopDesignerLessorFee = -2.0m ;
				obj.SmallShopDesignerBillingDate = new DateTime(1901,12,31) ;
			}
			 
		}
	}

}

