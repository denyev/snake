using System;
using System.Collections.Generic;

namespace snake
{
	public class VerticalLine : Figure
	{
		public VerticalLine(int y1, int y2, int x, char sym)
		{

			pList = new List<Point>();
			for (int y = y1; y <= y2; y++) {
				Point p = new Point (x, y, sym);
				pList.Add (p);
			}
		}
	}
}

