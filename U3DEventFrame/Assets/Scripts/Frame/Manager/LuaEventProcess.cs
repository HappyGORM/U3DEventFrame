//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;

using System.Collections.Generic;

namespace U3DEventFrame
{
	public class LuaEventProcess:MonoBase
	{

			
			
			void Awake()
			{
				instance = this;
			}
			
	    public override void ProcessEvent (MsgBase msg)
		{
			if(monoChild != null)
			{

				monoChild.ProcessEvent(msg);
			}
		}
			
    
		public void SettingChild(MonoBase  tmpChild)
		{

			monoChild = tmpChild ;
		}
			


		MonoBase    monoChild = null ;

		public static LuaEventProcess instance;
			
			

	}
}

