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
	public partial class PrecinctFactory : acr.FactoryBase< Precinct, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static PrecinctFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "Precinct" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [PrecinctID], [PrecinctDescription], [UpdateUserCode], [UpdateDateTime], [DeletionIndicator] ) values ( @PrecinctID, @PrecinctDescription, @UpdateUserCode, @UpdateDateTime, @DeletionIndicator ) " ;
			_insertIdentityˡ = "insert {0} ( [PrecinctID], [PrecinctDescription], [UpdateUserCode], [UpdateDateTime], [DeletionIndicator] ) values ( @PrecinctID, @PrecinctDescription, @UpdateUserCode, @UpdateDateTime, @DeletionIndicator ) " ;
			_updateˡ = "update {0} set [PrecinctID] = @PrecinctID, [PrecinctDescription] = @PrecinctDescription, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime, [DeletionIndicator] = @DeletionIndicator " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [PrecinctID] = @pk_PrecinctID " ;
			_whereSavePKˡ = "where [PrecinctID] = @pk_PrecinctID " ;
		}

		public Precinct Saveˡ( sds.SqlConnection connˡ, Precinct rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_PrecinctID", rowˡ.PrimaryKeyDictionaryˡ[ Precinct.column٠PrecinctID ] );
			base.AddParameterˡ( parametersˡ, "@PrecinctID", rowˡ.PrecinctID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@PrecinctDescription", rowˡ.PrecinctDescription, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateUserCode", rowˡ.UpdateUserCode, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@UpdateDateTime", rowˡ.UpdateDateTime, sd.SqlDbType.DateTime );
			base.AddParameterˡ( parametersˡ, "@RowTimestamp", rowˡ.RowTimestamp, sd.SqlDbType.Image );
			base.AddParameterˡ( parametersˡ, "@DeletionIndicator", rowˡ.DeletionIndicator, sd.SqlDbType.NText );

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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.PrecinctID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.PrecinctID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<Precinct> Saveˡ( sds.SqlConnection connˡ, scg.List<Precinct> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<Precinct> rowList2ˡ = new scg.List<Precinct>();
			foreach( Precinct rowˡ in rowListˡ )
			{
				Precinct row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public Precinct LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? PrecinctID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_PrecinctID", PrecinctID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<Precinct> Loadˡ
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

		public scg.List<Precinct> LoadByWhereˡ
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

