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
	public partial class ConsumerPriceIndexRentReviewFactory : acr.FactoryBase< ConsumerPriceIndexRentReview, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static ConsumerPriceIndexRentReviewFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "ConsumerPriceIndexRentReview" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [RentReviewID], [ConsumerPriceIndexDescription], [ConsumerPriceIndexIncrease], [UpdateUserCode], [UpdateDateTime] ) values ( @RentReviewID, @ConsumerPriceIndexDescription, @ConsumerPriceIndexIncrease, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [RentReviewID], [ConsumerPriceIndexDescription], [ConsumerPriceIndexIncrease], [UpdateUserCode], [UpdateDateTime] ) values ( @RentReviewID, @ConsumerPriceIndexDescription, @ConsumerPriceIndexIncrease, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [RentReviewID] = @RentReviewID, [ConsumerPriceIndexDescription] = @ConsumerPriceIndexDescription, [ConsumerPriceIndexIncrease] = @ConsumerPriceIndexIncrease, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [RentReviewID] = @pk_RentReviewID " ;
			_whereSavePKˡ = "where [RentReviewID] = @pk_RentReviewID " ;
		}

		public ConsumerPriceIndexRentReview Saveˡ( sds.SqlConnection connˡ, ConsumerPriceIndexRentReview rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_RentReviewID", rowˡ.PrimaryKeyDictionaryˡ[ ConsumerPriceIndexRentReview.column٠RentReviewID ] );
			base.AddParameterˡ( parametersˡ, "@RentReviewID", rowˡ.RentReviewID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexDescription", rowˡ.ConsumerPriceIndexDescription, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@ConsumerPriceIndexIncrease", rowˡ.ConsumerPriceIndexIncrease, sd.SqlDbType.Decimal );
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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.RentReviewID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.RentReviewID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<ConsumerPriceIndexRentReview> Saveˡ( sds.SqlConnection connˡ, scg.List<ConsumerPriceIndexRentReview> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<ConsumerPriceIndexRentReview> rowList2ˡ = new scg.List<ConsumerPriceIndexRentReview>();
			foreach( ConsumerPriceIndexRentReview rowˡ in rowListˡ )
			{
				ConsumerPriceIndexRentReview row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public ConsumerPriceIndexRentReview LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? RentReviewID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_RentReviewID", RentReviewID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<ConsumerPriceIndexRentReview> LoadByForeignKey٠From٠RentReview٠By٠RentReviewID
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

		public scg.List<ConsumerPriceIndexRentReview> Loadˡ
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

		public scg.List<ConsumerPriceIndexRentReview> LoadByWhereˡ
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

