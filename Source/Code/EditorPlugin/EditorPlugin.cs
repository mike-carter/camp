using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Duality.Editor;

namespace CampGame.Editor
{
	/// <summary>
	/// Defines a Duality editor plugin.
	/// </summary>
    public class CampGameEditorPlugin : EditorPlugin
	{
		public override string Id
		{
			get { return "CampGameEditorPlugin"; }
		}
	}
}
