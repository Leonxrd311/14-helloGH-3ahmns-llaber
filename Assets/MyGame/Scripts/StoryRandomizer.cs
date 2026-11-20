using UnityEngine;

public class StoryRandomizer : MonoBehaviour
{
    string[] locations = {
        "Serverstadt",
        "digitales Archiv",
        "Pixelwald",
        "Computersystem eines Raumschiff",
        "verlassenes Spiel",
        "unterirdisches Datennetz"
    };

        string[] damagecause = {
            "ein fehlerhaftesUpdate",
            "ein Computervirus",
            "ein abgestürztes Programm",
            "gestohlene Bytes",
            "eine beschädigte Datei",
            "eine unterbrochene Verbindung"
    };

        string[] wiederhergestellt = {
            "Farben",
            "Erinnerungen",
            "Daten",
            "Energie",
            "Verbindungen",
            "Spielfelder"
    };



void Start()
    {
            int randomLocation = Random.Range(0, locations.Length);
            string selectedLocation = locations[randomLocation];
            Debug.Log("Wo: " + selectedLocation);

            int randomDamageCause = Random.Range(0, damagecause.Length);
            string selectedDamageCause = damagecause[randomDamageCause];
            Debug.Log("Ursache: " + selectedDamageCause);

            
            int randomRestored = Random.Range(0, wiederhergestellt.Length);
            string selectedRestored = wiederhergestellt[randomRestored];
            Debug.Log("Wiederhergestellung: " + selectedRestored);


    }

    private int pflanze;

        int pflanze = 5;
        int pflanze = pflanze + 8; 
}
