/*
 * Created by SharpDevelop.
 * User: Mathieu
 * Date: 14/05/2014
 * Time: 12:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace CsharpNunitKoans
{
	/// <summary>
	/// Description of ClassNote.
	/// </summary>
	public class ClassNote
	{
		public ClassNote()
		{

		}
		
		
		private IEnumerable<User> getAllVersionReflection(string name)
	{
		Type userType = typeof(User);
		PropertyInfo property = userType.GetProperty(name);
		
		Func<User,object> sortBy = (u)=> property.GetValue(u,null);
		
		return users.OrderBy(sortBy);
	}

private IEnumerable<User> getAllVersionSwitch(string name)
{
	if(name == "Name")
		return users.OrderBy(x => x.name);
	if(name == "Id")
		return users.OrderBy(x => x.Id);
		
	return users;
}
	}
}
