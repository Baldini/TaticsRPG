using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions {

	public static Directions GetDirection (this Point p) {
		if (p.y > 0)
			return Directions.North;
		if (p.x > 0)
			return Directions.East;
		if (p.y < 0)
			return Directions.South;
		return Directions.West;
	}
}