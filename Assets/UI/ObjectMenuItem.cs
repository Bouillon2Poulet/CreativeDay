using UnityEngine;
using static EnvironmentDataManager;

[CreateAssetMenu(fileName = "ObjectMenuItem", menuName = "Scriptable Objects/ObjectMenuItem")]
public class ObjectMenuItem : MenuItemSimple
{
    public UniverseType universeType;
}
