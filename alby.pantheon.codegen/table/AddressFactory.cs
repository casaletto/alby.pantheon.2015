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
	public partial class AddressFactory : acr.FactoryBase< Address, ns.database.pantheonDatabaseSingletonHelper, ns.database.pantheonDatabase >
	{
		static AddressFactory() 
		{
			_assemblyˡ = sr.Assembly.GetExecutingAssembly() ;
			_schemaˡ = "dbo" ;
			_tableˡ = "Address" ;
			_selectˡ = "select * from {0} t " ;
			_insertˡ = "insert {0} ( [AddressID], [PartyID], [AddressType], [AddressLine1], [AddressLine2], [Suburb], [Town], [State], [Postcode], [Country], [UpdateUserCode], [UpdateDateTime] ) values ( @AddressID, @PartyID, @AddressType, @AddressLine1, @AddressLine2, @Suburb, @Town, @State, @Postcode, @Country, @UpdateUserCode, @UpdateDateTime ) " ;
			_insertIdentityˡ = "insert {0} ( [AddressID], [PartyID], [AddressType], [AddressLine1], [AddressLine2], [Suburb], [Town], [State], [Postcode], [Country], [UpdateUserCode], [UpdateDateTime] ) values ( @AddressID, @PartyID, @AddressType, @AddressLine1, @AddressLine2, @Suburb, @Town, @State, @Postcode, @Country, @UpdateUserCode, @UpdateDateTime ) " ;
			_updateˡ = "update {0} set [AddressID] = @AddressID, [PartyID] = @PartyID, [AddressType] = @AddressType, [AddressLine1] = @AddressLine1, [AddressLine2] = @AddressLine2, [Suburb] = @Suburb, [Town] = @Town, [State] = @State, [Postcode] = @Postcode, [Country] = @Country, [UpdateUserCode] = @UpdateUserCode, [UpdateDateTime] = @UpdateDateTime " ;
			_deleteˡ = "delete {0} " ;
			_whereLoadPKˡ = "where [AddressID] = @pk_AddressID " ;
			_whereSavePKˡ = "where [AddressID] = @pk_AddressID " ;
		}

		public Address Saveˡ( sds.SqlConnection connˡ, Address rowˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal, bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_AddressID", rowˡ.PrimaryKeyDictionaryˡ[ Address.column٠AddressID ] );
			base.AddParameterˡ( parametersˡ, "@AddressID", rowˡ.AddressID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@PartyID", rowˡ.PartyID, sd.SqlDbType.Int );
			base.AddParameterˡ( parametersˡ, "@AddressType", rowˡ.AddressType, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@AddressLine1", rowˡ.AddressLine1, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@AddressLine2", rowˡ.AddressLine2, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Suburb", rowˡ.Suburb, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Town", rowˡ.Town, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@State", rowˡ.State, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Postcode", rowˡ.Postcode, sd.SqlDbType.NText );
			base.AddParameterˡ( parametersˡ, "@Country", rowˡ.Country, sd.SqlDbType.NText );
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
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.AddressID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Insert ) 
				return this.LoadByPrimaryKeyˡ( connˡ, rowˡ.AddressID, tranˡ ) ;
			else
			if ( saveResultˡ == acr.SaveEnum.Delete )
				return null ;
			else
				return rowˡ ;
		}

		public scg.List<Address> Saveˡ( sds.SqlConnection connˡ, scg.List<Address> rowListˡ, acr.CodeGenSaveStrategy saveStrategyˡ = acr.CodeGenSaveStrategy.Normal,  bool identityProvidedˡ = false, sds.SqlTransaction tranˡ = null )
		{
			scg.List<Address> rowList2ˡ = new scg.List<Address>();
			foreach( Address rowˡ in rowListˡ )
			{
				Address row2ˡ = this.Saveˡ( connˡ, rowˡ, saveStrategyˡ, identityProvidedˡ, tranˡ ) ;
				if ( row2ˡ != null )	rowList2ˡ.Add( row2ˡ ) ;
			}
			return rowList2ˡ ;
		}

		public Address LoadByPrimaryKeyˡ
		(
			sds.SqlConnection connˡ,
			int? AddressID,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@pk_AddressID", AddressID );
			return base.ExecuteQueryReturnOneˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, _whereLoadPKˡ, false ) ;
		}

		public scg.List<Address> LoadByForeignKey٠From٠Party٠By٠PartyID
		(
			sds.SqlConnection connˡ,
			int? PartyID,
			int? topNˡ = null,
			scg.List<acr.CodeGenOrderBy> orderByˡ = null,
			sds.SqlTransaction tranˡ = null
		)
		{
			scg.List<sds.SqlParameter> parametersˡ = new scg.List<sds.SqlParameter>();
			base.AddParameterˡ( parametersˡ, "@PartyID", PartyID );
			string whereˡ = "where [PartyID] = @PartyID " ; 
			string sqlˡ = "" ; 
			return base.ExecuteQueryˡ( connˡ, tranˡ, parametersˡ, _assemblyˡ, _selectˡ, false, whereˡ, false, topNˡ, orderByˡ, out sqlˡ ) ;
		}

		public scg.List<Address> Loadˡ
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

		public scg.List<Address> LoadByWhereˡ
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
