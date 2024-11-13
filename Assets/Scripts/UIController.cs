using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace SMPScripts
{
    public class UIController : MonoBehaviour
    {
        [Header("UI Elements")]
        public TMP_Text speedText;
        public TMP_Text energyRecoveredText;
        public TMP_Text energyConsumedText; // Nou element
        public TMP_Text batteryStatusText;
        public Slider batterySlider; // Bară de progres pentru baterie

        // Metoda pentru actualizarea UI-ului
        public void UpdateUI(float speed, float energyRecovered, float energyConsumed, float batteryEnergy, float batteryCapacity)
        {
            // Convertim viteza din m/s în km/h
            float speedKmh = speed * 3.6f;
            speedText.text = $"Viteză: {speedKmh:F2} km/h";

            energyRecoveredText.text = $"Energie Recuperată: {energyRecovered:F2} J";
            energyConsumedText.text = $"Energie Consumata: {energyConsumed:F2} J";

            float batteryPercentage = (batteryEnergy / batteryCapacity) * 100f;
            batteryStatusText.text = $"Stare Baterie: {batteryPercentage:F2} %";
            batterySlider.value = batteryPercentage;
        }
    }
}
