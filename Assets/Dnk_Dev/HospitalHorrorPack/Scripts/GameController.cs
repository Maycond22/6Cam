using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject menuPanel;
    public GameObject cutScene;

    public static GameController instancia = null;

    private void Awake() {
        if (instancia == null) {
            instancia = this;
        }
        else if (instancia != null) {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    public void TrrPlayCutScene() {
        Debug.Log("oi");
        menuPanel.SetActive(false);
        Instantiate(cutScene);
    }

    public void TrFinishCutScene() {
        menuPanel.SetActive(true);
    }
}
