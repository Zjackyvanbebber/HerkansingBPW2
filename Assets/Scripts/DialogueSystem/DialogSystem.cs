using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour {
    public static DialogSystem Instance { get; set; }
    public GameObject dialoguePanel;
    public string npcName;
    public List<string> dialogueLines = new List<string>();

    Button continueButton;
    Text dialogueText, nameText;
    int dialogueIndex;
	
	void Awake () {
        continueButton = dialoguePanel.transform.FindChild("Continue").GetComponent<Button>();
        dialogueText = dialoguePanel.transform.FindChild("Text").GetComponent<Text>();
        nameText = dialoguePanel.transform.FindChild("Name").GetChild(0).GetComponent<Text>();
        continueButton.onClick.AddListener(delegate { ContinueDialogue(); });
        dialoguePanel.SetActive(false);
        
        

		if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
	}
	
	public void AddNewDialogue(string[] lines, string npcName)
    {
        dialogueIndex = 0;
        dialogueLines = new List<string>();
        foreach(string line in lines)
        {
            dialogueLines.Add(line);
        }
        this.npcName = npcName;

        Debug.Log(dialogueLines.Count);
        CreateDialogue();

        //dialogueLines = new List<string>(lines.Length);
        //dialogueLines.AddRange(lines);

    }

    public void CreateDialogue()
    {
        dialogueText.text = dialogueLines[dialogueIndex];
        nameText.text = npcName;
        dialoguePanel.SetActive(true);
    }
    
    public void ContinueDialogue()
    {
        if (dialogueIndex < dialogueLines.Count - 1)
        {
            dialogueIndex++;
            dialogueText.text = dialogueLines[dialogueIndex];
        }
        else
        {
            dialoguePanel.SetActive(false);
        }
    }
}
