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
	public partial class StoredProcedureFactory : acr.StoredProcedureFactoryBase< ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		public int FitoutDetailUpdate
		(
			sds.SqlConnection connˡ, 
			int? FitoutDetailID, 
			decimal? FitoutContribution, 
			int? FitoutPeriod, 
			decimal? IncentiveBudget, 
			string HandoverDate, 
			string ArchitectFeesPayableIndicator, 
			decimal? ArchitectFees, 
			string EngineerFeesPayableIndicator, 
			decimal? EngineerFees, 
			string SmallShopDesignerFeesPayableIndicator, 
			decimal? SmallShopDesignerFees, 
			decimal? SmallShopDesignerLessorFee, 
			DateTime? SmallShopDesignerBillingDate, 
			string SurveyFeePayableIndicator, 
			decimal? SurveyFees, 
			string TenantCoordinationFeesPayable, 
			decimal? TenantCoordinationFees, 
			string AgreementToLeaseIndicator, 
			string DevelopmentApprovalsRequiredIndicator, 
			string DevelopmentApprovalsDueDate, 
			string ConceptPlanSubmitDate, 
			string FullWorkingDrawingsSubmitDate, 
			string PracticalCompletionDateLessor, 
			string EstimatedOpeningDate, 
			string RefurbishmentRequiredIndicator, 
			string FitoutPlanSubmitDate, 
			string PracticalCompletionDateLessee, 
			string DevelopmentDesignFormSubmitDate, 
			decimal? LessorWorksCost, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "FitoutDetailUpdate" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡFitoutDetailID = base.AddParameterˡ( parametersˡ, "@FitoutDetailID", FitoutDetailID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡFitoutContribution = base.AddParameterˡ( parametersˡ, "@FitoutContribution", FitoutContribution, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡFitoutPeriod = base.AddParameterˡ( parametersˡ, "@FitoutPeriod", FitoutPeriod, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡIncentiveBudget = base.AddParameterˡ( parametersˡ, "@IncentiveBudget", IncentiveBudget, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡHandoverDate = base.AddParameterˡ( parametersˡ, "@HandoverDate", HandoverDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡArchitectFeesPayableIndicator = base.AddParameterˡ( parametersˡ, "@ArchitectFeesPayableIndicator", ArchitectFeesPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡArchitectFees = base.AddParameterˡ( parametersˡ, "@ArchitectFees", ArchitectFees, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡEngineerFeesPayableIndicator = base.AddParameterˡ( parametersˡ, "@EngineerFeesPayableIndicator", EngineerFeesPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡEngineerFees = base.AddParameterˡ( parametersˡ, "@EngineerFees", EngineerFees, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡSmallShopDesignerFeesPayableIndicator = base.AddParameterˡ( parametersˡ, "@SmallShopDesignerFeesPayableIndicator", SmallShopDesignerFeesPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡSmallShopDesignerFees = base.AddParameterˡ( parametersˡ, "@SmallShopDesignerFees", SmallShopDesignerFees, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡSmallShopDesignerLessorFee = base.AddParameterˡ( parametersˡ, "@SmallShopDesignerLessorFee", SmallShopDesignerLessorFee, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡSmallShopDesignerBillingDate = base.AddParameterˡ( parametersˡ, "@SmallShopDesignerBillingDate", SmallShopDesignerBillingDate, sd.SqlDbType.SmallDateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡSurveyFeePayableIndicator = base.AddParameterˡ( parametersˡ, "@SurveyFeePayableIndicator", SurveyFeePayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡSurveyFees = base.AddParameterˡ( parametersˡ, "@SurveyFees", SurveyFees, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡTenantCoordinationFeesPayable = base.AddParameterˡ( parametersˡ, "@TenantCoordinationFeesPayable", TenantCoordinationFeesPayable, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡTenantCoordinationFees = base.AddParameterˡ( parametersˡ, "@TenantCoordinationFees", TenantCoordinationFees, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡAgreementToLeaseIndicator = base.AddParameterˡ( parametersˡ, "@AgreementToLeaseIndicator", AgreementToLeaseIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡDevelopmentApprovalsRequiredIndicator = base.AddParameterˡ( parametersˡ, "@DevelopmentApprovalsRequiredIndicator", DevelopmentApprovalsRequiredIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡDevelopmentApprovalsDueDate = base.AddParameterˡ( parametersˡ, "@DevelopmentApprovalsDueDate", DevelopmentApprovalsDueDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡConceptPlanSubmitDate = base.AddParameterˡ( parametersˡ, "@ConceptPlanSubmitDate", ConceptPlanSubmitDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡFullWorkingDrawingsSubmitDate = base.AddParameterˡ( parametersˡ, "@FullWorkingDrawingsSubmitDate", FullWorkingDrawingsSubmitDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡPracticalCompletionDateLessor = base.AddParameterˡ( parametersˡ, "@PracticalCompletionDateLessor", PracticalCompletionDateLessor, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡEstimatedOpeningDate = base.AddParameterˡ( parametersˡ, "@EstimatedOpeningDate", EstimatedOpeningDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡRefurbishmentRequiredIndicator = base.AddParameterˡ( parametersˡ, "@RefurbishmentRequiredIndicator", RefurbishmentRequiredIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡFitoutPlanSubmitDate = base.AddParameterˡ( parametersˡ, "@FitoutPlanSubmitDate", FitoutPlanSubmitDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡPracticalCompletionDateLessee = base.AddParameterˡ( parametersˡ, "@PracticalCompletionDateLessee", PracticalCompletionDateLessee, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡDevelopmentDesignFormSubmitDate = base.AddParameterˡ( parametersˡ, "@DevelopmentDesignFormSubmitDate", DevelopmentDesignFormSubmitDate, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡLessorWorksCost = base.AddParameterˡ( parametersˡ, "@LessorWorksCost", LessorWorksCost, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡUpdateUserCode = base.AddParameterˡ( parametersˡ, "@UpdateUserCode", UpdateUserCode, sd.SqlDbType.VarChar, true, 50, null, null ) ; 
			sds.SqlParameter paramˡUpdateDateTime = base.AddParameterˡ( parametersˡ, "@UpdateDateTime", UpdateDateTime, sd.SqlDbType.DateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡRowTimestamp = base.AddParameterˡ( parametersˡ, "@RowTimestamp", RowTimestamp, sd.SqlDbType.Timestamp, false, null, null, null ) ; 
			sds.SqlParameter paramˡrcˡ = base.AddParameterReturnValueˡ( parametersˡ, "@rcˡ" ) ; 
			 
			sd.DataSet dsˡ = base.Executeˡ( connˡ, tranˡ, schemaˡ, spˡ, parametersˡ ) ;
			 
			RowTimestamp = base.GetParameterValueˡ<byte[]>( paramˡRowTimestamp ) ;
			return base.GetParameterValueˡ<int>( paramˡrcˡ ) ;
		}
	}

}

