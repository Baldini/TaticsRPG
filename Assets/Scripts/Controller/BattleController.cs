using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleController : StateMachine {
    public IEnumerator round;
    public StatPanelController statPanelController;
    public CameraRig cameraRig;
    public Board board;
    public LevelData levelData;
    public Transform tileSelectionIndicator;
    public Point pos;
    public AbilityMenuPanelController abilityMenuPanelController;
    public Turn turn = new Turn ();
    public List<Unit> units = new List<Unit> ();

    public GameObject heroPrefab;
    public Tile currentTile { get { return board.GetTile (pos); } }

    void Start () {
        ChangeState<InitBattleState> ();
    }
}