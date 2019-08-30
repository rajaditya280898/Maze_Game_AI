using System;


namespace Maze_Game_AI
{
	public class class_Variable
	{
		public static bool IsNumeric( string s )
		{
			try
			{
				int i = int.Parse( s );
				return true;
			}
			catch 
			{
				return false;
			}
		}

		private class_Variable() {}
	}
}
