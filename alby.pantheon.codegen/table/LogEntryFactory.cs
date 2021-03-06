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
	public partial class LogEntryFactory : acr.FactoryBase< LogEntry, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static LogEntryFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "LogEntry" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [LogEntryGUID], [LeaseID], [Severity], [Text], [Source], [LogDate], [UpdateUserCode], [UpdateDateTime] ) values ( @LogEntryGUID, @LeaseID, @Severity, @Text, @Source, @LogDate, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [LogEntryGUID], [LeaseID], [Severity], [Text], [Source], [LogDate], [UpdateUserCode], [UpdateDateTime] ) values ( @LogEntryGUID, @LeaseID, @Severity, @Text, @Source, @LogDate, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [LogEntryGUID] = @LogEntryGUID, [LeaseID] = @LeaseID, [Severity] = @Severity, [Text] = @Text, [Source] = @Source, [LogDate] = @LogDate, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [LogEntryGUID] = @pk_LogEntryGUID " ;
			_whereSavePKˡ = "where [LogEntryGUID] = @pk_LogEntryGUID " ;
		}

		public LogEntry Saveˡ( sds.SqlConnection connˡ, LogEntry rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_LogEntryGUID", rowˡ.PrimaryKeyDictionaryˡ[ LogEntry.column٠LogEntryGUID ] );
			base.AddParameterˡ( parametersˡ, "@LogEntryGUID", rowˡ.LogEntryGUID, sd.SqlDbType.UniqueIdentifier );
			base.AddParameterˡ( parametersˡ, "@LeaseID", rowˡ.LeaseID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@Severity", rowˡ.Severity, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Text", rowˡ.Text, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Source", rowˡ.Source, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@LogDate", rowˡ.LogDate, sd.SqlDbType.DateTime );
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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.LogEntryGUID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.LogEntryGUID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<LogEntry> Saveˡ( sds.SqlConnection connˡ, scg.List<LogEntry> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<LogEntry> rowList2ˡ = new scg.List<LogEntry>();
			foreach( LogEntry rowˡ in rowListˡ )
			{
				LogEntry row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public LogEntry LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			Guid? LogEntryGUID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_LogEntryGUID", LogEntryGUID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<LogEntry> LoadByForeignKey٠From٠Lease٠By٠LeaseID
		(
			sds.SqlConnection connˡ,
			int? LeaseID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@LeaseID", LeaseID );
			string whereˡ = "where [LeaseID] = @LeaseID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<LogEntry> Loadˡ
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

		public scg.List<LogEntry> LoadByWhereˡ
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

