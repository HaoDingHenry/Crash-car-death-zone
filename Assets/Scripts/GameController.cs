using UnityEngine;
using UnityEngine.UI;

public class ObjectVisibilityController : MonoBehaviour
{
    public GameObject panelToShow; // ��Inspector��ͼ�з���Ҫ��ʾ��Panel

    void Start()
    {
        // ȷ���ڿ�ʼʱ����Panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(false);
        }
    }

    void OnBecameVisible()
    {
        // �������Ϊ�ɼ�ʱ������Panel
        if (panelToShow != null)
        {
            panelToShow.SetActive(false);
        }
    }

    void OnBecameInvisible()
    {
        // �������Ϊ���ɼ�ʱ����ʾPanel
        if (panelToShow != null)
        {
            panelToShow.SetActive(true);
        }
    }
}