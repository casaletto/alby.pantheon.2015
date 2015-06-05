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
	public partial class LeaseAdministrationFactory : acr.FactoryBase< LeaseAdministration, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static LeaseAdministrationFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "LeaseAdministration" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [LeaseAdministrationID], [StaffID], [DeedOfConsentRequiredIndicator], [FranchiseID], [PaymentTypeID], [SendDocumentsTo], [TenantRenewingIndicator], [TenantRelocatingIndicator], [RelocationClauseRequiredIndicator], [BankOrFinInstitIndicator], [BankOrFinInstitSpecialConvenantsRequiredIndicator], [SpecialPrecinctConvenants], [UpdateUserCode], [UpdateDateTime] ) values ( @LeaseAdministrationID, @StaffID, @DeedOfConsentRequiredIndicator, @FranchiseID, @PaymentTypeID, @SendDocumentsTo, @TenantRenewingIndicator, @TenantRelocatingIndicator, @RelocationClauseRequiredIndicator, @BankOrFinInstitIndicator, @BankOrFinInstitSpecialConvenantsRequiredIndicator, @SpecialPrecinctConvenants, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [LeaseAdministrationID], [StaffID], [DeedOfConsentRequiredIndicator], [FranchiseID], [PaymentTypeID], [SendDocumentsTo], [TenantRenewingIndicator], [TenantRelocatingIndicator], [RelocationClauseRequiredIndicator], [BankOrFinInstitIndicator], [BankOrFinInstitSpecialConvenantsRequiredIndicator], [SpecialPrecinctConvenants], [UpdateUserCode], [UpdateDateTime] ) values ( @LeaseAdministrationID, @StaffID, @DeedOfConsentRequiredIndicator, @FranchiseID, @PaymentTypeID, @SendDocumentsTo, @TenantRenewingIndicator, @TenantRelocatingIndicator, @RelocationClauseRequiredIndicator, @BankOrFinInstitIndicator, @BankOrFinInstitSpecialConvenantsRequiredIndicator, @SpecialPrecinctConvenants, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [LeaseAdministrationID] = @LeaseAdministrationID, [StaffID] = @StaffID, [DeedOfConsentRequiredIndicator] = @DeedOfConsentRequiredIndicator, [FranchiseID] = @FranchiseID, [PaymentTypeID] = @PaymentTypeID, [SendDocumentsTo] = @SendDocumentsTo, [TenantRenewingIndicator] = @TenantRenewingIndicator, [TenantRelocatingIndicator] = @TenantRelocatingIndicator, [RelocationClauseRequiredIndicator] = @RelocationClauseRequiredIndicator, [BankOrFinInstitIndicator] = @BankOrFinInstitIndicator, [BankOrFinInstitSpecialConvenantsRequiredIndicator] = @BankOrFinInstitSpecialConvenantsRequiredIndicator, [SpecialPrecinctConvenants] = @SpecialPrecinctConvenants, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [LeaseAdministrationID] = @pk_LeaseAdministrationID " ;
			_whereSavePKˡ = "where [LeaseAdministrationID] = @pk_LeaseAdministrationID " ;
		}

		public LeaseAdministration Saveˡ( sds.SqlConnection connˡ, LeaseAdministration rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_LeaseAdministrationID", rowˡ.PrimaryKeyDictionaryˡ[ LeaseAdministration.column٠LeaseAdministrationID ] );
			base.AddParameterˡ( parametersˡ, "@LeaseAdministrationID", rowˡ.LeaseAdministrationID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@StaffID", rowˡ.StaffID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@DeedOfConsentRequiredIndicator", rowˡ.DeedOfConsentRequiredIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@FranchiseID", rowˡ.FranchiseID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@PaymentTypeID", rowˡ.PaymentTypeID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@SendDocumentsTo", rowˡ.SendDocumentsTo, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@TenantRenewingIndicator", rowˡ.TenantRenewingIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@TenantRelocatingIndicator", rowˡ.TenantRelocatingIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@RelocationClauseRequiredIndicator", rowˡ.RelocationClauseRequiredIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@BankOrFinInstitIndicator", rowˡ.BankOrFinInstitIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@BankOrFinInstitSpecialConvenantsRequiredIndicator", rowˡ.BankOrFinInstitSpecialConvenantsRequiredIndicator, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@SpecialPrecinctConvenants", rowˡ.SpecialPrecinctConvenants, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateUserCode", rowˡ.UpdateUserCode, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateDateTime", rowˡ.UpdateDateTime, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@RowTimestamp", rowˡ.RowTimestamp, sd.SqlDbType.Image );

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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.LeaseAdministrationID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.LeaseAdministrationID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<LeaseAdministration> Saveˡ( sds.SqlConnection connˡ, scg.List<LeaseAdministration> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<LeaseAdministration> rowList2ˡ = new scg.List<LeaseAdministration>();
			foreach( LeaseAdministration rowˡ in rowListˡ )
			{
				LeaseAdministration row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public LeaseAdministration LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? LeaseAdministrationID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_LeaseAdministrationID", LeaseAdministrationID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<LeaseAdministration> LoadByForeignKey٠From٠Franchise٠By٠FranchiseID
		(
			sds.SqlConnection connˡ,
			int? FranchiseID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@FranchiseID", FranchiseID );
			string whereˡ = "where [FranchiseID] = @FranchiseID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<LeaseAdministration> LoadByForeignKey٠From٠PaymentType٠By٠PaymentTypeID
		(
			sds.SqlConnection connˡ,
			int? PaymentTypeID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@PaymentTypeID", PaymentTypeID );
			string whereˡ = "where [PaymentTypeID] = @PaymentTypeID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<LeaseAdministration> LoadByForeignKey٠From٠Staff٠By٠StaffID
		(
			sds.SqlConnection connˡ,
			int? StaffID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@StaffID", StaffID );
			string whereˡ = "where [StaffID] = @StaffID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<LeaseAdministration> Loadˡ
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

		public scg.List<LeaseAdministration> LoadByWhereˡ
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
