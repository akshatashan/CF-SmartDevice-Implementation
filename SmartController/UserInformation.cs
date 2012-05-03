using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace MyNameSpace
{
	[DataContract()]
	public class UserInformation
	{

#region " Constructors "
	public UserInformation(string userFirstName, string userLastName, System.Nullable<System.Int32> age)
	{
		_firstName = userFirstName;
		_lastName = userLastName;
		_age = age;
	}
#endregion


#region " Fields "
	private System.String _firstName;
	private System.String _lastName;
	private System.Nullable<Int32> _age;
#endregion

#region " Properties "
	[DataMember()]
	public System.String UserName
	{
		[DebuggerStepThrough()]
		get { return _firstName + " " + _lastName; }
		[DebuggerStepThrough()]
		set { _firstName = value; }
	}

	[DataMember()]
	public System.Nullable<System.Int32> Age
	{
		[DebuggerStepThrough()]
		get { return _age; }
		[DebuggerStepThrough()]
		set { _age = value; }
	}
#endregion

	}
}