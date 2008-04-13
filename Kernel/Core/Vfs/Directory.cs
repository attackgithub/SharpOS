//
// (C) 2006-2008 The SharpOS Project Team (http://www.sharpos.org)
//
// Authors:
//	Michael Ruck (aka grover) <sharpos@michaelruck.de>
//
// Licensed under the terms of the GNU GPL v3,
//  with Classpath Linking Exception for Libraries
//

using System;
using InternalSystem.Collections;
using System.IO;


namespace SharpOS.Kernel.Vfs
{
	/// <summary>
	/// Represents a basic directory in the VFS namespace.
	/// </summary>
	/// <remarks>
	/// This class can be inherited if necessary to provide specialized
	/// directory handling if required.
	/// </remarks>
	public class Directory : NodeBase
	{

		#region Data members

		/// <summary>
		/// Holds all nodes added to the root vfs node.
		/// </summary>
		private ArrayList _nodes;

		#endregion // Data members

		#region Construction

		/// <summary>
		/// Initializes a new instance of the Directory object.
		/// </summary>
		/// <param name="name">The name of the node.</param>
		public Directory ()
			: base (VfsNodeType.Directory)
		{
			_nodes = new ArrayList ();
		}

		#endregion // Construction

		#region IVfsNode members

		public override IVfsNode Create (char[] name, VfsNodeType nodeType, object settings)
		{
			// FIXME: throw new NotImplementedException();
			return null;
		}

		public override IVfsNode Lookup (char[] name)
		{
			// FIXME: Lookup the node in the members
			return null;
		}

		public override object Open (FileAccess access, FileShare sharing)
		{
			// FIXME: return something like: new System.IO.DirectoryInfo(VirtualFileSystem.GetPath(this));
			//throw new NotImplementedException();
			return null;
		}

		public override void Delete ()
		{
			// FIXME: throw new NotImplementedException();
		}

		#endregion // IVfsNode members
	}
}