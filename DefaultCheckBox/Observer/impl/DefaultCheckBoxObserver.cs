namespace DefaultCheckBox.Observer.impl
{
    public class DefaultCheckBox : StateObserver
    {
        private StateDefaultImpl _state;
        private System.Windows.Forms.CheckBox _checkBox;

        public DefaultCheckBox(StateDefaultImpl state, System.Windows.Forms.CheckBox checkBox)
        {
            _state = state;
            _checkBox = checkBox;
        }

        public void update()
        {
            _checkBox.Checked = _state.ChkBoxDefault;
        }
    }
}