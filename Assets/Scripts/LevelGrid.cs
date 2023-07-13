using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    [SerializeField] private Transform gridDebugObjectPrefab;

    private GridSystem gridSystem;

    public static LevelGrid Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Only one instance of LevelGrid can exist" + transform + " - " + Instance);
            Destroy(gameObject);
            return;

        }
        Instance = this;

        gridSystem = new GridSystem(10, 10, 2f);
        gridSystem.CreateDebugObjects(gridDebugObjectPrefab);

    }

    public void AddUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
        //use the gridPosition value to determine which grid we are assigning the unit to
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);

        //use the gridobject's SetUnitAtThisGrid function to set it
        gridObject.AddUnit(unit);
    }

    public List<Unit> GetUnitListAtGridPosition(GridPosition gridPosition)
    {
        //use the gridPosition value to determine which grid we are retrieving unit from
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);

        return gridObject.GetUnitList();
    }

    public void RemoveUnitAtGridPosition(GridPosition gridPosition, Unit unit)
    {
        //use the gridPosition value to determine which grid we are retrieving unit from
        GridObject gridObject = gridSystem.GetGridObject(gridPosition);

        gridObject.RemoveUnit(unit);
    }

    public void UnitMovedGridPosition(Unit unit, GridPosition fromGridPosition, GridPosition toGridPosition)
    {
        RemoveUnitAtGridPosition(fromGridPosition, unit);

        AddUnitAtGridPosition(toGridPosition, unit);
    }

    public GridPosition GetGridPosition(Vector3 worldPosition) => gridSystem.GetGridPosition(worldPosition);


}
