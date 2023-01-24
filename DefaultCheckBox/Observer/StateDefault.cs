namespace DefaultCheckBox.Observer
{
    public interface StateDefault
    {
        void registerObserver(StateObserver o);
        void removeObserver(StateObserver o);
        void notifyObservers();
    }
}