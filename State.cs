using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[CreateAssetMenu(menuName = "_NAME_")] is Unity specific code that essentially creates an asset for the given name for the game.
[CreateAssetMenu(menuName = "State")]

//Creating the state class allows holding variables to represent values of the current state and available states and functions for switching states, etc.
public class State : ScriptableObject
{
    //Defining the placeholder for the text values to be displayed everytime a user enters a state
    [TextArea(10,14)] [SerializeField] string storyText;

    //Defining the placeholder to hold the subsequent states following the starting state
    [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }
    public State[] GetNextStates() {
        return nextStates;
    }
}
