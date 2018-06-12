using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Turn {
    public List<Tile> targets;
    public Unit actor;
    public bool hasUnitMoved;
    public bool hasUnitActed;
    public bool lockMove;
    Tile startTile;
    Directions startDir;
    public GameObject ability;
    public void Change (Unit current) {
        actor = current;
        hasUnitMoved = false;
        hasUnitActed = false;
        lockMove = false;
        startTile = actor.tile;
        startDir = actor.dir;
    }
    public void UndoMove () {
        hasUnitMoved = false;
        actor.Place (startTile);
        actor.dir = startDir;
        actor.Match ();
    }
}