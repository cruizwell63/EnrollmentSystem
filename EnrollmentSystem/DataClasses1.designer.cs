﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrollmentSystem
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="enrollment")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertuser(user instance);
    partial void Updateuser(user instance);
    partial void Deleteuser(user instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::EnrollmentSystem.Properties.Settings.Default.enrollmentConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<user> users
		{
			get
			{
				return this.GetTable<user>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.checkUsername")]
		public int checkUsername1([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string username)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.addUser")]
		public int addUser([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(30)")] string userpassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string temppassword, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string fname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string mname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string lname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(10)")] string gender, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> bdate, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(20)")] string role, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> created_at, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> updated_at)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, userpassword, temppassword, fname, mname, lname, gender, bdate, role, created_at, updated_at);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.users")]
	public partial class user : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _userID;
		
		private string _username;
		
		private string _userpassword;
		
		private string _temppassword;
		
		private string _fname;
		
		private string _mname;
		
		private string _lname;
		
		private string _gender;
		
		private System.Nullable<System.DateTime> _bdate;
		
		private System.Nullable<System.DateTime> _created_at;
		
		private System.Nullable<System.DateTime> _updated_at;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(int value);
    partial void OnuserIDChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnuserpasswordChanging(string value);
    partial void OnuserpasswordChanged();
    partial void OntemppasswordChanging(string value);
    partial void OntemppasswordChanged();
    partial void OnfnameChanging(string value);
    partial void OnfnameChanged();
    partial void OnmnameChanging(string value);
    partial void OnmnameChanged();
    partial void OnlnameChanging(string value);
    partial void OnlnameChanged();
    partial void OngenderChanging(string value);
    partial void OngenderChanged();
    partial void OnbdateChanging(System.Nullable<System.DateTime> value);
    partial void OnbdateChanged();
    partial void Oncreated_atChanging(System.Nullable<System.DateTime> value);
    partial void Oncreated_atChanged();
    partial void Onupdated_atChanging(System.Nullable<System.DateTime> value);
    partial void Onupdated_atChanged();
    #endregion
		
		public user()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="VarChar(20)")]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userpassword", DbType="VarChar(30)")]
		public string userpassword
		{
			get
			{
				return this._userpassword;
			}
			set
			{
				if ((this._userpassword != value))
				{
					this.OnuserpasswordChanging(value);
					this.SendPropertyChanging();
					this._userpassword = value;
					this.SendPropertyChanged("userpassword");
					this.OnuserpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_temppassword", DbType="VarChar(20)")]
		public string temppassword
		{
			get
			{
				return this._temppassword;
			}
			set
			{
				if ((this._temppassword != value))
				{
					this.OntemppasswordChanging(value);
					this.SendPropertyChanging();
					this._temppassword = value;
					this.SendPropertyChanged("temppassword");
					this.OntemppasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fname", DbType="VarChar(20)")]
		public string fname
		{
			get
			{
				return this._fname;
			}
			set
			{
				if ((this._fname != value))
				{
					this.OnfnameChanging(value);
					this.SendPropertyChanging();
					this._fname = value;
					this.SendPropertyChanged("fname");
					this.OnfnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mname", DbType="VarChar(20)")]
		public string mname
		{
			get
			{
				return this._mname;
			}
			set
			{
				if ((this._mname != value))
				{
					this.OnmnameChanging(value);
					this.SendPropertyChanging();
					this._mname = value;
					this.SendPropertyChanged("mname");
					this.OnmnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lname", DbType="VarChar(20)")]
		public string lname
		{
			get
			{
				return this._lname;
			}
			set
			{
				if ((this._lname != value))
				{
					this.OnlnameChanging(value);
					this.SendPropertyChanging();
					this._lname = value;
					this.SendPropertyChanged("lname");
					this.OnlnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gender", DbType="VarChar(10)")]
		public string gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				if ((this._gender != value))
				{
					this.OngenderChanging(value);
					this.SendPropertyChanging();
					this._gender = value;
					this.SendPropertyChanged("gender");
					this.OngenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bdate", DbType="Date")]
		public System.Nullable<System.DateTime> bdate
		{
			get
			{
				return this._bdate;
			}
			set
			{
				if ((this._bdate != value))
				{
					this.OnbdateChanging(value);
					this.SendPropertyChanging();
					this._bdate = value;
					this.SendPropertyChanged("bdate");
					this.OnbdateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_created_at", DbType="Date")]
		public System.Nullable<System.DateTime> created_at
		{
			get
			{
				return this._created_at;
			}
			set
			{
				if ((this._created_at != value))
				{
					this.Oncreated_atChanging(value);
					this.SendPropertyChanging();
					this._created_at = value;
					this.SendPropertyChanged("created_at");
					this.Oncreated_atChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_updated_at", DbType="Date")]
		public System.Nullable<System.DateTime> updated_at
		{
			get
			{
				return this._updated_at;
			}
			set
			{
				if ((this._updated_at != value))
				{
					this.Onupdated_atChanging(value);
					this.SendPropertyChanging();
					this._updated_at = value;
					this.SendPropertyChanged("updated_at");
					this.Onupdated_atChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591