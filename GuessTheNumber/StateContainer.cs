namespace GuessTheNumber
{
    public class StateContainer
    {
        private int? savedValue;

        public int Digits
        {
            get => savedValue ?? 0;
            set
            {
                savedValue = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();
    }

}