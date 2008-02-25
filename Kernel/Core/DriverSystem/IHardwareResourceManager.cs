﻿// 
// (C) 2006-2007 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Sander van Rossen <sander.vanrossen@gmail.com>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using System.Collections.Generic;
using System.Text;

namespace SharpOS.Kernel.DriverSystem {

	// NOTE: implemented in X86/HardwareResourceManager
	public interface IHardwareResourceManager {
		MemoryBlock		RequestMemoryBuffer	(uint address, uint length);
		IOPortStream	Request8bitIOPort	(ushort port);
	}
}
