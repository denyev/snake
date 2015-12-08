using System;
using System.Collections.Generic;

namespace snake
{
	public class HorizontalLine
	{
		List<Point> pList;

		public HorizontalLine (int xLeft, int xRight, int y, char sym)
		{
			pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++) {
				Point p = new Point (x, y, sym);
				pList.Add (p);
			}
		}

		public void pDraw()
		{
			foreach (Point p in pList) {
				p.Draw ();
			}
		}
	}
}

