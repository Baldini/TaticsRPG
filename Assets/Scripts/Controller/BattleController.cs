using UnityEngine;


public class BattleController : StateMachine
{

    // Use this for initialization
    public CameraRig cameraRig;
    public Board board;
    public LevelData levelData;
    public Transform tileSelectionIndicator;
    public Point pos;

    public GameObject heroPrefab;
    public Unit currentUnit;
    public Tile currentTile { get { return board.GetTile(pos); } }
    void Start()
    {
        ChangeState<InitBattleState>();
    }
}
