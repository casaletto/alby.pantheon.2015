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

namespace alby.pantheon.codegen.table
{
	public partial class RentDetailFactory : acr.FactoryBase< RentDetail, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static RentDetailFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "RentDetail" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [RentDetailID], [BaseRent], [BaseRentSQM], [BudgetedBaseRent], [CurrentBaseRent], [PercentageRent], [PercentageRentText], [MarketingLevy], [SpecialOpeningPromotionLevy], [MonthlyRent], [RentPaymentCommencementDate], [RentPaymentCommencementDateText], [MarketingLevyPaymentCommencementDate], [MarketingLevyPaymentCommencementDateText], [RentReviewID], [RentFreePeriod], [DirectorsPersonalGuaranteeIndicator], [BaseRentPayableIndicator], [OutgoingsPayableIndicator], [MarketingLevyPayableIndicator], [BankGuaranteeRequiredIndicator], [BankGuaranteeAmount], [BankGuaranteeAmountCalculated], [ReducedBankGuaranteeAmount], [BankGuaranteeRequiredLesseeIndicator], [ActualBankGuaranteeAmount], [OptionRequiredIndicator], [OptionTermYears], [OptionTermMonths], [OptionTermDays], [OptionTermText], [AtOptionRentReviewTypeID], [DuringOptionRentReviewTypeID], [UpdateUserCode], [UpdateDateTime], [ConsumerPriceIndexDescriptionAtOption], [ConsumerPriceIndexDescriptionDuringOption], [RentReviewIncreaseAtOption], [RentReviewIncreaseDuringOption] ) values ( @RentDetailID, @BaseRent, @BaseRentSQM, @BudgetedBaseRent, @CurrentBaseRent, @PercentageRent, @PercentageRentText, @MarketingLevy, @SpecialOpeningPromotionLevy, @MonthlyRent, @RentPaymentCommencementDate, @RentPaymentCommencementDateText, @MarketingLevyPaymentCommencementDate, @MarketingLevyPaymentCommencementDateText, @RentReviewID, @RentFreePeriod, @DirectorsPersonalGuaranteeIndicator, @BaseRentPayableIndicator, @OutgoingsPayableIndicator, @MarketingLevyPayableIndicator, @BankGuaranteeRequiredIndicator, @BankGuaranteeAmount, @BankGuaranteeAmountCalculated, @ReducedBankGuaranteeAmount, @BankGuaranteeRequiredLesseeIndicator, @ActualBankGuaranteeAmount, @OptionRequiredIndicator, @OptionTermYears, @OptionTermMonths, @OptionTermDays, @OptionTermText, @AtOptionRentReviewTypeID, @DuringOptionRentReviewTypeID, @UpdateUserCode, @UpdateDateTime, @ConsumerPriceIndexDescriptionAtOption, @ConsumerPriceIndexDescriptionDuringOption, @RentReviewIncreaseAtOption, @RentReviewIncreaseDuringOption ) " ;
			_insertIdentityˡ = "insert {0} ( [RentDetailID], [BaseRent], [BaseRentSQM], [BudgetedBaseRent], [CurrentBaseRent], [PercentageRent], [PercentageRentText], [MarketingLevy], [SpecialOpeningPromotionLevy], [MonthlyRent], [RentPaymentCommencementDate], [RentPaymentCommencementDateText], [MarketingLevyPaymentCommencementDate], [MarketingLevyPaymentCommencementDateText], [RentReviewID], [RentFreePeriod], [DirectorsPersonalGuaranteeIndicator], [BaseRentPayableIndicator], [OutgoingsPayableIndicator], [MarketingLevyPayableIndicator], [BankGuaranteeRequiredIndicator], [BankGuaranteeAmount], [BankGuaranteeAmountCalculated], [ReducedBankGuaranteeAmount], [BankGuaranteeRequiredLesseeIndicator], [ActualBankGuaranteeAmount], [OptionRequiredIndicator], [OptionTermYears], [OptionTermMonths], [OptionTermDays], [OptionTermText], [AtOptionRentReviewTypeID], [DuringOptionRentReviewTypeID], [UpdateUserCode], [UpdateDateTime], [ConsumerPriceIndexDescriptionAtOption], [ConsumerPriceIndexDescriptionDuringOption], [RentReviewIncreaseAtOption], [RentReviewIncreaseDuringOption] ) values ( @RentDetailID, @BaseRent, @BaseRentSQM, @BudgetedBaseRent, @CurrentBaseRent, @PercentageRent, @PercentageRentText, @MarketingLevy, @SpecialOpeningPromotionLevy, @MonthlyRent, @RentPaymentCommencementDate, @RentPaymentCommencementDateText, @MarketingLevyPaymentCommencementDate, @MarketingLevyPaymentCommencementDateText, @RentReviewID, @RentFreePeriod, @DirectorsPersonalGuaranteeIndicator, @BaseRentPayableIndicator, @OutgoingsPayableIndicator, @MarketingLevyPayableIndicator, @BankGuaranteeRequiredIndicator, @BankGuaranteeAmount, @BankGuaranteeAmountCalculated, @ReducedBankGuaranteeAmount, @BankGuaranteeRequiredLesseeIndicator, @ActualBankGuaranteeAmount, @OptionRequiredIndicator, @OptionTermYears, @OptionTermMonths, @OptionTermDays, @OptionTermText, @AtOptionRentReviewTypeID, @DuringOptionRentReviewTypeID, @UpdateUserCode, @UpdateDateTime, @ConsumerPriceIndexDescriptionAtOption, @ConsumerPriceIndexDescriptionDuringOption, @RentReviewIncreaseAtOption, @RentReviewIncreaseDuringOption ) " ;
			_updateˡ = "update {0} set [RentDetailID] = @RentDetailID, [BaseRent] = @BaseRent, [BaseRentSQM] = @BaseRentSQM, [BudgetedBaseRent] = @BudgetedBaseRent, [CurrentBaseRent] = @CurrentBaseRent, [PercentageRent] = @PercentageRent, [PercentageRentText] = @PercentageRentText, [MarketingLevy] = @MarketingLevy, [SpecialOpeningPromotionLevy] = @SpecialOpeningPromotionLevy, [MonthlyRent] = @MonthlyRent, [RentPaymentCommencementDate] = @RentPaymentCommencementDate, [RentPaymentCommencementDateText] = @RentPaymentCommencementDateText, [MarketingLevyPaymentCommencementDate] = @MarketingLevyPaymentCommencementDate, [MarketingLevyPaymentCommencementDateText] = @MarketingLevyPaymentCommencementDateText, [RentReviewID] = @RentReviewID, [RentFreePeriod] = @RentFreePeriod, [DirectorsPersonalGuaranteeIndicator] = @DirectorsPersonalGuaranteeIndicator, [BaseRentPayableIndicator] = @BaseRentPayableIndicator, [OutgoingsPayableIndicator] = @OutgoingsPayableIndicator, [MarketingLevyPayableIndicator] = @MarketingLevyPayableIndicator, [BankGuaranteeRequiredIndicator] = @BankGuaranteeRequiredIndicator, [BankGuaranteeAmount] = @BankGuaranteeAmount, [BankGuaranteeAmountCalculated] = @BankGuaranteeAmountCalculated, [ReducedBankGuaranteeAmount] = @ReducedBankGuaranteeAmount, [BankGuaranteeRequiredLesseeIndicator] = @BankGuaranteeRequiredLesseeIndicator, [ActualBankGuaranteeAmount] = @ActualBankGuaranteeAmount, [OptionRequiredIndicator] = @OptionRequiredIndicator, [OptionTermYears] = @OptionTermYears, [OptionTermMonths] = @OptionTermMonths, [OptionTermDays] = @OptionTermDays, [OptionTermText] = @OptionTermText, [AtOptionRentReviewTypeID] = @AtOptionRentReviewTypeID, [DuringOptionRentReviewTypeID] = @DuringOptionRentReviewTypeID, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime, [ConsumerPriceIndexDescriptionAtOption] = @ConsumerPriceIndexDescriptionAtOption, [ConsumerPriceIndexDescriptionDuringOption] = @ConsumerPriceIndexDescriptionDuringOption, [RentReviewIncreaseAtOption] = @RentReviewIncreaseAtOption, [RentReviewIncreaseDuringOption] = @RentReviewIncreaseDuringOption " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [RentDetailID] = @pk_RentDetailID " ;
			_whereSavePKˡ = "where [RentDetailID] = @pk_RentDetailID " ;
		}

		public RentDetail Saveˡ( sds.SqlConnection connˡ, RentDetail rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_RentDetailID", rowˡ.PrimaryKeyDictionaryˡ[ RentDetail.column٠RentDetailID ] );
			base.AddParameterˡ( parametersˡ, "@RentDetailID", rowˡ.RentDetailID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@BaseRent", rowˡ.BaseRent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@BaseRentSQM", rowˡ.BaseRentSQM, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@BudgetedBaseRent", rowˡ.BudgetedBaseRent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@CurrentBaseRent", rowˡ.CurrentBaseRent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@PercentageRent", rowˡ.PercentageRent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@PercentageRentText", rowˡ.PercentageRentText, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@MarketingLevy", rowˡ.MarketingLevy, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@SpecialOpeningPromotionLevy", rowˡ.SpecialOpeningPromotionLevy, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@MonthlyRent", rowˡ.MonthlyRent, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@RentPaymentCommencementDate", rowˡ.RentPaymentCommencementDate, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@RentPaymentCommencementDateText", rowˡ.RentPaymentCommencementDateText, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@MarketingLevyPaymentCommencementDate", rowˡ.MarketingLevyPaymentCommencementDate, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@MarketingLevyPaymentCommencementDateText", rowˡ.MarketingLevyPaymentCommencementDateText, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@RentReviewID", rowˡ.RentReviewID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@RentFreePeriod", rowˡ.RentFreePeriod, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@DirectorsPersonalGuaranteeIndicator", rowˡ.DirectorsPersonalGuaranteeIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@BaseRentPayableIndicator", rowˡ.BaseRentPayableIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@OutgoingsPayableIndicator", rowˡ.OutgoingsPayableIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@MarketingLevyPayableIndicator", rowˡ.MarketingLevyPayableIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@BankGuaranteeRequiredIndicator", rowˡ.BankGuaranteeRequiredIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@BankGuaranteeAmount", rowˡ.BankGuaranteeAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@BankGuaranteeAmountCalculated", rowˡ.BankGuaranteeAmountCalculated, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@ReducedBankGuaranteeAmount", rowˡ.ReducedBankGuaranteeAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@BankGuaranteeRequiredLesseeIndicator", rowˡ.BankGuaranteeRequiredLesseeIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@ActualBankGuaranteeAmount", rowˡ.ActualBankGuaranteeAmount, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@OptionRequiredIndicator", rowˡ.OptionRequiredIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@OptionTermYears", rowˡ.OptionTermYears, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@OptionTermMonths", rowˡ.OptionTermMonths, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@OptionTermDays", rowˡ.OptionTermDays, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@OptionTermText", rowˡ.OptionTermText, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@AtOptionRentReviewTypeID", rowˡ.AtOptionRentReviewTypeID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@DuringOptionRentReviewTypeID", rowˡ.DuringOptionRentReviewTypeID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@UpdateUserCode", rowˡ.UpdateUserCode, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateDateTime", rowˡ.UpdateDateTime, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@RowTimestamp", rowˡ.RowTimestamp, sd.SqlDbType.Image );
			base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexDescriptionAtOption", rowˡ.ConsumerPriceIndexDescriptionAtOption, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexDescriptionDuringOption", rowˡ.ConsumerPriceIndexDescriptionDuringOption, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@RentReviewIncreaseAtOption", rowˡ.RentReviewIncreaseAtOption, sd.SqlDbType.Decimal );
			base.AddParameterˡ( parametersˡ, "@RentReviewIncreaseDuringOption", rowˡ.RentReviewIncreaseDuringOption, sd.SqlDbType.Decimal );

			int? identityIDˡ = null ;
			object objˡ = null ;
		 
			acr.SaveEnum saveResultˡ ;
		 
			if ( saveStrategyˡ != acr.CodeGenSaveStrategy.Normal )
			{
				saveResultˡ = base.ExecuteForceSaveˡ( rowˡ, connˡ, tranˡ, parametersˡ, saveStrategyˡ, _insertˡ, _insertIdentityˡ, _updateˡ, _deleteˡ, _whereLoadPKˡ, false, identityProvidedˡ, out objˡ ) ;
				if ( objˡ != null )
					identityIDˡ = int.Parse( objˡ.ToString() ) ;
			}
			else
			{
				saveResultˡ = base.ExecuteSaveˡ( rowˡ, connˡ, tranˡ, parametersˡ, _insertˡ, _insertIdentityˡ, _updateˡ, _deleteˡ, _whereSavePKˡ, false, identityProvidedˡ, out objˡ ) ;
				if ( objˡ != null )
					identityIDˡ = int.Parse( objˡ.ToString() ) ;
			}
		 
			if ( saveResultˡ == acr.SaveEnum.Update ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.RentDetailID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.RentDetailID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<RentDetail> Saveˡ( sds.SqlConnection connˡ, scg.List<RentDetail> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<RentDetail> rowList2ˡ = new scg.List<RentDetail>();
			foreach( RentDetail rowˡ in rowListˡ )
			{
				RentDetail row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public RentDetail LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? RentDetailID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_RentDetailID", RentDetailID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<RentDetail> LoadByForeignKey٠From٠RentReview٠By٠RentReviewID
		(
			sds.SqlConnection connˡ,
			int? RentReviewID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@RentReviewID", RentReviewID );
			string whereˡ = "where [RentReviewID] = @RentReviewID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<RentDetail> LoadByForeignKey٠From٠RentReviewType٠By٠AtOptionRentReviewTypeID
		(
			sds.SqlConnection connˡ,
			int? AtOptionRentReviewTypeID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@AtOptionRentReviewTypeID", AtOptionRentReviewTypeID );
			string whereˡ = "where [AtOptionRentReviewTypeID] = @AtOptionRentReviewTypeID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<RentDetail> LoadByForeignKey٠From٠RentReviewType٠By٠DuringOptionRentReviewTypeID
		(
			sds.SqlConnection connˡ,
			int? DuringOptionRentReviewTypeID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@DuringOptionRentReviewTypeID", DuringOptionRentReviewTypeID );
			string whereˡ = "where [DuringOptionRentReviewTypeID] = @DuringOptionRentReviewTypeID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<RentDetail> Loadˡ
		(
			sds.SqlConnection connˡ,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			string whereˡ = "";
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<RentDetail> LoadByWhereˡ
		(
			sds.SqlConnection connˡ,
			string whereˡ,
			scg.List<sds.SqlParameter> parametersˡ = null,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

	}

}

