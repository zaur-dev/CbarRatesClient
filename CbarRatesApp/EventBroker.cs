namespace CbarRatesApp
{
    public class EventBroker
    {
        public event EventHandler<CurrencySelectedEventArgs> CurrencySelected;

        public void OnCurrencySelected(string currencyCode)
        {
            CurrencySelected?.Invoke(this, new CurrencySelectedEventArgs() { SelectedCurrencyCode = currencyCode });
        }
    }

    public class CurrencySelectedEventArgs : EventArgs
    {
        public string SelectedCurrencyCode { get; set; }
    }
}
