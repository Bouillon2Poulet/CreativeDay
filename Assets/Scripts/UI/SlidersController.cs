using UnityEngine;
using UnityEngine.UI;

public class SlidersController : MonoBehaviour
{
    [SerializeField]
    private Slider farmSlider;
    [SerializeField]
    private Slider warSlider;
    [SerializeField]
    private Slider spaceSlider;

    public void OnFarmSliderButtonClicked()
    {
        WorkflowManager.Instance.PassUserEventToFSM(new ItemButtonClickedEvent(UserEvent.ITEM_BUTTON_CLICKED, EnvironmentDataManager.UniverseType.FARM));
    }

    public void OnWarSliderButtonClicked()
    {
        WorkflowManager.Instance.PassUserEventToFSM(new ItemButtonClickedEvent(UserEvent.ITEM_BUTTON_CLICKED, EnvironmentDataManager.UniverseType.WARRIOR));
    }

    public void OnSpaceSliderButtonClicked()
    {
        WorkflowManager.Instance.PassUserEventToFSM(new ItemButtonClickedEvent(UserEvent.ITEM_BUTTON_CLICKED, EnvironmentDataManager.UniverseType.SPACE));
    }

    public void SetSliderValue(float normalizedValue, EnvironmentDataManager.UniverseType universeType)
    {
        Slider targetSlider = null;
        switch (universeType)
        {
            case EnvironmentDataManager.UniverseType.FARM: targetSlider = farmSlider; break;
            case EnvironmentDataManager.UniverseType.SPACE: targetSlider = spaceSlider; break;
            case EnvironmentDataManager.UniverseType.WARRIOR: targetSlider = warSlider; break;
        }
        targetSlider.normalizedValue = normalizedValue;
    }
}
