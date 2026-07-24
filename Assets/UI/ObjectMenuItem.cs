using UnityEngine;

[CreateAssetMenu(fileName = "ObjectMenuItem", menuName = "Scriptable Objects/ObjectMenuItem")]
public class ObjectMenuItem : MenuItemSimple
{
    [System.Serializable]
    public enum EnvironmentType
    {
        Farm,
        Space,
        War
    }

    public EnvironmentType environment;
}
