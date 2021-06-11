///////////////////////////////////////////////////////////
//  IAccount.cs
//  Implementation of the Interface IAccount
//  Created on:      07-θών-2021 13:22:37
//  Original author: Aleksey Shirin
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Model;



using Interfaces;
namespace Interfaces {
	public interface IAccount
    {
        string Name {
            get;
        }
        int Disscount {
            get; init;
        }

        EnumTypeAccount TypeAccount {
			get;
		}
        int Id {
            get; init;
        }
    }//end IAccount

}//end namespace Interfaces