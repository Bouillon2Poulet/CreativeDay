using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectsButtonFactory : MonoBehaviour
{
    [SerializeField] List<ObjectMenuItem> themes;
    [SerializeField] LayoutGroup layoutGroup;
    [SerializeField] GameObject objectButtonPrefab;
    private List<Button> objectsButtons = new List<Button>();

    [ContextMenu("Generate")]
    void Generate()
    {
        for (int i = layoutGroup.transform.childCount - 1; i >= 0; i--)
        {
            Button buttonComponent = layoutGroup.transform.GetChild(i).GetComponentInChildren<Button>();
            buttonComponent.onClick.RemoveAllListeners();
            if (Application.isPlaying)
            {
                Destroy(layoutGroup.transform.GetChild(i).gameObject);
            }
            else
            {
                DestroyImmediate(layoutGroup.transform.GetChild(i).gameObject);
            }
        }

        objectsButtons.Clear();

        for (int i = 0; i < themes.Count; i++)
        {
            ObjectMenuItem data = themes[i];

            GameObject button = Instantiate(objectButtonPrefab);
            button.name = $"{themes[i].Name}";
            button.transform.SetParent(layoutGroup.transform);
            button.transform.localPosition = Vector3.zero;
            button.transform.localScale = Vector3.one;
            button.transform.localRotation = Quaternion.identity;

            MenuItemHandler ObjectMenuItemHandler = button.GetComponentInChildren<MenuItemHandler>();
            if (ObjectMenuItemHandler == null)
            {
                Debug.LogError("[themesHandler] Cannot find ParametersdataHandler on instanciated object : " + button.name);
                return;
            }
            Button buttonComponent = button.GetComponentInChildren<Button>();
            buttonComponent.onClick.AddListener(() => OnButtonClicked(data));
            objectsButtons.Add(buttonComponent);

            ObjectMenuItemHandler.Initialize(data);
        }
    }

    private void OnButtonClicked(ObjectMenuItem data)
    {
        Debug.Log("Button for " + data.universeType.ToString() + " clicked !");
        Debug.Log(WorkflowManager.Instance == null);
        WorkflowManager.Instance.PassUserEventToFSM(new ItemButtonClickedEvent(UserEvent.ITEM_BUTTON_CLICKED, data.universeType));
    }

    void Start()
    {
        Generate();
    }
}
