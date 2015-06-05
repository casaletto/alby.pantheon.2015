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
		public int RentDetailAdd
		(
			sds.SqlConnection connˡ, 
			int? RentDetailID, 
			decimal? BaseRent, 
			decimal? BaseRentSQM, 
			decimal? BudgetedBaseRent, 
			decimal? CurrentBaseRent, 
			decimal? PercentageRent, 
			string PercentageRentText, 
			decimal? MarketingLevy, 
			decimal? SpecialOpeningPromotionLevy, 
			decimal? MonthlyRent, 
			DateTime? RentPaymentCommencementDate, 
			string RentPaymentCommencementDateText, 
			DateTime? MarketingLevyPaymentCommencementDate, 
			string MarketingLevyPaymentCommencementDateText, 
			int? RentReviewID, 
			int? RentFreePeriod, 
			string DirectorsPersonalGuaranteeIndicator, 
			string BaseRentPayableIndicator, 
			string OutgoingsPayableIndicator, 
			string MarketingLevyPayableIndicator, 
			string BankGuaranteeRequiredIndicator, 
			decimal? BankGuaranteeAmount, 
			decimal? BankGuaranteeAmountCalculated, 
			decimal? ReducedBankGuaranteeAmount, 
			string BankGuaranteeRequiredLesseeIndicator, 
			decimal? ActualBankGuaranteeAmount, 
			string OptionRequiredIndicator, 
			int? OptionTermYears, 
			int? OptionTermMonths, 
			int? OptionTermDays, 
			string OptionTermText, 
			int? AtOptionRentReviewTypeID, 
			int? DuringOptionRentReviewTypeID, 
			string ConsumerPriceIndexDescriptionAtOption, 
			string ConsumerPriceIndexDescriptionDuringOption, 
			decimal? RentReviewIncreaseAtOption, 
			decimal? RentReviewIncreaseDuringOption, 
			string UpdateUserCode, 
			DateTime? UpdateDateTime, 
			ref byte[] RowTimestamp, 
			sds.SqlTransaction tranˡ = null
		)
		{
			const string schemaˡ = "dbo" ; 
			const string spˡ = "RentDetailAdd" ; 
			 
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>() ;
			sds.SqlParameter paramˡRentDetailID = base.AddParameterˡ( parametersˡ, "@RentDetailID", RentDetailID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡBaseRent = base.AddParameterˡ( parametersˡ, "@BaseRent", BaseRent, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡBaseRentSQM = base.AddParameterˡ( parametersˡ, "@BaseRentSQM", BaseRentSQM, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡBudgetedBaseRent = base.AddParameterˡ( parametersˡ, "@BudgetedBaseRent", BudgetedBaseRent, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡCurrentBaseRent = base.AddParameterˡ( parametersˡ, "@CurrentBaseRent", CurrentBaseRent, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡPercentageRent = base.AddParameterˡ( parametersˡ, "@PercentageRent", PercentageRent, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡPercentageRentText = base.AddParameterˡ( parametersˡ, "@PercentageRentText", PercentageRentText, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡMarketingLevy = base.AddParameterˡ( parametersˡ, "@MarketingLevy", MarketingLevy, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡSpecialOpeningPromotionLevy = base.AddParameterˡ( parametersˡ, "@SpecialOpeningPromotionLevy", SpecialOpeningPromotionLevy, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡMonthlyRent = base.AddParameterˡ( parametersˡ, "@MonthlyRent", MonthlyRent, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡRentPaymentCommencementDate = base.AddParameterˡ( parametersˡ, "@RentPaymentCommencementDate", RentPaymentCommencementDate, sd.SqlDbType.DateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡRentPaymentCommencementDateText = base.AddParameterˡ( parametersˡ, "@RentPaymentCommencementDateText", RentPaymentCommencementDateText, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡMarketingLevyPaymentCommencementDate = base.AddParameterˡ( parametersˡ, "@MarketingLevyPaymentCommencementDate", MarketingLevyPaymentCommencementDate, sd.SqlDbType.DateTime, true, null, null, null ) ; 
			sds.SqlParameter paramˡMarketingLevyPaymentCommencementDateText = base.AddParameterˡ( parametersˡ, "@MarketingLevyPaymentCommencementDateText", MarketingLevyPaymentCommencementDateText, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡRentReviewID = base.AddParameterˡ( parametersˡ, "@RentReviewID", RentReviewID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡRentFreePeriod = base.AddParameterˡ( parametersˡ, "@RentFreePeriod", RentFreePeriod, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡDirectorsPersonalGuaranteeIndicator = base.AddParameterˡ( parametersˡ, "@DirectorsPersonalGuaranteeIndicator", DirectorsPersonalGuaranteeIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡBaseRentPayableIndicator = base.AddParameterˡ( parametersˡ, "@BaseRentPayableIndicator", BaseRentPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡOutgoingsPayableIndicator = base.AddParameterˡ( parametersˡ, "@OutgoingsPayableIndicator", OutgoingsPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡMarketingLevyPayableIndicator = base.AddParameterˡ( parametersˡ, "@MarketingLevyPayableIndicator", MarketingLevyPayableIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡBankGuaranteeRequiredIndicator = base.AddParameterˡ( parametersˡ, "@BankGuaranteeRequiredIndicator", BankGuaranteeRequiredIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡBankGuaranteeAmount = base.AddParameterˡ( parametersˡ, "@BankGuaranteeAmount", BankGuaranteeAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡBankGuaranteeAmountCalculated = base.AddParameterˡ( parametersˡ, "@BankGuaranteeAmountCalculated", BankGuaranteeAmountCalculated, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡReducedBankGuaranteeAmount = base.AddParameterˡ( parametersˡ, "@ReducedBankGuaranteeAmount", ReducedBankGuaranteeAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡBankGuaranteeRequiredLesseeIndicator = base.AddParameterˡ( parametersˡ, "@BankGuaranteeRequiredLesseeIndicator", BankGuaranteeRequiredLesseeIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡActualBankGuaranteeAmount = base.AddParameterˡ( parametersˡ, "@ActualBankGuaranteeAmount", ActualBankGuaranteeAmount, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡOptionRequiredIndicator = base.AddParameterˡ( parametersˡ, "@OptionRequiredIndicator", OptionRequiredIndicator, sd.SqlDbType.Char, true, 1, null, null ) ; 
			sds.SqlParameter paramˡOptionTermYears = base.AddParameterˡ( parametersˡ, "@OptionTermYears", OptionTermYears, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡOptionTermMonths = base.AddParameterˡ( parametersˡ, "@OptionTermMonths", OptionTermMonths, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡOptionTermDays = base.AddParameterˡ( parametersˡ, "@OptionTermDays", OptionTermDays, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡOptionTermText = base.AddParameterˡ( parametersˡ, "@OptionTermText", OptionTermText, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡAtOptionRentReviewTypeID = base.AddParameterˡ( parametersˡ, "@AtOptionRentReviewTypeID", AtOptionRentReviewTypeID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡDuringOptionRentReviewTypeID = base.AddParameterˡ( parametersˡ, "@DuringOptionRentReviewTypeID", DuringOptionRentReviewTypeID, sd.SqlDbType.Int, true, null, 10, 0 ) ; 
			sds.SqlParameter paramˡConsumerPriceIndexDescriptionAtOption = base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexDescriptionAtOption", ConsumerPriceIndexDescriptionAtOption, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡConsumerPriceIndexDescriptionDuringOption = base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexDescriptionDuringOption", ConsumerPriceIndexDescriptionDuringOption, sd.SqlDbType.NVarChar, true, 100, null, null ) ; 
			sds.SqlParameter paramˡRentReviewIncreaseAtOption = base.AddParameterˡ( parametersˡ, "@RentReviewIncreaseAtOption", RentReviewIncreaseAtOption, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
			sds.SqlParameter paramˡRentReviewIncreaseDuringOption = base.AddParameterˡ( parametersˡ, "@RentReviewIncreaseDuringOption", RentReviewIncreaseDuringOption, sd.SqlDbType.Decimal, true, null, 28, 10 ) ; 
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
