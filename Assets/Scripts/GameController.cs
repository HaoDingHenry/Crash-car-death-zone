using UnityEngine;
using UnityEngine.UI;

public class ObjectVisibilityController : MonoBehaviour
{
    public GameObject panelToShow; // 在Inspector视图中分配要显示的Panel

    void Start()
    {
        // 确保在开始时隐藏Panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(false);
        }
    }

    void OnBecameVisible()
    {
        // 当物体变为可见时，隐藏Panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(false);
        }
    }

    void OnBecameInvisible()
    {
        // 当物体变为不可见时，显示Panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(true);
        }
    }
}