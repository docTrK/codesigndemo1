using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //[SerializeField] - adds the variable as a field into the unity inspector and allows dynamic manipulation of values
    //Records texts components that are to be shown on the lcd display
    [SerializeField] Text textComponent;

    //To initialize the contents to be displayed on the lcd.
    [SerializeField] State startingState;


    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    //This method, when called, will enable users to select an option using the number keys. The state will be changed based on the the selected option.
    private void ManageState() {
        var nextStates = state.GetNextStates();
        for(int i = 0; i < nextStates.Length; i++) {
            if(Input.GetKeyDown(KeyCode.A)) {
                state = nextStates[0];
            }
            else if(Input.GetKeyDown(KeyCode.B)) {
                state = nextStates[1];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}