using UnityEngine;
using UnityEngine.SceneManagement;

namespace InitialScreenScripts
{
    public class LoadScene : MonoBehaviour
    {
        public void PlayScene() {  
            SceneManager.LoadScene("PlayScene");  
        }  
        public void InventoryScene() {  
            SceneManager.LoadScene("InventoryScene");  
        }  
        public void SkeletonsScene() {  
            SceneManager.LoadScene("SkeletonsScene");  
        }
        public void StoreScene() {  
            SceneManager.LoadScene("StoreScene");  
        }
    }
}
